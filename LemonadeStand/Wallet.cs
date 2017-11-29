using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {
        public double Money = 20.00;
        public bool Bankrupt;


        public double GetCurrentMoney()
        {
            return Money;
        }
        public bool CheckWallet(ItemCost)
        {
            if (ItemCost > Money)
                Console.WriteLine("You do not have enough money!");
            return Bankrupt;
        }
        public double BuyItem()
        {
            if (!Bankrupt)
            {
                Money = ItemCost - Money;                
                return Money;
            }
        }
    }
}
