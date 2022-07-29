using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.CollectionDemoimp
{
    class ParamsKeywordDemo
    {

        public static int Add(params int [] Nums) // useing by params keyword 
        {
            int sum = 0;

            foreach (int i in Nums)
            {
                sum = sum + i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ParamsKeywordDemo.Add(20,22,33,85,75,96));
            Console.ReadLine();
        }
    }
}
