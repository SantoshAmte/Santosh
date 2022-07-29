using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Arrayex
{
    class MultiArraysDemo
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];//multiDimensional  Arryas 

            arr[0, 1] = 20;
            arr[1, 2] = 40;
            arr[2, 0] = 270;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + "  ");
                }
                Console.WriteLine();
            }



        }
    }

    class Arrays2d
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };//declaration and initialization  

            //traversal  
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();//new line at each row  
            }
        }
    }


    class arrays3sample
    {
        static void Main(string[] args)
        {
            //int [] [] arr = new int[][]; 

            int[] arr = { 120, 20, 30, 40, 50 };

            Array.Sort(arr);

            foreach (int i in arr)

            {
                Console.WriteLine(arr[2]);
            }






        }

    }


    class methoddemo
    {
        


        
    }
    

    



}
