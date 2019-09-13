using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using XamarinAPIHomework.Models;
using XamarinAPIHomework.Services;

namespace XamarinAPIHomework.ViewModels
{
    public class WeatherViewModel:INotifyPropertyChanged
    {

        public ICommand GetWeatherCommand { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        IWeatherApi apiService = new ApiService();
        public CityWeather CityWeather { get; set; }

        public string ImageLink { get; set; }
        public string InputCity { get; set; }
        public WeatherViewModel()
        {
            InputCity = "Santo Domingo";
            GetWeatherCommand = new Command(async () =>
            {
                await GetWeather();
            });

           
        }

        async Task GetWeather()
        {
            try
            {
                var current = Connectivity.NetworkAccess;
                if (current == NetworkAccess.Internet)
                {

                    CityWeather = await apiService.GetWeather(InputCity);
                    ImageLink = $"http://openweathermap.org/img/wn/{CityWeather.Weather[0].Icon}@2x.png";
                 
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Error", "You don't have internet connection", "Ok");
                }
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", "Unable to connect to the server", "Ok");
            }
        }
    }
}
