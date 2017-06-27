using System;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Flurl.Http;

namespace RevStackCore.Net
{
	public static partial class Http
	{
		/// <summary>
		/// Delete Async
		/// </summary>
		/// <returns>bool async</returns>
		/// <param name="url">URL.</param>
		public async static Task<bool> DeleteAsync(string url)
		{
			try
			{
				var response = await url.DeleteAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		/// <summary>
		/// Delete Async with Basic Authentication
		/// </summary>
		/// <returns>bool async</returns>
		/// <param name="url">URL.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		public async static Task<bool> DeleteAsync(string url, string username, string password)
		{
			try
			{
				var response = await url.WithBasicAuth(username, password).DeleteAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		/// <summary>
		/// Delete Async with OAuth Authentication
		/// </summary>
		/// <returns>bool async</returns>
		/// <param name="url">URL.</param>
		/// <param name="token">Token.</param>
		public async static Task<bool> DeleteAsync(string url, string token)
		{
			try
			{
				var response = await url.WithOAuthBearerToken(token).DeleteAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		/// <summary>
		/// Delete Async with Cookie Authentication
		/// </summary>
		/// <returns>bool async</returns>
		/// <param name="url">URL.</param>
		/// <param name="cookie">Cookie.</param>
		public async static Task<bool> DeleteAsync(string url, Cookie cookie)
		{
			try
			{
				var response = await url.WithCookie(cookie).DeleteAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		/// <summary>
		/// Delete Async with Cookies
		/// </summary>
		/// <returns>bool async</returns>
		/// <param name="url">URL.</param>
		/// <param name="cookies">Cookies Anonymous Object</param>
        /// <param name="expDate">ExpDate</param>
		public async static Task<bool> DeleteAsync(string url, object cookies, DateTime? expDate)
		{
			try
			{
				var response = await url.WithCookies(cookies,expDate).DeleteAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		/// <summary>
		///  Delete Async with Header
		/// </summary>
		/// <returns>bool async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="header">Header.</param>
		public async static Task<bool> DeleteAsync(string url, RequestHeader header)
		{
			try
			{
				var response = await url.WithHeader(header.Key,header.Value).DeleteAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		/// <summary>
		///  Delete Async with Headers
		/// </summary>
		/// <returns>bool async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		public async static Task<bool> DeleteAsync(string url, object headers)
		{
			try
			{
				var response = await url.WithHeaders(headers).DeleteAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		/// <summary>
		/// Delete Async with OAuth Authentication & Headers
		/// </summary>
		/// <returns>bool async</returns>
		/// <param name="url">URL.</param>
		/// <param name="token">Token.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		public async static Task<bool> DeleteAsync(string url, string token, object headers)
		{
			try
			{
				var response = await url.WithOAuthBearerToken(token).WithHeaders(headers).DeleteAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		/// <summary>
		/// Delete Async with Basic Authentication & Headers
		/// </summary>
		/// <returns>bool async</returns>
		/// <param name="url">URL.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		public async static Task<bool> DeleteAsync(string url, string username, string password, object headers)
		{
			try
			{
				var response = await url.WithBasicAuth(username, password).WithHeaders(headers).DeleteAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}




		/// <summary>
		/// Delete Async
		/// </summary>
		/// <returns>HttpResponseMessage async</returns>
		/// <param name="url">URL.</param>
        public async static Task<HttpResponseMessage> DeleteResponseAsync(string url)
		{
			try
			{
				return await url.DeleteAsync();
			}
			catch (Exception ex)
			{
                return errorResponse(ex);
			}
		}

		/// <summary>
		/// Delete Async with Basic Authentication
		/// </summary>
		/// <returns>HttpResponseMessage async</returns>
		/// <param name="url">URL.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
        public async static Task<HttpResponseMessage> DeleteResponseAsync(string url, string username, string password)
		{
			try
			{
				return await url.WithBasicAuth(username, password).DeleteAsync();
			}
			catch (Exception ex)
			{
                return errorResponse(ex);
			}
		}

		/// <summary>
		/// Delete Async with OAuth Authentication
		/// </summary>
		/// <returns>HttpResponseMessage async</returns>
		/// <param name="url">URL.</param>
		/// <param name="token">Token.</param>
        public async static Task<HttpResponseMessage> DeleteResponseAsync(string url, string token)
		{
			try
			{
				return await url.WithOAuthBearerToken(token).DeleteAsync();
			}
			catch (Exception ex)
			{
                return errorResponse(ex);
			}
		}

		/// <summary>
		/// Delete Async with Cookie Authentication
		/// </summary>
		/// <returns>HttpResponseMessage async</returns>
		/// <param name="url">URL.</param>
		/// <param name="cookie">Cookie.</param>
        public async static Task<HttpResponseMessage> DeleteResponseAsync(string url, Cookie cookie)
		{
			try
			{
				return await url.WithCookie(cookie).DeleteAsync();
			
			}
			catch (Exception ex)
			{
                return errorResponse(ex);
			}
		}

		/// <summary>
		/// Delete Async with Cookies
		/// </summary>
		/// <returns>HttpResponseMessage async</returns>
		/// <param name="url">URL.</param>
		/// <param name="cookies">Cookies Anonymous Object</param>
		/// <param name="expDate">ExpDate</param>
        public async static Task<HttpResponseMessage> DeleteResponseAsync(string url, object cookies, DateTime? expDate)
		{
			try
			{
				return await url.WithCookies(cookies, expDate).DeleteAsync();
			}
			catch (Exception ex)
			{
                return errorResponse(ex);
			}
		}

		/// <summary>
		///  Delete Async with Header
		/// </summary>
		/// <returns>HttpResponseMessage async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="header">Header.</param>
        public async static Task<HttpResponseMessage> DeleteResponseAsync(string url, RequestHeader header)
		{
			try
			{
				return await url.WithHeader(header.Key, header.Value).DeleteAsync();
		
			}
			catch (Exception ex)
			{
                return errorResponse(ex);
			}
		}

		/// <summary>
		///  Delete Async with Headers
		/// </summary>
		/// <returns>HttpResponseMessage async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		public async static Task<HttpResponseMessage> DeleteResponseAsync(string url, object headers)
		{
			try
			{
				return await url.WithHeaders(headers).DeleteAsync();
			}
			catch (Exception ex)
			{
                return errorResponse(ex);
			}
		}

		/// <summary>
		/// Delete Async with OAuth Authentication & Headers
		/// </summary>
		/// <returns>HttpResponseMessage async</returns>
		/// <param name="url">URL.</param>
		/// <param name="token">Token.</param>
		/// <param name="headers">Headers Anonymous Object</param>
        public async static Task<HttpResponseMessage> DeleteResponseAsync(string url, string token, object headers)
		{
			try
			{
				return await url.WithOAuthBearerToken(token).WithHeaders(headers).DeleteAsync();
			}
			catch (Exception ex)
			{
                return errorResponse(ex);
			}
		}

		/// <summary>
		/// Delete Async with Basic Authentication & Headers
		/// </summary>
		/// <returns>HttpResponseMessage async</returns>
		/// <param name="url">URL.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <param name="headers">Headers Anonymous Object</param>
        public async static Task<HttpResponseMessage> DeleteResponseAsync(string url, string username, string password, object headers)
		{
			try
			{
				return await url.WithBasicAuth(username, password).WithHeaders(headers).DeleteAsync();
			}
			catch (Exception ex)
			{
                return errorResponse(ex);
			}
		}
	}
}
