using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Weather.Api.Models;

namespace Weather.Api
{
    public class Controller
    {
        public Controller() { }

        public string Call()
        {
            var uri = ApiSettings.Default.Url;
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        if (stream == null) return null;
                        using (StreamReader streamReader = new StreamReader(stream))
                        {
                            string weather = streamReader.ReadToEnd();
                            return weather;
                        }
                    }
                }
            }
            catch (WebException) { return null; }
        }
    }
}
