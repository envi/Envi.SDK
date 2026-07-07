namespace Envi.SDK
{
	/// <summary>
	/// Shared string constants used by HTTP request and content composition.
	/// </summary>
	internal static class Constants
	{
		#region Members

		/// <summary>
		/// MIME type for JSON payloads.
		/// </summary>
		public const string JsonContentType = "application/json";

		/// <summary>
		/// MIME type for encapsulated HTTP content in OData batch requests.
		/// </summary>
		public const string HttpContentType = "application/http";

		/// <summary>
		/// Header name used to control HTTP content type.
		/// </summary>
		public const string ContentTypeHeader = "Content-Type";

		#endregion
	}
}
