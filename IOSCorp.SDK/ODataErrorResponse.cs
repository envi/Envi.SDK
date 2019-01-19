using Newtonsoft.Json;

namespace IOSCorp.SDK
{
	/// <summary>
	/// Class ODataErrorResponse.
	/// </summary>
	class ODataErrorResponse
	{
		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		[JsonProperty("error")]
		public Error Description { get; set; }
	}

	/// <summary>
	/// Class Error.
	/// </summary>
	public class Error
	{
		/// <summary>
		/// Gets or sets the code.
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		/// Gets or sets the message.
		/// </summary>
		[JsonProperty("message")]
		public string Message { get; set; }
	}
}
