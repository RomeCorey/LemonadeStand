using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UserInterface
    {
        Player player = new Player();
        UserInterface userinterface = new UserInterface();
        Day day = new Day();
        Weather weather = new Weather();
        Store Store = new Store();
        Random random = new Random();
        Recipe recipe = new Recipe();
        Store store = new Store();

        public void StartGame()
        {
            Welcome();
            Rules();
            Menu(weather, store, recipe, player);
        }
        public void Welcome()
        {
            Console.WriteLine("Welcome to your very own Lemonade Stand!");            
        }

        public void Rules()
        {
            Console.WriteLine("The goal is to make as much money you can over a 7 day period at a lemonade stand.");
            Console.WriteLine("Customers will walk buy. Their chance of buying is affected by the price per cup that you set and the weather.");
            Console.WriteLine("Each day you can buy the supplies you will need to make more lemonade.");
            Console.WriteLine("Then choose how much lemonade you want to make for the day.");
        }
        
        public void Menu(Weather weather, Store store, Recipe recipe, Player player)
        {
            Console.WriteLine("This is the Main Menu. Use the numbers to navagate from below:");
            Console.WriteLine("'1' - Check the Weather");
            Console.WriteLine("'2' - Buy Supplies from the store");
            Console.WriteLine("'3' - Change your price and recipe for your lemonade");
            Console.WriteLine("'4' - Play");
            string MenuChoice = Console.ReadLine();

            if (MenuChoice == "1")
            {
                weather.GetWeather();
            }
            else if (MenuChoice == "2")
            {
                store.BuyMenu();
                store.BuyOptionsResult();
                // Complete store path
            }
            else if (MenuChoice == "3")
            {
                recipe.SetRecipeOptions();
                recipe.RecipePath(player, userinterface, weather, store, recipe);
            }




        }



    }
}
