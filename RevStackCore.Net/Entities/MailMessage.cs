using System.Collections.Generic;

namespace RevStackCore.Net
{
	/// <summary>
	/// Mail message.
	/// </summary>
	public class MailMessage
	{
		public IEnumerable<string> To { get; set; }
		public IEnumerable<string> Cc { get; set; }
		public IEnumerable<string> Bcc { get; set; }
		public string From { get; set; }
		public string Body { get; set; }
		public bool IsHtml { get; set; }
		public string Subject { get; set; }
		public MessageAttachment Attachment { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="T:RevStackCore.Net.MailMessage"/> class.
		/// </summary>
		public MailMessage()
		{
			IsHtml = false;
			To = new List<string>();
			Cc = new List<string>();
			Bcc = new List<string>();
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="T:RevStackCore.Net.MailMessage"/> class.
		/// </summary>
		/// <param name="to">To.</param>
		public MailMessage(string to)
		{
			IsHtml = false;
			To = new List<string>(new string[] { to });
			Cc = new List<string>();
			Bcc = new List<string>();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:RevStackCore.Net.MailMessage"/> class.
		/// </summary>
		/// <param name="to">To.</param>
		/// <param name="sender">Sender.</param>
		public MailMessage(string to, string sender)
		{
			IsHtml = false;
			To = new List<string>(new string[] { to });
			Cc = new List<string>();
			From = sender;
			Bcc = new List<string>();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:RevStackCore.Net.MailMessage"/> class.
		/// </summary>
		/// <param name="to">To.</param>
		/// <param name="isHtml">If set to <c>true</c> is html.</param>
		public MailMessage(string to, bool isHtml)
		{
			IsHtml = isHtml;
			IsHtml = false;
			To = new List<string>(new string[] { to });
			Cc = new List<string>();
			Bcc = new List<string>();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:RevStackCore.Net.MailMessage"/> class.
		/// </summary>
		/// <param name="to">To.</param>
		/// <param name="sender">Sender.</param>
		/// <param name="isHtml">If set to <c>true</c> is html.</param>
		public MailMessage(string to, string sender, bool isHtml)
		{
			IsHtml = isHtml;
			From = sender;
			To = new List<string>(new string[] { to });
			Cc = new List<string>();
			Bcc = new List<string>();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:RevStackCore.Net.MailMessage"/> class.
		/// </summary>
		/// <param name="to">To.</param>
		/// <param name="sender">Sender.</param>
		/// <param name="isHtml">If set to <c>true</c> is html.</param>
		public MailMessage(IEnumerable<string> to,string sender, bool isHtml)
		{
			IsHtml = isHtml;
			To = to;
			Cc = new List<string>();
			From = sender;
			Bcc = new List<string>();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:RevStackCore.Net.MailMessage"/> class.
		/// </summary>
		/// <param name="to">To.</param>
		/// <param name="cc">Cc.</param>
		/// <param name="sender">Sender.</param>
		/// <param name="isHtml">If set to <c>true</c> is html.</param>
		public MailMessage(IEnumerable<string> to, IEnumerable<string> cc,string sender, bool isHtml)
		{
			IsHtml = isHtml;
			To = to;
			Cc = cc;
			From = sender;
			Bcc = new List<string>();
		}


	}
}
