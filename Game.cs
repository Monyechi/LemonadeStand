﻿using System;
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
                    store.StoreMenu();
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

    }
}