using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Basic1
{
    class Swapping
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int temp;
            Console.WriteLine(" before swapping value of a ={0},b ={1}", a, b);

            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("after swapping value of a = {0},b={1}", a, b);
            Console.ReadLine();

        }
    }
}
