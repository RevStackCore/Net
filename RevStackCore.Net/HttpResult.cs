using System;
using System.Collections.Generic;
using System.Net;

namespace RevStackCore.Net
{
    public class HttpResult
    {
        public HttpStatusCode StatusCode { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public string StatusDescription { get; set; }
        public string ContentBody { get; set; }
        public string ContentType { get; set; }
        public long ContentLength { get; set; }
        public Exception Exception { get; set; }
    }

}
