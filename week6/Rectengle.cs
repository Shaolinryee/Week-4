using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week4.week6
{
    public class Rectangle
    {
        // Private fields
        private double length;
        private double breadth;

        // Property with expression-bodied members
        public double Length
        {
            get => length;
            set => length = value;
        }

        // Property with expression-bodied members
        public double Breadth
        {
            get => breadth;
            set => breadth = value;
        }

        // Method with expression-bodied member - Calculate area
        public double GetArea() => length * breadth;

        // Method with expression-bodied member - Calculate perimeter
        public double GetPerimeter() => 2 * (length + breadth);

        // Method with expression-bodied member - Show details
        public string ShowDetails() => $"Length: {length}, Breadth: {breadth}";
    }
}