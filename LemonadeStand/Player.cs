using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {       
        private Wallet wallet = new Wallet();
        private Inventory inventory = new Inventory();
        
        public Inventory GetPlayerInventory()
        {
            return inventory;
        }

        public Wallet GetPlayerWallet()
        {
            return wallet;
        }

    }
}
