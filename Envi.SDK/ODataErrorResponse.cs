using Newtonsoft.Json;

namespace Envi.SDK;

/// <summary>
/// Represents an OData error payload wrapper returned by bulk operations.
/// </summary>
class ODataErrorResponse
{
	#region Members

	/// <summary>
	/// Gets or sets the error description payload mapped from the API's "value" field.
	/// </summary>
	[JsonProperty("value")]
	public string Description { get; set; }

	#endregion
}