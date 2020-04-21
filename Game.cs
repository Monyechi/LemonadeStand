using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        //Member variables (HAS A) 
        public Player player1;
        
        public Game()
        {
            player1 = new Player();
        }
        public void RunGame() //Master Method
        {
            Menu();
        }

        public void Menu()
        {
            Store store = new Store();
            Console.WriteLine("Please select what you would like to do.\n1) Go to Store\n2) Set Recipe\n3)Check Inventory\n4)Start Day");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    //call store menu
                    StoreMenu();
                    break;
                case "2":
                    //set recipe
                    break;
                case "3":
                    //check inventory
                    CheckInventory();
                    break;
                case "4":
                    //start day
                default:
                    Console.WriteLine("Invalid Input");
                    Menu();
                    break;
            }
        }
        public void CheckInventory()
        {
            Console.WriteLine(player1.inventory);
            Console.ReadLine();

        }
        public void PurchaseItem()
        {
            
        }
        public void StoreMenu()
        {
            Store store = new Store();

            Console.WriteLine("Welcome to the Store!");
            Console.WriteLine("What would you like to purchase?\n1) Purchase More Lemons\n2) Purchase More Sugar Cubes\n3)Purchase More Cups\n4)Purchase More Ice");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    //Purchase Lemons
                    store.SellLemons(player1);
                    break;
                case "2":
                    //Purchase Sugar 
                    store.SellSugarCubes(player1);
                    break;
                case "3":
                    //Purchase Cups
                    store.SellCups(player1);
                    break;
                case "4":
                    //Purchase Ice
                    store.SellIceCubes(player1);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Menu();
                    break;
            }
        }

    }
}
