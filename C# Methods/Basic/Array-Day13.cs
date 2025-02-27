using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    // Note:- To call arrays into objects   Basic.Array obj = new Basic.Array(); it exists.
    internal class Array
    {
        public void ArrayExample()
        {
            // Example 1
            // Declare an array with 3 numbers
            int[] numbers = { 5, 10, 15 };

            // Print the numbers using their index
            Console.WriteLine(numbers[0]); // First element
            Console.WriteLine(numbers[1]); // Second element
            Console.WriteLine(numbers[2]); // Third element

            // Example 2
            string[] fruits = { "Apple", "Banana", "Mango" };

            // Array ke elements print karna
            Console.WriteLine(fruits[0]); // Apple
            Console.WriteLine(fruits[1]); // Banana
            Console.WriteLine(fruits[2]); // Mango 

            // Example 3
            string[] color = { "Red", "Yellow", "Grren", "White" };
            for (int j = 0; j < color.Length; j++)
            {
                Console.WriteLine(color[j]);
            }
        }

        public void foreachArrayExample2()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
