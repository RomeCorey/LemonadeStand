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
        public int PricePerPitcher;
        public int RecipeOption;

        public int SetRecipeOptions()
        {
            Console.WriteLine("Select which part of the recipe you would like to change. \n Remember each pitcher makes 10 cups of lemonade.");
            Console.WriteLine("'1' Lemons per pitcher.");
            Console.WriteLine("'2' Ice per pitcher.");
            Console.WriteLine("'3' Sugar per pitcher.");
            Console.WriteLine("'4' Price per pitcher.");
            Console.WriteLine("'5' How many pitchers would you like to make for the day?");
            string UserInput = Console.ReadLine();
            int RecipeOption = Int32.Parse(UserInput);
            return RecipeOption;
        }

        public void RecipePath(Player player,UserInterface userinterface, Weather weather, Store store, Recipe recipe)
        {
            if (RecipeOption == 1)
            {
                GetLemonsPerPitcher();
                GetDaysWorthOfLemons();
                SubtractLemonsFromInventory(player);
            }
            else if (RecipeOption == 2)
            {
                GetIcePerPitcher();
                GetDaysWorthOfIce();
                SubtractIceFromInventory(player);
            }
            else if (RecipeOption == 3)
            {
                GetSugarPerPitcher();
                GetDaysWorthOfSugar();
                SubtractSugarFromInventory(player);
            }
            else if (RecipeOption == 4)
            {
                GetPricePerPitcher();
            }
            else
            {
                Console.WriteLine("That was not an option, please try again");
                userinterface.Menu(weather, store, recipe, player);
            }
        }
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

        public int GetPricePerPitcher()
        {
            Console.WriteLine("How much would you like to sell each cup for? I would suggest between $0.20 and $0.50");
            string UserInput = Console.ReadLine();
            int PricePerPitcher = Int32.Parse(UserInput);
            return PricePerPitcher;
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
            Inventory PlayerInventory = player.GetPlayerInventory();
            return PlayerInventory.InventoryLemons -= LemonsPerPitcher;
        }

        public int SubtractIceFromInventory(Player player)
        {
            Inventory PlayerInventory = player.GetPlayerInventory();
            return PlayerInventory.InventoryIce -= IcePerPitcher;
        }

        public int SubtractSugarFromInventory(Player player)
        {
            Inventory PlayerInventory = player.GetPlayerInventory();
            return PlayerInventory.InventorySugar -= LemonsPerPitcher;
        }

        public int SubtractCupsFromInventory(Player player)
        {
            Inventory PlayerInventory = player.GetPlayerInventory();
            return PlayerInventory.InventoryCups -= CupsPerPitcher;
        }
    }
}
