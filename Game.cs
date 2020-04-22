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
        List<Day> days;
        public Game()
        {
            player1 = new Player();
            days = new List<Day>() { new Day(), new Day(), new Day(), new Day(), new Day(), new Day(), new Day() };
        }
        public void RunGame() //Master Method
        {
            foreach(Day day in days)
            {
                MainMenu(day);
            }
            
        }
        public void MainMenu(Day day)
        {
            Console.Clear();
            Store store = new Store();
            Console.WriteLine("Please select what you would like to do.\n1) Go to Store\n2) Set Recipe\n3) Check Inventory\n4) Check Recipe\n5) Start Day");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    //call store menu
                    store.StoreMenu(player1);
                    break;
                case "2":
                    //set recipe
                    player1.recipe.SetRecipe();
                    break;
                case "3":
                    //check inventory
                    player1.inventory.CheckInventory(player1);
                    break;
                case "4":
                    //check recipe
                    player1.recipe.CheckRecipe();
                    break;
                case "5":
                    //start day
                    //day.StartDay();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    MainMenu(day);
                    break;
            }
        }

    }
}
