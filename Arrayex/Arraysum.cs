using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Arrayex
{
    class Arraysum
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 },
                         { 5, 5, 8 },
                         { 9, 3, 7 } };

            for (int i = 0; i <a.GetLength(0); i++)
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
            
