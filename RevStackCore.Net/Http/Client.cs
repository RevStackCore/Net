using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RevStackCore.Net
{
	public class HttpClient
	{
		private int OK = 200;
		private string _contentType = "application/json";
		private int InternalServerError = 500;
		private string _url { get; set; }
		public WebRequest Request { get; set; }
		public string ContentType { get; set; }
        /// <summary>
        /// Sends an http request async.
        /// </summary>
        /// <returns>ResponseType async.</returns>
        /// <param name="json">Json.</param>
        /// <param name="method">Method.</param>
		public async Task<ResponseType<string>> SendAsync(string json, HttpMethod method)
		{
			UTF8Encoding enc = new UTF8Encoding();
			Request.Method = method.ToString().ToLower();
			try
			{
				using (Stream dataStream = await Request.GetRequestStreamAsync())
				{
					dataStream.Write(enc.GetBytes(json), 0, json.Length);
					WebResponse wr = await Request.GetResponseAsync();
					Stream receiveStream = wr.GetResponseStream();
					StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
					string content = reader.ReadToEnd();
					return new ResponseType<string>(content, OK);
				}
			}
			catch (Exception ex)
			{
				return new ResponseType<string>(null, InternalServerError, ex.Message);
			}
		}

		public HttpClient(string url)
		{
			_url = url;
			Request = WebRequest.Create(url);
			Request.ContentType = _contentType;
		}

		public HttpClient(string url, string contentType)
		{
			_url = url;
			Request = WebRequest.Create(url);
			Request.ContentType = contentType;
		}
	}
}
