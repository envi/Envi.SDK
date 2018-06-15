using Newtonsoft.Json;
using System;

namespace IOSCorp.SDK
{
	public class JWT
    {
        public JWT()
        {
            IssuedAt = DateTime.Now;
        }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonIgnore]
        public DateTime IssuedAt { get; }

        [JsonIgnore]
        public bool IsValid => IssuedAt.AddSeconds(ExpiresIn) > DateTime.Now;
    }
}

