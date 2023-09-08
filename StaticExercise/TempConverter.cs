using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {

        


        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double result = (fahrenheit - 32) / 1.8;
           

            return result;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            
            double result = (celsius * 9) / 5 + 32;
            

            return result;
        }
    }
}
