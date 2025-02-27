using System;   // Is used to include the System namespace, Now you can use commonly used classes such as Console, String, Math directly.
using Basic;  // class ko access karne ke liye namespace import karo.

class Program    // class Writes the program to define an entry point class, which starts the execution of the program.
{
    static void Main()  // is the entry point of the program.
    {
        Syntax Obj = new Syntax();       // class ka object banao.
        Obj.SyntaxExample();         // Method call karo.
    }
}

