using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Arrayex
{
    class JaggedArraysDemo
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];//Declare the Array 

            arr[0] = new int[] { 21, 56, 5, 59, 89 };//initialize the arrays
            arr[1] = new int[] { 89, 45, 5, 6, 68, 9, 5, 9, 93, 6 };

            //Traverse Array Element 

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write(arr[i][j] + "  ");
                }

                Console.WriteLine();
            }


        }


        //    class jsample
        //    {
        //        static void Main(string[] args)
        //        {
        //            int[][] arr = new int[3][]
        //            {
        //                new int [] {12,2,1512,15,35,1,8},
        //                new int [] {45,56,56,54,6,88},
        //                new int [] {4,4} 
        //            };

        //            for (int i = 0; i < arr.Length; i++)
        //            {
        //                for (int j = 0; j < arr.Length; j++)
        //                {
        //                    Console.Write(arr[i][j]+"  ");
        //                }

        //                Console.WriteLine();
        //            }



        //        }
        //    }
        //}



    }
    




}