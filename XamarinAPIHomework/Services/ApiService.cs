using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinAPIHomework.Models;

namespace XamarinAPIHomework.Services
{
    public class ApiService: IWeatherApi
    {
        public ApiService()
        {
           
        }

        public async Task<CityWeather> GetWeather(string InputCity)
        {
            var apiResponse = RestService.For<IWeatherApi>("http://api.openweathermap.org");
            var cityWeather = await apiResponse.GetWeather(InputCity);

            return cityWeather;


        }

    }
}
