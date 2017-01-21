using MimeKit;
using MimeKit.Text;
using SocketOptions = MailKit.Security;

namespace RevStackCore.Net
{
	/// <summary>
	/// Internal Mail extensions.
	/// </summary>
	internal static class MailExtensions
	{
		/// <summary>
		/// Tos the MIME message.
		/// </summary>
		/// <returns>The MIME message.</returns>
		/// <param name="msg">Message.</param>
		public static MimeMessage ToMimeMessage(this MailMessage msg)
		{
			var mm = new MimeMessage();
			foreach (string to in msg.To)
			{
				mm.To.Add(new MailboxAddress(to));
			}
			foreach (string cc in msg.Cc)
			{
				mm.Cc.Add(new MailboxAddress(cc));
			}
			foreach (string bcc in msg.Bcc)
			{
				mm.Bcc.Add(new MailboxAddress(bcc));
			}
			mm.From.Add(new MailboxAddress(msg.From));

			MimeEntity body;

			if (msg.IsHtml)
			{
				body = new TextPart(TextFormat.Html) { Text = msg.Body };
			}
			else
			{
				body = new TextPart("plain") { Text = msg.Body };
			}
			mm.Subject = msg.Subject;

			if (msg.Attachment != null)
			{
				var attachment = new MimePart(msg.Attachment.MediaType, msg.Attachment.MediaSubType)
				{
					ContentObject = new ContentObject(msg.Attachment.File, ContentEncoding.Default),
					ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
					ContentTransferEncoding = ContentEncoding.Base64,
					FileName = msg.Attachment.Filename
				};

				var multipart = new Multipart("mixed");
				multipart.Add(body);
				multipart.Add(attachment);

				// now set the multipart/mixed as the message body
				mm.Body = multipart;
			}
			else
			{
				mm.Body = body;
			}

			return mm;

		}

		/// <summary>
		/// Tos the mail kit socket option.
		/// </summary>
		/// <returns>The mail kit socket option.</returns>
		/// <param name="option">Option.</param>
		public static SocketOptions.SecureSocketOptions ToMailKitSocketOption(this SecureSocketOptions option)
		{
			SocketOptions.SecureSocketOptions mkOption;
			if (option == SecureSocketOptions.Auto)
				mkOption = SocketOptions.SecureSocketOptions.Auto;
			else if (option == SecureSocketOptions.SslOnConnect)
				mkOption = SocketOptions.SecureSocketOptions.SslOnConnect;
			else if (option == SecureSocketOptions.StartTls)
				mkOption = SocketOptions.SecureSocketOptions.StartTls;
			else if (option == SecureSocketOptions.StartTlsWhenAvailable)
				mkOption = SocketOptions.SecureSocketOptions.StartTlsWhenAvailable;
			else mkOption = SocketOptions.SecureSocketOptions.None;

			return mkOption;
		}

	}
}
