using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Arrayex
{
    class sumnum
    {
        static void Main(string[] args)
        {
            int[] a = new int[3];
            Console.WriteLine("enter the array element");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }
            int sum = 0;
            for (int j = 0; j < a.Length; j++)
            {
                sum = sum + a[j];
            }
            Console.WriteLine(sum);
        }
    }
    class Max
    {
        public static void Main(string[] args)
        {
            int i, max = 0, min = 0;
            int[] arr = new int[2];

            Console.Write("Enter five numbers:");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            max = min = arr[0];
            for (i = 0; i < 5; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }

                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Largest element is:" + max);
            Console.WriteLine("Smallest element is:" + min);
        }
    }
}

