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

        public void IncrementDay()
        {
            CurrentDay++;
        }
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
    
    }
}
