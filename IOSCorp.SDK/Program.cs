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
using Api.Common.Entities.Usages.DTO;
using Api.Common.Entities.Vendors.DTO;

namespace IOSCorp.SDK
{
	/// <summary>
	/// Class Program.
	/// </summary>
	internal class Program
	{
		#region Private fields

		/// <summary>
		/// Base address of OData API Service
		/// </summary>
		private static readonly string _baseAddress = "https://API_HOST_NAME";

		/// <summary>
		/// Holds instance of correctly initialized HTTP Client
		/// </summary>
		private static HttpClient _client;

		/// <summary>
		/// Holds instance of obtained JWT token
		/// </summary>
		private static JWT _token;

		#endregion

		#region Authentication

		/// <summary>
		/// Gets the token.
		/// </summary>
		/// <returns>Task&lt;JWT&gt;.</returns>
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

		/// <summary>
		/// Requests the token.
		/// </summary>
		/// <param name="requestData">The request data.</param>
		/// <returns>Task&lt;JWT&gt;.</returns>
		private static async Task<JWT> RequestToken(List<KeyValuePair<string, string>> requestData)
		{
			var response = await Client.PostAsync("oauth2/token", new FormUrlEncodedContent(requestData));
			var content = await response.Content.ReadAsStringAsync();

			return JsonConvert.DeserializeObject<JWT>(content);
		}

		#endregion

		#region Constructor

		/// <summary>
		/// Defines the entry point of the application.
		/// </summary>
		public static void Main()
		{
			// Inventory examples contains simple operation for Inventory like new item creation, update, patch, retrieving paged list
			// of Inventory or individual item by its primary key 
			InventoryExamples().GetAwaiter().GetResult();

			// Contains an example on how to execute requests in a batch, so one batch request contains multiple individual requests 
			// which are executed separately on the server side and results are combined to a single response
			BatchExample().GetAwaiter().GetResult();

			// Example on how to invoke few different API end-points in order to obtain the same data as 
			// returned by current Inventory Master interface (changed Inventory, corresponding Inventory/Locations
			// and Inventory/Vendors and related Vendors information)
			InventoryMasterInterface(new DateTime(2017, 10, 1), null, null ).GetAwaiter().GetResult();

			// OData query options usage examples shows how to use system query options correctly based on Inventory end-point
			TopSkipExamples().GetAwaiter().GetResult();
			OrderByExamples().GetAwaiter().GetResult();
			FilteringExamples().GetAwaiter().GetResult();
			SearchExamples().GetAwaiter().GetResult();
			FormatExamples().GetAwaiter().GetResult();
			
			// Example how to use HTTP depletion interface using OData API
			DepletionInterface().GetAwaiter().GetResult();
		}

		#endregion

		#region Inventory Master interface example

