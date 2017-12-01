using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        
        public string BuyChoice;
        public int UserLemonQuantity;
        public int UserCupQuantity;
        public int UserIceQuantity;
        public int UserSugarQuantity;        
        public double ItemCost;

        public Store()
        {
            UserLemonQuantity = 0;
            UserCupQuantity = 0;
            UserIceQuantity = 0;
            UserIceQuantity = 0;
            UserSugarQuantity = 0;
        }

        public string BuyMenu()
        {
            Console.WriteLine("Welcome to the store, what would you like to buy?");            
            Console.WriteLine("'1' Buy Lemons");
            Console.WriteLine("'2' Buy Cups");
            Console.WriteLine("'3' Buy Ice"); 
            Console.WriteLine("'4' Buy Sugar");
            Console.ReadLine();
            return BuyChoice = Console.ReadLine();
            
        }

        public void BuyOptionsResult()
        {
            if (BuyChoice == "1")
            {
                GetLemonQuantity();
            }
            else if (BuyChoice == "2")
            {
                GetCupQuantity();
            }
            else if (BuyChoice == "3")
            {
                GetIceQuantity();
            }
            else if (BuyChoice == "4")
            {
                GetSugarQuantity();
            }
            else Console.WriteLine("That was not an option, try again");
            BuyMenu();
        }


        public int GetLemonQuantity()
        {
            Console.WriteLine("How many lemons would you like to buy? 1-100");
            string UserInput = Console.ReadLine();
            int UserLemonQuantity = Int32.Parse(UserInput);
            return UserLemonQuantity;            
        }

        public double GetLemonPurchasePrice()
        {
            Lemon lemon = new Lemon();
            ItemCost = lemon.GetLemonCost() * UserLemonQuantity;
            return ItemCost;
        }

        public void PayForLemons(Player player)
        {
            Wallet PlayerWallet = player.GetPlayerWallet();
            PlayerWallet.CheckWallet(ItemCost);
            PlayerWallet.BuyItem();
        }




        public int GetCupQuantity()
        {
            Console.WriteLine("How many cups would you like to buy? 1-100");
            string UserInput = Console.ReadLine();
            int UserCupQuantity = Int32.Parse(UserInput);
            return UserCupQuantity;
        }

        public double GetCupPurchasePrice()
        {
            Cups cup = new Cups();
            ItemCost = cup.GetCupCost() * UserCupQuantity;
            return ItemCost;
        }

        public void PayForCups(Player player)
        {
            Wallet PlayerWallet = player.GetPlayerWallet();
            PlayerWallet.CheckWallet(ItemCost);
            PlayerWallet.BuyItem();
        }




        public int GetIceQuantity()
        {
            Console.WriteLine("How much ice would you like to buy? 1-100");
            string UserInput = Console.ReadLine();
            int UserIceQuantity = Int32.Parse(UserInput);
            return UserIceQuantity;
        }

        public double GetIcePurchasePrice()
        {
            Ice ice = new Ice();
            ItemCost = ice.GetIceCost() * UserIceQuantity;
            return ItemCost;
        }

        public void PayForIce(Player player)
        {
            Wallet PlayerWallet = player.GetPlayerWallet();
            PlayerWallet.CheckWallet(ItemCost);
            PlayerWallet.BuyItem();
        }



        public int GetSugarQuantity()
        {
            Console.WriteLine("How much sugar would you like to buy? 1-100");
            string UserInput = Console.ReadLine();
            int UserSugarQuantity = Int32.Parse(UserInput);
            return UserSugarQuantity;
        }

        public double GetSugarPurchasePrice()
        {
            Sugar sugar = new Sugar();
            ItemCost = sugar.GetSugarCost() * UserSugarQuantity;
            return ItemCost;
        }

        public void PayForSugar(Player player)
        {
            Wallet PlayerWallet = player.GetPlayerWallet();
            PlayerWallet.CheckWallet(ItemCost);
            PlayerWallet.BuyItem();
        }

        public void AddLemonsToInventory(Player player)
        {
            Inventory PlayerInventory = player.GetPlayerInventory();
            PlayerInventory.InventoryLemons += UserLemonQuantity;
        }

        public void AddIceToInventory(Player player)
        {
            Inventory PlayerInventory = player.GetPlayerInventory();
            PlayerInventory.InventoryIce += UserLemonQuantity;
        }

        public void AddSugarToInventory(Player player)
        {
            Inventory PlayerInventory = player.GetPlayerInventory();
            PlayerInventory.InventorySugar += UserLemonQuantity;
        }

        public void AddCupsToInventory(Player player)
        {
            Inventory PlayerInventory = player.GetPlayerInventory();
            PlayerInventory.InventoryCups += UserLemonQuantity;
        }
    }
}


