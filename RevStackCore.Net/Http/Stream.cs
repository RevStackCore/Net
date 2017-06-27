using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.IO;
using Flurl.Http;

namespace RevStackCore.Net
{
	public static partial class Http
	{
		/// <summary>
		/// Async Get bytes Request
		/// </summary>
		/// <returns>byte[] async</returns>
		/// <param name="url">URL.</param>
		public async static Task<byte[]> GetBytesAsync(string url)
		{
			try
			{
				var response = await url.GetBytesAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		///  Async Get bytes Request with Basic Authentication
		/// </summary>
		/// <returns>byte[] async</returns>
		/// <param name="url">URL.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		public async static Task<byte[]> GetBytesAsync(string url, string username, string password)
		{
			try
			{
				var response = await url.WithBasicAuth(username, password).GetBytesAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Async Get bytes Request with OAuth Authentication
		/// </summary>
		/// <returns>byte[] async</returns>
		/// <param name="url">URL.</param>
		/// <param name="token">Token.</param>
		public async static Task<byte[]> GetBytesAsync(string url, string token)
		{
			try
			{
				var response = await url.WithOAuthBearerToken(token).GetBytesAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		///  Async Get bytes Request with Cookie Authentication
		/// </summary>
		/// <returns>byte[] async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="cookie">Cookie.</param>
		public async static Task<byte[]> GetBytesAsync(string url, Cookie cookie)
		{
			try
			{
				var response = await url.WithCookie(cookie).GetBytesAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		///  Async Get bytes Request with Cookies
		/// </summary>
		/// <returns>byte[] async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="cookies">Cookies Anonymous Object</param>
        /// <param name="expDate">ExpDate</param>
		public async static Task<byte[]> GetBytesAsync(string url, object cookies, DateTime? expDate)
		{
			try
			{
				var response = await url.WithCookies(cookies,expDate).GetBytesAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		///  Async Get bytes Request with Header
		/// </summary>
		/// <returns>byte[] async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="header">Header.</param>
		public async static Task<byte[]> GetBytesAsync(string url, RequestHeader header)
		{
			try
			{
				var response = await url.WithHeader(header.Key, header.Value).GetBytesAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		///  Async Get bytes Request with Headera
		/// </summary>
		/// <returns>byte[] async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		public async static Task<byte[]> GetBytesAsync(string url, object headers)
		{
			try
			{
				var response = await url.WithHeaders(headers).GetBytesAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Async Get bytes Request with OAuth Authentication & Headers
		/// </summary>
		/// <returns>byte[] async</returns>
		/// <param name="url">URL.</param>
		/// <param name="token">Token.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		public async static Task<byte[]> GetBytesAsync(string url, string token, object headers)
		{
			try
			{
				var response = await url.WithOAuthBearerToken(token).WithHeaders(headers).GetBytesAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		///  Async Get bytes Request with Basic Authentication & Headers
		/// </summary>
		/// <returns>byte[] async</returns>
		/// <param name="url">URL.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		public async static Task<byte[]> GetBytesAsync(string url, string username, string password, object headers)
		{
			try
			{
				var response = await url.WithBasicAuth(username, password).WithHeaders(headers).GetBytesAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}


		/// <summary>
		///  Async Get Stream Request
		/// </summary>
		/// <returns>Stream async</returns>
		/// <param name="url">URL.</param>
		public async static Task<Stream> GetStreamAsync(string url)
		{
			try
			{
				var response = await url.GetStreamAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Async Get Stream Request with Basic Authentication
		/// </summary>
		/// <returns>Stream async</returns>
		/// <param name="url">URL.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		public async static Task<Stream> GetStreamAsync(string url, string username, string password)
		{
			try
			{
				var response = await url.WithBasicAuth(username, password).GetStreamAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		///  Async Get Stream Request with OAuth Authentication
		/// </summary>
		/// <returns>Stream async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="token">Token.</param>
		public async static Task<Stream> GetStreamAsync(string url, string token)
		{
			try
			{
				var response = await url.WithOAuthBearerToken(token).GetStreamAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		///  Async Get Stream Request with Cookie Authentication
		/// </summary>
		/// <returns>Stream async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="cookie">Cookie.</param>
		public async static Task<Stream> GetStreamAsync(string url, Cookie cookie)
		{
			try
			{
				var response = await url.WithCookie(cookie).GetStreamAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		///  Async Get Stream Request with Cookies
		/// </summary>
		/// <returns>Stream async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="cookies">Cookies Anonymous Object</param>
        /// <param name="expDate">ExpDate</param>
		public async static Task<Stream> GetStreamAsync(string url, object cookies, DateTime? expDate)
		{
			try
			{
				var response = await url.WithCookies(cookies,expDate).GetStreamAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		///  Async Get Stream Request with Header
		/// </summary>
		/// <returns>Stream async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="header">Header.</param>
		public async static Task<Stream> GetStreamAsync(string url, RequestHeader header)
		{
			try
			{
				var response = await url.WithHeader(header.Key, header.Value).GetStreamAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		///  Async Get Stream Request with Headers
		/// </summary>
		/// <returns>Stream async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		public async static Task<Stream> GetStreamAsync(string url, object headers)
		{
			try
			{
				var response = await url.WithHeaders(headers).GetStreamAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		///  Async Get Stream Request with OAuth Authentication & Headers
		/// </summary>
		/// <returns>Stream async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="token">Token.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		public async static Task<Stream> GetStreamAsync(string url, string token, object headers)
		{
			try
			{
				var response = await url.WithOAuthBearerToken(token).WithHeaders(headers).GetStreamAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Async Get Stream Request with Basic Authentication & Headers
		/// </summary>
		/// <returns>Stream async</returns>
		/// <param name="url">URL.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		public async static Task<Stream> GetStreamAsync(string url, string username, string password, object headers)
		{
			try
			{
				var response = await url.WithBasicAuth(username, password).WithHeaders(headers).GetStreamAsync();
				return response;
			}
			catch (Exception)
			{
				return null;
			}
		}





		/// <summary>
		/// Async Get ResponseType bytes Request
		/// </summary>
		/// <returns>ResponseType byte[] async</returns>
		/// <param name="url">URL.</param>
		public async static Task<ResponseType<byte[]>> GetBytesResponseAsync(string url)
		{
			try
			{
				var response = await url.GetBytesAsync();
                return new ResponseType<byte[]>(response, OK);
			}
			catch (Exception ex)
			{
                return new ResponseType<byte[]>(null, InternalServerError, ex.Message);
			}
		}

		/// <summary>
		///  Async Get ResponseType bytes Request with Basic Authentication
		/// </summary>
		/// <returns>ResponseType byte[] async</returns>
		/// <param name="url">URL.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		public async static Task<ResponseType<byte[]>> GetBytesResponseAsync(string url, string username, string password)
		{
			try
			{
				var response = await url.WithBasicAuth(username, password).GetBytesAsync();
                return new ResponseType<byte[]>(response, OK);
			}
			catch (Exception ex)
			{
                return new ResponseType<byte[]>(null, InternalServerError, ex.Message);
			}
		}

		/// <summary>
		/// Async Get ResponseType bytes Request with OAuth Authentication
		/// </summary>
		/// <returns>ResponseType byte[] async</returns>
		/// <param name="url">URL.</param>
		/// <param name="token">Token.</param>
		public async static Task<ResponseType<byte[]>> GetBytesResponseAsync(string url, string token)
		{
			try
			{
				var response = await url.WithOAuthBearerToken(token).GetBytesAsync();
                return new ResponseType<byte[]>(response, OK);
			}
			catch (Exception ex)
			{
                return new ResponseType<byte[]>(null, InternalServerError, ex.Message);
			}
		}

		/// <summary>
		///  Async Get ResponseType bytes Request with Cookie Authentication
		/// </summary>
		/// <returns>ResponseType byte[] async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="cookie">Cookie.</param>
		public async static Task<ResponseType<byte[]>> GetBytesResponseAsync(string url, Cookie cookie)
		{
			try
			{
				var response = await url.WithCookie(cookie).GetBytesAsync();
                return new ResponseType<byte[]>(response, OK);
			}
			catch (Exception ex)
			{
                return new ResponseType<byte[]>(null, InternalServerError, ex.Message);
			}
		}

		/// <summary>
		///  Async Get ResponseType bytes Request with Cookies
		/// </summary>
		/// <returns>ResponseType byte[] async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="cookies">Cookies Anonymous Object</param>
		/// <param name="expDate">ExpDate</param>
		public async static Task<ResponseType<byte[]>> GetBytesResponseAsync(string url, object cookies, DateTime? expDate)
		{
			try
			{
				var response = await url.WithCookies(cookies, expDate).GetBytesAsync();
                return new ResponseType<byte[]>(response, OK);
			}
			catch (Exception ex)
			{
                return new ResponseType<byte[]>(null, InternalServerError, ex.Message);
			}
		}

		/// <summary>
		///  Async Get ResponseType bytes Request with Header
		/// </summary>
		/// <returns>ResponseType byte[] async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="header">Header.</param>
		public async static Task<ResponseType<byte[]>> GetBytesResponseAsync(string url, RequestHeader header)
		{
			try
			{
				var response = await url.WithHeader(header.Key, header.Value).GetBytesAsync();
                return new ResponseType<byte[]>(response, OK);
			}
			catch (Exception ex)
			{
                return new ResponseType<byte[]>(null, InternalServerError, ex.Message);
			}
		}

		/// <summary>
		///  Async Get ResponseType bytes Request with Headera
		/// </summary>
		/// <returns>ResponseType byte[] async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		public async static Task<ResponseType<byte[]>> GetBytesResponseAsync(string url, object headers)
		{
			try
			{
				var response = await url.WithHeaders(headers).GetBytesAsync();
                return new ResponseType<byte[]>(response, OK);
			}
			catch (Exception ex)
			{
                return new ResponseType<byte[]>(null, InternalServerError, ex.Message);
			}
		}

		/// <summary>
		/// Async Get ResponseType bytes Request with OAuth Authentication & Headers
		/// </summary>
		/// <returns>ResponseType byte[] async</returns>
		/// <param name="url">URL.</param>
		/// <param name="token">Token.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		public async static Task<ResponseType<byte[]>> GetBytesResponseAsync(string url, string token, object headers)
		{
			try
			{
				var response = await url.WithOAuthBearerToken(token).WithHeaders(headers).GetBytesAsync();
                return new ResponseType<byte[]>(response, OK);
			}
			catch (Exception ex)
			{
                return new ResponseType<byte[]>(null, InternalServerError, ex.Message);
			}
		}

		/// <summary>
		///  Async Get ResponseType bytes Request with Basic Authentication & Headers
		/// </summary>
		/// <returns>ResponseType byte[] async</returns>
		/// <param name="url">URL.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		public async static Task<ResponseType<byte[]>> GetBytesResponseAsync(string url, string username, string password, object headers)
		{
			try
			{
				var response = await url.WithBasicAuth(username, password).WithHeaders(headers).GetBytesAsync();
                return new ResponseType<byte[]>(response, OK);
			}
			catch (Exception ex)
			{
                return new ResponseType<byte[]>(null, InternalServerError, ex.Message);
			}
		}


	}
		
}

