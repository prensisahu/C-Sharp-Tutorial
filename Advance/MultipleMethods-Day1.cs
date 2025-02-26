using System;

namespace MyApplication
{
    class MultipleMethods
    {
        //  Example 1
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        static void Main()
        {
            MyMethod();
            MyMethod();
            MyMethod();
        }  
    }
}