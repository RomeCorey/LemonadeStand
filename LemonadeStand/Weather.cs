using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        Random random = new Random();

        public string GetWeather()
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
        
    }
}
