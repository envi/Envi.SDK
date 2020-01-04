using Newtonsoft.Json;

namespace IOSCorp.SDK
{
	/// <summary>
	/// Class ODataSingleValueResponse.
	/// </summary>
	public class ODataSingleValueResponse<T>
	{
		/// <summary>
		/// Gets or sets the odata context.
		/// </summary>
		[JsonProperty("@odata.context")]
		public string ODataContext { get; set; }

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		public T Value { get; set; }
	}
}