using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Loops
    {
        public void WhileLoopExample()
        {
            // Example 1
            int i = 0;
            while (i < 5)   // 0 < 5, 1 < 5, 2 < 5, 3 < 5, 4 < 5
            {
                Console.WriteLine(i);
                i++;    // i = i + 1;
            }
            Console.WriteLine(); // Empty line

            // Example 2
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j = j + 2;
            }
            Console.WriteLine();    // Empty line

            // Example 3
            int k = 0;
            while (k <= 10)
            {
                if (k % 2 == 0)
                {
                    Console.WriteLine(k);
                }
                k++;
            }
        }

        public void DoWhileLoopExample()
        {
            // Example 1
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
            Console.WriteLine(); // Empty line

            // Example 2
            int j = 0;
            do
            {
                Console.WriteLine(j);
                j = j + 2;
            } while (j < 10);
            Console.WriteLine(); // Empty line

            // Example 3
            int k = 0;
            do
            {
                if (k % 2 == 0)
                {
                    Console.WriteLine(k);
                }
                k++;
            } while (k <= 10);
        }

        public void ForLoopExample()
        {
            // Example 1
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(); // Empty line

            // Example 2
            for (int i = 0; i < 10; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(); // Empty line

            // Example 3
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void NestedLoopsExample()
        {
            // Outer loop
            for (int i = 1; i <= 2; ++i)
            {
                Console.WriteLine("Outer: " + i);  // Executes 2 times

                // Inner loop
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j);  // Executes 6 times (2 * 3)
                }
            }
        }

        public void foreachLoopExample()

            /* foreach (type variableName in arrayName) 
           {
             // code block to be executed
           }  */

        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
