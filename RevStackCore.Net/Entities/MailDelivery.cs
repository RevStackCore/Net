using System;
using System.Net;
namespace RevStackCore.Net
{
	/// <summary>
	/// Mail delivery.
	/// </summary>
	public class MailDelivery 
	{
		public string Host { get; set; }
		public int Port { get; set; }
		public ICredentials Credentials { get; set; }
		public SecureSocketOptions SecureSocketOption { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="T:RevStackCore.Net.MailDelivery"/> class.
		/// </summary>
		public MailDelivery()
		{
			Port = 25;
			SecureSocketOption = SecureSocketOptions.None;
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="T:RevStackCore.Net.MailDelivery"/> class.
		/// </summary>
		/// <param name="host">Host.</param>
		public MailDelivery(string host)
		{
			Host = host;
			Port = 25;
			SecureSocketOption = SecureSocketOptions.None;
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="T:RevStackCore.Net.MailDelivery"/> class.
		/// </summary>
		/// <param name="host">Host.</param>
		/// <param name="port">Port.</param>
		public MailDelivery(string host,int port)
		{
			Host = host;
			Port = port;
			SecureSocketOption = SecureSocketOptions.None;
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="T:RevStackCore.Net.MailDelivery"/> class.
		/// </summary>
		/// <param name="host">Host.</param>
		/// <param name="option">Option.</param>
		public MailDelivery(string host,SecureSocketOptions option)
		{
			Host = host;
			Port = 25;
			SecureSocketOption = option;
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="T:RevStackCore.Net.MailDelivery"/> class.
		/// </summary>
		/// <param name="host">Host.</param>
		/// <param name="port">Port.</param>
		/// <param name="option">Option.</param>
		public MailDelivery(string host, int port,SecureSocketOptions option)
		{
			Host = host;
			Port = port;
			SecureSocketOption = option;
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="T:RevStackCore.Net.MailDelivery"/> class.
		/// </summary>
		/// <param name="host">Host.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		public MailDelivery(string host,string username, string password)
		{
			Credentials = new NetworkCredential(username, password);
			Host = host;
			Port = 25;
			SecureSocketOption = SecureSocketOptions.None;
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="T:RevStackCore.Net.MailDelivery"/> class.
		/// </summary>
		/// <param name="host">Host.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <param name="option">Option.</param>
		public MailDelivery(string host, string username, string password, SecureSocketOptions option)
		{
			Credentials = new NetworkCredential(username, password);
			Host = host;
			Port = 25;
			SecureSocketOption = option;
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="T:RevStackCore.Net.MailDelivery"/> class.
		/// </summary>
		/// <param name="host">Host.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <param name="port">Port.</param>
		public MailDelivery(string host, string username, string password, int port)
		{
			Credentials = new NetworkCredential(username, password);
			Host = host;
			Port = port;
			SecureSocketOption = SecureSocketOptions.None;
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="T:RevStackCore.Net.MailDelivery"/> class.
		/// </summary>
		/// <param name="host">Host.</param>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <param name="port">Port.</param>
		/// <param name="option">Option.</param>
		public MailDelivery(string host, string username, string password, int port,SecureSocketOptions option)
		{
			Credentials = new NetworkCredential(username, password);
			Host = host;
			Port = port;
			SecureSocketOption = option;
		}


	}
}
