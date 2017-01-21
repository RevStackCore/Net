using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using Flurl.Http;

namespace RevStackCore.Net
{
	public static partial class Http
	{
		/// <summary>
		/// Async Get Request
		/// </summary>
		/// <returns>content string async</returns>
		/// <param name="url">URL.</param>
		public async static Task<string> GetAsync(string url)
		{
			try
			{
				var response = await url.GetStringAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Async Get Request with Basic Authentication
		/// </summary>
		/// <returns>content string async</returns>
		/// <param name="url">URL.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		public async static Task<string> GetAsync(string url, string username, string password)
		{
			try
			{
				var response = await url.WithBasicAuth(username, password).GetStringAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Async Get Request with OAuth Authentication
		/// </summary>
		/// <returns>content string async</returns>
		/// <param name="url">URL.</param>
		/// <param name="token">Token.</param>
		public async static Task<string> GetAsync(string url, string token)
		{
			try
			{
				var response = await url.WithOAuthBearerToken(token).GetStringAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Async Get Request with Cookie Authentication
		/// </summary>
		/// <returns>content string async</returns>
		/// <param name="url">URL.</param>
		/// <param name="cookie">Cookie.</param>
		public async static Task<string> GetAsync(string url, Cookie cookie)
		{
			try
			{
				var response = await url.WithCookie(cookie).GetStringAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		///  Async Get Request with Header
		/// </summary>
		/// <returns>content string async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="header">Header.</param>
		public async static Task<string> GetAsync(string url, RequestHeader header)
		{
			try
			{
				var response = await url.WithHeader(header.Key,header.Value).GetStringAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Async Get Request
		/// </summary>
		/// <returns>The HttpResponseMessage async</returns>
		/// <param name="url">URL.</param>
		public async static Task<HttpResponseMessage> GetResponseAsync(string url)
		{
			try
			{
				var response = await url.GetAsync();
				return response;
			}
			catch (Exception ex)
			{
				return errorResponse(ex);
			}
		}

		/// <summary>
		/// Async Get Request with Basic Authentication
		/// </summary>
		/// <returns>The HttpResponseMessage async</returns>
		/// <param name="url">URL.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		public async static Task<HttpResponseMessage> GetResponseAsync(string url, string username, string password)
		{
			try
			{
				var response = await url.WithBasicAuth(username, password).GetAsync();
				return response;
			}
			catch (Exception ex)
			{
				return errorResponse(ex);
			}
		}

		/// <summary>
		/// Async Get Request with OAuth Authentication
		/// </summary>
		/// <returns>The HttpResponseMessage async</returns>
		/// <param name="url">URL.</param>
		/// <param name="token">Token.</param>
		public async static Task<HttpResponseMessage> GetResponseAsync(string url, string token)
		{
			try
			{
				var response = await url.WithOAuthBearerToken(token).GetAsync();
				return response;
			}
			catch (Exception ex)
			{
				return errorResponse(ex);
			}
		}

		/// <summary>
		///  Async Get Request with Header
		/// </summary>
		/// <returns>The HttpResponseMessage async</returns>
		/// <param name="url">URL.</param>
		/// <param name="header">Header.</param>
		public async static Task<HttpResponseMessage> GetResponseAsync(string url, RequestHeader header)
		{
			try
			{
				var response = await url.WithHeader(header.Key,header.Value).GetAsync();
				return response;
			}
			catch (Exception ex)
			{
				return errorResponse(ex);
			}
		}

		/// <summary>
		/// Async Get Request with Cookie Authentication
		/// </summary>
		/// <returns>The HttpResponseMessage async</returns>
		/// <param name="url">URL.</param>
		/// <param name="cookie">Cookie.</param>
		public async static Task<HttpResponseMessage> GetResponseAsync(string url, Cookie cookie)
		{
			try
			{
				var response = await url.WithCookie(cookie).GetAsync();
				return response;
			}
			catch (Exception ex)
			{
				return errorResponse(ex);
			}
		}


		/// <summary>
		/// Async Json Get Request
		/// </summary>
		/// <returns>The json content string async</returns>
		/// <param name="url">URL.</param>
		public async static Task<string> GetJsonAsync(string url)
		{
			try
			{
				var response = await url.GetJsonAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}


		/// <summary>
		/// Async Json Get Request with Basic Authentication
		/// </summary>
		/// <returns>The json content string async</returns>
		/// <param name="url">URL.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		public async static Task<string> GetJsonAsync(string url, string username, string password)
		{
			try
			{
				var response = await url.WithBasicAuth(username, password).GetJsonAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Async Json Get Request with OAuth Authentication
		/// </summary>
		/// <returns>The json content string async</returns>
		/// <param name="url">URL.</param>
		/// <param name="token">Token.</param>
		public async static Task<string> GetJsonAsync(string url, string token)
		{
			try
			{
				var response = await url.WithOAuthBearerToken(token).GetJsonAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Async Json Get Request with Cookie Authentication
		/// </summary>
		/// <returns>The json content string async</returns>
		/// <param name="url">URL.</param>
		/// <param name="cookie">Cookie.</param>
		public async static Task<string> GetJsonAsync(string url, Cookie cookie)
		{
			try
			{
				var response = await url.WithCookie(cookie).GetJsonAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		///  Async Json Get Request with Header
		/// </summary>
		/// <returns>The json content string async</returns>
		/// <param name="url">URL.</param>
		/// <param name="header">Header.</param>
		public async static Task<string> GetJsonAsync(string url, RequestHeader header)
		{
			try
			{
				var response = await url.WithHeader(header.Key,header.Value).GetJsonAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Typed Async Json Get Request
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<T> GetTypedAsync<T>(string url)
		{
			try
			{
				var response = await url.GetJsonAsync<T>();
				return response;
			}
			catch (Exception)
			{
				return default(T);
			}
		}

		/// <summary>
		/// Typed Async Json Get Request with Basic Authentication
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<T> GetTypedAsync<T>(string url, string username, string password)
		{
			try
			{
				var response = await url.WithBasicAuth(username, password).GetJsonAsync<T>();
				return response;
			}
			catch (Exception)
			{
				return default(T);
			}
		}

		/// <summary>
		/// Typed Async Json Get Request with OAuth Authentication
		/// </summary>
		/// <returns>The entity type async </returns>
		/// <param name="url">URL.</param>
		/// <param name="token">Token.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<T> GetTypedAsync<T>(string url, string token)
		{
			try
			{
				var response = await url.WithOAuthBearerToken(token).GetJsonAsync<T>();
				return response;
			}
			catch (Exception)
			{
				return default(T);
			}
		}

		/// <summary>
		/// Typed Async Json Get Request with Cookie Authentication
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="cookie">Cookie.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<T> GetTypedAsync<T>(string url, Cookie cookie)
		{
			try
			{
				var response = await url.WithCookie(cookie).GetJsonAsync<T>();
				return response;
			}
			catch (Exception)
			{
				return default(T);
			}
		}

		/// <summary>
		///  Typed Async Json Get Request with Header
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="header">Header.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<T> GetTypedAsync<T>(string url, RequestHeader header)
		{
			try
			{
				var response = await url.WithHeader(header.Key,header.Value).GetJsonAsync<T>();
				return response;
			}
			catch (Exception)
			{
				return default(T);
			}
		}


		/// <summary>
		/// Typed Async Json Get Request
		/// </summary>
		/// <returns>ResponseType of type T async</returns>
		/// <param name="url">URL.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<ResponseType<T>> GetResponseTypedAsync<T>(string url)
		{
			try
			{
				var response = await url.GetJsonAsync<T>();
				return new ResponseType<T>(response, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				return new ResponseType<T>(default(T), HttpStatusCode.InternalServerError);
			}
		}

		/// <summary>
		/// Typed Async Json Get Request with Basic Authentication
		/// </summary>
		/// <returns>ResponseType of type T async</returns>
		/// <param name="url">URL.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<ResponseType<T>> GetResponseTypedAsync<T>(string url, string username, string password)
		{
			try
			{
				var response = await url.WithBasicAuth(username,password).GetJsonAsync<T>();
				return new ResponseType<T>(response, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				return new ResponseType<T>(default(T), HttpStatusCode.InternalServerError);
			}
		}

		/// <summary>
		/// Typed Async Json Get Request with OAuth Authentication
		/// </summary>
		/// <returns>ResponseType of type T async</returns>
		/// <param name="url">URL.</param>
		/// <param name="token">Token.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<ResponseType<T>> GetResponseTypedAsync<T>(string url, string token)
		{
			try
			{
				var response = await url.WithOAuthBearerToken(token).GetJsonAsync<T>();
				return new ResponseType<T>(response, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				return new ResponseType<T>(default(T), HttpStatusCode.InternalServerError);
			}
		}

		/// <summary>
		/// Typed Async Json Get Request with Cookie Authentication
		/// </summary>
		/// <returns>ResponseType of type T async</returns>
		/// <param name="url">URL.</param>
		/// <param name="cookie">Cookie.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<ResponseType<T>> GetResponseTypedAsync<T>(string url, Cookie cookie)
		{
			try
			{
				var response = await url.WithCookie(cookie).GetJsonAsync<T>();
				return new ResponseType<T>(response, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				return new ResponseType<T>(default(T), HttpStatusCode.InternalServerError);
			}
		}

		/// <summary>
		///  Typed Async Json Get Request with Header
		/// </summary>
		/// <returns>ResponseType of type T async</returns>
		/// <param name="url">URL.</param>
		/// <param name="header">Header.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<ResponseType<T>> GetResponseTypedAsync<T>(string url, RequestHeader header)
		{
			try
			{
				var response = await url.WithHeader(header.Key,header.Value).GetJsonAsync<T>();
				return new ResponseType<T>(response, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				return new ResponseType<T>(default(T), HttpStatusCode.InternalServerError);
			}
		}

	}
}
