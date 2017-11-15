using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace CapStone.Models
{
    public class Weather
    {
        public object getweatherForcast()
        {



            string url = "http://api.openweathermap.org/data/2.5/weather?q=Milwaukee&APPID=57a30f253654d8374160b752d1e17997&units=imperial";
            //synchronous client.
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<object>(content);
            return jsonContent;

        }
    }
}