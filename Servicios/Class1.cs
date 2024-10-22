using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Service
    {
        private static string url = "https://jsonplaceholder.typicode.com/posts";
        public static string GetPost()
        {
            WebRequest request = WebRequest.Create(url);

            request.Method = "GET";

            var httpResponse = (HttpWebResponse)request.GetResponse();
            using (var StreamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                return StreamReader.ReadToEnd();
            }
        }
    }
}
