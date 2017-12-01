using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {        
        public int LemonsPerPitcher;
        public int IcePerPitcher;
        public int SugarPerPitcher;
        public int CupsPerPitcher;
        public int PitcherQuantity;

        public int GetLemonsPerPitcher()
        {            
            Console.WriteLine("How many lemons do you want in each pitcher?");
            string UserInput = Console.ReadLine();
            int LemonsPerPitcher = Int32.Parse(UserInput);
            return LemonsPerPitcher;            
        }

        public int GetIcePerPitcher()
        {
            Console.WriteLine("How much ice do you want in each pitcher?");
            string UserInput = Console.ReadLine();
            int IcePerPitcher = Int32.Parse(UserInput);
            return IcePerPitcher;
        }

        public int GetSugarPerPitcher()
        {
            Console.WriteLine("How much Sugar do you want in each pitcher?");
            string UserInput = Console.ReadLine();
            int SugarPerPitcher = Int32.Parse(UserInput);
            return SugarPerPitcher;
        }

        public int GetPitcherQuantity()
        {
            Console.WriteLine("How many pitchers of lemonade would you like to make? Each pitcher makes 10 cups of lemonade!");
            string UserInput = Console.ReadLine();
            int PitcherQuantity = Int32.Parse(UserInput);
            return PitcherQuantity;
        }

        public int GetDaysWorthOfLemons()
        {
            return LemonsPerPitcher = LemonsPerPitcher * PitcherQuantity;           
        }

        public int GetDaysWorthOfIce()
        {
            return IcePerPitcher = IcePerPitcher * PitcherQuantity;
        }

        public int GetDaysWorthOfSugar()
        {
            return SugarPerPitcher = SugarPerPitcher * PitcherQuantity;
        }

        public int GetDaysWorthOfCups()
        {
            return CupsPerPitcher = 10 * PitcherQuantity;
        }
        
        public int SubtractLemonsFromInventory(Player player)
        {
            return player.inventory.InventoryLemons -= LemonsPerPitcher;
        }

        public int SubtractIceFromInventory(Player player)
        {
            return player.inventory.InventoryIce -= IcePerPitcher;
        }

        public int SubtractSugarFromInventory(Player player)
        {
            return player.inventory.InventorySugar -= LemonsPerPitcher;
        }

        public int SubtractCupsFromInventory(Player player)
        {
            return player.inventory.InventoryCups -= CupsPerPitcher;
        }
    }
}
