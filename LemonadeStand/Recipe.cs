using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {        
        public int LemonsPerPitcher;
        public int IcePerPitcher;
        public int SugarPerPitcher;
        public int CupsPerPitcher;
        public int PitcherQuantity;
        public double PricePerPitcher;
        public string RecipeOption;
        public int FinalCups;

        public Recipe()
        {
            PricePerPitcher = 0;
            FinalCups = 0;
        }

        public string SetRecipeOptions(Player player)
        {
            Console.WriteLine("Select which part of the recipe you would like to change. \n Remember each pitcher makes 10 cups of lemonade.");
            Console.WriteLine("'1' Lemons per pitcher.");
            Console.WriteLine("'2' Ice per pitcher.");
            Console.WriteLine("'3' Sugar per pitcher.");
            Console.WriteLine("'4' Price per pitcher.");
            Console.WriteLine("'5' How many pitchers would you like to make for the week?");

            return RecipeOption = Console.ReadLine();
        }

        public void RecipePath(Player player, Weather weather, Store store, Recipe recipe)
        {
            if (RecipeOption == "1")
            {
                GetLemonsPerPitcher(player);
                //GetDaysWorthOfLemons();
                //SubtractLemonsFromInventory(player);
            }
            else if (RecipeOption == "2")
            {
                GetIcePerPitcher(player);
                //GetDaysWorthOfIce();
                //SubtractIceFromInventory(player);
            }
            else if (RecipeOption == "3")
            {
                GetSugarPerPitcher(player);
                //GetDaysWorthOfSugar();
                //SubtractSugarFromInventory(player);
            }
            else if (RecipeOption == "4")
            {
                GetPricePerPitcher();
                
            }
            else if (RecipeOption == "5")
            {
                GetPitcherQuantity(player);
            }
            else
            {
                Console.WriteLine("That was not an option, please try again");
                SetRecipeOptions(player);
            }
        }
        public int GetLemonsPerPitcher(Player player)
        {            
            Console.WriteLine("How many lemons do you want in each pitcher?");
            string UserInput = Console.ReadLine();
            int LemonsPerPitcher = Int32.Parse(UserInput);
            Console.WriteLine("You now have "+LemonsPerPitcher+" of lemons in each pitcher of lemonade");
            return player.CurrentInventory.RecipeLemons = LemonsPerPitcher;            
        }

        public int GetIcePerPitcher(Player player)
        {
            Console.WriteLine("How much ice do you want in each pitcher?");
            string UserInput = Console.ReadLine();
            int IcePerPitcher = Int32.Parse(UserInput);
            Console.WriteLine("You now have " + IcePerPitcher + " cubes of ice in each pitcher of lemonade");
            return player.CurrentInventory.RecipeIce = IcePerPitcher;
        }

        public int GetSugarPerPitcher(Player player)
        {
            Console.WriteLine("How much Sugar do you want in each pitcher?");
            string UserInput = Console.ReadLine();
            int SugarPerPitcher = Int32.Parse(UserInput);
            Console.WriteLine("You now have " + SugarPerPitcher + " cubes of Sugar in each pitcher of lemonade");
            return player.CurrentInventory.RecipeSugar = SugarPerPitcher;
        }

        public int GetPitcherQuantity(Player player)
        {
            Console.WriteLine("How many pitchers of lemonade would you like to make? Each pitcher makes 25 cups of lemonade!");
            string UserInput = Console.ReadLine();
            int PitcherQuantity = Int32.Parse(UserInput);
            int TotalLemons = player.CurrentInventory.RecipeLemons * PitcherQuantity;
            int TotalCups = player.CurrentInventory.RecipeCups * PitcherQuantity;
            int TotalSugar = player.CurrentInventory.RecipeSugar * PitcherQuantity;
            int TotalIce = player.CurrentInventory.RecipeIce * PitcherQuantity;
            if (TotalLemons > player.CurrentInventory.InventoryLemons || TotalIce > player.CurrentInventory.InventoryIce || TotalCups > player.CurrentInventory.InventoryCups || TotalSugar > player.CurrentInventory.InventorySugar)
            {
                Console.WriteLine("Your inventory does not hold enought to make that recipe, please choose another recipe, or buy more inventory!");
                return FinalCups;
            }
            else
            {
                player.CurrentInventory.InventoryLemons = player.CurrentInventory.InventoryLemons - TotalLemons;
                Console.WriteLine("You have " + player.CurrentInventory.InventoryLemons + " lemons left");
                player.CurrentInventory.InventorySugar = player.CurrentInventory.InventorySugar - TotalSugar;
                Console.WriteLine("You have " + player.CurrentInventory.InventorySugar + " sugar cubes left");
                player.CurrentInventory.InventoryIce = player.CurrentInventory.InventoryIce - TotalIce;
                Console.WriteLine("You have " + player.CurrentInventory.InventoryIce + " ice cubes left");
                int FinalCups = PitcherQuantity * 25;
                player.CurrentInventory.InventoryCups = player.CurrentInventory.InventoryCups - TotalCups;
                player.CurrentInventory.InventoryCups = player.CurrentInventory.InventoryCups - FinalCups;
                Console.WriteLine("You made " + FinalCups + " cups of lemonade total!");
                return FinalCups;
            }
            
        }

        

        public void GetPricePerPitcher()
        {
            Console.WriteLine("How much would you like to sell each cup for? I suggest setting the price between $0.20 and $0.50");
            string UserInput = Console.ReadLine();
            PricePerPitcher = Convert.ToDouble(UserInput);
            
        }

        //public int GetDaysWorthOfLemons()
        //{
        //    return LemonsPerPitcher = LemonsPerPitcher * PitcherQuantity;           
        //}

        //public int GetDaysWorthOfIce()
        //{
        //    return IcePerPitcher = IcePerPitcher * PitcherQuantity;
        //}

        //public int GetDaysWorthOfSugar()
        //{
        //    return SugarPerPitcher = SugarPerPitcher * PitcherQuantity;
        //}

        //public int GetDaysWorthOfCups()
        //{
        //    return CupsPerPitcher = 10 * PitcherQuantity;
        //}
        
        //public int SubtractLemonsFromInventory(Player player)
        //{
        //    Inventory PlayerInventory = player.GetPlayerInventory();
        //    return PlayerInventory.InventoryLemons -= LemonsPerPitcher;
        //}

        //public int SubtractIceFromInventory(Player player)
        //{
        //    Inventory PlayerInventory = player.GetPlayerInventory();
        //    return PlayerInventory.InventoryIce -= IcePerPitcher;
        //}

        //public int SubtractSugarFromInventory(Player player)
        //{
        //    Inventory PlayerInventory = player.GetPlayerInventory();
        //    return PlayerInventory.InventorySugar -= LemonsPerPitcher;
        //}

        //public int SubtractCupsFromInventory(Player player)
        //{
        //    Inventory PlayerInventory = player.GetPlayerInventory();
        //    return PlayerInventory.InventoryCups -= CupsPerPitcher;                
        //}        
        
        }
}
