using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit.Text;
using MimeKit;

namespace RevStackCore.Net.Service
{
    public class SmtpService : ISmtpService
    {
        private readonly BasicCredentials _credentials;

        public SmtpService(BasicCredentials credentials)
        {
            _credentials = credentials;
        }

        
        public bool SendEmail(string to, string from, string subject, string body, bool isHtml)
        {
            var list = new List<string>() { to };
            return SendEmail(list, from, subject, body, isHtml);
        }

        public Task<bool> SendEmailAsync(string to, string from, string subject, string body, bool isHtml)
        {
            var list = new List<string>() { to };
            return SendEmailAsync(list, from, subject, body, isHtml);
        }

        public bool SendEmail(List<string> to, string from, string subject, string body, bool isHtml)
        {
            return SendEmail(to, from, subject, body, isHtml, _credentials);
        }

        public Task<bool> SendEmailAsync(List<string> to, string from, string subject, string body, bool isHtml)
        {
            return SendEmailAsync(to, from, subject, body, isHtml, _credentials);
        }

        public bool SendEmail(List<string> to, string from, string subject, string body, bool isHtml, BasicCredentials credentials)
        {
            return SendEmailAsync(to, from, subject, body, isHtml, credentials).Result;
        }

        public Task<bool> SendEmailAsync(List<string> to, string from, string subject, string body, bool isHtml, BasicCredentials credentials)
        {
            return SendEmailInternal(to, from, subject, body, isHtml, credentials);
        }

        #region "private"

        private async Task<bool> SendEmailInternal(List<string> to, string from, string subject, string body, bool isHtml, BasicCredentials credentials)
        {
            try
            {
                var emailMessage = new MimeMessage();
                emailMessage.From.Add(new MailboxAddress(from));

                foreach (var email in to)
                    emailMessage.To.Add(new MailboxAddress("", email));

                emailMessage.Subject = subject;

                if (isHtml)
                {
                    emailMessage.Body = new TextPart(TextFormat.Html) { Text = body };
                }
                else
                {
                    emailMessage.Body = new TextPart("plain") { Text = body };
                }

                if (credentials == null)
                    credentials = _credentials;

                using (var client = new SmtpClient())
                {
                    client.Authenticate(new NetworkCredential(credentials.Username, credentials.Password));
                    client.LocalDomain = credentials.LocalDomain;
                    await client.ConnectAsync(credentials.Host, credentials.Port, SecureSocketOptions.None).ConfigureAwait(false);
                    await client.SendAsync(emailMessage).ConfigureAwait(false);
                    await client.DisconnectAsync(true).ConfigureAwait(false);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion
    }
}
