using System;
using Newtonsoft.Json;

namespace Envi.SDK
{
	/// <summary>
	/// Class JWT.
	/// </summary>
	public class JWT
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="JWT"/> class.
		/// </summary>
		public JWT()
		{
			IssuedAt = DateTime.Now;
		}

		/// <summary>
		/// Gets or sets the access token.
		/// </summary>
		[JsonProperty("access_token")]
		public string AccessToken { get; set; }

		/// <summary>
		/// Converts to kentype.
		/// </summary>
		[JsonProperty("token_type")]
		public string TokenType { get; set; }

		/// <summary>
		/// Gets or sets the expires in.
		/// </summary>
		[JsonProperty("expires_in")]
		public int ExpiresIn { get; set; }

		/// <summary>
		/// Gets or sets the refresh token.
		/// </summary>
		[JsonProperty("refresh_token")]
		public string RefreshToken { get; set; }

		/// <summary>
		/// Gets the issued at.
		/// </summary>
		[JsonIgnore]
		public DateTime IssuedAt { get; }

		/// <summary>
		/// Returns isvalid value.
		/// </summary>
		[JsonIgnore]
		public bool IsValid => IssuedAt.AddSeconds(ExpiresIn) > DateTime.Now;
	}
}

