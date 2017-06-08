﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using Flurl.Http;


namespace RevStackCore.Net
{
	public static partial class Http
	{
		/// <summary>
		/// Async Post UrlEncoded
		/// </summary>
		/// <returns>The HttpResponseMessage async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<HttpResponseMessage> PostAsync<T>(string url, T entity)
		{
			try
			{
				var result = await url.PostUrlEncodedAsync(entity);
				return result;
			}
			catch (Exception ex)
			{
				return errorResponse(ex);
			}
		}

		/// <summary>
		/// Async Post UrlEncoded with Basic Authentication
		/// </summary>
		/// <returns>The HttpResponseMessage async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<HttpResponseMessage> PostAsync<T>(string url, T entity, string username, string password)
		{
			try
			{
				var result = await url.WithBasicAuth(username,password).PostUrlEncodedAsync(entity);
				return result;
			}
			catch (Exception ex)
			{
				return errorResponse(ex);
			}
		}

		/// <summary>
		/// Async Post UrlEncoded with OAuth Authentication
		/// </summary>
		/// <returns>The HttpResponseMessage async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="token">Token.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<HttpResponseMessage> PostAsync<T>(string url, T entity, string token)
		{
			try
			{
				var result = await url.WithOAuthBearerToken(token).PostUrlEncodedAsync(entity);
				return result;
			}
			catch (Exception ex)
			{
				return errorResponse(ex);
			}
		}

		/// <summary>
		/// Async Post UrlEncoded with Cookie Authentication
		/// </summary>
		/// <returns>The HttpResponseMessage async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="cookie">Cookie.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<HttpResponseMessage> PostAsync<T>(string url, T entity, Cookie cookie)
		{
			try
			{
				var result = await url.WithCookie(cookie).PostUrlEncodedAsync(entity);
				return result;
			}
			catch (Exception ex)
			{
				return errorResponse(ex);
			}
		}

		/// <summary>
		/// Async Post UrlEncoded with Cookies
		/// </summary>
		/// <returns>The HttpResponseMessage async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="cookies">Cookies Anonymous Object</param>
		/// <param name="expDate">Expiration Date </param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<HttpResponseMessage> PostAsync<T>(string url, T entity, object cookies, DateTime? expDate)
		{
			try
			{
                var result = await url.WithCookies(cookies,expDate).PostUrlEncodedAsync(entity);
				return result;
			}
			catch (Exception ex)
			{
				return errorResponse(ex);
			}
		}

	    /// <summary>
	    ///  Async Post UrlEncoded with Header
	    /// </summary>
	    /// <returns>The HttpResponseMessage async</returns>
	    /// <param name="url">URL.</param>
	    /// <param name="entity">Entity.</param>
	    /// <param name="header">Header.</param>
	    /// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<HttpResponseMessage> PostAsync<T>(string url, T entity, RequestHeader header)
		{
			try
			{
				var result = await url.WithHeader(header.Key,header.Value).PostUrlEncodedAsync(entity);
				return result;
			}
			catch (Exception ex)
			{
				return errorResponse(ex);
			}
		}

		/// <summary>
		///  Async Post UrlEncoded with Headers
		/// </summary>
		/// <returns>The HttpResponseMessage async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
        public async static Task<HttpResponseMessage> PostAsync<T>(string url, T entity, object headers)
		{
			try
			{
                var result = await url.WithHeaders(headers).PostUrlEncodedAsync(entity);
				return result;
			}
			catch (Exception ex)
			{
				return errorResponse(ex);
			}
		}

		/// <summary>
		/// Async Post UrlEncoded with OAuth Authentication and Headers
		/// </summary>
		/// <returns>The HttpResponseMessage async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="token">Token.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<HttpResponseMessage> PostAsync<T>(string url, T entity, string token, object headers)
		{
			try
			{
				var result = await url.WithOAuthBearerToken(token).WithHeaders(headers).PostUrlEncodedAsync(entity);
				return result;
			}
			catch (Exception ex)
			{
				return errorResponse(ex);
			}
		}

		/// <summary>
		/// Async Post UrlEncoded with Basic Authentication & Headers
		/// </summary>
		/// <returns>The HttpResponseMessage async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<HttpResponseMessage> PostAsync<T>(string url, T entity, string username, string password, object headers)
		{
			try
			{
				var result = await url.WithBasicAuth(username, password).WithHeaders(headers).PostUrlEncodedAsync(entity);
				return result;
			}
			catch (Exception ex)
			{
				return errorResponse(ex);
			}
		}

