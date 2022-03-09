using Newtonsoft.Json;

namespace Envi.SDK
{
	/// <summary>
	/// Class ODataErrorResponse.
	/// </summary>
	class ODataErrorResponse
	{
		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		[JsonProperty("value")]
		public string Description { get; set; }
	}
}
