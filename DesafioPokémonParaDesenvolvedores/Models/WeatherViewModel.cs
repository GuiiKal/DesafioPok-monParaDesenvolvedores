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
            //public int Id { get; set; }
            // public string Main { get; set; }
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
        //public class Wind
        //{
        //    public double Speed { get; set; }
        //    public int Deg { get; set; }
        //}
        //public class Clouds
        //{
        //    public int All { get; set; }
        //}

        public class Sys
        {
            //public int Type { get; set; }
            //public int Id { get; set; }
            public string Country { get; set; }
            //public int Sunrise { get; set; }
            //public int Sunset { get; set; }
        }

        public class RootObject
        {
            //public COORD Coord { get; set; }
            public List<Weather> Weather { get; set; }
            //public string @Base { get; set; }
            public Main Main { get; set; }
            //public int Visibility { get; set; }
            //public Wind Wind { get; set; }
            //public Clouds Wlouds { get; set; }
            //public int Dt { get; set; }
            public Sys Sys { get; set; }
            //public int Timezone { get; set; }
            //public int Id { get; set; }
            public string Name { get; set; }
            //public int Cod { get; set; }
        }
    }
}