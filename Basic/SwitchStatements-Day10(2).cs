using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class SwitchStatements

    /* Syntax:-
       switch(expression) 
    {
       case x:
              // code block
       break;
       case y:
             // code block
       break;
       default:
            // code block
       break;
     }           */


    {
        public void SwitchStatementsExample()
        {
            // Example 1

            int day = 1;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");    // Monday will be printed
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }

            // Example 2

            int month = 10;
            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");   // October will be printed
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Invalid month");
                    break;
            }
        }
    }
}
