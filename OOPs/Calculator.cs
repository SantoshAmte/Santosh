using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.OOPs
{
    public class Calculator
    {
       int num1;
        int num2;
        int result;

        void Add()
        {
            result = num1 + num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }
        void Subcract()
        {
            result = num1 - num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void Main (string[]args)
        {
            Calculator pops = new Calculator();
            pops.num1 = 2324;
            pops.num2 = 29493;
            pops.Add();

            Calculator kaka = new Calculator();
            kaka.num1 = 898;
            kaka.num2 = 3435;
            kaka.Subcract();
        }
    }

}