		/// <summary>
		/// Async Json Post
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<T> PostTypedAsync<T>(string url, T entity)
		{
			try
			{
				var result = await url.PostJsonAsync(entity).ReceiveJson<T>();
				return result;
			}
			catch (Exception)
			{
				return default(T);
			}
		}

		/// <summary>
		/// Async Json Post with Basic Authentication
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<T> PostTypedAsync<T>(string url, T entity, string username, string password)
		{
			try
			{
				var result = await url.WithBasicAuth(username, password).PostJsonAsync(entity).ReceiveJson<T>();
				return result;
			}
			catch (Exception)
			{
				return default(T);
			}
		}

		/// <summary>
		/// Async Json Post with OAuth Authentication
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="token">Token.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<T> PostTypedAsync<T>(string url, T entity, string token)
		{
			try
			{
				var result = await url.WithOAuthBearerToken(token).PostJsonAsync(entity).ReceiveJson<T>();
				return result;
			}
			catch (Exception)
			{
				return default(T);
			}
		}

		/// <summary>
		/// Async Json Post with Cookie Authentication
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="cookie">Cookie.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<T> PostTypedAsync<T>(string url, T entity, Cookie cookie)
		{
			try
			{
				var result = await url.WithCookie(cookie).PostJsonAsync(entity).ReceiveJson<T>();
				return result;
			}
			catch (Exception)
			{
				return default(T);
			}
		}

		/// <summary>
		/// Async Json Post with Cookies
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="cookies">Cookies Anonymous Object</param>
        /// <param name="expDate">ExpDate</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
        public async static Task<T> PostTypedAsync<T>(string url, T entity, object cookies, DateTime? expDate)
		{
			try
			{
				var result = await url.WithCookies(cookies,expDate).PostJsonAsync(entity).ReceiveJson<T>();
				return result;
			}
			catch (Exception)
			{
				return default(T);
			}
		}

		/// <summary>
		///  Async Json Post with Header
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="header">Header.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<T> PostTypedAsync<T>(string url, T entity, RequestHeader header)
		{
			try
			{
				var result = await url.WithHeader(header.Key,header.Value).PostJsonAsync(entity).ReceiveJson<T>();
				return result;
			}
			catch (Exception)
			{
				return default(T);
			}
		}

		/// <summary>
		///  Async Json Post with Headers
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="headers">param name="headers" Anonymous Object</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<T> PostTypedAsync<T>(string url, T entity, object headers)
		{
			try
			{
				var result = await url.WithHeaders(headers).PostJsonAsync(entity).ReceiveJson<T>();
				return result;
			}
			catch (Exception)
			{
				return default(T);
			}
		}

		/// <summary>
		/// Async Json Post with OAuth Authentication & Headers
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="token">Token.</param>
        /// <param name="headers">Headers Anonymous Object</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<T> PostTypedAsync<T>(string url, T entity, string token, object headers)
		{
			try
			{
				var result = await url.WithOAuthBearerToken(token).WithHeaders(headers).PostJsonAsync(entity).ReceiveJson<T>();
				return result;
			}
			catch (Exception)
			{
				return default(T);
			}
		}

		/// <summary>
		/// Async Json Post with Basic Authentication & Headers
		/// </summary>
		/// <returns>The entity type async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
        /// <param name="headers">Headers Anonymous Object</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<T> PostTypedAsync<T>(string url, T entity, string username, string password,object headers)
		{
			try
			{
				var result = await url.WithBasicAuth(username, password).WithHeaders(headers).PostJsonAsync(entity).ReceiveJson<T>();
				return result;
			}
			catch (Exception)
			{
				return default(T);
			}
		}



