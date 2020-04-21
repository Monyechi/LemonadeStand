using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Inventory
    {
        // member variables (HAS A)
        public List<Lemon> lemons;
        public List<CupOfSugar> cupsOfSugar;
        public List<IceCube> iceCubes;
        public List<Cup> cups;

        // constructor (SPAWNER)
        public Inventory()
        {
            lemons = new List<Lemon>();
            cupsOfSugar = new List<CupOfSugar>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
        }

        // member methods (CAN DO)
        public void AddLemonsToInventory(int numberOfLemons)
        {
            for(int i = 0; i < numberOfLemons; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
        }

        public void AddCupsOfSugarToInventory(int numberOfCupsOfSugar)
        {
            for(int i = 0; i < numberOfCupsOfSugar; i++)
            {
                CupOfSugar CupOfSugar = new CupOfSugar();
                cupsOfSugar.Add(CupOfSugar);
            }
        }

        public void CheckInventory(Player player)
        {

            player.wallet.CheckMoney();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("You have:");
            Console.WriteLine(player.inventory.lemons.Count + " Lemons");
            Console.WriteLine("");            
            Console.WriteLine(player.inventory.cupsOfSugar.Count + " Cups of Sugar");
            Console.WriteLine("");
            Console.WriteLine(player.inventory.iceCubes.Count + " Ice Cubes");
            Console.WriteLine("");
            Console.WriteLine(player.inventory.cups.Count + " Cups");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();

            

        }

        public void AddIceCubesToInventory(int numberOfIceCubes)
        {
            for(int i = 0; i < numberOfIceCubes; i++)
            {
                IceCube iceCube = new IceCube();
                iceCubes.Add(iceCube);
            }
        }

        public void AddCupsToInventory(int numberOfCups)
        {
            for(int i = 0; i < numberOfCups; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
        }
    }
}
