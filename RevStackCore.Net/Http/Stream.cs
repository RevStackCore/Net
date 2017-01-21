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

	}
		
}

