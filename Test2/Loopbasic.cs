using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Test2
{
    class divigiblenumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (i % 5 == 0 && i % 10 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }

    class Loop
    {
        static void Main(string[] args)
        {
            {
                int b = 0;
                do
                {
                    int a = 2;
                    b++;
                    Console.WriteLine(a++);
                }
                while (b != 3);
            }
        }
    }

    class Predict
    {
        static void Main(string[] args)
        {
            int i = 1, k = 1;
            while (i++ <= 5)
            {
                k *= i;
            }
            Console.WriteLine("k= " + k + "i=" + i);

        }
    }

    class Spynumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER ANY NUMBER");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int product = 0;
            while (num > 0)
            {
                int r = num % 10;
                sum = sum + r;
                product = product * r;
                num = num / 10;

            }
            if (sum == product)
            {
                Console.WriteLine("num is spy number");
            }
            else
            {
                Console.WriteLine("num is not spy number");
            }
        }
    }

    class pattern
    {
        static void Main(string[] args)
        {
            int i, j, k = 4, m;
            for (i = 1; i <= 4; i++)
            {
                for (j = 1; j <= k; j++)
                {
                    Console.Write(" ");
                }

                for (m = 1; m <= i; m++)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                Console.WriteLine("/n");
                k = k - 1;


            }
        }
    }
}

    
			




