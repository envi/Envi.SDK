using Api.Common.Entities.Inventory.DTO;
using IOSCorp.SDK.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Api.Common.Entities.InventoryLocations.DTO;
using Api.Common.Entities.InventoryVendors.DTO;
using Api.Common.Entities.Vendors.DTO;

namespace IOSCorp.SDK
{
    internal class Program
    {
		/// <summary>
		/// Base address of OData API Service
		/// </summary>
	    private static readonly string _baseAddress = "https://API_HOST_NAME";

		/// <summary>
		/// Holds instance of correctlly initialized HTTP Client
		/// </summary>
        private static HttpClient _client;

		/// <summary>
		/// Holds instance of obtained JWT token
		/// </summary>
        private static JWT _token;

        //private static readonly string _formatString = "?$format=application/json;odata.metadata=none";

		#region Authentication

		private static async Task<JWT> GetToken()
		{
			if (_token == null)
			{
				List<KeyValuePair<string, string>> requestData = new List<KeyValuePair<string, string>> {
					new KeyValuePair<string, string>("grant_type", "password"),
					new KeyValuePair<string, string>("client_id", "099153c2625149bc8ecb3e85e03f0022"),
					new KeyValuePair<string, string>("username", "USER_NAME"),
					new KeyValuePair<string, string>("password", "PASSWORD")
				};
				_token = await RequestToken(requestData);
			}
			if (!_token.IsValid)
			{
				List<KeyValuePair<string, string>> requestData = new List<KeyValuePair<string, string>> {
					new KeyValuePair<string, string>("grant_type", "refresh_token"),
					new KeyValuePair<string, string>("client_id", "099153c2625149bc8ecb3e85e03f0022"),
					new KeyValuePair<string, string>("refresh_token", _token.RefreshToken)
				};
				_token = await RequestToken(requestData);
			}
			return _token;
		}

	    private static async Task<JWT> RequestToken(List<KeyValuePair<string, string>> requestData)
	    {
		    var response = await Client.PostAsync("oauth2/token", new FormUrlEncodedContent(requestData));
		    var content = await response.Content.ReadAsStringAsync();

		    return JsonConvert.DeserializeObject<JWT>(content);
	    }

		#endregion
		
	    public static void Main()
	    {
			// Inventory examples contains simple operation for Inventory like new item creation, update, patch, retrieving paged list
		    // of Inventory or individual item by its primary key 
		    InventoryExamples().GetAwaiter().GetResult();

			// Contains an axample on how to execute requests in a batch, so one batch reauest contains multiple individual requests 
		    // which are executed separatelly on the server side and results are combined to a single response
		    BatchExample().GetAwaiter().GetResult();

			// Example on how to invoke few different API end-points in order to obtain the same data as 
		    // returned by current Inventory Master interface (changed Inventory, corresponding Inventory/Locations
			// and Inventory/Vendors and related Vendors information)
		    InventoryMasterInterface(new DateTime(2017, 10, 1), null, null ).GetAwaiter().GetResult();
	    }

		#region Inventory Master interface example

		private static async Task InventoryMasterInterface(DateTime lastRunDate, Guid? facilityPK, bool? syncFlag)
		{
			const string invntoryUrlTmpl = "/odata/Inventory/GetAllFromDate(from={0},facilityId={1},syncFlag={2})";
			const string invntoryLocationsUrlTmpl = "/odata/InventoryLocations/GetAllFromDate(from={0},facilityId={1},syncFlag={2})";
			const string invntoryVendorsUrlTmpl = "/odata/InventoryVendors/GetAllFromDate(from={0},facilityId={1},syncFlag={2})";
			const string vendorsUrlTmpl = "/odata/Vendors/GetVendorsInfo(facilityId={0})";
			const string dateFormat = "yyyy-MM-dd";

			//Obtain JWT token and set access token to authorization header
			await SetAuthHeader();

			//Retrieving of Inventory Info
			var inventoryUrl = string.Format(invntoryUrlTmpl,
				lastRunDate.ToString(dateFormat),
				facilityPK?.ToString() ?? "null",
				syncFlag?.ToString() ?? "null");
			var response = await Client.GetAsync(inventoryUrl);
			var inventoryResult = await response.Content.ReadAsStringAsync();
			var inventory = JsonConvert.DeserializeObject<ODataListResponse<Inventory>>(inventoryResult).Value;

			// Retrieving of corresponding Inventory/Locations
			var inventoryLocationsUrl = string.Format(invntoryLocationsUrlTmpl,
				lastRunDate.ToString(dateFormat),
				facilityPK?.ToString() ?? "null",
				syncFlag?.ToString() ?? "null");
			response = await Client.GetAsync(inventoryLocationsUrl);
			var inventoryLocationsResult = await response.Content.ReadAsStringAsync();
			var inventoryLocations = JsonConvert.DeserializeObject<ODataListResponse<InventoryLocation>>(inventoryLocationsResult).Value;

			// Retrieving of corresponding Inventory/Vendors
			var inventoryVendorsUrl = string.Format(invntoryVendorsUrlTmpl,
				lastRunDate.ToString(dateFormat),
				facilityPK?.ToString() ?? "null",
				syncFlag?.ToString() ?? "null");
			response = await Client.GetAsync(inventoryVendorsUrl);
			var inventoryVenorsResult = await response.Content.ReadAsStringAsync();
			var inventoryVendors = JsonConvert.DeserializeObject<ODataListResponse<InventoryVendor>>(inventoryVenorsResult).Value;

			// Retrieving of resulting Vendor Ids
			var vendorIds = inventoryVendors.GroupBy(pk => pk.VendorId).Select(g => g.Key).ToList();

			// Retrieving of Vendors information
			var vendorsUrl = string.Format(vendorsUrlTmpl, facilityPK?.ToString() ?? "null");
			var content = new StringContent(Serialize(new ListRepresentation<Guid?> { Value = vendorIds }), Encoding.UTF8, "application/json");
			response = await Client.PostAsync(vendorsUrl, content);
			var vendorsResult = await response.Content.ReadAsStringAsync();
			var vendors = JsonConvert.DeserializeObject<ODataListResponse<VendorInfo>>(vendorsResult).Value;

			// Getting information combined (adding of Inventory/Vendors and Inventory/Locations to corresponding Inventory)
			inventory.ForEach(i => i.InventoryLocations = new List<InventoryLocation>(inventoryLocations.Where(il => il.InventoryId == i.InventoryId).ToList()));
			inventory.ForEach(i => i.InventoryVendors = new List<InventoryVendor>(inventoryVendors.Where(iv => iv.InventoryId == i.InventoryId).ToList()));
			await Task.FromResult(0);
		}

