using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class BreakContinue
    {
        public void BreakExample()
        {
            // Example 1
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine(); // Empty line

            // Example 2

            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
                if (j == 6)
                {
                    break;
                }
            }     
        }

        public void ContinueExample()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine();    // Empty line

            // Example 2

            int j = 0;
            while (j < 10)
            {
                if (j == 9)
                {
                    j++;
                    continue;
                }
                Console.WriteLine(j);
                j++;
            }
        }
    }
}
