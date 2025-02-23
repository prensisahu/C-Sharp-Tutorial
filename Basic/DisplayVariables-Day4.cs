using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class DisplayVariables
    {
        public void DisplayVariablesExample()
        {
            string name = "Prensi";
            Console.WriteLine("Hello " + name);
        }

        public void DisplayVariablesExample2()
        {
            string firstName = "Prensi ";
            string lastName = "Sahu";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);
        }

        public void DisplayVariablesExample3()
        {
            int x = 3;
            int y = 3;
            Console.WriteLine(x + y);
        }
    }
}
