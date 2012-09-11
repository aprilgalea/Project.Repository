using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace MailableMe.Service.Core
{
    public enum WebMethod
    { 
        GET = 0,
        POST = 1,
        DELETE = 2,
        PUT = 3
    }

    public class RackSpaceClient
    {
        const string UserAgent = ".NET API";

        public string UserKey { get; set; }
        public string SecretKey { get; set; }
        
        public string URL { get; set; }
        public string Format { get; set; }
        public WebMethod Method { get; set; }

        HttpWebRequest _request;
        public HttpWebRequest HttpRequest { get { return this._request; } }

        public RackSpaceClient()
        {
            string timeStamp = DateTime.Now.ToString("YYYYMMDDHHmmss");
            string hash = Common.Helper.ConvertToBase64SHA1(string.Format("{0}{1}{2}{3}", this.UserKey, UserAgent, timeStamp, this.SecretKey));

            this._request = (HttpWebRequest)WebRequest.Create(this.URL);
            this._request.Method = Enum.GetName(typeof(WebMethod), Method);
            this._request.Accept = Format;
            this._request.Headers["X-Api-Signature"] = this.UserKey + timeStamp + hash;
            this._request.UserAgent = UserAgent;
        }

        public RackSpaceClient(string userkey, string secretkey, string url, string format, WebMethod method)
        {
            this.UserKey = userkey;
            this.SecretKey = secretkey;
            this.URL = url;
            this.Format = format;
            this.Method = method;
        }
    }
}
