using System;
using System.Threading.Tasks;

namespace RevStackCore.Net.Service
{
    public interface IHttpService
    {
        HttpResult Request(string url, string method, string body);
        Task<HttpResult> RequestAsync(string url, string method, string body);
        HttpResult Request(string url, string method, string body, string username, string password);
        Task<HttpResult> RequestAsync(string url, string method, string body, string username, string password);
        HttpResult Request(string url, string method, string body, string contentType, string username, string password);
        Task<HttpResult> RequestAsync(string url, string method, string body, string contentType, string username, string password);
    }
}
