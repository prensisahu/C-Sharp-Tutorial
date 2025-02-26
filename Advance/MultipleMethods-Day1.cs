using System;

namespace MyApplication
{
    class Methods
    {
        //  Example 1
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        static void Main()
        {
            MyMethod(); // Note:- methods can be called repeatedly.
        }  
    }
}