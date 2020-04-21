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
        Random rnd = new Random();

        // constructor (SPAWNER)
        public Weather()
        {
            weatherConditions = new List<string>();
            weatherConditions.Add("Sunny");
            weatherConditions.Add("Rainy");
            weatherConditions.Add("Cloudy");
            CurrentCondition();
            CurrentTemperature();
        }

        // member methods (CAN DO)
        public int RandomNumber(Random random)
        {
            int numberGenerated = random.Next(1, 3);
            return numberGenerated;            
        }
        public void CurrentCondition()
        {
           
            int i = RandomNumber(rnd);
            condition = weatherConditions[i];          
        }
        public void CurrentTemperature()
        {
            temperature = rnd.Next(60, 94);
                        
        }
        
    }
}
