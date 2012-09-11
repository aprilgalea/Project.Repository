using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Configuration;

namespace MailableMe.Service.Common
{
    public class RackSpaceHelper
    {
        public static string Post(Core.RackSpaceClient client)
        {
            client.Method = Core.WebMethod.POST;
            return ProcessRackSpace(client);
        }

        public static string Get(Core.RackSpaceClient client)
        {
            client.Method = Core.WebMethod.GET;
            return ProcessRackSpace(client);
        }

        public static string GetUserKey()
        {
            return ConfigurationManager.AppSettings["UserKey"].ToString();
        }

        public static string GetSecretKey()
        {
            return ConfigurationManager.AppSettings["SecretKey"].ToString();
        }

        private static string ProcessRackSpace(Core.RackSpaceClient client)
        {
            HttpWebResponse response = (HttpWebResponse)client.HttpRequest.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }
    }
}
