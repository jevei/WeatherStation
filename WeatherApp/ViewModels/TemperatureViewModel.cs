using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.Commands;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public class TemperatureViewModel : BaseViewModel
    {
        /// TODO : Ajoutez le code nécessaire pour réussir les tests et répondre aux requis du projet
        public DelegateCommand<string> GetTempCommand { get; set; }
        public TemperatureModel CurrentTemp { get; set; }
        public ITemperatureService TemperatureService;
        public TemperatureViewModel()
        {
            GetTempCommand = new DelegateCommand<string>(GetTemp);
        }

        private void GetTemp(string obj)
        {
            CurrentTemp = TemperatureService.GetTempAsync().Result;
        }

        public static double CelsiusInFahrenheit(double c)
        {
            double temp = c * 9 / 5 + 32;
            temp = Math.Round(temp, 1);
            return temp;
        }

        public static double FahrenheitInCelsius(double f)
        {
            double temp = (f - 32) * 5 / 9;
            temp = Math.Round(temp, 1);
            return temp;
        }

        public bool CanGetTemp()
        {
            if (TemperatureService == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void SetTemperatureService(ITemperatureService _service)
        {
            TemperatureService = _service;
        }
    }
}
