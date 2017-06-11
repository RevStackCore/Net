using System;
using System.Threading.Tasks;
using System.Net;
using Flurl.Http;

namespace RevStackCore.Net
{
	public static partial class Http
	{
		/// <summary>
		/// Async Json Put
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<T> PutTypedAsync<T>(string url, T entity)
		{
			try
			{
				var result = await url.PutJsonAsync(entity).ReceiveJson<T>();
				return result;
			}
			catch (Exception)
			{
				return default(T);
			}
		}

		/// <summary>
		/// Async Json Put with Basic Authentication
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<T> PutTypedAsync<T>(string url, T entity, string username, string password)
		{
			try
			{
				var result = await url.WithBasicAuth(username, password).PutJsonAsync(entity).ReceiveJson<T>();
				return result;
			}
			catch (Exception)
			{
				return default(T);
			}
		}

		/// <summary>
		/// Async Json Put with OAuth Authentication
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="token">Token.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<T> PutTypedAsync<T>(string url, T entity, string token)
		{
			try
			{
				var result = await url.WithOAuthBearerToken(token).PutJsonAsync(entity).ReceiveJson<T>();
				return result;
			}
			catch (Exception)
			{
				return default(T);
			}
		}

		/// <summary>
		/// Async Json Put with Cookie Authentication
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="cookie">Cookie.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<T> PutTypedAsync<T>(string url, T entity, Cookie cookie)
		{
			try
			{
				var result = await url.WithCookie(cookie).PutJsonAsync(entity).ReceiveJson<T>();
				return result;
			}
			catch (Exception)
			{
				return default(T);
			}
		}

		/// <summary>
		/// Async Json Put with Cookies
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="cookies">Cookies Anonymous Object</param>
        /// <param name="expDate">ExpDate</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<T> PutTypedAsync<T>(string url, T entity, object cookies, DateTime? expDate)
		{
			try
			{
				var result = await url.WithCookies(cookies,expDate).PutJsonAsync(entity).ReceiveJson<T>();
				return result;
			}
			catch (Exception)
			{
				return default(T);
			}
		}

		/// <summary>
		///  Async Json Put with Header
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="header">Header.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<T> PutTypedAsync<T>(string url, T entity, RequestHeader header)
		{
			try
			{
				var result = await url.WithHeader(header.Key,header.Value).PutJsonAsync(entity).ReceiveJson<T>();
				return result;
			}
			catch (Exception)
			{
				return default(T);
			}
		}

		/// <summary>
		///  Async Json Put with Headers
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<T> PutTypedAsync<T>(string url, T entity, object headers)
		{
			try
			{
				var result = await url.WithHeaders(headers).PutJsonAsync(entity).ReceiveJson<T>();
				return result;
			}
			catch (Exception)
			{
				return default(T);
			}
		}

		/// <summary>
		/// Async Json Put with OAuth Authentication & Headers
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="token">Token.</param>
        /// <param name="headers">Headers Anomymous Object</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<T> PutTypedAsync<T>(string url, T entity, string token,object headers)
		{
			try
			{
				var result = await url.WithOAuthBearerToken(token).WithHeaders(headers).PutJsonAsync(entity).ReceiveJson<T>();
				return result;
			}
			catch (Exception)
			{
				return default(T);
			}
		}

		/// <summary>
		/// Async Json Put with Basic Authentication & Headers
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <param name="headers">Headers Anomymous Object</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<T> PutTypedAsync<T>(string url, T entity, string username, string password,object headers)
		{
			try
			{
				var result = await url.WithBasicAuth(username, password).WithHeaders(headers).PutJsonAsync(entity).ReceiveJson<T>();
				return result;
			}
			catch (Exception)
			{
				return default(T);
			}
		}



