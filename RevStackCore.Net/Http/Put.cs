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

	}
}
