using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.ExceptionDemo
{
    class OutOfRangeExaptiondemo
    {
        static void Main(string[] args)
        {

            try
            {
                int[] arr = new int[3];
                arr[0] = 23;
                arr[1] = 24;
                arr[2] = 25;
                arr[3] = 26;
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
