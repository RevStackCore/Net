using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RevStackCore.Net.Service
{
    public class HttpService : IHttpService
    {
        const string CONTENT_TYPE = "application/json; charset=utf-8";

        public HttpService()
        {

        }

        public HttpResult Request(string url, string method, string body)
        {
            return Request(url, method, body, "", "");
        }

        public Task<HttpResult> RequestAsync(string url, string method, string body)
        {
            return RequestAsync(url, method, body, "", "");
        }

        public HttpResult Request(string url, string method, string body, string username, string password)
        {
            return Request(url, method, body, "", "", "");
        }

        public Task<HttpResult> RequestAsync(string url, string method, string body, string username, string password)
        {
            return RequestAsync(url, method, body, "", username, password);
        }

        public HttpResult Request(string url, string method, string body, string contentType, string username, string password)
        {
            return RequestAsync(url, method, body, contentType, username, password).Result;
        }

        public Task<HttpResult> RequestAsync(string url, string method, string body, string contentType, string username, string password)
        {
            return RequestInternal(url, method, body, contentType, username, password);
        }

        #region "private"

        private async Task<HttpResult> RequestInternal(string url, string method, string body, string contentType, string username, string password)
        {
            HttpResult httpResult = new HttpResult();
            HttpWebResponse response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = method;

                if (!string.IsNullOrEmpty(username))
                {
                    var cred = new NetworkCredential(username, password);
                    request.Credentials = cred;
                    
                }

                if (string.IsNullOrEmpty(contentType))
                    request.ContentType = CONTENT_TYPE;

                if (!string.IsNullOrEmpty(body))
                {
                    var bytes = Encoding.UTF8.GetBytes(body);
                    using (var stream = await request.GetRequestStreamAsync().ConfigureAwait(false))
                    {
                        stream.Write(bytes, 0, bytes.Length);
                    }
                }

                response = (HttpWebResponse)await request.GetResponseAsync();
                httpResult.StatusCode = ((HttpWebResponse)response).StatusCode;
                httpResult.StatusDescription = ((HttpWebResponse)response).StatusDescription;
                httpResult.ContentLength = response.ContentLength;
                httpResult.ContentType = response.ContentType;
                response.Headers.AllKeys.ToList().ForEach(o => httpResult.Headers.Add(o, response.Headers[o]));

            }
            catch (WebException ex)
            {
                httpResult.Exception = ex;
                if (ex.Response != null)
                {
                    httpResult.StatusCode = ((HttpWebResponse)ex.Response).StatusCode;
                    httpResult.StatusDescription = ((HttpWebResponse)ex.Response).StatusDescription;
                    response = (HttpWebResponse)ex.Response;
                }
            }
            catch (Exception ex)
            {
                httpResult.Exception = ex;
            }

            if (response != null && response.ContentLength > 0)
            {
                int count = 0;
                byte[] buf = new byte[8192];
                StringBuilder sb = new StringBuilder();

                do
                {
                    count = response.GetResponseStream().Read(buf, 0, buf.Length);
                    if (count != 0)
                    {
                        string tempString = Encoding.UTF8.GetString(buf, 0, count);
                        sb.Append(tempString);
                    }
                }
                while (count > 0);

                httpResult.ContentBody = sb.ToString();
            }
            
            return httpResult;
        }

        #endregion
    }
}
