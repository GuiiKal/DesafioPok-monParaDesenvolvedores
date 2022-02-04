using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using static DesafioPokémonParaDesenvolvedores.Models.WeatherViewModel;

namespace DesafioPokémonParaDesenvolvedores.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Weather()
        {
            return View();
        }


        [HttpPost]
        public String WeatherDetail(String city)
        {
            //Assign API KEY which received from OPENWEATHERMAP.ORG  
            string appId = "e77f0776f1489f161a3b1de7fa8844a0";

            //API path with CITY parameter and other parameters.  
            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&APPID={1}", city, appId);

            using (WebClient client = new WebClient())
            {

                string json = client.DownloadString(url);

                //Converting to OBJECT from JSON string.  

                RootObject weatherInfo = (new JavaScriptSerializer()).Deserialize<RootObject>(json);

                //Special VIEWMODEL design to send only required fields not all fields which received from   
                //www.openweathermap.org api  
                ResultViewModel rslt = new ResultViewModel();

                rslt.Country = weatherInfo.Sys.Country;
                rslt.City = weatherInfo.Name;
                rslt.Description = weatherInfo.Weather[0].Description;
                rslt.Humidity = Convert.ToString(weatherInfo.Main.Humidity);

                rslt.Temp = weatherInfo.Main.ConverteCelcius(weatherInfo.Main.Temp);
                rslt.WeatherIcon = weatherInfo.Weather[0].Icon;

                //Converting OBJECT to JSON String   
                var jsonstring = new JavaScriptSerializer().Serialize(rslt);

                //Return JSON string.  
                return jsonstring;

            }
        }

    }
}