		/// <summary>
		/// Inventories the master interface.
		/// </summary>
		/// <param name="lastRunDate">The last run date.</param>
		/// <param name="facilityPK">The facility pk.</param>
		/// <param name="syncFlag">if set to <c>true</c> [synchronize flag].</param>
		/// <returns>Task.</returns>
		private static async Task InventoryMasterInterface(DateTime lastRunDate, Guid? facilityPK, bool? syncFlag)
		{
			const string INVNTORY_URL_TMPL = "/odata/Inventory/GetAllFromDate(from={0},facilityId={1},syncFlag={2})";
			const string INVNTORY_LOCATIONS_URL_TMPL = "/odata/InventoryLocations/GetAllFromDate(from={0},facilityId={1},syncFlag={2})";
			const string INVNTORY_VENDORS_URL_TMPL = "/odata/InventoryVendors/GetAllFromDate(from={0},facilityId={1},syncFlag={2})";
			const string VENDORS_URL_TMPL = "/odata/Vendors/GetVendorsInfo(facilityId={0})";
			const string DATE_FORMAT = "yyyy-MM-dd";

			//Obtain JWT token and set access token to authorization header
			await SetAuthHeader();

			//Retrieving of Inventory Info
			var inventoryUrl = string.Format(INVNTORY_URL_TMPL,
				lastRunDate.ToString(DATE_FORMAT),
				facilityPK?.ToString() ?? "null",
				syncFlag?.ToString() ?? "null");
			var response = await Client.GetAsync(inventoryUrl);
			var inventoryResult = await response.Content.ReadAsStringAsync();
			var inventory = JsonConvert.DeserializeObject<ODataListResponse<Inventory>>(inventoryResult).Value;

			// Retrieving of corresponding Inventory/Locations
			var inventoryLocationsUrl = string.Format(INVNTORY_LOCATIONS_URL_TMPL,
				lastRunDate.ToString(DATE_FORMAT),
				facilityPK?.ToString() ?? "null",
				syncFlag?.ToString() ?? "null");
			response = await Client.GetAsync(inventoryLocationsUrl);
			var inventoryLocationsResult = await response.Content.ReadAsStringAsync();
			var inventoryLocations = JsonConvert.DeserializeObject<ODataListResponse<InventoryLocation>>(inventoryLocationsResult).Value;

			// Retrieving of corresponding Inventory/Vendors
			var inventoryVendorsUrl = string.Format(INVNTORY_VENDORS_URL_TMPL,
				lastRunDate.ToString(DATE_FORMAT),
				facilityPK?.ToString() ?? "null",
				syncFlag?.ToString() ?? "null");
			response = await Client.GetAsync(inventoryVendorsUrl);
			var inventoryVenorsResult = await response.Content.ReadAsStringAsync();
			var inventoryVendors = JsonConvert.DeserializeObject<ODataListResponse<InventoryVendor>>(inventoryVenorsResult).Value;

			// Retrieving of resulting Vendor Ids
			var vendorIds = inventoryVendors.GroupBy(pk => pk.VendorId).Select(g => g.Key).ToList();

			// Retrieving of Vendors information
			var vendorsUrl = string.Format(VENDORS_URL_TMPL, facilityPK?.ToString() ?? "null");
			var content = new StringContent(Serialize(new ListRepresentation<Guid?> { Value = vendorIds }), Encoding.UTF8, "application/json");
			response = await Client.PostAsync(vendorsUrl, content);
			var vendorsResult = await response.Content.ReadAsStringAsync();
			var vendors = JsonConvert.DeserializeObject<ODataListResponse<VendorInfo>>(vendorsResult).Value;

			// Getting information combined (adding of Inventory/Vendors and Inventory/Locations to corresponding Inventory)
			inventory.ForEach(i => i.InventoryLocations = new List<InventoryLocation>(inventoryLocations.Where(il => il.InventoryId == i.InventoryId).ToList()));
			inventory.ForEach(i => i.InventoryVendors = new List<InventoryVendor>(inventoryVendors.Where(iv => iv.InventoryId == i.InventoryId).ToList()));
		}

		#endregion

		#region Batch Example

		/// <summary>
		/// Batches the example.
		/// </summary>
		/// <returns>Task.</returns>
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

			// Multiple POST Requests
			// multi-part content that represents the change-set container
			MultipartContent changeSet = new MultipartContent("mixed", $"changeset_{Guid.NewGuid()}");

			// Add POST content to the change-set
			var content1 = new StringContent(Serialize(GetNewInventory()), Encoding.UTF8, "application/json");
			var content2 = new StringContent(Serialize(GetNewInventory()), Encoding.UTF8, "application/json");
			var content3 = new StringContent(Serialize(GetNewInventory()), Encoding.UTF8, "application/json");
			changeSet.Add(ComposePostContent($"{_baseAddress}/odata/Inventory", content1));
			changeSet.Add(ComposePostContent($"{_baseAddress}/odata/Inventory", content2));
			changeSet.Add(ComposePostContent($"{_baseAddress}/odata/Inventory", content3));

