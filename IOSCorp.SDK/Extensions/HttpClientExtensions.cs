using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace IOSCorp.SDK.Extensions
{
	/// <summary>
	/// Class HttpClientExtensions.
	/// </summary>
	public static class HttpClientExtensions
	{
		/// <summary>
		/// Perform PATCH request.
		/// </summary>
		/// <param name="client">The HTTP client.</param>
		/// <param name="requestUri">The request URI.</param>
		/// <param name="content">The content.</param>
		/// <returns>Result of request.</returns>
		public static Task<HttpResponseMessage> PatchAsync(this HttpClient client, string requestUri, HttpContent content)
		{
			HttpRequestMessage request = new HttpRequestMessage {
				Method = new HttpMethod("PATCH"),
				RequestUri = new Uri($"{client.BaseAddress}{requestUri}"),
				Content = content
			};
			return client.SendAsync(request);
		}
	}
}

