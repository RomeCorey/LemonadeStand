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
        public int UserLemonQuantity;
        public double LemonFinalPrice;
        public double IceBought;
        public double CupsBought;
        public double SugarBought;


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

        public void BuyOptionsResult()
        {
            if (BuyChoice == "1")
            {
                GetLemonQuantity();
            }
            else if (BuyChoice == "2")
            {
                GetCupQuantity();
            }
            else if (BuyChoice == "3")
            {
                GetIceQuantity();
            }
            else if (BuyChoice == "4")
            {
                GetSugarQuantity();
            }
            else Console.WriteLine("That was not an option, try again");
            BuyMenu();
        
                    
        }


        public int GetLemonQuantity()
        {
            Console.WriteLine("How many lemons would you like to buy?");
            string UserInput = Console.ReadLine();
            int UserLemonQuantity = Int32.Parse(UserInput);
            return UserLemonQuantity;            
        }

        public double GetLemonPurchasePrice()
        {
            Lemon lemon = new Lemon();
            LemonFinalPrice = lemon.GetLemonCost() * UserLemonQuantity;
            return LemonFinalPrice;
        }

        public double PayForLemons()
        {

        }
        
        //method that sums the total cost
        //item * cost 

    }
}


