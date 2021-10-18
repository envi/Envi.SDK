using System.Collections.Generic;
using Newtonsoft.Json;

namespace Envi.SDK
{
	/// <summary>
	/// Class ODataListResponse.
	/// </summary>
	public class ODataListResponse<T>
	{
		/// <summary>
		/// Gets or sets the odata context.
		/// </summary>
		[JsonProperty("@odata.context")]
		public string ODataContext { get; set; }

		/// <summary>
		/// Gets or sets the odata count.
		/// </summary>
		[JsonProperty("@odata.count")]
		public int ODataCount { get; set; }

		/// <summary>
		/// Gets or sets the odata next link.
		/// </summary>
		[JsonProperty("@odata.nextLink")]
		public string ODataNextLink { get; set; }

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		public List<T> Value { get; set; }
	}
}

