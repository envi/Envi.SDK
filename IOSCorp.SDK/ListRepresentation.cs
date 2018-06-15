using System.Collections.Generic;
using Newtonsoft.Json;

namespace IOSCorp.SDK
{
	public class ListRepresentation<T>
	{
		[JsonProperty("value")]
		public List<T> Value { get; set; }
	}
}
