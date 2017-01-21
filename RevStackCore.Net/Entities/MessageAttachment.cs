using MimeKit;
using System.IO;

namespace RevStackCore.Net
{
	/// <summary>
	/// Message part.
	/// </summary>
	public class MessageAttachment
	{
		public string Filename { get; set; }
		public FileStream File { get; set; }
		public string MediaType { get; set; }
		public string MediaSubType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="T:RevStackCore.Net.MessageAttachment"/> class.
		/// </summary>
		public MessageAttachment()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:RevStackCore.Net.MessageAttachment"/> class.
		/// </summary>
		/// <param name="mediaType">Media type.</param>
		/// <param name="mediaSubType">Media sub type.</param>
		public MessageAttachment(string mediaType, string mediaSubType)
		{
			MediaType = mediaType;
			MediaSubType = mediaSubType;
		}
	}
}
