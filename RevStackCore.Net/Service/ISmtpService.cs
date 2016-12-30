using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RevStackCore.Net.Service
{
    public interface ISmtpService
    {
        bool SendEmail(string to, string from, string subject, string body, bool isHtml);
        Task<bool> SendEmailAsync(string to, string from, string subject, string body, bool isHtml);
        bool SendEmail(List<string> to, string from, string subject, string body, bool isHtml);
        Task<bool> SendEmailAsync(List<string> to, string from, string subject, string body, bool isHtml);
        bool SendEmail(List<string> to, string from, string subject, string body, bool isHtml, BasicCredentials credentials);
        Task<bool> SendEmailAsync(List<string> to, string from, string subject, string body, bool isHtml, BasicCredentials credentials);
    }
}
