using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class UserInterface
    {
        Player player;
        Day day;
        Weather weather;
        Store store;
        Random random = new Random();
        Recipe recipe;
        public UserInterface()
        {
            weather = new Weather();
            store = new Store();
            player = new Player();
            day = new Day(player);

        }
        public void StartGame()
        {
            Welcome();
            Rules();
            Menu();
        }
        private void Welcome()
        {
            Console.WriteLine("Welcome to your very own Lemonade Stand!");            
        }

        private void Rules()
        {
            Console.WriteLine("The goal is to make as much money you can over a 7 day period at a lemonade stand. You start with $20.00");
            Console.WriteLine("Customers will walk buy. Their chance of buying is affected by the price per cup that you set and the weather.");
            Console.WriteLine("Each day you can buy the supplies you will need to make more lemonade.");
            Console.WriteLine("Then choose how much lemonade you want to make for the day.");
        }
        
        private void Menu()
        {
            Console.WriteLine("This is the Main Menu. Use the numbers to navagate from below:");
            Console.WriteLine("'1' - Check the Weather Forecast for the week");
            Console.WriteLine("'2' - Buy Supplies from the store");
            Console.WriteLine("'3' - Change your price and recipe for your lemonade");
            Console.WriteLine("'4' - Play Week");
            Console.WriteLine("You have $"+ Math.Round(player.CurrentMoney.Money, 2));
            string MenuChoice = Console.ReadLine();

            if (MenuChoice == "1")
            {
                string weatherInfo = weather.GetWeather();
                Console.WriteLine("Monday - " + weatherInfo);
                string weatherInfoDayTwo = weather.GetWeather();
                Console.WriteLine("Tuesday - " + weatherInfoDayTwo);
                string weatherInfoDayThree = weather.GetWeather();
                Console.WriteLine("Wednesday - " + weatherInfoDayThree);
                string weatherInfoDayFour = weather.GetWeather();
                Console.WriteLine("Thursday - " + weatherInfoDayFour);
                string weatherInfoDayFive = weather.GetWeather();
                Console.WriteLine("Friday - " + weatherInfoDayFive);
                string weatherInfoDaySix = weather.GetWeather();
                Console.WriteLine("Saturday - " + weatherInfoDaySix);
                string weatherInfoDaySeven = weather.GetWeather();
                Console.WriteLine("Sunday - " + weatherInfoDaySeven);
                Menu();
            }
            else if (MenuChoice == "2")
            {
                store.BuyMenu();
                store.BuyOptionsResult(player);
                Menu();

            }
            else if (MenuChoice == "3")
            {
                player.recipe.SetRecipeOptions(player);
                player.recipe.RecipePath(player, weather, store, day.recipe);
                Menu();
            }
            else if (MenuChoice == "4")
            {
                do
                {
                    for (int i = 0; i < 7; i++)
                    {
                        day.FillCustomers();
                        day.WeatherAffect();
                        day.PriceEffect();
                        day.CustomerBuy();
                        day.RunningProfit();
                    }
                    Menu();

                }
                while (recipe.FinalCups > 0);
            }



            else
            {
                Console.WriteLine("Please enter a valid option");
                Menu();
            }

            
        }
        
    }
}
