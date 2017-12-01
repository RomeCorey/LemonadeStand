using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {   public int CurrentDay = 0;
        List<Customer> customers = new List<Customer>();
        Random rnd = new Random();
        Weather weather = new Weather();
        
        public int GetDay()
        {
            return CurrentDay;
        }

        public void FillCustomers()
        {
            for (int i = 1; i <= 50; i++)
            {
                Customer customer = new Customer();
                customer.percentChanceToBuy = rnd.Next(40, 61);
                customers.Add(customer); 
            }     
        }

        public void WeatherAffect()
        {

            string weatherinfo = weather.GetWeather();

            if (weatherinfo == "Rain")
            {
                
                for (int i = 0; i > customers.Count; i++)
                {
                    customers[i].percentChanceToBuy -= 10;                    
                }
            }
            else if (weatherinfo == "Overcast")
            {

                for (int i = 0; i > customers.Count; i++)
                {
                    customers[i].percentChanceToBuy -= 6;
                }
            }
            else if (weatherinfo == "Cloudy")
            {

                for (int i = 0; i > customers.Count; i++)
                {
                    customers[i].percentChanceToBuy -= 1;
                }
            }
            if (weatherinfo == "Sunny")
            {

                for (int i = 0; i > customers.Count; i++)
                {
                    customers[i].percentChanceToBuy += 10;
                }
            }            
        }

    }
}
