using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Api.Common.Entities.APBatch.DTO;
using Api.Common.Entities.Inventory.DTO;

using Newtonsoft.Json;

namespace Envi.SDK.Examples;

/// <summary>
/// Demonstrates creating and executing OData batch requests.
/// </summary>
internal sealed class BatchRequestExampleRunner(SdkRuntimeConfiguration configuration)
{
	#region Public Methods

	/// <summary>
	/// Batches the example.
	/// </summary>
	/// <returns>Task.</returns>
	public async Task RunAsync()
	{
		var client = CreateODataClient();
		var batchUrl = $"{configuration.BaseAddress}/odata/$batch";

		// Global batch request
		var batchRequest = new HttpRequestMessage(HttpMethod.Post, batchUrl);
		batchRequest.Headers.Authorization = new AuthenticationHeaderValue("bearer", await client.GetAccessTokenAsync());

		// Send request
		await CreateBatchAsync(client, new APBatch { BatchNo = "Batch No" });

		var inventoryList = await GetInventoryListAsync(client);

		// Multiple GET Requests
		var batchContent = new MultipartContent("mixed", $"batches_{Guid.NewGuid()}")
		{
			ComposeGetRequestContent($"{configuration.BaseAddress}{ApiRoutes.Inventory}({inventoryList.Value[0].InventoryId})"),
			ComposeGetRequestContent($"{configuration.BaseAddress}{ApiRoutes.Inventory}({inventoryList.Value[1].InventoryId})"),
			ComposeGetRequestContent($"{configuration.BaseAddress}{ApiRoutes.Inventory}({inventoryList.Value[2].InventoryId})")
		};

		// Multiple POST Requests
		// multi-part content that represents the change-set container
		var changeSet = new MultipartContent("mixed", $"changeset_{Guid.NewGuid()}");

		// Add POST content to the change-set
		var content1 = new StringContent(client.Serialize(CreateNewInventoryItem()), Encoding.UTF8, Constants.JsonContentType);
		var content2 = new StringContent(client.Serialize(CreateNewInventoryItem()), Encoding.UTF8, Constants.JsonContentType);
		var content3 = new StringContent(client.Serialize(CreateNewInventoryItem()), Encoding.UTF8, Constants.JsonContentType);

		changeSet.Add(ComposePostRequestContent($"{configuration.BaseAddress}{ApiRoutes.Inventory}", content1));
		changeSet.Add(ComposePostRequestContent($"{configuration.BaseAddress}{ApiRoutes.Inventory}", content2));
		changeSet.Add(ComposePostRequestContent($"{configuration.BaseAddress}{ApiRoutes.Inventory}", content3));

		// Add the change-set to the batch content
		batchContent.Add(changeSet);

		batchRequest.Content = batchContent;

		using var http = new HttpClient();
		var response = await http.SendAsync(batchRequest);
		var result = await response.Content.ReadAsMultipartAsync();

		// Batch response handling
		foreach (var currentContent in result.Contents)
		{
			// 1. a "single" response
			if (currentContent.Headers.ContentType!.MediaType.Equals(Constants.HttpContentType, StringComparison.OrdinalIgnoreCase)
				&& !currentContent.Headers.ContentType.Parameters.Any(parameter => parameter.Name.Equals("msgtype", StringComparison.OrdinalIgnoreCase) && parameter.Value.Equals("response", StringComparison.OrdinalIgnoreCase)))
			{
				currentContent.Headers.ContentType.Parameters.Add(new NameValueHeaderValue("msgtype", "response"));
				await currentContent.ReadAsHttpResponseMessageAsync();
				// The workingResponse object contains a classic exploitable HttpResponseMessage (with IsSuccessStatusCode, Content.ReadAsStringAsync().Result, etc.)
			}
			// 2. a change-set response with multi-part content
			else
			{
				var subMultipartContent = await currentContent.ReadAsMultipartAsync();
				foreach (var currentSubContent in subMultipartContent.Contents)
				{
					currentSubContent.Headers.ContentType!.Parameters.Add(new NameValueHeaderValue("msgtype", "response"));
					await currentSubContent.ReadAsHttpResponseMessageAsync();
					// Same here, the workingResponse object contains a classic exploitable HttpResponseMessage
				}
			}
		}
	}

	#endregion

	#region Private Methods

	/// <summary>
	/// Create batch.
	/// </summary>
	/// <param name="client">The OData client.</param>
	/// <param name="batch">List of usages.</param>
	/// <returns>Id of new created batch - Guid.</returns>
	private static async Task<ODataSingleValueResponse<Guid>> CreateBatchAsync(EnviODataClient client, APBatch batch)
	{
		var result = await client.Post<APBatch, ODataSingleValueResponse<Guid>>(ApiRoutes.Batches, batch);

		return result;
	}

	/// <summary>
	/// Gets the inventory list.
	/// </summary>
	/// <returns>List of inventory items.</returns>
	private static async Task<ODataListResponse<Inventory>> GetInventoryListAsync(EnviODataClient client)
	{
		var result = await client.Get<ODataListResponse<Inventory>>(ApiRoutes.Inventory);

		return result;
	}

	/// <summary>
	/// Creates a new configured OData client.
	/// </summary>
	/// <returns>Configured <see cref="EnviODataClient"/> instance.</returns>
	private EnviODataClient CreateODataClient()
	{
		return new EnviODataClient(
			configuration.BaseAddress,
			configuration.ClientId,
			configuration.UserName,
			configuration.Password);
	}

	/// <summary>
	/// Gets the new inventory.
	/// </summary>
	/// <returns>Return new Inventory.</returns>
	private Inventory CreateNewInventoryItem()
	{
		return new Inventory
		{
			InventoryGroupId = configuration.InventoryGroupId,
			InventoryNo = new Random().Next(0, int.MaxValue).ToString(),
			InventoryDescription = "InventoryDescription",
			StockUOM = "EA",
			SystemTypeId = 1,
			ActiveStatus = true
		};
	}

	/// <summary>
	/// Composes the content of the get.
	/// </summary>
	/// <param name="url">The URL.</param>
	/// <returns>HttpMessageContent.</returns>
	private static HttpMessageContent ComposeGetRequestContent(string url)
	{
		var getContent = new HttpMessageContent(new HttpRequestMessage(HttpMethod.Get, url));
		getContent.Headers.Remove(Constants.ContentTypeHeader);
		getContent.Headers.Add(Constants.ContentTypeHeader, Constants.HttpContentType);
		getContent.Headers.Add("Content-Transfer-Encoding", "binary");

		return getContent;
	}

	/// <summary>
	/// Composes the content of the post.
	/// </summary>
	/// <param name="url">The URL.</param>
	/// <param name="serializedContent">Content serialized as JSON.</param>
	/// <param name="contentId">The content identifier.</param>
	/// <returns>HttpMessageContent.</returns>
	private static HttpMessageContent ComposePostRequestContent(string url, StringContent serializedContent, string contentId = null)
	{
		var postRequest = new HttpRequestMessage
		{
			Content = serializedContent,
			Method = HttpMethod.Post,
			RequestUri = new Uri(url)
		};

		var postContent = new HttpMessageContent(postRequest);
		postContent.Headers.Remove(Constants.ContentTypeHeader);
		postContent.Headers.Add(Constants.ContentTypeHeader, Constants.HttpContentType);
		postContent.Headers.Add("Content-Transfer-Encoding", "binary");
		postContent.Headers.Add("Content-ID", contentId ?? Guid.NewGuid().ToString());

		return postContent;
	}

	#endregion

}
