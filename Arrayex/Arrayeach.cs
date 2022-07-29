using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Arrayex
{
    class Arrayeach
    {
        static void Main(string[] args)
        {
            int[,] number = new int[2, 1];
            for (int i = 0; i <1; i++)
            {
                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("Please enter number");
                    number[x, i] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 3; x++)
                {
                    Console.Write(number[x, i] + " ");
                }
                Console.WriteLine(" ");
                Console.ReadLine();
            }
        }
    }
}
