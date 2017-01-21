using System;
namespace RevStackCore.Net
{
	/// <summary>
	/// Secure socket options.
	/// </summary>
	public enum SecureSocketOptions
	{
		Auto,
		None,
		SslOnConnect,
		StartTls,
		StartTlsWhenAvailable
	}
}
