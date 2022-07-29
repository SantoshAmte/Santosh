using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Basic1
{
    class Fibonaccidemo
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, n3, i, number;

            Console.WriteLine("Enter The Number Of Element ");
            number = int.Parse(Console.ReadLine());

            Console.Write(n1 + "  " + n2+ "  ");
            for (i = 2; i <number; i++)
            {
                n3 = n1+n2;
                Console.Write(n3 +"  ");
                n1 = n2;
                n2 = n3;
               


            }


        }
    }
}
