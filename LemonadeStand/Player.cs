using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public Wallet CurrentMoney;
        public Inventory CurrentInventory;

        public Player()
        {
            CurrentMoney = new Wallet();
            CurrentInventory = new Inventory();
        }
        
        

       

    }
}
