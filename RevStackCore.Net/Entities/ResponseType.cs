using System.Net;
namespace RevStackCore.Net
{
	public class ResponseType<T>
	{
		public T Value { get; set; }
		public int StatusCode { get; set; }
        public string Error { get; set; }

		public ResponseType()
		{
		}
		public ResponseType(T value, int statusCode)
		{
			Value = value;
            StatusCode = statusCode;
		}
		public ResponseType(T value, int statusCode, string error)
		{
			Value = value;
            StatusCode = statusCode;
            Error = error;
		}
	}
}
