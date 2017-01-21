﻿using System;
using System.Threading.Tasks;
using System.Net;
using Flurl.Http;

namespace RevStackCore.Net
{
	public static partial class Http
	{
		/// <summary>
		/// Downloads file async.
		/// </summary>
		/// <returns>string async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="path">Path.</param>
		public async static Task<string> DownloadAsync(string url, string path)
		{
			try
			{
				var result = await url.DownloadFileAsync(path);
				return result;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Downloads file async with Basic Authentication
		/// </summary>
		/// <returns>string async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="path">Path.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		public async static Task<string> DownloadAsync(string url, string path, string username, string password)
		{
			try
			{
				var result = await url.WithBasicAuth(username,password).DownloadFileAsync(path);
				return result;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Downloads file async with OAuth Authentication
		/// </summary>
		/// <returns>string async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="path">Path.</param>
		/// <param name="token">Token.</param>
		public async static Task<string> DownloadAsync(string url, string path, string token)
		{
			try
			{
				var result = await url.WithOAuthBearerToken(token).DownloadFileAsync(path);
				return result;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Downloads file async with Cookie Authentication
		/// </summary>
		/// <returns>string async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="path">Path.</param>
		/// <param name="cookie">Cookie.</param>
		public async static Task<string> DownloadAsync(string url, string path, Cookie cookie)
		{
			try
			{
				var result = await url.WithCookie(cookie).DownloadFileAsync(path);
				return result;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Downloads file async with Header
		/// </summary>
		/// <returns>string async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="path">Path.</param>
		/// <param name="header">Header.</param>
		public async static Task<string> DownloadAsync(string url, string path, RequestHeader header)
		{
			try
			{
				var result = await url.WithHeader(header.Key,header.Value).DownloadFileAsync(path);
				return result;
			}
			catch (Exception)
			{
				return null;
			}
		}

	}
}