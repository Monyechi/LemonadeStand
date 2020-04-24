using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        // member variables (HAS A)
        public bool boughtLemonade;
        
        // constructor (SPAWNER)
        public Customer()
        {
             
        }
        // member methods (CAN DO)
        public void BuysLemonade(Weather weather, Recipe recipe, Player player)
        {
            Random random = new Random();
            
            
           while (weather.condition == "Rainy")
           {
                
                if (recipe.pricePerCup <= 1.50 && recipe.sugerPerPitcher >= 5 && recipe.lemonsPerPitcher >= 2)
                {
                    SeventyPercentChanceToBuy(random, player);
                }
                else if (recipe.pricePerCup >= 3.50 || recipe.sugerPerPitcher <= 2 || recipe.lemonsPerPitcher <= 2)
                {
                    TwentyPercentChanceToBuy(random, player);
                }
                else
                {
                    SixtyPercentChanceToBuy(random, player);
                }
           }
           while (weather.condition == "Sunny")
           {
                if (recipe.pricePerCup <= 3.00 && recipe.sugerPerPitcher >= 3 || recipe.lemonsPerPitcher <= 2)
                {
                    NinetyPercentChanceToBuy(random, player);
                }
                else if (recipe.pricePerCup >= 5.00 || recipe.sugerPerPitcher <= 2 || recipe.lemonsPerPitcher <= 2)
                {
                    FiftyPercentChanceToBuy(random, player);
                }
                else
                {
                    SeventyPercentChanceToBuy(random, player);
                }
            } 
           while (weather.condition == "Cloudy")
           {
                if (recipe.pricePerCup <= 3.00 && recipe.sugerPerPitcher >= 3 || recipe.lemonsPerPitcher <= 2)
                {
                    SeventyPercentChanceToBuy(random, player);
                }
                else if (recipe.pricePerCup >= 5.00 || recipe.sugerPerPitcher <= 2 || recipe.lemonsPerPitcher <= 2)
                {
                    TwentyPercentChanceToBuy(random, player);
                }
                else
                {
                    FourtyPercentChanceToBuy(random, player);
                }
            }
         

        }
        public void TwentyPercentChanceToBuy(Random random, Player player)
        {

            if (random.Next(10) < 2)
            {// 20% chance to be true, 80% chance to be false
                int amountOfCups = player.inventory.cups.Count;
                double pricePerCup = player.recipe.pricePerCup;
                double CashRegister = player.wallet.Money;

                CashRegister = CashRegister + pricePerCup;
                amountOfCups--;
            }
            else
            {

            }

        }
        public void FourtyPercentChanceToBuy(Random random, Player player)
        {

            if (random.Next(10) < 4)
            {// 40% chance to be true, 60% chance to be false
                int amountOfCups = player.inventory.cups.Count;
                double pricePerCup = player.recipe.pricePerCup;
                double CashRegister = player.wallet.Money;

                CashRegister = CashRegister + pricePerCup;
                amountOfCups--;
            }
            else
            {

            }

        }
        public void FiftyPercentChanceToBuy(Random random, Player player)
        {

            if (random.Next(10) < 5)
            {// 50% chance to be true, 50% chance to be false
                int amountOfCups = player.inventory.cups.Count;
                double pricePerCup = player.recipe.pricePerCup;
                double CashRegister = player.wallet.Money;

                CashRegister = CashRegister + pricePerCup;
                amountOfCups--;
            }
            else
            {

            }

        }
        public void SixtyPercentChanceToBuy(Random random, Player player)
        {

            if (random.Next(10) < 6)
            {// 60% chance to be true, 40% chance to be false
                int amountOfCups = player.inventory.cups.Count;
                double pricePerCup = player.recipe.pricePerCup;
                double CashRegister = player.wallet.Money;

                CashRegister = CashRegister + pricePerCup;
                amountOfCups--;
            }
            else
            {

            }

        }
        public void SeventyPercentChanceToBuy(Random random, Player player)
        {

            if (random.Next(10) < 7)
            {// 70% chance to be true, 30% chance to be false
                int amountOfCups = player.inventory.cups.Count;
                double pricePerCup = player.recipe.pricePerCup;
                double CashRegister = player.wallet.Money;

                CashRegister = CashRegister + pricePerCup;
                amountOfCups--;
            }
            else
            {

            }

        }
        public void NinetyPercentChanceToBuy(Random random, Player player)
        {           
                      
            if (random.Next(10) < 9)
            {// 90% chance to be true, 20% chance to be false
                int amountOfCups = player.inventory.cups.Count;
                double pricePerCup = player.recipe.pricePerCup;
                double CashRegister = player.wallet.Money;

                CashRegister = CashRegister + pricePerCup;
                amountOfCups--;
            }
            else
            {

            }
           
        }
        public void PurchaceMade(Player player)
        {
           
        }
    }
}
