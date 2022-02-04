using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PInvoke;

namespace DesafioPokémonParaDesenvolvedores.Models
{
    public class WeatherViewModel
    {
        public class ResultViewModel
        {
            public string City { get; set; }
            public string Country { get; set; }
            public string Description { get; set; }
            public string Humidity { get; set; }
            public Double Temp { get; set; }
            public string WeatherIcon { get; set; }
        }
        public class Weather
        {
            public string Description { get; set; }
            public string Icon { get; set; }
        }
        public class Main
        {
            public double Temp { get; set; }
            public double Humidity { get; set; }
            public double ConverteCelcius(Double temp)
            {
                Double valorCelcius = Temp - 273.15;
                return valorCelcius;
            }
        }
  

        public class Sys
        {
            public string Country { get; set; }
        }

        public class RootObject
        {
            public List<Weather> Weather { get; set; }
            public Main Main { get; set; }
            public Sys Sys { get; set; }
            public string Name { get; set; }
        }
    }
}