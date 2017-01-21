using Encryption = CoreFtp.Enum;

namespace RevStackCore.Net
{
	internal static class FtpExtensions
	{
		public static Encryption.FtpEncryption ToCoreFTPEncryption(this FtpEncryption encryption)
		{
			if (encryption == FtpEncryption.Explicit)
				return Encryption.FtpEncryption.Explicit;
			else if (encryption == FtpEncryption.Implicit)
				return Encryption.FtpEncryption.Implicit;
			else return Encryption.FtpEncryption.None;
		}
	}
}
