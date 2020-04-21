using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Store
    {
        // member variables (HAS A)
        private double pricePerLemon;
        private double pricePerCupOfSugar;
        private double pricePerIceCube;
        private double pricePerCup;

        // constructor (SPAWNER)
        public Store()
        {
            pricePerLemon = .5;
            pricePerCupOfSugar = .1;
            pricePerIceCube = .01;
            pricePerCup = .25;
        }
        public void StoreMenu(Player player1)
        {
            
            Console.WriteLine("Welcome to the Store!");
            Console.WriteLine("What would you like to purchase?\n1)Lemons\n2)Sugar\n3)Cups\n4)Ice");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    //Purchase Lemons
                    SellLemons(player1);
                    break;
                case "2":
                    //Purchase Sugar 
                    SellCupsOfSugar(player1);
                    break;
                case "3":
                    //Purchase Cups
                    SellCups(player1);
                    break;
                case "4":
                    //Purchase Ice
                    SellIceCubes(player1);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    StoreMenu(player1);
                    break;
            }
        }
        // member methods (CAN DO)
        public void SellLemons(Player player) 
        {
            int lemonsToPurchase = UserInterface.GetNumberOfItems("lemons");
            double transactionAmount = CalculateTransactionAmount(lemonsToPurchase, pricePerLemon);
            if(player.wallet.Money >= transactionAmount)
            {
                player.wallet.PayMoneyForItems(transactionAmount);
                player.inventory.AddLemonsToInventory(lemonsToPurchase);
            }
        }

        public void SellCupsOfSugar(Player player)
        {
            int sugarToPurchase = UserInterface.GetNumberOfItems("cups of sugar");
            double transactionAmount = CalculateTransactionAmount(sugarToPurchase, pricePerCupOfSugar);
            if(player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddCupsOfSugarToInventory(sugarToPurchase);
            }
        }

        public void SellIceCubes(Player player)
        {
            int iceCubesToPurchase = UserInterface.GetNumberOfItems("ice cubes");
            double transactionAmount = CalculateTransactionAmount(iceCubesToPurchase, pricePerIceCube);
            if(player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddIceCubesToInventory(iceCubesToPurchase);
            }
        }

        public void SellCups(Player player)
        {
            int cupsToPurchase = UserInterface.GetNumberOfItems("cups");
            double transactionAmount = CalculateTransactionAmount(cupsToPurchase, pricePerCup);
            if(player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddCupsToInventory(cupsToPurchase);
            }
        }

        private double CalculateTransactionAmount(int itemCount, double itemPricePerUnit)
        {
            double transactionAmount = itemCount * itemPricePerUnit;
            return transactionAmount;
        }

        private void PerformTransaction(Wallet wallet, double transactionAmount)
        {
            wallet.PayMoneyForItems(transactionAmount);
        }
    }
}
