﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Basic1
{
    class primenumberdemo
    {

        static void Main(string[] args)
        {
            int n, i, m = 0, flag = 0;

            Console.WriteLine("Enter The Number TO Check Prime ");
            n = int.Parse(Console.ReadLine());

            m = n / 2;
            for ( i = 2; i <=m; i++)
            {
                if (n%i==0)
                {
                    Console.Write("Number Is Not Prime");

                    flag = 1;
                    break;
                }
            }

            if (flag==0)
            {
                Console.WriteLine("number is prime ");
            }
        }
    }
}