		/// <summary>
		/// Async Json Put
		/// </summary>
		/// <returns>ResponseType of type T async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<ResponseType<T>> PutResponseTypedAsync<T>(string url, T entity)
		{
			try
			{
				var result = await url.PutJsonAsync(entity).ReceiveJson<T>();
				return new ResponseType<T>(result, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				return new ResponseType<T>(default(T), HttpStatusCode.InternalServerError);
			}
		}

		/// <summary>
		/// Async Json Put with Basic Authentication
		/// </summary>
		/// <returns>ResponseType of type T async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<ResponseType<T>> PutResponseTypedAsync<T>(string url, T entity, string username, string password)
		{
			try
			{
				var result = await url.WithBasicAuth(username, password).PutJsonAsync(entity).ReceiveJson<T>();
				return new ResponseType<T>(result, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				return new ResponseType<T>(default(T), HttpStatusCode.InternalServerError);
			}
		}

		/// <summary>
		/// Async Json Put with OAuth Authentication
		/// </summary>
		/// <returns>ResponseType of type T async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="token">Token.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<ResponseType<T>> PutResponseTypedAsync<T>(string url, T entity, string token)
		{
			try
			{
				var result = await url.WithOAuthBearerToken(token).PutJsonAsync(entity).ReceiveJson<T>();
				return new ResponseType<T>(result, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				return new ResponseType<T>(default(T), HttpStatusCode.InternalServerError);
			}
		}

		/// <summary>
		/// Async Json Put with Cookie Authentication
		/// </summary>
		/// <returns>ResponseType of type T async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="cookie">Cookie.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<ResponseType<T>> PutResponseTypedAsync<T>(string url, T entity, Cookie cookie)
		{
			try
			{
				var result = await url.WithCookie(cookie).PutJsonAsync(entity).ReceiveJson<T>();
				return new ResponseType<T>(result, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				return new ResponseType<T>(default(T), HttpStatusCode.InternalServerError);
			}
		}

		/// <summary>
		/// Async Json Put with Cookies
		/// </summary>
		/// <returns>ResponseType of type T async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="cookies">Cookies Anonymous Object</param>
        /// <param name="expDate">ExpDate</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<ResponseType<T>> PutResponseTypedAsync<T>(string url, T entity, object cookies, DateTime? expDate)
		{
			try
			{
				var result = await url.WithCookies(cookies,expDate).PutJsonAsync(entity).ReceiveJson<T>();
				return new ResponseType<T>(result, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				return new ResponseType<T>(default(T), HttpStatusCode.InternalServerError);
			}
		}

		/// <summary>
		///  Async Json Put with Header
		/// </summary>
		/// <returns>ResponseType of type T async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="header">Header.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<ResponseType<T>> PutResponseTypedAsync<T>(string url, T entity, RequestHeader header)
		{
			try
			{
				var result = await url.WithHeader(header.Key,header.Value).PutJsonAsync(entity).ReceiveJson<T>();
				return new ResponseType<T>(result, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				return new ResponseType<T>(default(T), HttpStatusCode.InternalServerError);
			}
		}

		/// <summary>
		///  Async Json Put with Headers
		/// </summary>
		/// <returns>ResponseType of type T async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<ResponseType<T>> PutResponseTypedAsync<T>(string url, T entity, object headers)
		{
			try
			{
				var result = await url.WithHeaders(headers).PutJsonAsync(entity).ReceiveJson<T>();
				return new ResponseType<T>(result, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				return new ResponseType<T>(default(T), HttpStatusCode.InternalServerError);
			}
		}

		/// <summary>
		/// Async Json Put with OAuth Authentication & Headers
		/// </summary>
		/// <returns>ResponseType of type T async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="token">Token.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<ResponseType<T>> PutResponseTypedAsync<T>(string url, T entity, string token,object headers)
		{
			try
			{
				var result = await url.WithOAuthBearerToken(token).WithHeaders(headers).PutJsonAsync(entity).ReceiveJson<T>();
				return new ResponseType<T>(result, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				return new ResponseType<T>(default(T), HttpStatusCode.InternalServerError);
			}
		}

		/// <summary>
		/// Async Json Put with Basic Authentication & Headers
		/// </summary>
		/// <returns>ResponseType of type T async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<ResponseType<T>> PutResponseTypedAsync<T>(string url, T entity, string username, string password, object headers)
		{
			try
			{
				var result = await url.WithBasicAuth(username, password).WithHeaders(headers).PutJsonAsync(entity).ReceiveJson<T>();
				return new ResponseType<T>(result, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				return new ResponseType<T>(default(T), HttpStatusCode.InternalServerError);
			}
		}


		/// <summary>
		/// Async Put String
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="json">Json String</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<string> PuttStringAsync(string url, string json)
		{
			try
			{
				var result = await url.PutStringAsync(json).ReceiveString();
				return result;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Async Put String with Basic Authentication
		/// </summary>
		/// <returns>The HttpResponseMessage async</returns>
		/// <param name="url">URL.</param>
		/// <param name="json">Json String</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<string> PutStringAsync(string url, string json, string username, string password)
		{
			try
			{
				var result = await url.WithBasicAuth(username, password).PutStringAsync(json).ReceiveString();
				return result;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Async Put String with OAuth Authentication
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="json">Json String</param>
		/// <param name="token">Token.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<string> PutStringAsync(string url, string json, string token)
		{
			try
			{
				var result = await url.WithOAuthBearerToken(token).PutStringAsync(json).ReceiveString();
				return result;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Async Put String with Cookie Authentication
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="json">Json String</param>
		/// <param name="cookie">Cookie.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<string> PutStringAsync<T>(string url, string json, Cookie cookie)
		{
			try
			{
				var result = await url.WithCookie(cookie).PutStringAsync(json).ReceiveString();
				return result;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Async Put with Cookies
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="json">Json String</param>
		/// <param name="cookies">Cookies Anonymous Object</param>
		/// <param name="expDate">ExpDate</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<string> PutStringAsync<T>(string url, string json, object cookies, DateTime? expDate)
		{
			try
			{
				var result = await url.WithCookies(cookies, expDate).PutStringAsync(json).ReceiveString();
				return result;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		///  Async Put String with Header
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="json">Json String</param>
		/// <param name="header">Header.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<string> PutStringAsync(string url, string json, RequestHeader header)
		{
			try
			{
				var result = await url.WithHeader(header.Key, header.Value).PutStringAsync(json).ReceiveString();
				return result;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		///  Async Put String with Headers
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="json">Json String</param>
		/// <param name="headers">param name="headers" Anonymous Object</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<string> PutStringAsync(string url, string json, object headers)
		{
			try
			{
				var result = await url.WithHeaders(headers).PutStringAsync(json).ReceiveString();
				return result;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Async Put String with OAuth Authentication & Headers
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="json">Json String</param>
		/// <param name="token">Token.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<string> PutStringAsync(string url, string json, string token, object headers)
		{
			try
			{
				var result = await url.WithOAuthBearerToken(token).WithHeaders(headers).PutStringAsync(json).ReceiveString();
				return result;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Async Put String with Basic Authentication & Headers
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="json">Json String</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<string> PutStringAsync(string url, string json, string username, string password, object headers)
		{
			try
			{
				var result = await url.WithBasicAuth(username, password).WithHeaders(headers).PutStringAsync(json).ReceiveString();
				return result;
			}
			catch (Exception)
			{
				return null;
			}
		}


	}
}
