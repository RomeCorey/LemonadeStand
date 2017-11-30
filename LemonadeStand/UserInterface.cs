using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UserInterface
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to your very own Lemonade Stand!");            
        }

        public void Rules()
        {
            Console.WriteLine("The goal is to make as much money you can over a 7 day period at a lemonade stand.");
            Console.WriteLine("Customers will walk buy their chance of buying is affected by the price per cup that you set and the weather.");
            Console.WriteLine("Each day you can buy the supplies you will need to make more lemonade.");
            Console.WriteLine("Then choose how much lemonade you want to make for the day.");

        }
    }
}