			// Add the change-set to the batch content
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
				// 2. a change-set response with multi-part content
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
		}

		/// <summary>
		/// Composes the content of the get.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <returns>HttpMessageContent.</returns>
		private static HttpMessageContent ComposeGetContent(string url)
		{
			HttpMessageContent getContent = new HttpMessageContent(new HttpRequestMessage(HttpMethod.Get, url));
			getContent.Headers.Remove("Content-Type");
			getContent.Headers.Add("Content-Type", "application/http");
			getContent.Headers.Add("Content-Transfer-Encoding", "binary");

			return getContent;
		}

		/// <summary>
		/// Composes the content of the post.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <param name="serrializedContent">Content of the serrialized.</param>
		/// <param name="contentId">The content identifier.</param>
		/// <returns>HttpMessageContent.</returns>
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

		/// <summary>
		/// Inventories the examples.
		/// </summary>
		/// <returns>Task.</returns>
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
			inventory.UNSPSCCode = "41120000";

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

		/// <summary>
		/// Gets the inventory by identifier.
		/// </summary>
		/// <param name="inventoryId">The inventory identifier.</param>
		/// <returns>Task&lt;Inventory&gt;.</returns>
		private static async Task<Inventory> GetInventoryById(Guid inventoryId)
		{
			await SetAuthHeader();
			var response = await Client.GetAsync($"/odata/Inventory({inventoryId})");
			return JsonConvert.DeserializeObject<Inventory>(await response.Content.ReadAsStringAsync());
		}

		/// <summary>
		/// Gets the inventory list.
		/// </summary>
		/// <returns>Task&lt;ODataListResponse&lt;Inventory&gt;&gt;.</returns>
		private static async Task<ODataListResponse<Inventory>> GetInventoryList()
		{
			await SetAuthHeader();
			var response = await Client.GetAsync("/odata/Inventory");
			return JsonConvert.DeserializeObject<ODataListResponse<Inventory>>(await response.Content.ReadAsStringAsync());
		}

		/// <summary>
		/// Patches the inventory.
		/// </summary>
		/// <param name="entityId">The entity identifier.</param>
		/// <param name="patch">The patch.</param>
		/// <returns>Task&lt;System.Boolean&gt;.</returns>
		private static async Task<bool> PatchInventory(Guid entityId, Inventory patch)
		{
			await SetAuthHeader();
			var content = new StringContent(Serialize(patch), Encoding.UTF8, "application/json");
			var response = await Client.PatchAsync($"odata/Inventory({entityId})", content);
			return response.IsSuccessStatusCode;
		}

		/// <summary>
		/// Posts the inventory.
		/// </summary>
		/// <param name="newItem">The new item.</param>
		/// <returns>Task&lt;ODataSingleValueResponse&lt;Guid&gt;&gt;.</returns>
		private static async Task<ODataSingleValueResponse<Guid>> PostInventory(Inventory newItem)
		{
			await SetAuthHeader();
			var content = new StringContent(Serialize(newItem), Encoding.UTF8, "application/json");
			var response = await Client.PostAsync("/odata/Inventory", content);
			return JsonConvert.DeserializeObject<ODataSingleValueResponse<Guid>>(await response.Content.ReadAsStringAsync());
		}

		/// <summary>
		/// Puts the inventory.
		/// </summary>
		/// <param name="inventory">The inventory.</param>
		/// <returns>Task&lt;System.Boolean&gt;.</returns>
		private static async Task<bool> PutInventory(Inventory inventory)
		{
			await SetAuthHeader();
			var content = new StringContent(Serialize(inventory), Encoding.UTF8, "application/json");
			var response = await Client.PutAsync($"odata/Inventory({inventory.InventoryId})", content);
			return response.IsSuccessStatusCode;
		}

		#endregion

		#region HTTP Depletion interface using OData API

