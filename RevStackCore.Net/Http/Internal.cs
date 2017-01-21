using System;
using System.Net;
using System.Net.Http;

namespace RevStackCore.Net
{
	public static partial class Http
	{
		/// <summary>
		/// Errors the response.
		/// </summary>
		/// <returns>The response.</returns>
		/// <param name="ex">Ex.</param>
		private static HttpResponseMessage errorResponse(Exception ex)
		{
			var errResponse = new HttpResponseMessage();
			errResponse.StatusCode = HttpStatusCode.InternalServerError;
			errResponse.ReasonPhrase = ex.Message;
			return errResponse;
		}
	}
}
