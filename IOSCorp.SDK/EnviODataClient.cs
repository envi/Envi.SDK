using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using IOSCorp.SDK.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace IOSCorp.SDK
{
	public class EnviODataClient
	{
		#region Private Properties

		/// <summary>
		/// Base address of OData API Service
		/// </summary>
		private readonly string _baseAddress;

		/// <summary>
		/// Hold client_id for OAuth 2.0 password grant flow
		/// </summary>
		private readonly string _clientId;

		/// <summary>
		/// Hold user name for OAuth 2.0 password grant flow
		/// </summary>
		private readonly string _userName;

		/// <summary>
		/// Hold user password for OAuth 2.0 password grant flow
		/// </summary>
		private readonly string _password;

		/// <summary>
		/// Holds instance of correctly initialized HTTP Client
		/// </summary>
		private HttpClient _client;

		/// <summary>
		/// Holds instance of obtained JWT token
		/// </summary>
		private JWT _token;

		#endregion

		#region Instance Constructors

		/// <summary>
		/// Creates new instance of <see cref="EnviODataClient"/> using default settings from app.config file
		/// </summary>
		public EnviODataClient()
		{
			_baseAddress = ConfigurationManager.AppSettings["baseAddress"];
			_clientId = ConfigurationManager.AppSettings["clientId"];
			_userName = ConfigurationManager.AppSettings["userName"];
			_password = ConfigurationManager.AppSettings["password"];
			VerifyOAuthParams(_baseAddress, _clientId, _userName, _password);
		}

		/// <summary>
		/// Creates new instance of <see cref="EnviODataClient"/> using specified information
		/// </summary>
		/// <param name="baseAddress">Base address of OData API Service</param>
		/// <param name="clientId">client_id for OAuth 2.0 password grant flow</param>
		/// <param name="userName">user name for OAuth 2.0 password grant flow</param>
		/// <param name="password">user password for OAuth 2.0 password grant flow</param>
		public EnviODataClient(string baseAddress, string clientId, string userName, string password)
		{
			_baseAddress = baseAddress;
			_clientId = clientId;
			_userName = userName;
			_password = password;
			VerifyOAuthParams(_baseAddress, _clientId, _userName, _password);
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
			await SetAuthHeader();

			var response = await Client.GetAsync(requestUri);
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
				if (list.Value.Any())
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
			await SetAuthHeader();

			var content = new StringContent(Serialize<TSrc>(entity), Encoding.UTF8, "application/json");
			var response = await Client.PostAsync(requestUri, content);
			var result = JsonConvert.DeserializeObject<TRes>(await response.Content.ReadAsStringAsync());

			return result;
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
			await SetAuthHeader();

			var content = new StringContent(Serialize<T>(entity), Encoding.UTF8, "application/json");
			var response = await Client.PatchAsync(requestUri, content);

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
			await SetAuthHeader();

			var content = new StringContent(Serialize<T>(entity), Encoding.UTF8, "application/json");
			var response = await Client.PutAsync(requestUri, content);

			return response.IsSuccessStatusCode;
		}

		#endregion

		#region Private Properties

		/// <summary>
		/// Holds correctly configured instance of <see cref="HttpClient"/>
		/// </summary>
		private HttpClient Client
		{
			get
			{
				if (_client == null)
				{
					_client = new HttpClient
					{
						BaseAddress = new Uri(_baseAddress)
					};
					_client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				}
				return _client;
			}
		}

		#endregion

		#region Private Authentication Methods

		/// <summary>
		/// Retrieves JWT Token either existing one or new, based on user credentials or refresh token
		/// </summary>
		/// <returns>instance of <see cref="JWT"/></returns>
		private async Task<JWT> GetToken()
		{
			if (_token == null)
			{
				List<KeyValuePair<string, string>> requestData = new List<KeyValuePair<string, string>> {
					new KeyValuePair<string, string>("grant_type", "password"),
					new KeyValuePair<string, string>("client_id", _clientId),
					new KeyValuePair<string, string>("username", _userName),
					new KeyValuePair<string, string>("password", _password)
				};
				_token = await RequestToken(requestData);
			}
			if (!_token.IsValid)
			{
				List<KeyValuePair<string, string>> requestData = new List<KeyValuePair<string, string>> {
					new KeyValuePair<string, string>("grant_type", "refresh_token"),
					new KeyValuePair<string, string>("client_id", _clientId),
					new KeyValuePair<string, string>("refresh_token", _token.RefreshToken)
				};
				_token = await RequestToken(requestData);
			}
			return _token;
		}

		/// <summary>
		/// Requests Token from token endpoint based on provided parameters
		/// </summary>
		/// <param name="requestData">token endpoint parameters</param>
		/// <returns>instance of <see cref="JWT"/></returns>
		private async Task<JWT> RequestToken(List<KeyValuePair<string, string>> requestData)
		{
			var response = await Client.PostAsync("oauth2/token", new FormUrlEncodedContent(requestData));
			var content = await response.Content.ReadAsStringAsync();

			return JsonConvert.DeserializeObject<JWT>(content);
		}

		#endregion

		#region Private Methods

		/// <summary>
		/// Performs verification that all required parameters are specified
		/// </summary>
		/// <param name="values">values to verify</param>
		private void VerifyOAuthParams(params string[] values)
		{
			foreach (var value in values)
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("constructor parameters cannot be null or empty string");
				}
			}
		}

		/// <summary>
		/// Sets authorization header for each request
		/// </summary>
		/// <returns></returns>
		private async Task SetAuthHeader()
		{
			var auth = await GetToken();
			Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", auth.AccessToken);
		}

		/// <summary>
		/// Performs serialization of object with type <typeparamref name="T"/> to JSON format
		/// </summary>
		/// <typeparam name="T">Type of the entity</typeparam>
		/// <param name="entity">entity to serialize</param>
		/// <returns>JSON representation of the entity</returns>
		private string Serialize<T>(T entity)
		{
			var serializerSettings = new JsonSerializerSettings
			{
				ContractResolver = new CamelCasePropertyNamesContractResolver(),
				NullValueHandling = NullValueHandling.Ignore
			};

			return JsonConvert.SerializeObject(entity, serializerSettings);
		}

		#endregion
	}
}