		/// <summary>
		/// Depletions the interface.
		/// </summary>
		/// <returns>Task.</returns>
		private static async Task DepletionInterface()
		{
			//Only Facility No is required for usage creation
			var usageA = new Usage { FacilityNo = "Facility No" };
			var usageB = new Usage { FacilityNo = "Facility No" };
			var usageList = new List<Usage> { usageA, usageB };

			// Result is list of usage Ids joined by ',' separator
			var usages = PostUsages(usageList).Result.Split(',').ToList();

			var usagePK = Guid.Parse(usages.FirstOrDefault());

			// Usage Id is required for item insert, in this case free-form item will be created
			var usageLineItemA = new UsageItem { UsageId = usagePK };
			var usageLineItemB = new UsageItem { UsageId = usagePK };
			var usageLineItemList = new List<UsageItem> { usageLineItemA, usageLineItemB };

			await PostUsageItems(usageLineItemList);

			// Usage ID and Procedure No are required for usage procedure creation
			var usageProcedureA = new UsageProcedure { UsageId = usagePK, ProcedureNo = "ProcedureNo A" };
			var usageProcedureB = new UsageProcedure { UsageId = usagePK, ProcedureNo = "ProcedureNo B" };
			var usageProcedureList = new List<UsageProcedure> { usageProcedureA, usageProcedureB };

			await PostUsageProcedures(usageProcedureList);

			// Usage Id is required for usage submit
			var usageSubmitA = new Usage { UsageId = usagePK };
			var usageSubmitB = new Usage { UsageId = Guid.Parse(usages[1]) };
			var usageSubmitList = new List<Usage> { usageSubmitA, usageSubmitB };

			// Result is list of dictionary <Guid,string>, where Guid is unsubmitted usage Id and message with error description
			// In success case result will be empty
			var result = SubmitUsages(usageSubmitList).Result;
		}

		/// <summary>
		/// Create usages.
		/// </summary>
		/// <param name="usages">List of usages.</param>
		/// <returns>Ids of new created Usages - string of Guid joined by ",".</returns>
		public static async Task<string> PostUsages(List<Usage> usages)
		{
			await SetAuthHeader();
			var content = new StringContent(Serialize(new { usages }), Encoding.UTF8, "application/json");
			var response = await Client.PostAsync($"/odata/Usages/BulkAdd", content);
			return JsonConvert.DeserializeObject<ODataSingleValueResponse<string>>(await response.Content.ReadAsStringAsync()).Value;
		}
	
		/// <summary>
		/// Posts the usage items.
		/// </summary>
		/// <param name="usageItems">List of usage items.</param>
		/// <returns>Id of new created Usage Items.</returns>
		public static async Task PostUsageItems(List<UsageItem> usageItems)
		{
			await SetAuthHeader();
			var content = new StringContent(Serialize(new { usageItems }), Encoding.UTF8, "application/json");
			var response = await Client.PostAsync("/odata/UsageItems/BulkAdd", content);
			await response.Content.ReadAsStringAsync();
		}

		/// <summary>
		/// Posts the usage procedures.
		/// </summary>
		/// <param name="usageProcedures">List of usage procedures.</param>
		/// <returns>Id of new created Usage Procedures.</returns>
		public static async Task PostUsageProcedures(List<UsageProcedure> usageProcedures)
		{
			await SetAuthHeader();
			var content = new StringContent(Serialize(new { usageProcedures }), Encoding.UTF8, "application/json");
			var response = await Client.PostAsync("/odata/UsageProcedures/BulkAdd", content);
			await response.Content.ReadAsStringAsync();
		}

