using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Recipe
    {
        public int lemonsPerPitcher;
        public int icePerCup;
        public int sugerPerPitcher;
        public double pricePerCup;
       
        public void SetRecipe()
        {
            Console.WriteLine("Please enter price per Cup:");
            Console.ReadLine();
            pricePerCup = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Please enter amount of Lemons per Pitcher");
            Console.ReadLine();
            lemonsPerPitcher = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Please enter amount of Suger per Pitcher");
            Console.ReadLine();
            sugerPerPitcher = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Please enter amount of Ice per Cup");
            icePerCup = int.Parse(Console.ReadLine());

        }

    }
}
