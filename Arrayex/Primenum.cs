using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Arrayex
{
    class PrintPrime
    {


        public static void Main(string[] args)
        {

            int s = 0;
            int[] arr = new int[5];

            Console.Write("Enter array elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int j = 2;
                int count = 1;

                while (j < arr[i])
                {
                    if (arr[i] % j == 0)
                    {
                        count = 0;
                        break;
                    }
                    j++;

                }

                if (count == 1)
                {
                    s = s + arr[i];
                }
            }
            Console.Write("Sum of prime numbers:" + s);
        }
    }
}
