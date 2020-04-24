using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day : Game
    {
        // member variables (HAS A)
        public int generatedCustomers;
        public Weather weather;
        List<Customer> customers;
        // constructor (SPAWNER)
        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>();
        }
        // member methods (CAN DO)
        public void GenerateCustomers()
        {
            //generate randoom number of customers
            //gen a random number between 10 and 60
            //user that number in a for loop (to determine how many time the loop will run)
            //inside of the loop, add a new customer object to the list of customers every iteration                       
            for (int i = 0; i < 7; i++)
            {
                Random rng = new Random();
                generatedCustomers = rng.Next(50, 89);
                generatedCustomers = customers.Count;
            }         

        }
        public void StartDay()
        {
            BeginDay();

        }
    }
}
