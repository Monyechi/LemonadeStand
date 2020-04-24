using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Pitcher : Item
    {
        // Member Variables (HAS A) 
        public int sugarPerPitcher;
        public int lemonsPerPitcher;
        public int cupsPerPitcher = 5;
        // Constructor (SPAWNER)
        public Pitcher()
        {
            name = "pitcher";
        }

        // Member methods 
    }
}
