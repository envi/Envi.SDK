using System.Collections.Generic;
using Newtonsoft.Json;

namespace IOSCorp.SDK
{
	/// <summary>
	/// Class ListRepresentation.
	/// </summary>
	public class ListRepresentation<T>
	{
		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		[JsonProperty("value")]
		public List<T> Value { get; set; }
	}
}
