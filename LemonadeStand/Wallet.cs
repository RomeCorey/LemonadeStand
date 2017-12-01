using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Wallet
    {

        public double Money;
        public bool Bankrupt;

       

        public Wallet()
        {
            Money = 20;
            Bankrupt = false;
        }

        public double GetCurrentMoney()
        {
            return Money;
        }
        public bool CheckWallet(double ItemCost)
        {
            if (ItemCost > Money)
                Console.WriteLine("You do not have enough money!");
            return Bankrupt;
        }
        public double BuyItem()
        {
            Store store = new Store();
            if (!Bankrupt)
            {
                Money = store.ItemCost - Money;  
            }
            return Money;

        }
    }
}
