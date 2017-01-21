using System.Net;
namespace RevStackCore.Net
{
	public class ResponseType<T>
	{
		public T Value { get; set; }
		public HttpStatusCode HttpStatusCode { get; set; }

		public ResponseType()
		{
		}
		public ResponseType(T value, HttpStatusCode statusCode)
		{
			Value = value;
			HttpStatusCode = statusCode;
		}
	}
}
