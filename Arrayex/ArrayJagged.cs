using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Arrayex
{
    class ArrayJagged
    {
        static void Main(string[] args)
        {
            int[][] Myarray = new int[3][];
            Myarray[0] = new[] { 12, 34, 45, 65, 67, 78, 89 };
            Myarray[1] =new [] { 12,45,567,67,78,676,768};
            Myarray[2] = new[] { 13, 345, 465, 567, 67, 87 };


            foreach (int[] item in Myarray) 
            {
                foreach (int i in item)
                {
                    Console.Write(i + "  ");
                }
                Console.WriteLine();


            }

            //for (int i = 0; i < Myarray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Myarray[i].Length; j++)
            //    {
            //        Console.Write(Myarray[i]  [j] +" ");
            //    }
            //    Console.WriteLine();
            //}

            }
    }


    class jarrays
    {
        static void Main(string[] args)
        {
            int[,] kaka = new int[3,2];//multiple arryas  just practice 


          
        }
    }
        
}
