using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public enum TempChoice { Fifties, Sixties, Seventies, Eighties, Nineties, }

        Random random = new Random();

        public string getWeather()
        {

            int number = random.Next(1, 5);
            if (number == 1)
            {
                return "Rain";
            }
            if (number == 2)
            {
                return "Overcast";
            }
            if (number == 3)
            {
                return "Cloudy";
            }
            if (number == 4)
            {
                return "Sunny";
            }
            return "";
        }

        public string getTemperature()
        {

            int number = random.Next(1, 7);
            if (number == 1)
            {
                return "50's";
            }
            if (number == 2)
            {
                return "60's";
            }
            if (number == 3)
            {
                return "70's";
            }
            if (number == 4)
            {
                return "80's";
            }
            if (number == 5)
            {
                return "90's";
            }
            if (number == 6)
            {
                return "100's";
            }
            return "";
        }
    }
}
