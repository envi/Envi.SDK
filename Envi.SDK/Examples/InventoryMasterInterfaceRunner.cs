using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Api.Common.Entities.Inventory.DTO;
using Api.Common.Entities.InventoryLocations.DTO;
using Api.Common.Entities.InventoryVendors.DTO;
using Api.Common.Entities.Vendors.DTO;

namespace Envi.SDK.Examples;

/// <summary>
/// Demonstrates retrieval of inventory master data across related endpoints.
/// </summary>
internal sealed class InventoryMasterInterfaceRunner(SdkRuntimeConfiguration configuration)
{
	#region Public Methods

	/// <summary>
	/// Inventories the master interface.
	/// </summary>
	/// <param name="lastRunDate">The last run date.</param>
	/// <param name="facilityId">The facility pk.</param>
	/// <param name="syncFlag">if set to <c>true</c> [synchronize flag].</param>
	/// <returns>Task.</returns>
	public async Task<(List<VendorInfo>, List<Inventory>)> RunAsync(DateTime lastRunDate, Guid? facilityId, bool? syncFlag)
	{
		const string inventoryUrlTemplate = "GetAllFromDate(from={0},facilityId={1},syncFlag={2})";
		const string inventoryLocationsUrlTemplate = "GetAllFromDate(from={0},facilityId={1},syncFlag={2})";
		const string inventoryVendorsUrlTemplate = "GetAllFromDate(from={0},facilityId={1},syncFlag={2})";
		const string vendorsUrlTemplate = "GetVendorsInfo(facilityId={0})";
		const string dateFormat = "yyyy-MM-dd";

		var client = new EnviODataClient(
			configuration.BaseAddress,
			configuration.ClientId,
			configuration.UserName,
			configuration.Password);

		// Retrieving of Inventory Info
		var inventoryUrl = string.Format($"{ApiRoutes.Inventory}/{inventoryUrlTemplate}",
			lastRunDate.ToString(dateFormat),
			facilityId?.ToString() ?? "null",
			syncFlag?.ToString() ?? "null");

		var inventoryResponse = await client.Get<ODataListResponse<Inventory>>(inventoryUrl);

		var inventoryLocationsUrl = string.Format($"{ApiRoutes.InventoryLocations}/{inventoryLocationsUrlTemplate}",
			lastRunDate.ToString(dateFormat),
			facilityId?.ToString() ?? "null",
			syncFlag?.ToString() ?? "null");

		var inventoryLocationsResponse = await client.Get<ODataListResponse<InventoryLocation>>(inventoryLocationsUrl);

		var inventoryVendorsUrl = string.Format($"{ApiRoutes.InventoryVendors}/{inventoryVendorsUrlTemplate}",
			lastRunDate.ToString(dateFormat),
			facilityId?.ToString() ?? "null",
			syncFlag?.ToString() ?? "null");

		var inventoryVendorsResponse = await client.Get<ODataListResponse<InventoryVendor>>(inventoryVendorsUrl);

		// Getting information combined (adding of Inventory/Vendors and Inventory/Locations to corresponding Inventory)
		inventoryResponse.Value.ForEach(i => i.InventoryLocations = [.. inventoryLocationsResponse.Value.Where(il => il.InventoryId == i.InventoryId)]);
		inventoryResponse.Value.ForEach(i => i.InventoryVendors = [.. inventoryVendorsResponse.Value.Where(iv => iv.InventoryId == i.InventoryId)]);

		// Retrieving of resulting Vendor Ids
		var vendorIds = inventoryVendorsResponse.Value.GroupBy(pk => pk.VendorId).Select(g => g.Key).ToList();

		// Retrieving of Vendors information
		var vendorsUrl = string.Format($"{ApiRoutes.Vendors}/{vendorsUrlTemplate}", facilityId?.ToString() ?? "null");
		var idList = new ListRepresentation<Guid?> { Value = vendorIds };
		var vendorsResponse = await client.Post<ListRepresentation<Guid?>, ODataListResponse<VendorInfo>>(vendorsUrl, idList);

		// Interface data consists of two lists:
		return (vendorsResponse.Value, inventoryResponse.Value);
	}

	#endregion
}
