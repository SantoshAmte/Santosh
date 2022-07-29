using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Arrayex
{
    class SingleArraysDemo
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];//creating arryas //single arrays difine 

            arr[0] = 10;
            arr[2] = 85;
            arr[3] = 7896;
            arr[4] = 2213;


            for (int i = 0; i <arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }


        }
    }


    class Arraysdemo2
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 20, 30, 40, 50, 18 };

            foreach (int i in arr)
            {

                Console.WriteLine(i);

                
            }
        }
    }

    class arrays3
    {
        static void Main(string[] args)
        {
            int[] arr = { 123, 145, 258, 369, 89 };
            //Using For Loop in arryas


            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }

     
}
