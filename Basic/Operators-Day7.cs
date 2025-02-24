using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Operators
    {
        public void OperatorsExample()
        {
            int x = 3;
            int y = 5;
            Console.WriteLine(x + y);  // Addition
            Console.WriteLine(x - y);  // Subtraction
            Console.WriteLine(x * y);  // Multiplication
            Console.WriteLine(x / y);  // Division
            Console.WriteLine(x % y);  // Modulus
        }
        public void Arithmetic()
        {
            int x = 3 + 3;
            Console.WriteLine(x);

            // Second Example
            int sum1 = 50 + 50; // 100 (50 + 50)
            int sum2 = sum1 + 70; // 170 (100 + 70)
            int sum3 = sum1 + sum2; // 270 (100 + 170)
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
        }

        public void Assignment()
        {
            int x = 5;
            Console.WriteLine(x); // 5
            x += 3;
            Console.WriteLine(x); // 8
            x -= 3;
            Console.WriteLine(x); // 5
            x *= 3;
            Console.WriteLine(x); // 15
        }

        public void Comparison()
        {
            int x = 5;
            int y = 3;
            Console.WriteLine(x == y); // False
            Console.WriteLine(x != y); // True
            Console.WriteLine(x > y); // True
            Console.WriteLine(x < y); // False
            Console.WriteLine(x >= y); // True
            Console.WriteLine(x <= y); // False
        }

        public void Logical()
        {
            bool x = true;
            bool y = false;
            Console.WriteLine(x && y); // False
            Console.WriteLine(x || y); // True
            Console.WriteLine(!x); // False
        }
        public void math()
        {
            Console.WriteLine(Math.Max(3, 8));  // Returns the largest number
            Console.WriteLine(Math.Min(3, 8));  // Returns the smallest number  
            Console.WriteLine(Math.Sqrt(81));  // Returns the square root
            Console.WriteLine(Math.Abs(-4.7));  // Returns the absolute value
            Console.WriteLine(Math.Round(9.99));  // Rounds a number

        }
    }
}
