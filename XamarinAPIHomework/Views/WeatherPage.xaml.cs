using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAPIHomework.Models;
using XamarinAPIHomework.Services;
using XamarinAPIHomework.ViewModels;

namespace XamarinAPIHomework
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();
            this.BindingContext = new WeatherViewModel();
        }


       
        
    }
}