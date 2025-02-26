using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance
{
    internal class Program
    {
        /*  Some steps to run any .cs file.
             1. Open **Visual Studio (VS)** and click on the **View** menu.  
             2. Click on **Solution Explorer**.  
             3. Right-click on the **folder** where the file is located.  
             4. Go to **Properties**.  
             5. Scroll down and select the `.cs` file you want to run in the **Startup Object** section.   */

        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        static void Main()
        {
            MyMethod();
        }
    }
}
