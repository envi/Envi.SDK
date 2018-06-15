using Newtonsoft.Json;

namespace IOSCorp.SDK
{
	public class ODataSingleValueResponse<T>
    {
        [JsonProperty("@odata.context")]
        public string ODataContext { get; set; }

        public T Value { get; set; }
    }
}

