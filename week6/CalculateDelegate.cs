using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week4.week6
{
    public delegate int Calculate(int num1, int num2);

    // Class containing methods for Calculate delegate
    public class Calculator
    {
        // Method to add two numbers
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // Method to subtract two numbers
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}