using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.ViewModels
{
    public class TemperatureViewModel : BaseViewModel
    {
        /// TODO : Ajoutez le code nécessaire pour réussir les tests et répondre aux requis du projet
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
    }
}
