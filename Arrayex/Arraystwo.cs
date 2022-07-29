using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Arrayex
{
    class Arraystwo
    {
        static void Main(string[] args)
        {
            int[,] Myarray = new int[3, 4]
            {
                { 12,34,45,56},
                { 13,35,65,67},
                { 45,56,67,78}
            };
            for (int i = 0; i < Myarray.GetLength(0); i++)
            {
                for (int j = 0; j <Myarray.GetLength(1); j++)
                {
                    Console.WriteLine(Myarray[i,j]+"  ");
                }
            }

            Console.ReadLine();
        }
    }
}
