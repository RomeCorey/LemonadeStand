﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {   public int CurrentDay = 0;
        List<Customer> customers = new List<Customer>();
        Random rnd = new Random();
        Weather weather = new Weather();
        Recipe recipe = new Recipe();
        Player player;
        
        public int GetDay()
        {
            return CurrentDay;
        }

        public void FillCustomers()
        {
            for (int i = 1; i <= 50; i++)
            {
                Customer customer = new Customer();
                customer.percentChanceToBuy = rnd.Next(40, 61);
                customers.Add(customer); 
            }     
        }

        public void WeatherAffect()
        {

            string weatherInfo = weather.GetWeather();

            if (weatherInfo == "Rain")
            {

                foreach (Customer customers in customers)
                {
                    customers.percentChanceToBuy -= 10;
                }
            }
            else if (weatherInfo == "Overcast")
            {

                foreach (Customer customers in customers)
                {
                    customers.percentChanceToBuy -= 6;
                }
            }
            else if (weatherInfo == "Cloudy")
            {
                foreach (Customer customers in customers)
                {
                    customers.percentChanceToBuy -= 1;
                }
            }
            if (weatherInfo == "Sunny")
            {

                foreach (Customer customers in customers)
                {
                    customers.percentChanceToBuy += 10;
                }
            }            
        }

        public void WeatherPriceAffect()
        {

            string weatherInfo = weather.GetWeather();

            if (weatherInfo == "Rain")
            {
                foreach (Customer customers in customers)
                {
                    customers.percentChanceToBuy -= 10;
                }
                
            }
            else if (weatherInfo == "Overcast")
            {

                foreach (Customer customers in customers)
                {
                    customers.percentChanceToBuy -= 6;
                }
            }
            else if (weatherInfo == "Cloudy")
            {

                foreach (Customer customers in customers)
                {
                    customers.percentChanceToBuy -= 1;
                }
            }
            if (weatherInfo == "Sunny")
            {

                foreach (Customer customers in customers)
                {
                    customers.percentChanceToBuy += 10;
                }
            }
        }

        public void PriceEffect()
        {
            if (recipe.PricePerPitcher <= .30)
            {
                foreach (Customer customers in customers)
                {
                    customers.percentChanceToBuy -= 5;
                }
            }
            else if (recipe.PricePerPitcher <= .40)
            {
                foreach (Customer customers in customers)
                {
                    customers.percentChanceToBuy += 5;
                }
            }
            else if (recipe.PricePerPitcher <= .50)
            {
                foreach (Customer customers in customers)
                {
                    customers.percentChanceToBuy -= 5;
                }
            }
        }

        public void CustomerBuy()
        {
            foreach (Customer customers in customers)
            {
                if (customers.percentChanceToBuy >= 48)
                {
                    player.CurrentMoney.Money = recipe.PricePerPitcher + player.CurrentMoney.Money;
                }
            }
        }

    }

    }

