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

        //public Store()
        //{
            //UserLemonQuantity = 0;
            //UserCupQuantity = 0;
            //UserIceQuantity = 0;
            //UserIceQuantity = 0;
            //UserSugarQuantity = 0;
        //}



        public string BuyMenu()
        {
            Console.WriteLine("Welcome to the store, what would you like to buy? You have $20.00");            
            Console.WriteLine("'1' Buy Lemons for $0.08 each");
            Console.WriteLine("'2' Buy Cups for $0.03 each");
            Console.WriteLine("'3' Buy Ice for $0.05 each"); 
            Console.WriteLine("'4' Buy Sugar for $.08 each");
            //Console.ReadLine();
            return BuyChoice = Console.ReadLine();
            
        }

        public void BuyOptionsResult(Player player)
        {
            
            if (BuyChoice == "1")
            {
                GetLemonQuantityAndCost(player);
                //GetLemonPurchasePrice();
                //PayForLemons(player, wallet);
                //AddLemonsToInventory(player);
                
            }
            else if (BuyChoice == "2")
            {
                GetCupQuantity(player);
                //GetCupPurchasePrice();
                //PayForCups(player, wallet);
                //AddCupsToInventory(player);
            }
            else if (BuyChoice == "3")
            {
                GetIceQuantity(player);
                //GetIcePurchasePrice();
                //PayForIce(player, wallet);
                //AddIceToInventory(player);
            }
            else if (BuyChoice == "4")
            {
                GetSugarQuantity(player);
                //GetSugarPurchasePrice();
                //PayForSugar(player, wallet);
                //AddSugarToInventory(player);
            }
            else Console.WriteLine("That was not an option, try again");
            //BuyMenu();
        }
        

        public double GetLemonQuantityAndCost(Player player)
        {
            Lemon lemon = new Lemon();
            Console.WriteLine("How many lemons would you like to buy? 1-100");
            string UserInput = Console.ReadLine();
            int UserLemonQuantity = Int32.Parse(UserInput);
            ItemCost = lemon.GetLemonCost() * UserLemonQuantity;
            if (ItemCost > player.CurrentMoney.Money)
            {
                player.CurrentMoney.Money = player.CurrentMoney.Money - ItemCost;
                Console.WriteLine("You bought " + UserLemonQuantity + " lemons and now have $" + player.CurrentMoney.Money);
                player.CurrentInventory.InventoryLemons = UserLemonQuantity + player.CurrentInventory.InventoryLemons;
                Console.WriteLine("You now have " + player.CurrentInventory.InventoryLemons + " in your inventory");
                return player.CurrentMoney.Money;
            }
            else
            {
                return player.CurrentMoney.Money;

            }
        }

        //public double GetLemonPurchasePrice()
        //{
        //    Lemon lemon = new Lemon();
        //     ItemCost = lemon.GetLemonCost() * UserLemonQuantity;
        //    //Display cost
        //    return ItemCost;
        //}

        //public double PayForLemons(Player player, Wallet wallet)
        //{
            
        //    //Wallet PlayerWallet = player.GetPlayerWallet();
        //    wallet.CheckWallet(ItemCost);
        //    wallet.Money = wallet.Money - ItemCost;
        //    //PlayerWallet.BuyItem();
        //    return wallet.Money;
        //}




        public double GetCupQuantity(Player player)
        {
            Cups cups = new Cups();
            Console.WriteLine("How many cups would you like to buy? 1-100");
            string UserInput = Console.ReadLine();
            int UserCupQuantity = Int32.Parse(UserInput);
            ItemCost = cups.GetCupCost() * UserCupQuantity;
            if (ItemCost > player.CurrentMoney.Money)
            {
                player.CurrentMoney.Money = player.CurrentMoney.Money - ItemCost;
                Console.WriteLine("You bought " + UserCupQuantity + " cups and now have $" + player.CurrentMoney.Money);
                player.CurrentInventory.InventoryCups = UserCupQuantity + player.CurrentInventory.InventoryCups;
                Console.WriteLine("You now have " + player.CurrentInventory.InventoryCups + " in your inventory");
                return player.CurrentMoney.Money;
            }
            else
            {
                return player.CurrentMoney.Money;
            }
        }

        //public double GetCupPurchasePrice()
        //{
        //    Cups cup = new Cups();
        //    ItemCost = cup.GetCupCost() * UserCupQuantity;
        //    Console.WriteLine("That will cost " +ItemCost);
        //    return ItemCost;
        //}

        //public double PayForCups(Player player, Wallet wallet)
        //{
        //    //Wallet PlayerWallet = player.GetPlayerWallet();
        //    wallet.CheckWallet(ItemCost);
        //    wallet.Money = wallet.Money - ItemCost;
        //    //PlayerWallet.BuyItem();
        //    return wallet.Money;
        //}


        

        public double GetIceQuantity(Player player)
        {
            Ice ice = new Ice();
            Console.WriteLine("How much ice would you like to buy? 1-100");
            string UserInput = Console.ReadLine();
            int UserIceQuantity = Int32.Parse(UserInput);
            ItemCost = ice.GetIceCost() * UserIceQuantity;
            if (ItemCost > player.CurrentMoney.Money)
            {
                player.CurrentMoney.Money = player.CurrentMoney.Money - ItemCost;
                Console.WriteLine("You bought " + UserIceQuantity + " ice and now have $" + player.CurrentMoney.Money);
                player.CurrentInventory.InventoryIce = UserIceQuantity + player.CurrentInventory.InventoryIce;
                Console.WriteLine("You now have " + player.CurrentInventory.InventoryIce + " in your inventory");
                return player.CurrentMoney.Money;
            }
            else
            {
                return player.CurrentMoney.Money;
            }
        }

        //public double GetIcePurchasePrice()
        //{
        //    Ice ice = new Ice();
        //    ItemCost = ice.GetIceCost() * UserIceQuantity;
        //    return ItemCost;
        //}

       
        //public double PayForIce(Player player, Wallet wallet)
        //{
        //    //Wallet PlayerWallet = player.GetPlayerWallet();
        //    wallet.CheckWallet(ItemCost);
        //    wallet.Money = wallet.Money - ItemCost;
        //    //PlayerWallet.BuyItem();
        //    return wallet.Money;
        //}



        

        public double GetSugarQuantity(Player player)
        {
            Sugar sugar = new Sugar();
            Console.WriteLine("How much sugar would you like to buy? 1-100");
            string UserInput = Console.ReadLine();
            int UserSugarQuantity = Int32.Parse(UserInput);
            ItemCost = sugar.GetSugarCost() * UserSugarQuantity;
            if (ItemCost > player.CurrentMoney.Money)
            {
                player.CurrentMoney.Money = player.CurrentMoney.Money - ItemCost;
                Console.WriteLine("You bought " + UserSugarQuantity + " sugar and now have $" + player.CurrentMoney.Money);
                player.CurrentInventory.InventorySugar = UserSugarQuantity + player.CurrentInventory.InventorySugar;
                Console.WriteLine("You now have " + player.CurrentInventory.InventorySugar + " in your inventory");
                return player.CurrentMoney.Money;
            }
            else
            {
                return player.CurrentMoney.Money;
            }
        }

        //public double GetSugarPurchasePrice()
        //{
        //    Sugar sugar = new Sugar();
        //    ItemCost = sugar.GetSugarCost() * UserSugarQuantity;
        //    return ItemCost;
        //}

        //public void PayForSugar(Player player)
        //{

        //    player.CurrentMoney = player.CurrentMoney - ItemCost;
        //    PlayerWallet.BuyItem();
        //}

        //public void AddLemonsToInventory(Player player)
        //{

        //    Inventory PlayerInventory = player.GetPlayerInventory();
        //    PlayerInventory.InventoryLemons += UserLemonQuantity;
        //}

        //public void AddIceToInventory(Player player)
        //{

        //    Inventory PlayerInventory = player.GetPlayerInventory();
        //    PlayerInventory.InventoryIce += UserLemonQuantity;
        //}

        //public void AddSugarToInventory(Player player)
        //{

        //    Inventory PlayerInventory = player.GetPlayerInventory();
        //    PlayerInventory.InventorySugar += UserLemonQuantity;
        //}

        //public void AddCupsToInventory(Player player)
        //{

        //    Inventory PlayerInventory = player.GetPlayerInventory();
        //    PlayerInventory.InventoryCups += UserLemonQuantity;
        //}
    }
}


