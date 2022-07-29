using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Arrayex
{
    class Arrayrow
    {
       
            static void Main(string[] args)
            {
                int[,] a = { { 785,987,980 }, { 978,97, 8 }, { 76,56,34 } };
           

                for (int i = 0; i < a.GetLength(0); i++)
                {
                    int sum = 0;
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        sum = sum + a[i, j];
                        Console.Write(a[i, j] + "  ");
                    }


                    Console.Write("sum" + sum);
                    Console.WriteLine();
                }

            }
        
    }
}
