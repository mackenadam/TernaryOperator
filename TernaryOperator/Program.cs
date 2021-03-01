using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ternary operators
            int temperature = -5;
            string stateOfWater;

            // Regular if/else statement
            /* if (temperature < 0)
            {
                stateOfWater = "solid";
            }
            else
            {
                stateOfWater = "liquid";
            } */

            // As a ternary
            stateOfWater = temperature < 0 ? "solid" : "liquid";
            Console.WriteLine("State of water at {0} degrees celcius is {1}", temperature, stateOfWater);

            temperature += 30;
            stateOfWater = temperature < 0 ? "solid" : "liquid";
            Console.WriteLine("State of water at {0} degrees celcius is {1}", temperature, stateOfWater);
        }
    }
}
