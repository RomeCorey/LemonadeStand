using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        public string BuyChoice;

        public string BuyMenu()
        {
            Console.WriteLine("Welcome to the store, what would you like to buy?");
            Console.WriteLine("'1' Buy Lemons");
            Console.WriteLine("'2' Buy Cups");
            Console.WriteLine("'3' Buy Ice"); 
            Console.WriteLine("'4' Buy Sugar");
            Console.ReadLine();
            return BuyChoice = Console.ReadLine();
            
        }

        public void BuyLemons()
        {
            if (BuyChoice == "1")
            {
                BuyLemons();
            }
            else if (BuyChoice == "2")
            {
                BuyCups();
            }
            else if (BuyChoice == "3")
            {
                BuyIce();
            }
            else if (BuyChoice == "4")
            {
                BuySugar();
            }
            else Console.WriteLine("That was not an option, try again");
            BuyMenu();
        
                    
        }


        public int BuyLemons()
        {

        }
        
        //method that sums the total cost
        //item * cost 

    }
}


