using System;
using System.Threading.Tasks;

using Api.Common.Entities.Inventory.DTO;

namespace Envi.SDK.Examples;

/// <summary>
/// Demonstrates basic CRUD-style inventory API operations.
/// </summary>
internal sealed class InventoryExampleRunner(SdkRuntimeConfiguration configuration)
{
	#region Public Methods

	/// <summary>
	/// Inventory examples contains simple operation for Inventory like new item creation, update, patch, retrieving paged list
	/// of Inventory or individual item by its primary key.
	/// </summary>
	/// <returns>Inventory.</returns>
	public async Task<Inventory> RunAsync()
	{
		var client = CreateODataClient();
		var inventoryList = await GetInventoryListAsync();

		Inventory inventoryById = null;
		var inventoryId = inventoryList.Value[0].InventoryId;

		if (inventoryId is not null)
		{
			inventoryById = await GetInventoryByIdAsync(inventoryId.Value);
		}

		var newItem = CreateNewInventoryItem();
		var createResponse = await client.Post<Inventory, ODataSingleValueResponse<Guid>>(ApiRoutes.Inventory, newItem);

		var inventory = await client.Get<Inventory>($"{ApiRoutes.Inventory}({createResponse.Value})");

		inventory.HCPCSCode = "H0001";
		inventory.UNSPSCCode = "41120000";

		var isUpdated = await client.Put($"{ApiRoutes.Inventory}({inventory.InventoryId!.Value})", inventory);

		if (isUpdated)
		{
			inventoryById = await client.Get<Inventory>($"{ApiRoutes.Inventory}({inventory.InventoryId.Value})");
		}

		var patch = new Inventory
		{
			UNSPSCCode = "41120001"
		};

		var isPatched = await client.Patch($"{ApiRoutes.Inventory}({inventory.InventoryId.Value})", patch);

		if (isPatched)
		{
			inventoryById = await client.Get<Inventory>($"{ApiRoutes.Inventory}({inventory.InventoryId.Value})");
		}

		return inventoryById;
	}

	#endregion

	#region Private Methods

	/// <summary>
	/// Gets the inventory by identifier.
	/// </summary>
	/// <param name="inventoryId">The inventory identifier.</param>
	/// <returns>Inventory.</returns>
	private async Task<Inventory> GetInventoryByIdAsync(Guid inventoryId)
	{
		var client = CreateODataClient();

		var result =  await client.Get<Inventory>($"{ApiRoutes.Inventory}({inventoryId})");

		return result;
	}

	/// <summary>
	/// Get Inventory List.
	/// </summary>
	/// <returns>List of Inventory.</returns>
	private async Task<ODataListResponse<Inventory>> GetInventoryListAsync()
	{
		var client = CreateODataClient();

		var result = await client.Get<ODataListResponse<Inventory>>(ApiRoutes.Inventory);

		return result;
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

	#endregion
}
