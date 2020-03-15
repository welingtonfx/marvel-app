using System;
using System.Net;

namespace Infra.Comum
{
    public class MarvelException : Exception
    {
        public HttpStatusCode StatusCode { get; set; }
        public string StatusMessage { get; set; }
    }
}
