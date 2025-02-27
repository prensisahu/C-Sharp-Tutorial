using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class MultidimensionalArrays
    {
        public void MultidimensionalArraysExample()
        {
            // Example 1
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            Console.WriteLine(numbers[0, 2]);  // Outputs 2 becaus o index mins { 1, 4, 2 } and 2 mens { 3, 6, 8 }, 0 = 3, 1 = 6, 2 = 2

            // Example 2
            int[,] numbers2 = { { 1, 4, 2 }, { 3, 6, 8 } };
            numbers[0, 0] = 5;  // Change the value of the first element 
            Console.WriteLine(numbers2[0, 0]);
        }
    }
}
