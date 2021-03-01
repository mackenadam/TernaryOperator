using System;

namespace TernaryOperator
{
    class Program
    {
        static string stateOfWater;

        static void Main(string[] args)
        {
            // Ternary operators
            // Regular if/else statement
            /* if (temperature < 0)
            {
                stateOfWater = "solid";
            }
            else
            {
                stateOfWater = "liquid";
            } */

            // As a method
            CheckStateOfWater(-5);
            CheckStateOfWater(20);
            CheckStateOfWater(110);
        }

        public static void CheckStateOfWater(int temperature)
        {
            // Using ternary operator
            stateOfWater = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";
            Console.WriteLine("State of water at {0} degrees celcius is {1}", temperature, stateOfWater);
        }
    }
}
