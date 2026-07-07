using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Envi.SDK;

/// <summary>
/// Provides authenticated CRUD helpers for Envi OData endpoints.
/// </summary>
public class EnviODataClient
{
	#region Private Fields

	/// <summary>
	/// Base address of OData API Service
	/// </summary>
	private readonly string _baseAddress;

	/// <summary>
	/// Shared request context used for authentication, HTTP execution, and serialization.
	/// </summary>
	private readonly SdkRequestContext _requestContext;

	#endregion

	#region Instance Constructor

	/// <summary>
	/// Creates new instance of <see cref="EnviODataClient"/> using specified information
	/// </summary>
	/// <param name="baseAddress">Base address of OData API Service</param>
	/// <param name="clientId">client_id for OAuth 2.0 password grant flow</param>
	/// <param name="userName">user name for OAuth 2.0 password grant flow</param>
	/// <param name="password">user password for OAuth 2.0 password grant flow</param>
	public EnviODataClient(string baseAddress, string clientId, string userName, string password)
	{
		VerifyOAuthParams(baseAddress, clientId, userName, password);
		_baseAddress = baseAddress;
		_requestContext = new SdkRequestContext(baseAddress, clientId, userName, password);
	}

	#endregion

	#region Public Methods

	/// <summary>
	/// Performs GET request to Envi OData API
	/// </summary>
	/// <typeparam name="T">Type of the expected result</typeparam>
	/// <param name="requestUri">relative target resource Uri</param>
	/// <returns>Instance of <typeparamref name="T"/></returns>
	public async Task<T> Get<T>(string requestUri)
	{
		await EnsureAuthorizationAsync();

		var response = await _requestContext.Client.GetAsync(requestUri);
		var result = JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());

		return result;
	}

	/// <summary>
	/// Retrieves all available pages for the entity type based on specified query
	/// and page size ($top parameter). If no page size is specified, default one
	/// is used instead
	/// </summary>
	/// <typeparam name="T">Type of the expected entity</typeparam>
	/// <param name="requestUri">relative target resource Uri</param>
	/// <returns>All pages/data available based on specified query</returns>
	public async Task<List<T>> GetAllPages<T>(string requestUri)
	{
		var result = new List<T>();

		while (!string.IsNullOrEmpty(requestUri))
		{
			var list = await Get<ODataListResponse<T>>(requestUri);

			if (list.Value.Count != 0)
			{
				result.AddRange(list.Value);
			}

			requestUri = list.ODataNextLink;

			if (!string.IsNullOrEmpty(requestUri))
			{
				requestUri = requestUri.Replace(_baseAddress, string.Empty);
			}
		}

		return result;
	}

	/// <summary>
	/// Performs POST request to Envi OData API
	/// </summary>
	/// <typeparam name="TSrc">Type of the supplied entity</typeparam>
	/// <typeparam name="TRes">Type of the expected result</typeparam>
	/// <param name="requestUri">relative target resource Uri</param>
	/// <param name="entity">entity details to post</param>
	/// <returns>Instance of <typeparamref name="TRes"/></returns>
	public async Task<TRes> Post<TSrc, TRes>(string requestUri, TSrc entity)
	{
		var response = await PostRaw(requestUri, entity);

		var result = JsonConvert.DeserializeObject<TRes>(await response.Content.ReadAsStringAsync());

		return result;
	}

	/// <summary>
	/// Performs a POST request and returns the raw HTTP response.
	/// </summary>
	/// <typeparam name="TSrc">Type of the supplied entity.</typeparam>
	/// <param name="requestUri">Relative target resource Uri.</param>
	/// <param name="entity">Entity details to post.</param>
	/// <returns>Raw HTTP response message.</returns>
	public async Task<HttpResponseMessage> PostRaw<TSrc>(string requestUri, TSrc entity)
	{
		await EnsureAuthorizationAsync();

		var content = new StringContent(_requestContext.Serialize(entity), Encoding.UTF8, Constants.JsonContentType);
		return await _requestContext.Client.PostAsync(requestUri, content);
	}

	/// <summary>
	/// Performs PATCH request to Envi OData API
	/// </summary>
	/// <typeparam name="T">Type of the supplied entity</typeparam>
	/// <param name="requestUri">relative target resource Uri</param>
	/// <param name="entity">entity details to patch</param>
	/// <returns>True if patch has been successful, false - otherwise</returns>
	public async Task<bool> Patch<T>(string requestUri, T entity)
	{
		await EnsureAuthorizationAsync();

		var content = new StringContent(_requestContext.Serialize(entity), Encoding.UTF8, Constants.JsonContentType);
		var response = await _requestContext.Client.PatchAsync(requestUri, content);

		return response.IsSuccessStatusCode;
	}

	/// <summary>
	/// Performs PUT request to Envi OData API
	/// </summary>
	/// <typeparam name="T">Type of the supplied entity</typeparam>
	/// <param name="requestUri">relative target resource Uri</param>
	/// <param name="entity">entity details to modify</param>
	/// <returns>True if put has been successful, false - otherwise</returns>
	public async Task<bool> Put<T>(string requestUri, T entity)
	{
		await EnsureAuthorizationAsync();

		var content = new StringContent(_requestContext.Serialize(entity), Encoding.UTF8, Constants.JsonContentType);
		var response = await _requestContext.Client.PutAsync(requestUri, content);

		return response.IsSuccessStatusCode;
	}

	/// <summary>
	/// Gets a valid bearer access token for custom HTTP scenarios.
	/// </summary>
	/// <returns>OAuth access token string.</returns>
	public async Task<string> GetAccessTokenAsync()
	{
		return await _requestContext.GetAccessTokenAsync();
	}

	/// <summary>
	/// Serializes a payload with SDK JSON settings.
	/// </summary>
	/// <typeparam name="T">Type of the supplied payload.</typeparam>
	/// <param name="entity">Payload entity to serialize.</param>
	/// <returns>Serialized JSON payload.</returns>
	public string Serialize<T>(T entity)
	{
		return _requestContext.Serialize(entity);
	}

	#endregion

	#region Private Methods

	/// <summary>
	/// Performs verification that all required parameters are specified
	/// </summary>
	/// <param name="values">values to verify</param>
	private static void VerifyOAuthParams(params string[] values)
	{
		if (values.Any(x => string.IsNullOrWhiteSpace(x)))
		{
			throw new ArgumentException("constructor parameters cannot be null or empty string");
		}
	}

	/// <summary>
	/// Sets authorization header for each request.
	/// </summary>
	private async Task EnsureAuthorizationAsync()
	{
		await _requestContext.SetAuthHeaderAsync();
	}

	#endregion
}