		#endregion

		#region Batch Example

		private static async Task BatchExample()
		{
			var batchUrl = $"{_baseAddress}/odata/$batch";
			// Global batch request
			var batchRequest = new HttpRequestMessage(HttpMethod.Post, batchUrl);
			batchRequest.Headers.Authorization = new AuthenticationHeaderValue("bearer", (await GetToken()).AccessToken);
			
			// Multiple GET Requests
			var batchContent = new MultipartContent("mixed", $"batch_{Guid.NewGuid()}")
			{
				ComposeGetContent($"{_baseAddress}/odata/Inventory({new Guid("4311192f-c46f-4655-8d51-fc2f49aabf78")})"),
				ComposeGetContent($"{_baseAddress}/odata/Inventory({new Guid("71395601-8db7-4f3a-b466-106663990c90")})"),
				ComposeGetContent($"{_baseAddress}/odata/Inventory({new Guid("2a3e66aa-2e15-4035-8534-cb8a2280beea")})")
			};

			// Multile POST Requests
			// multipart content that represents the changeset container
			MultipartContent changeSet = new MultipartContent("mixed", $"changeset_{Guid.NewGuid()}");

			// Add POST content to the changeset
			var content1 = new StringContent(Serialize(GetNewInventory()), Encoding.UTF8, "application/json");
			var content2 = new StringContent(Serialize(GetNewInventory()), Encoding.UTF8, "application/json");
			var content3 = new StringContent(Serialize(GetNewInventory()), Encoding.UTF8, "application/json");
			changeSet.Add(ComposePostContent($"{_baseAddress}/odata/Inventory", content1));
			changeSet.Add(ComposePostContent($"{_baseAddress}/odata/Inventory", content2));
			changeSet.Add(ComposePostContent($"{_baseAddress}/odata/Inventory", content3));

			// Add the changeset to the batch content
			batchContent.Add(changeSet);

			batchRequest.Content = batchContent;

			var http = new HttpClient();
			HttpResponseMessage response = await http.SendAsync(batchRequest);
			var result = await response.Content.ReadAsMultipartAsync();

			// Batch response handling
			foreach (HttpContent currentContent in result.Contents)
			{
				// 1. a "single" response
				if (currentContent.Headers.ContentType.MediaType.Equals("application/http", StringComparison.OrdinalIgnoreCase)
					&& !currentContent.Headers.ContentType.Parameters.Any(parameter => parameter.Name.Equals("msgtype", StringComparison.OrdinalIgnoreCase) && parameter.Value.Equals("response", StringComparison.OrdinalIgnoreCase)))
				{
					currentContent.Headers.ContentType.Parameters.Add(new NameValueHeaderValue("msgtype", "response"));
					await currentContent.ReadAsHttpResponseMessageAsync();
					// The workingResponse object contains a classic exploitable HttpResponseMessage (with IsSuccessStatusCode, Content.ReadAsStringAsync().Result, etc.)
				}
				// 2. a changeset response with multipart content
				else
				{
					var subMultipartContent = await currentContent.ReadAsMultipartAsync();
					foreach (HttpContent currentSubContent in subMultipartContent.Contents)
					{
						currentSubContent.Headers.ContentType.Parameters.Add(new NameValueHeaderValue("msgtype", "response"));
						await currentSubContent.ReadAsHttpResponseMessageAsync();
						// Same here, the workingResponse object contains a classic exploitable HttpResponseMessage
					}
				}
			}

			await Task.FromResult(0);
		}

