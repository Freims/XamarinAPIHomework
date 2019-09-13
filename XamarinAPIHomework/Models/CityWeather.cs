using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinAPIHomework.Models
{
    public class CityWeather
    {
        public IList<Weather> Weather { get; set; }
        public Main Main { get; set; }
        public string Name { get; set; }   
        public Sys Sys { get; set; }

    }


    public class Weather
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }

    public class Main
    {
        public double Temp { get; set; }
       
    }
    public class Sys
    {
        public string Country { get; set; }
       
    }

}
