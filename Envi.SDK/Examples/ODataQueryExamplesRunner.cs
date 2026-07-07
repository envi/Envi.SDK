using System.Threading.Tasks;

using Api.Common.Entities.Inventory.DTO;
using Api.Common.Entities.Receiving.DTO;

namespace Envi.SDK.Examples;

/// <summary>
/// Demonstrates OData query options for inventory and receipt endpoints.
/// </summary>
internal sealed class ODataQueryExamplesRunner(SdkRuntimeConfiguration configuration)
{
	private readonly EnviODataClient _client = new(
			configuration.BaseAddress,
			configuration.ClientId,
			configuration.UserName,
			configuration.Password);

	#region Public Methods

	/// <summary>
	/// Runs all OData query option examples.
	/// </summary>
	/// <returns>Task.</returns>
	public async Task RunAllAsync()
	{
		// retrieve top 50 records
		await TopSkipExamplesAsync("$top=50");

		// retrieve top 50 records starting from record #11
		await TopSkipExamplesAsync("$top=50&$skip=10");

		// retrieve default amount of records starting from record #21
		await TopSkipExamplesAsync("$skip=20");

		// sorting by notes field in ascending order
		await OrderByExamplesAsync("notes");

		// sorting by classificationName field in ascending order by specifying sorting direction explicitly
		await OrderByExamplesAsync("classificationName asc");

		// sorting by stockUOM field in descending order by specifying sorting direction explicitly
		await OrderByExamplesAsync("stockUOM desc");

		// filtering by facilityNo field with strict match
		await FilteringExamplesAsync("facilityNo eq 'test'");

		// filtering by facilityNo field with LIKE expression
		await FilteringExamplesAsync("contains(facilityNo,'test')");

		// filtering by facilityNo field with LIKE expression and by vendorName field with strict match
		// Note: Mix of AND/OR statements in one query is not supported.
		await FilteringExamplesAsync("contains(facilityNo,'TestFacility') AND vendorName eq 'TestVendor'");

		// filtering by vendorName field with strict match or by buyerName field with strict match
		// Note: Mix of AND/OR statements in one query is not supported.
		await FilteringExamplesAsync("vendorName eq 'medication' OR buyerName eq 'Jack Winston'");

		// filtering by dateAdded field with 'IN' operator
		await FilteringExamplesAsync("dateAdded in ('2019-06-23', '2019-06-25', '2019-06-27')");

		// filtering by sequenceNo field with 'IN' operator
		await FilteringExamplesAsync("sequenceNo in ('1563', '10', '50')");

		// filtering by leadTime field with 'lt' (less than) operator
		await FilteringExamplesAsync("leadTime lt 9");

		// filtering by leadTime field with 'le' (less equal) operator
		await FilteringExamplesAsync("leadTime le 9");

		// filtering by leadTime field with 'gt' (great than) operator
		await FilteringExamplesAsync("leadTime gt 9");

		// filtering by leadTime field with 'ge' (great equal) operator
		await FilteringExamplesAsync("leadTime ge 9");

		// filtering by expectedDeliveryDate field with 'lt' (less than) operator
		await FilteringExamplesAsync("expectedDeliveryDate lt 2019-07-30");

		// filtering by expectedDeliveryDate field with 'le' (less equal) operator
		await FilteringExamplesAsync("expectedDeliveryDate le 2019-07-30");

		// filtering by expectedDeliveryDate field with 'gt' (great than) operator
		await FilteringExamplesAsync("expectedDeliveryDate gt 2019-07-30");

		// filtering by expectedDeliveryDate field with 'ge' (great equal) operator
		await FilteringExamplesAsync("expectedDeliveryDate ge 2019-07-30");

		// search by all fields with "test" search value
		await SearchExamplesAsync();

		// retrieving Inventory list with default metadata amount
		await FormatExamplesAsync();

		// retrieving Inventory list with default metadata amount specified explicitly
		await FormatExamplesAsync("application/json;odata.metadata=minimal");

		// retrieving Inventory list without metadata information included
		// Notice: result variable is of ODataListResponse<Inventory> type, so ODataContext property should be "null" since
		// it does not included into response
		await FormatExamplesAsync("application/json;odata.metadata=none");

		// retrieving Inventory list with all possible metadata information included
		// Notice: result variable is of ODataListResponse<Inventory> type, so no additional data will be included into .net object
		// to observe the difference with default metadata amount, please examine stringResult variable.
		// In order to have all properties available in .net class, the class itself should be regenerated based on extended JSON
		// There is no sense to generate this class at the moment since it contains all entity related information,
		// including action and functions, which are subjects of future changes
		await FormatExamplesAsync("application/json;odata.metadata=full");
	}

	#endregion

	#region Private Methods

	/// <summary>
	/// Executes a format example query.
	/// </summary>
	/// <param name="format">Optional OData format expression.</param>
	/// <returns>Inventory response payload.</returns>
	private async Task<ODataListResponse<Inventory>> FormatExamplesAsync(string format = null)
	{
		var parameters = string.IsNullOrWhiteSpace(format) ? ApiRoutes.Inventory : $"{ApiRoutes.Inventory}?$format={format}";

		var result = await _client.Get<ODataListResponse<Inventory>>(parameters);

		return result;
	}

	/// <summary>
	/// Executes a search example query.
	/// </summary>
	/// <returns>Inventory response payload.</returns>
	private async Task<ODataListResponse<Inventory>> SearchExamplesAsync()
	{
		var result =  await _client.Get<ODataListResponse<Inventory>>($"{ApiRoutes.Inventory}?$search=test");

		return result;
	}

	/// <summary>
	/// Executes a filter example query.
	/// </summary>
	/// <param name="filter">OData filter expression.</param>
	/// <returns>Receipt response payload.</returns>
	private async Task<ODataListResponse<Receipt>> FilteringExamplesAsync(string filter)
	{
		var result = await _client.Get<ODataListResponse<Receipt>>($"{ApiRoutes.Receipts}?$filter={filter}");

		return result;
	}

	/// <summary>
	/// Executes a top/skip example query.
	/// </summary>
	/// <param name="parameter">Top/skip query expression.</param>
	/// <returns>Inventory response payload.</returns>
	private async Task<ODataListResponse<Inventory>> TopSkipExamplesAsync(string parameter)
	{
		var result = await _client.Get<ODataListResponse<Inventory>>($"{ApiRoutes.Inventory}?{parameter}");

		return result;
	}

	/// <summary>
	/// Executes an order-by example query.
	/// </summary>
	/// <param name="parameter">Order-by query expression.</param>
	/// <returns>Inventory response payload.</returns>
	private async Task<ODataListResponse<Inventory>> OrderByExamplesAsync(string parameter)
	{
		var result = await _client.Get<ODataListResponse<Inventory>>($"{ApiRoutes.Inventory}?$orderBy={parameter}");

		return result;
	}

	#endregion
}
