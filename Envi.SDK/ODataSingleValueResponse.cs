using Newtonsoft.Json;

namespace Envi.SDK;

/// <summary>
/// Class ODataSingleValueResponse.
/// </summary>
public class ODataSingleValueResponse<T>
{
	#region Members

	/// <summary>
	/// Gets or sets the odata context.
	/// </summary>
	[JsonProperty("@odata.context")]
	public string ODataContext { get; set; }

	/// <summary>
	/// Gets or sets the value.
	/// </summary>
	public T Value { get; set; }

	#endregion
}