using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Basic1
{
    class Inputoutput
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("enter your name ");
            name = Console.ReadLine();

            Console.WriteLine("username: " +name );

        }
    }

    class intoutput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition:{0} ",num+num2);

        }
    }
}
