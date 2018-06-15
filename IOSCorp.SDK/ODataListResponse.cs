using Newtonsoft.Json;
using System.Collections.Generic;

namespace IOSCorp.SDK
{
	public class ODataListResponse<T>
    {
        [JsonProperty("@odata.context")]
        public string ODataContext { get; set; }

        [JsonProperty("@odata.count")]
        public int ODataCount { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string ODataNextLink { get; set; }

        public List<T> Value { get; set; }
    }
}

