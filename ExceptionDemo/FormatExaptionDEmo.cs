using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.ExceptionDemo
{
    class FormatExaptionDEmo
    {
        static void Main(string[] args)
        {

            try
            {
                string str = " santosh";
                int a = int.Parse(Console.ReadLine());
            }

            catch (FormatException EX)
            {
                Console.WriteLine(EX.Message);
            }


        }
    }
}