		/// <summary>
		/// Submits the usages.
		/// </summary>
		/// <param name="usageIds">List of usages.</param>
		/// <returns>Result of usages submittions.</returns>
		public static async Task<Dictionary<Guid, string>> SubmitUsages(List<Usage> usageIds)
		{
			await SetAuthHeader();
			var content = new StringContent(Serialize(new { usageIds }), Encoding.UTF8, "application/json");
			var response = await Client.PostAsync("/odata/Usages/BulkSubmit", content);
			return JsonConvert.DeserializeObject<Dictionary<Guid, string>>(
				JsonConvert.DeserializeObject<ODataErrorResponse>(await response.Content.ReadAsStringAsync())
					.Description
					.Message);
		}

		#endregion

		#region Odata Query Options Examples

		/// <summary>
		/// Formats the examples.
		/// </summary>
		/// <returns>Task.</returns>
		private static async Task FormatExamples()
		{
			var inventoryUrl = "/odata/Inventory";
			//Obtain JWT token and set access token to authorization header
			await SetAuthHeader();

			// retrieving Inventory list with default metadata amount
			var response = await Client.GetAsync(inventoryUrl);
			var result = JsonConvert.DeserializeObject<ODataListResponse<Inventory>>(await response.Content.ReadAsStringAsync());

			// retrieving Inventory list with default metadata amount specified explicitly
			response = await Client.GetAsync($"{inventoryUrl}?$format=application/json;odata.metadata=minimal");
			result = JsonConvert.DeserializeObject<ODataListResponse<Inventory>>(await response.Content.ReadAsStringAsync());

			// retrieving Inventory list without metadata information included
			// Notice: result variable is of ODataListResponse<Inventory> type, so ODataContext property should be "null" since 
			// it does not included into response
			response = await Client.GetAsync($"{inventoryUrl}?$format=application/json;odata.metadata=none");
			var stringResult = await response.Content.ReadAsStringAsync();
			result = JsonConvert.DeserializeObject<ODataListResponse<Inventory>>(stringResult);

			// retrieving Inventory list with all possible metadata information included
			// Notice: result variable is of ODataListResponse<Inventory> type, so no additional data will be included into .net object
			// to observe the difference with default metadata amount, please examine stringResult variable.
			// In order to have all properties available in .net class, the class itself should be regenerated based on extended JSON
			// There is no sense to generate this class at the moment since it contains all entity related information,
			// including action and functions, which are subjects of future changes
			response = await Client.GetAsync($"{inventoryUrl}?$format=application/json;odata.metadata=full");
			stringResult = await response.Content.ReadAsStringAsync();
			result = JsonConvert.DeserializeObject<ODataListResponse<Inventory>>(stringResult);
		}

		/// <summary>
		/// Searches the examples.
		/// </summary>
		/// <returns>Task.</returns>
		private static async Task SearchExamples()
		{
			var inventoryUrl = "/odata/Inventory";
			//Obtain JWT token and set access token to authorization header
			await SetAuthHeader();

			// search by all fields with "test" search value
			var response = await Client.GetAsync($"{inventoryUrl}?$search=test");
			var result = JsonConvert.DeserializeObject<ODataListResponse<Inventory>>(await response.Content.ReadAsStringAsync());
		}

		/// <summary>
		/// Filterings the examples.
		/// </summary>
		/// <returns>Task.</returns>
		private static async Task FilteringExamples()
		{
			var inventoryUrl = "/odata/Inventory";
			//Obtain JWT token and set access token to authorization header
			await SetAuthHeader();

			// filtering by inventoryDescription field with strict match
			var response = await Client.GetAsync($"{inventoryUrl}?$filter=inventoryDescription eq 'test'");
			var result = JsonConvert.DeserializeObject<ODataListResponse<Inventory>>(await response.Content.ReadAsStringAsync());

			// filtering by inventoryDescription field with LIKE expression
			response = await Client.GetAsync($"{inventoryUrl}?$filter=contains(inventoryDescription,'test')");
			result = JsonConvert.DeserializeObject<ODataListResponse<Inventory>>(await response.Content.ReadAsStringAsync());

			// filtering by inventoryNo field with LIKE expression and by classificationName field with strict match
			// Note: Mix of AND/OR statements in one query is not supported.
			response = await Client.GetAsync($"{inventoryUrl}?$filter=contains(inventoryNo,'inv') AND classificationName eq 'medication'");
			result = JsonConvert.DeserializeObject<ODataListResponse<Inventory>>(await response.Content.ReadAsStringAsync());

			// filtering by classificationName field with strict match or by systemType field with strict match
			// Note: Mix of AND/OR statements in one query is not supported.
			response = await Client.GetAsync($"{inventoryUrl}?$filter=classificationName eq 'medication' OR systemType eq 'implant'");
			result = JsonConvert.DeserializeObject<ODataListResponse<Inventory>>(await response.Content.ReadAsStringAsync());
		}

