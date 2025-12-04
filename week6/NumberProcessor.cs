using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week4.week6
{
    public class NumberProcessor
    {
        // Method that processes numbers based on a condition using Func delegate
        // Func<int, bool> takes an int parameter and returns a bool
        public static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            Console.WriteLine("Processing numbers with the given condition:");

            bool foundAny = false;
            foreach (int number in numbers)
            {
                // Apply the condition to each number
                if (condition(number))
                {
                    Console.Write($"{number} ");
                    foundAny = true;
                }
            }

            if (!foundAny)
            {
                Console.Write("No numbers match the condition");
            }

            Console.WriteLine(); // New line after results
        }

        // Helper method: Returns true if number is even
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // Helper method: Returns true if number is greater than 10
        public static bool IsGreaterThan10(int number)
        {
            return number > 10;
        }
    }
}