using System;

using Microsoft.Extensions.Configuration;

namespace Envi.SDK;

/// <summary>
/// Holds strongly typed runtime settings loaded from appsettings.json.
/// </summary>
internal sealed class SdkRuntimeConfiguration
{
	#region Constructor

	/// <summary>
	/// Initializes a new instance of the <see cref="SdkRuntimeConfiguration"/> class.
	/// </summary>
	/// <param name="baseAddress">Base URL of the API service.</param>
	/// <param name="userName">OAuth user name.</param>
	/// <param name="password">OAuth password.</param>
	/// <param name="clientId">OAuth client identifier.</param>
	/// <param name="inventoryGroupId">Default inventory group identifier used by examples.</param>
	/// <param name="facilityList">Configured facility numbers used by depletion examples.</param>
	private SdkRuntimeConfiguration(
		string baseAddress,
		string userName,
		string password,
		string clientId,
		Guid inventoryGroupId,
		string[] facilityList)
	{
		BaseAddress = baseAddress;
		UserName = userName;
		Password = password;
		ClientId = clientId;
		InventoryGroupId = inventoryGroupId;
		FacilityList = facilityList;
	}

	#endregion

	#region Public Properties

	/// <summary>
	/// Gets the base URL of the API service.
	/// </summary>
	public string BaseAddress { get; }

	/// <summary>
	/// Gets the OAuth user name.
	/// </summary>
	public string UserName { get; }

	/// <summary>
	/// Gets the OAuth password.
	/// </summary>
	public string Password { get; }

	/// <summary>
	/// Gets the OAuth client identifier.
	/// </summary>
	public string ClientId { get; }

	/// <summary>
	/// Gets the default inventory group identifier.
	/// </summary>
	public Guid InventoryGroupId { get; }

	/// <summary>
	/// Gets the configured list of facility numbers.
	/// </summary>
	public string[] FacilityList { get; }

	#endregion

	#region Public Methods

	/// <summary>
	/// Attempts to load required runtime settings from appsettings.json.
	/// </summary>
	/// <param name="configuration">Loaded runtime configuration when successful.</param>
	/// <returns>True when all required settings are present; otherwise false.</returns>
	public static bool TryLoad(out SdkRuntimeConfiguration configuration)
	{
		var builder = new ConfigurationBuilder()
			.AddJsonFile("appsettings.json", false, true);

		IConfiguration configurationManager = builder.Build();

		var baseAddress = configurationManager["baseAddress"];
		var userName = configurationManager["userName"];
		var password = configurationManager["password"];
		var clientId = configurationManager["clientId"];
		var inventoryGroupIdString = configurationManager["inventoryGroupId"];
		var facilitiesNoString = configurationManager["facilitiesNoList"];

		if (string.IsNullOrWhiteSpace(baseAddress)
			|| string.IsNullOrWhiteSpace(userName)
			|| string.IsNullOrWhiteSpace(password)
			|| string.IsNullOrWhiteSpace(clientId)
			|| string.IsNullOrWhiteSpace(inventoryGroupIdString)
			|| string.IsNullOrWhiteSpace(facilitiesNoString))
		{
			Console.WriteLine("Some of the required configuration values are missing. Please check AppSetting section of appsettings.json.");
			configuration = null;
			return false;
		}

		configuration = new SdkRuntimeConfiguration(
			baseAddress,
			userName,
			password,
			clientId,
			Guid.Parse(inventoryGroupIdString),
			facilitiesNoString.Split(','));

		return true;
	}

	#endregion
}
