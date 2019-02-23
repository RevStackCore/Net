using System.Threading.Tasks;
using MailKit.Net.Smtp;
using System.Net;

namespace RevStackCore.Net
{
	/// <summary>
	/// Smtp Static Class
	/// </summary>
	public static class Smtp
	{
		/// <summary>
		/// Sends the mail.
		/// </summary>
		/// <returns><c>true</c>, if mail was sent, <c>false</c> otherwise.</returns>
		/// <param name="message">Message.</param>
		/// <param name="mail">Mail.</param>
		public static bool SendMail(MailMessage message, MailDelivery mail)
		{
			var mimeMessage = message.ToMimeMessage();
            var socketOption = mail.SecureSocketOption.ToMailKitSocketOption();
			using (var client = new SmtpClient())
			{
				client.Connect(mail.Host, mail.Port, socketOption);
                client.Authenticate(mail.Credentials);
				client.Send(mimeMessage);
				client.Disconnect(true);
			}

			return true;
		}

		/// <summary>
		/// Sends the mail.
		/// </summary>
		/// <returns><c>true</c>, if mail was sent, <c>false</c> otherwise.</returns>
		/// <param name="to">To.</param>
		/// <param name="sender">Sender.</param>
		/// <param name="subject">Subject.</param>
		/// <param name="body">Body.</param>
		/// <param name="isHtml">If set to <c>true</c> is html.</param>
		/// <param name="host">Host.</param>
		/// <param name="credentials">Credentials.</param>
		public static bool SendMail(string to, string sender, string subject, string body, bool isHtml,string host, ICredentials credentials)
		{
			var message = new MailMessage(to);
			message.From = sender;
			message.IsHtml = isHtml;
			message.Subject = subject;
			message.Body = body;

			var mail = new MailDelivery(host);
			mail.Credentials = credentials;
			return SendMail(message, mail);
		}

		/// <summary>
		/// Sends the mail.
		/// </summary>
		/// <returns><c>true</c>, if mail was sent, <c>false</c> otherwise.</returns>
		/// <param name="to">To.</param>
		/// <param name="sender">Sender.</param>
		/// <param name="subject">Subject.</param>
		/// <param name="body">Body.</param>
		/// <param name="isHtml">If set to <c>true</c> is html.</param>
		/// <param name="host">Host.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		public static bool SendMail(string to, string sender, string subject, string body, bool isHtml, string host, string username, string password)
		{
			var message = new MailMessage(to);
			message.From = sender;
			message.IsHtml = isHtml;
			message.Subject = subject;
			message.Body = body;

			var mail = new MailDelivery(host,username,password);
			return SendMail(message, mail);
		}

		/// <summary>
		/// Sends the mail async.
		/// </summary>
		/// <returns>The mail async.</returns>
		/// <param name="message">Message.</param>
		/// <param name="mail">Mail.</param>
		public static Task<bool> SendMailAsync(MailMessage message, MailDelivery mail)
		{
			return Task.FromResult(SendMail(message, mail));
		}


		/// <summary>
		/// Sends the mail async.
		/// </summary>
		/// <returns>bool async.</returns>
		/// <param name="to">To.</param>
		/// <param name="sender">Sender.</param>
		/// <param name="subject">Subject.</param>
		/// <param name="body">Body.</param>
		/// <param name="isHtml">If set to <c>true</c> is html.</param>
		public static Task<bool> SendMailAsync(string to, string sender, string subject, string body,bool isHtml,string host, ICredentials credentials)
		{
			return Task.FromResult(SendMail(to, sender, subject, body, isHtml,host,credentials));
		}

		/// <summary>
		/// Sends the mail async.
		/// </summary>
		/// <returns>bool async</returns>
		/// <param name="to">To.</param>
		/// <param name="sender">Sender.</param>
		/// <param name="subject">Subject.</param>
		/// <param name="body">Body.</param>
		/// <param name="isHtml">If set to <c>true</c> is html.</param>
		/// <param name="host">Host.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		public static Task<bool> SendMailAsync(string to, string sender, string subject, string body, bool isHtml, string host, string username,string password)
		{
			return Task.FromResult(SendMail(to, sender, subject, body, isHtml, host, username,password));
		}

	}
}
