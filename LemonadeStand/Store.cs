using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {         

        public int LemonPurchase()
        {
            Inventory PlayerInventory = new Inventory();
            Console.WriteLine("How many lemons would you like to purchase? \n'1' 10 for $.66 \n '2' 30 for $2.26 \n '3' 75 for $4.05");
            string LemonInput = Console.ReadLine();
            
            if (LemonInput == "1")
            {
                PlayerInventory.InventoryLemons += 10;
                PlayerInventory.Money -= .66;
            } 
            else if (LemonInput == "2")
            {   
                PlayerInventory.InventoryLemons += 30;
                PlayerInventory.Money -= 2.26;
            }
            else if (LemonInput == "3")
            {
                PlayerInventory.InventoryLemons += 75;
                PlayerInventory.Money -= 4.05;
            }

        }
        public int SugarPurchase()
        {
            Inventory PlayerInventory = new Inventory();
            Console.WriteLine("How much Sugar would you like to purchase? \n'1' 8 for $.56 \n '2' 20 for $1.59 \n '3' 48 for $3.50");
            string SugarInput = Console.ReadLine();

            if (SugarInput == "1")
            {
                PlayerInventory.InventorySugar += 8;
                PlayerInventory.Money -= .56;
            }
            else if (SugarInput == "2")
            {
                PlayerInventory.InventorySugar += 20;
                PlayerInventory.Money -= 1.59;
            }
            else if (SugarInput == "3")
            {
                PlayerInventory.InventorySugar += 48;
                PlayerInventory.Money -= 3.50;
            }

        }


    }
}
