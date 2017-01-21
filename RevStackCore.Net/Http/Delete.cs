using System;
using System.Threading.Tasks;
using System.Net;
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
	}
}
