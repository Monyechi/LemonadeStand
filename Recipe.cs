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
            Console.Clear();
            Console.WriteLine("Please enter price per Cup:");           
            pricePerCup = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Please enter amount of Lemons per Pitcher");
            lemonsPerPitcher = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Please enter amount of Suger per Pitcher");
            sugerPerPitcher = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Please enter amount of Ice per Cup");
            icePerCup = int.Parse(Console.ReadLine());

        }
        public void CheckRecipe()
        {
            Console.Clear();
            Console.WriteLine("Price Per Cup: " + pricePerCup);
            Console.WriteLine("");
            Console.WriteLine("Lemons Per Pitcher: " + lemonsPerPitcher);
            Console.WriteLine("");
            Console.WriteLine("Cups of Suger Per Pitcher " + sugerPerPitcher);
            Console.WriteLine("");
            Console.WriteLine("Ice Per Cup " + icePerCup);
            Console.WriteLine("");
            Console.WriteLine("Press Enter To Return To Menu.");
            Console.ReadLine();
           
        }

    }
}
