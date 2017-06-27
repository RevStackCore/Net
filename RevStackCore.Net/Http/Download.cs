using System;
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
		/// Downloads file async with Cookies
		/// </summary>
		/// <returns>string async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="path">Path.</param>
		/// <param name="cookies">Cookies Anonymous Object</param>
		public async static Task<string> DownloadAsync(string url, string path, object cookies, DateTime? expDate)
		{
			try
			{
				var result = await url.WithCookies(cookies,expDate).DownloadFileAsync(path);
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

		/// <summary>
		/// Downloads file async with Headers
		/// </summary>
		/// <returns>string async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="path">Path.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		public async static Task<string> DownloadAsync(string url, string path, object headers)
		{
			try
			{
				var result = await url.WithHeaders(headers).DownloadFileAsync(path);
				return result;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Downloads file async with OAuth Authentication & Headers
		/// </summary>
		/// <returns>string async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="path">Path.</param>
		/// <param name="token">Token.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		public async static Task<string> DownloadAsync(string url, string path, string token, object headers)
		{
			try
			{
				var result = await url.WithOAuthBearerToken(token).WithHeaders(headers).DownloadFileAsync(path);
				return result;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Downloads file async with Basic Authentication & Headers
		/// </summary>
		/// <returns>string async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="path">Path.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <param name="headers">Headers Anonymous Object</param>
		public async static Task<string> DownloadAsync(string url, string path, string username, string password, object headers)
		{
			try
			{
				var result = await url.WithBasicAuth(username, password).WithHeaders(headers).DownloadFileAsync(path);
				return result;
			}
			catch (Exception)
			{
				return null;
			}
		}





		/// <summary>
		/// Downloads file async.
		/// </summary>
		/// <returns>ResponseType async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="path">Path.</param>
        public async static Task<ResponseType<string>> DownloadStringAsync(string url, string path)
		{
			try
			{
				var result = await url.DownloadFileAsync(path);
                return new ResponseType<string>(result, OK);
			}
			catch (Exception ex)
			{
                return new ResponseType<string>(null, InternalServerError, ex.Message);
			}
		}

		/// <summary>
		/// Downloads file async with Basic Authentication
		/// </summary>
		/// <returns>ResponseType async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="path">Path.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		public async static Task<ResponseType<string>> DownloadStringAsync(string url, string path, string username, string password)
		{
			try
			{
				var result = await url.WithBasicAuth(username, password).DownloadFileAsync(path);
                return new ResponseType<string>(result, OK);
			}
			catch (Exception ex)
			{
                return new ResponseType<string>(null, InternalServerError, ex.Message);
			}
		}

		/// <summary>
		/// Downloads file async with OAuth Authentication
		/// </summary>
		/// <returns>ResponseType async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="path">Path.</param>
		/// <param name="token">Token.</param>
        public async static Task<ResponseType<string>> DownloadStringAsync(string url, string path, string token)
		{
			try
			{
				var result = await url.WithOAuthBearerToken(token).DownloadFileAsync(path);
                return new ResponseType<string>(result, OK);
			}
			catch (Exception ex)
			{
                return new ResponseType<string>(null, InternalServerError, ex.Message);
			}
		}

		/// <summary>
		/// Downloads file async with Cookie Authentication
		/// </summary>
		/// <returns>ResponseType async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="path">Path.</param>
		/// <param name="cookie">Cookie.</param>
        public async static Task<ResponseType<string>> DownloadStringAsync(string url, string path, Cookie cookie)
		{
			try
			{
				var result = await url.WithCookie(cookie).DownloadFileAsync(path);
                return new ResponseType<string>(result, OK);
			}
			catch (Exception ex)
			{
                return new ResponseType<string>(null, InternalServerError, ex.Message);
			}
		}

		/// <summary>
		/// Downloads file async with Cookies
		/// </summary>
		/// <returns>ResponseType async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="path">Path.</param>
		/// <param name="cookies">Cookies Anonymous Object</param>
        public async static Task<ResponseType<string>> DownloadStringAsync(string url, string path, object cookies, DateTime? expDate)
		{
			try
			{
				var result = await url.WithCookies(cookies, expDate).DownloadFileAsync(path);
                return new ResponseType<string>(result, OK);
			}
			catch (Exception ex)
			{
                return new ResponseType<string>(null, InternalServerError, ex.Message);
			}
		}

		/// <summary>
		/// Downloads file async with Header
		/// </summary>
		/// <returns>ResponseType async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="path">Path.</param>
		/// <param name="header">Header.</param>
        public async static Task<ResponseType<string>> DownloadStringAsync(string url, string path, RequestHeader header)
		{
			try
			{
				var result = await url.WithHeader(header.Key, header.Value).DownloadFileAsync(path);
                return new ResponseType<string>(result, OK);
			}
            catch (Exception ex)
			{
                return new ResponseType<string>(null, InternalServerError, ex.Message);
			}
		}

		/// <summary>
		/// Downloads file async with Headers
		/// </summary>
		/// <returns>ResponseType async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="path">Path.</param>
		/// <param name="headers">Headers Anonymous Object</param>
        public async static Task<ResponseType<string>> DownloadStringAsync(string url, string path, object headers)
		{
			try
			{
				var result = await url.WithHeaders(headers).DownloadFileAsync(path);
                return new ResponseType<string>(result, OK);
			}
			catch (Exception ex)
			{
                return new ResponseType<string>(null, InternalServerError, ex.Message);
			}
		}

		/// <summary>
		/// Downloads file async with OAuth Authentication & Headers
		/// </summary>
		/// <returns>ResponseType async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="path">Path.</param>
		/// <param name="token">Token.</param>
		/// <param name="headers">Headers Anonymous Object</param>
        public async static Task<ResponseType<string>> DownloadStringAsync(string url, string path, string token, object headers)
		{
			try
			{
				var result = await url.WithOAuthBearerToken(token).WithHeaders(headers).DownloadFileAsync(path);
                return new ResponseType<string>(result, OK);
			}
			catch (Exception ex)
			{
                return new ResponseType<string>(null, InternalServerError, ex.Message);
			}
		}

		/// <summary>
		/// Downloads file async with Basic Authentication & Headers
		/// </summary>
		/// <returns>ResponseType async.</returns>
		/// <param name="url">URL.</param>
		/// <param name="path">Path.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <param name="headers">Headers Anonymous Object</param>
        public async static Task<ResponseType<string>> DownloadStringAsync(string url, string path, string username, string password, object headers)
		{
			try
			{
				var result = await url.WithBasicAuth(username, password).WithHeaders(headers).DownloadFileAsync(path);
                return new ResponseType<string>(result, OK);
			}
			catch (Exception ex)
			{
                return new ResponseType<string>(null, InternalServerError, ex.Message);
			}
		}





	}
}
