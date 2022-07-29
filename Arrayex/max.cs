using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Arrayex
{
    class max
    {
        static void Main(string[] args)
        {
                int i = 0;
                int max = 2;

                int[] arr = new int[2];
                Console.WriteLine("Enter array element: ");
                for (i = 0; i < arr.Length; i++)
                {
                    Console.Write("Element[" + (i + 1) + "]:    ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
                max = arr[0];
                for (i = 1; i < arr.Length; i++)
                {
                    if (max < arr[i])
                        max = arr[i];
                }
                Console.WriteLine(max);
            
        }
    }
}
