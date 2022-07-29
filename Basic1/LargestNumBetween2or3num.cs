using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Basic1
{
    class LargestNumBetween2or3num
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            if (a > b)
            {
                Console.WriteLine(" a is greater ");
            }
            else
            {
                Console.WriteLine("b is greater");
            }
            Console.ReadLine();

        }


    }
  

    class example2 
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 15;
            int c = 18;

            if (a > b && a > c)
            {
                Console.WriteLine("a is greater");

            }
            else if (b>c&&b>a)
            {
                Console.WriteLine("b is greater ");

            }
            else
            {
                Console.WriteLine("c is greater");

            }
            Console.ReadLine();
        }
        
    }

}
