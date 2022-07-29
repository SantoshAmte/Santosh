using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.other_program
{
    class Scope
    {
        int x = 10;
        static int y = 20;
        static void Main(string[] args)
        {
            int x = 100; int y=200;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(Scope.y);
        }
    }

    class arr
    {
        static void Main(string[] args)
        {
            char[] arr = new char[] { 'k', 'i', 'c', 'i', 't' }; 
        }
    }

  
}
