using System;
using System.Threading.Tasks;

using Envi.SDK.Examples;

namespace Envi.SDK;

/// <summary>
/// Class Program.
/// </summary>
internal static class Program
{
	#region Entry Point

	/// <summary>
	/// Defines the entry point of the application.
	/// </summary>
	public static async Task Main()
	{
		if (!SdkRuntimeConfiguration.TryLoad(out var configuration))
		{
			return;
		}

		var inventoryExamples = new InventoryExampleRunner(configuration);
		var batchExamples = new BatchRequestExampleRunner(configuration);
		var inventoryMasterExamples = new InventoryMasterInterfaceRunner(configuration);
		var odataQueryExamples = new ODataQueryExamplesRunner(configuration);
		var depletionExamples = new DepletionInterfaceRunner(configuration);

		// Inventory examples contains simple operation for Inventory like new item creation, update, patch, retrieving paged list
		// of Inventory or individual item by its primary key
		await inventoryExamples.RunAsync();

		// Contains an example on how to execute requests in a batch, so one batch request contains multiple individual requests
		// which are executed separately on the server side and results are combined to a single response
		await batchExamples.RunAsync();

		// Example on how to invoke few different API end-points in order to obtain the same data as
		// returned by current Inventory Master interface (changed Inventory, corresponding Inventory/Locations
		// and Inventory/Vendors and related Vendors information)
		await inventoryMasterExamples.RunAsync(new DateTime(2017, 10, 1, 0, 0, 0, DateTimeKind.Utc), null, null);

		// OData query options usage examples shows how to use system query options correctly based on Inventory end-point
		await odataQueryExamples.RunAllAsync();

		// Example how to use HTTP depletion interface using OData API
		await depletionExamples.RunAsync();
	}

	#endregion
}