		private static HttpMessageContent ComposeGetContent(string url)
		{
			HttpMessageContent getContent = new HttpMessageContent(new HttpRequestMessage(HttpMethod.Get, url));
			getContent.Headers.Remove("Content-Type");
			getContent.Headers.Add("Content-Type", "application/http");
			getContent.Headers.Add("Content-Transfer-Encoding", "binary");

			return getContent;
		}

		private static HttpMessageContent ComposePostContent(string url, StringContent serrializedContent, string contentId = null)
		{
			var postRequest = new HttpRequestMessage
			{
				Content = serrializedContent,
				Method = HttpMethod.Post,
				RequestUri = new Uri(url)
			};

			HttpMessageContent postContent = new HttpMessageContent(postRequest);
			postContent.Headers.Remove("Content-Type");
			postContent.Headers.Add("Content-Type", "application/http");
			postContent.Headers.Add("Content-Transfer-Encoding", "binary");
			postContent.Headers.Add("Content-ID", contentId ?? Guid.NewGuid().ToString());

			return postContent;
		}

		#endregion

		#region Inventory Examples

		private static async Task InventoryExamples()
		{
			Inventory inventoryById = null;
			var inventoryList = await GetInventoryList();

			var inventoryId = inventoryList.Value[0].InventoryId;
			if (inventoryId != null)
			{
				inventoryById = await GetInventoryById(inventoryId.Value);
			}
			
			var newItem = GetNewInventory();
			var response = await PostInventory(newItem);

			Inventory inventory = await GetInventoryById(response.Value);

			inventory.HCPCSCode = "H0001";
			inventory.UNSPSC = "41120000";

			if (await PutInventory(inventory))
			{
				if (inventory.InventoryId != null)
				{
					Inventory inventory5 = await GetInventoryById(inventory.InventoryId.Value);
				}
			}

			Inventory patch = new Inventory
			{
				InventoryNo = "78-95-1938"
			};
			
			if (inventory.InventoryId != null && await PatchInventory(inventory.InventoryId.Value, patch))
			{
				if (patch.InventoryId != null)
				{
					Inventory inventory6 = await GetInventoryById(patch.InventoryId.Value);
				}
			}
		}

		private static async Task<Inventory> GetInventoryById(Guid inventoryId)
		{
			await SetAuthHeader();
			var response = await Client.GetAsync($"/odata/Inventory({inventoryId})");
			return JsonConvert.DeserializeObject<Inventory>(await response.Content.ReadAsStringAsync());
		}

		private static async Task<ODataListResponse<Inventory>> GetInventoryList()
		{
			await SetAuthHeader();
			var response = await Client.GetAsync("/odata/Inventory");
			return JsonConvert.DeserializeObject<ODataListResponse<Inventory>>(await response.Content.ReadAsStringAsync());
		}

		private static async Task<bool> PatchInventory(Guid entityId, Inventory patch)
		{
			await SetAuthHeader();
			var content = new StringContent(Serialize(patch), Encoding.UTF8, "application/json");
			var response = await Client.PatchAsync($"odata/Inventory({entityId})", content);
			return response.IsSuccessStatusCode;
		}

		private static async Task<ODataSingleValueResponse<Guid>> PostInventory(Inventory newItem)
		{
			await SetAuthHeader();
			var content = new StringContent(Serialize(newItem), Encoding.UTF8, "application/json");
			var response = await Client.PostAsync("/odata/Inventory", content);
			return JsonConvert.DeserializeObject<ODataSingleValueResponse<Guid>>(await response.Content.ReadAsStringAsync());
		}

		private static async Task<bool> PutInventory(Inventory inventory)
		{
			await SetAuthHeader();
			var content = new StringContent(Serialize(inventory), Encoding.UTF8, "application/json");
			var response = await Client.PutAsync($"odata/Inventory({inventory.InventoryId})", content);
			return response.IsSuccessStatusCode;
		}

		#endregion

	    private static Inventory GetNewInventory()
	    {
			var inventory = new Inventory
			{
				InventoryGroupId = new Guid("88212fc1-7698-40b3-8642-edd4ff793fcd"),
				InventoryNo = new Random().Next(0, int.MaxValue).ToString(),
				InventoryDescription = "InventoryDescription",
				StockUOM = "EA",
				SystemTypeId = 1,
				ActiveStatus = true
			};

		    return inventory;
	    }

	    private static string Serialize<T>(T target)
	    {
			var serializerSettings = new JsonSerializerSettings
			{
				ContractResolver = new CamelCasePropertyNamesContractResolver(),
				NullValueHandling = NullValueHandling.Ignore
			};

		    return JsonConvert.SerializeObject(target, serializerSettings);
	    }

	    private static async Task<bool> SetAuthHeader()
        {
	        var auth = await GetToken();
	        if (auth != null)
	        {
		        Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", auth.AccessToken);
	        }

	        return auth != null;
        }

        private static HttpClient Client
        {
            get
            {
                if (_client == null)
                {
					_client = new HttpClient {
                        BaseAddress = new Uri(_baseAddress)
                    };
                    _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                }
                return _client;
            }
        }
    }
}