		/// <summary>
		/// Async Json Post
		/// </summary>
		/// <returns>ResponseType of type T async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<ResponseType<T>> PostResponseTypedAsync<T>(string url, T entity)
		{
			try
			{
				var result = await url.PostJsonAsync(entity).ReceiveJson<T>();
				return new ResponseType<T>(result, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				return new ResponseType<T>(default(T), HttpStatusCode.InternalServerError);
			}
		}

		/// <summary>
		/// Async Json Post with Basic Authentication
		/// </summary>
		/// <returns>ResponseType of type T async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<ResponseType<T>> PostResponseTypedAsync<T>(string url, T entity, string username, string password)
		{
			try
			{
				var result = await url.WithBasicAuth(username,password).PostJsonAsync(entity).ReceiveJson<T>();
				return new ResponseType<T>(result, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				return new ResponseType<T>(default(T), HttpStatusCode.InternalServerError);
			}
		}

		/// <summary>
		/// Async Json Post with OAuth Authentication
		/// </summary>
		/// <returns>ResponseType of type T async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="token">Token.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<ResponseType<T>> PostResponseTypedAsync<T>(string url, T entity, string token)
		{
			try
			{
				var result = await url.WithOAuthBearerToken(token).PostJsonAsync(entity).ReceiveJson<T>();
				return new ResponseType<T>(result, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				return new ResponseType<T>(default(T), HttpStatusCode.InternalServerError);
			}
		}

		/// <summary>
		/// Async Json Post with Cookie Authentication
		/// </summary>
		/// <returns>ResponseType of type T async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="cookie">Cookie.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<ResponseType<T>> PostResponseTypedAsync<T>(string url, T entity, Cookie cookie)
		{
			try
			{
				var result = await url.WithCookie(cookie).PostJsonAsync(entity).ReceiveJson<T>();
				return new ResponseType<T>(result, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				return new ResponseType<T>(default(T), HttpStatusCode.InternalServerError);
			}
		}

		/// <summary>
		/// Async Json Post with Cookies
		/// </summary>
		/// <returns>ResponseType of type T async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="cookies">Cookie Anonymous Object</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<ResponseType<T>> PostResponseTypedAsync<T>(string url, T entity, object cookies, DateTime? expDate)
		{
			try
			{
				var result = await url.WithCookies(cookies,expDate).PostJsonAsync(entity).ReceiveJson<T>();
				return new ResponseType<T>(result, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				return new ResponseType<T>(default(T), HttpStatusCode.InternalServerError);
			}
		}

		/// <summary>
		///  Async Json Post with Header
		/// </summary>
		/// <returns>ResponseType of type T async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="header">Header.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<ResponseType<T>> PostResponseTypedAsync<T>(string url, T entity, RequestHeader header)
		{
			try
			{
				var result = await url.WithHeader(header.Key,header.Value).PostJsonAsync(entity).ReceiveJson<T>();
				return new ResponseType<T>(result, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				return new ResponseType<T>(default(T), HttpStatusCode.InternalServerError);
			}
		}

		/// <summary>
		///  Async Json Post with Header
		/// </summary>
		/// <returns>ResponseType of type T async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<ResponseType<T>> PostResponseTypedAsync<T>(string url, T entity, object headers)
		{
			try
			{
				var result = await url.WithHeaders(headers).PostJsonAsync(entity).ReceiveJson<T>();
				return new ResponseType<T>(result, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				return new ResponseType<T>(default(T), HttpStatusCode.InternalServerError);
			}
		}

		/// <summary>
		/// Async Json Post with OAuth Authentication & Headers
		/// </summary>
		/// <returns>ResponseType of type T async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="token">Token.</param>
        /// <param name="headers">Headers Anonymous Object</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<ResponseType<T>> PostResponseTypedAsync<T>(string url, T entity, string token,object headers)
		{
			try
			{
				var result = await url.WithOAuthBearerToken(token).WithHeaders(headers).PostJsonAsync(entity).ReceiveJson<T>();
				return new ResponseType<T>(result, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				return new ResponseType<T>(default(T), HttpStatusCode.InternalServerError);
			}
		}

		/// <summary>
		/// Async Json Post with Basic Authentication & Headers
		/// </summary>
		/// <returns>ResponseType of type T async</returns>
		/// <param name="url">URL.</param>
		/// <param name="entity">Entity.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
        /// <param name="headers">Headers Anonymous Object</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public async static Task<ResponseType<T>> PostResponseTypedAsync<T>(string url, T entity, string username, string password,object headers)
		{
			try
			{
				var result = await url.WithBasicAuth(username, password).WithHeaders(headers).PostJsonAsync(entity).ReceiveJson<T>();
				return new ResponseType<T>(result, HttpStatusCode.OK);
			}
			catch (Exception)
			{
				return new ResponseType<T>(default(T), HttpStatusCode.InternalServerError);
			}
		}

	}
}