		/// <summary>
		/// Converts to pskipexamples.
		/// </summary>
		/// <returns>Task.</returns>
		private static async Task TopSkipExamples()
		{
			var inventoryUrl = "/odata/Inventory";
			//Obtain JWT token and set access token to authorization header
			await SetAuthHeader();

			// retrieve top 50 records
			var response = await Client.GetAsync($"{inventoryUrl}?$top=50");
			var result = JsonConvert.DeserializeObject<ODataListResponse<Inventory>>(await response.Content.ReadAsStringAsync());

			// retrieve top 50 records starting from record #11
			response = await Client.GetAsync($"{inventoryUrl}?$top=50&$skip=10");
			result = JsonConvert.DeserializeObject<ODataListResponse<Inventory>>(await response.Content.ReadAsStringAsync());

			// retrieve default amount of records starting from record #21
			response = await Client.GetAsync($"{inventoryUrl}?$skip=20");
			result = JsonConvert.DeserializeObject<ODataListResponse<Inventory>>(await response.Content.ReadAsStringAsync());
		}

		/// <summary>
		/// Orders the by examples.
		/// </summary>
		/// <returns>Task.</returns>
		private static async Task OrderByExamples()
		{
			var inventoryUrl = "/odata/Inventory";
			//Obtain JWT token and set access token to authorization header
			await SetAuthHeader();

			// sorting by notes field in ascending order
			var response = await Client.GetAsync($"{inventoryUrl}?$orderBy=notes");
			var result = JsonConvert.DeserializeObject<ODataListResponse<Inventory>>(await response.Content.ReadAsStringAsync());

			// sorting by classificationName field in ascending order by specifying sorting direction explicitly
			response = await Client.GetAsync($"{inventoryUrl}?$orderBy=classificationName asc");
			result = JsonConvert.DeserializeObject<ODataListResponse<Inventory>>(await response.Content.ReadAsStringAsync());

			// sorting by stockUOM field in descending order by specifying sorting direction explicitly
			response = await Client.GetAsync($"{inventoryUrl}?$orderBy=stockUOM desc");
			result = JsonConvert.DeserializeObject<ODataListResponse<Inventory>>(await response.Content.ReadAsStringAsync());
		}

		#endregion

		#region Private Methods

		/// <summary>
		/// Gets the new inventory.
		/// </summary>
		/// <returns>Retrun new Inventory.</returns>
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

		/// <summary>
		/// Serializes the specified target.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="target">The target.</param>
		/// <returns>System.String.</returns>
		private static string Serialize<T>(T target)
		{
			var serializerSettings = new JsonSerializerSettings
			{
				ContractResolver = new CamelCasePropertyNamesContractResolver(),
				NullValueHandling = NullValueHandling.Ignore
			};

			return JsonConvert.SerializeObject(target, serializerSettings);
		}

		/// <summary>
		/// Sets the authentication header.
		/// </summary>
		private static async Task<bool> SetAuthHeader()
		{
			var auth = await GetToken();
			if (auth != null)
			{
				Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", auth.AccessToken);
			}

			return auth != null;
		}

		/// <summary>
		/// Gets the client.
		/// </summary>
		/// <value>The HTTP client.</value>
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

		#endregion
	}
}

