using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Envi.SDK;

/// <summary>
/// Provides shared HTTP/authentication helpers for SDK example runners.
/// </summary>
/// <param name="baseAddress">Base URL of the API service.</param>
/// <param name="clientId">OAuth client identifier.</param>
/// <param name="userName">OAuth user name.</param>
/// <param name="password">OAuth password.</param>
internal sealed class SdkRequestContext(string baseAddress, string clientId, string userName, string password)
{
	#region Private Fields

	private readonly string _baseAddress = baseAddress;
	private readonly string _clientId = clientId;
	private readonly string _userName = userName;
	private readonly string _password = password;

	private HttpClient _client;
	private Jwt _token;

	#endregion

	#region Public Members

	/// <summary>
	/// Gets a configured HTTP client instance bound to the API base address.
	/// </summary>
	public HttpClient Client
	{
		get
		{
			if (_client is null)
			{
				_client = new HttpClient
				{
					BaseAddress = new Uri(_baseAddress)
				};
				_client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Constants.JsonContentType));
			}

			return _client;
		}
	}

	/// <summary>
	/// Refreshes and applies a bearer token to the shared HTTP client.
	/// </summary>
	/// <returns>True when authorization header is set; otherwise false.</returns>
	public async Task<bool> SetAuthHeaderAsync()
	{
		var auth = await GetTokenAsync();

		if (auth is not null)
		{
			Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", auth.AccessToken);
		}

		return auth is not null;
	}

	/// <summary>
	/// Gets the current valid access token.
	/// </summary>
	/// <returns>OAuth access token string.</returns>
	public async Task<string> GetAccessTokenAsync()
	{
		var token = await GetTokenAsync();
		return token.AccessToken;
	}

	/// <summary>
	/// Serializes an object to camel-case JSON while omitting null values.
	/// </summary>
	/// <typeparam name="T">Type of source object.</typeparam>
	/// <param name="target">Object to serialize.</param>
	/// <returns>Serialized JSON payload.</returns>
	public string Serialize<T>(T target)
	{
		var serializerSettings = new JsonSerializerSettings
		{
			ContractResolver = new CamelCasePropertyNamesContractResolver(),
			NullValueHandling = NullValueHandling.Ignore
		};

		return JsonConvert.SerializeObject(target, serializerSettings);
	}

	#endregion

	#region Private Methods

	/// <summary>
	/// Retrieves a valid JWT token using password or refresh token grant.
	/// </summary>
	/// <returns>Valid token instance.</returns>
	private async Task<Jwt> GetTokenAsync()
	{
		if (_token is null)
		{
			var requestData = new List<KeyValuePair<string, string>>
			{
				new("grant_type", "password"),
				new("client_id", _clientId),
				new("username", _userName),
				new("password", _password)
			};

			_token = await RequestTokenAsync(requestData);
		}

		if (!_token.IsValid)
		{
			var requestData = new List<KeyValuePair<string, string>>
			{
				new("grant_type", "refresh_token"),
				new("client_id", _clientId),
				new("refresh_token", _token.RefreshToken)
			};

			_token = await RequestTokenAsync(requestData);
		}

		return _token;
	}

	/// <summary>
	/// Requests a token from the OAuth token endpoint.
	/// </summary>
	/// <param name="requestData">Token endpoint form parameters.</param>
	/// <returns>Token response payload.</returns>
	private async Task<Jwt> RequestTokenAsync(List<KeyValuePair<string, string>> requestData)
	{
		var response = await Client.PostAsync("oauth2/token", new FormUrlEncodedContent(requestData));
		var content = await response.Content.ReadAsStringAsync();

		return JsonConvert.DeserializeObject<Jwt>(content)!;
	}

	#endregion
}
