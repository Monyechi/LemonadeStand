using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        // member variables (HAS A)
        public string condition;
        public int temperature;
        private List<string> weatherConditions;
        

        // constructor (SPAWNER)
        public Weather()
        {
            Random rnd = new Random();

            weatherConditions = new List<string>();
            weatherConditions.Add("Sunny");
            weatherConditions.Add("Rainy");
            weatherConditions.Add("Cloudy");
            CurrentCondition(rnd);
            CurrentTemperature();
        }

        // member methods (CAN DO)
       
        public void CurrentCondition(Random random)
        {
            int numberGenerated = random.Next(1, 3);            
            int i = numberGenerated;
            condition = weatherConditions[i];          
        }
        public void CurrentTemperature()
        {
            Random rnd = new Random();
            temperature = rnd.Next(60, 94);
                        
        }
        
    }
}
