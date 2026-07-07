using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Api.Common.Entities.Usages.DTO;

using Newtonsoft.Json;

namespace Envi.SDK.Examples;

/// <summary>
/// Demonstrates depletion API flow for usages, usage items, usage procedures, and submission.
/// </summary>
internal sealed class DepletionInterfaceRunner(SdkRuntimeConfiguration configuration)
{
	private readonly EnviODataClient _client = new(
		configuration.BaseAddress,
		configuration.ClientId,
		configuration.UserName,
		configuration.Password);

	#region Public Methods

	/// <summary>
	/// Depletion interface.
	/// </summary>
	/// <returns>Task.</returns>
	public async Task<Dictionary<Guid, string>> RunAsync()
	{
		var usageList = configuration.FacilityList.Select(f => new Usage { FacilityNo = f.Trim() }).ToList();

		// Result is list of usage Ids joined by ',' separator
		var usages = (await CreateUsagesAsync(usageList)).Split(',').ToList();

		var usageId = Guid.Parse(usages[0]);

		// Usage Id is required for item insert, in this case free-form item will be created
		var usageLineItems = new List<UsageItem>
		{
			new() { UsageId = usageId },
			new() { UsageId = usageId }
		};
		await CreateUsageItemsAsync(usageLineItems);

		// Usage ID and Procedure No are required for usage procedure creation
		var usageProcedures = new List<UsageProcedure>
		{
			new() { UsageId = usageId, ProcedureNo = "ProcedureNo A" },
			new() { UsageId = usageId, ProcedureNo = "ProcedureNo B" }
		};
		await CreateUsageProceduresAsync(usageProcedures);

		// Usage Id is required for usage submit
		var usageSubmissions = new List<Usage>
		{
			new() { UsageId = usageId },
			new() { UsageId = Guid.Parse(usages[1]) }
		};

		// Result is list of dictionary <Guid,string>, where Guid is unsubmitted usage Id and message with error description
		// In success case result will be empty
		return await SubmitUsagesAsync(usageSubmissions);
	}

	#endregion

	#region Private Methods

	/// <summary>
	/// Create usages.
	/// </summary>
	/// <param name="usages">List of usages.</param>
	/// <returns>Ids of new created Usages - string of Guid joined by ",".</returns>
	private async Task<string> CreateUsagesAsync(List<Usage> usages)
	{
		var result = await _client.Post<object, ODataSingleValueResponse<string>>($"{ApiRoutes.Usages}/BulkAdd", new { usages });

		return result.Value;
	}

	/// <summary>
	/// Posts the usage items.
	/// </summary>
	/// <param name="usageItems">List of usage items.</param>
	/// <returns>Id of new created Usage Items.</returns>
	private async Task<string> CreateUsageItemsAsync(List<UsageItem> usageItems)
	{
		using var response = await _client.PostRaw($"{ApiRoutes.UsageItems}/BulkAdd", new { usageItems });

		var result = await response.Content.ReadAsStringAsync();

		return result;
	}

	/// <summary>
	/// Posts the usage procedures.
	/// </summary>
	/// <param name="usageProcedures">List of usage procedures.</param>
	/// <returns>Id of new created Usage Procedures.</returns>
	private async Task<string> CreateUsageProceduresAsync(List<UsageProcedure> usageProcedures)
	{
		using var response = await _client.PostRaw($"{ApiRoutes.UsageProcedures}/BulkAdd", new { usageProcedures });

		var result = await response.Content.ReadAsStringAsync();

		return result;
	}

	/// <summary>
	/// Submits the usages.
	/// </summary>
	/// <param name="usageIds">List of usages.</param>
	/// <returns>Result of usages submittions.</returns>
	private async Task<Dictionary<Guid, string>> SubmitUsagesAsync(List<Usage> usageIds)
	{
		var errorResponse = await _client.Post<object, ODataErrorResponse>($"{ApiRoutes.Usages}/BulkSubmit", new { usageIds });

		var result = JsonConvert.DeserializeObject<Dictionary<Guid, string>>(errorResponse!.Description)!;

		return result;
	}

	#endregion
}
