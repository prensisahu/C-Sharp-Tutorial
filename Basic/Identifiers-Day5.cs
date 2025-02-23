using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Identifiers
    {
        public void IdentifiersExample()
        {
            int minutesPerHour = 60;     // Good.

            int m = 60; // OK, but not so easy to understand what m actually is.

            Console.WriteLine(minutesPerHour);
            Console.WriteLine(m);
        }

    }
}

        // All C# variables must be identified with unique names.
