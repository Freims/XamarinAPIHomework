using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinAPIHomework.Models;


namespace XamarinAPIHomework.Services
{
    public interface IWeatherApi
    {
       [Get("/data/2.5/weather?q={city}&APPID=7d022d935c4a44446fbfb1b07b9dcecf")]
      Task<CityWeather> GetWeather(string city);

    }
}
