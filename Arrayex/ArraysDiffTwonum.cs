//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyNewFunda.Arrayex
//{
//    class ArraysDiffTwonum
//    {


//        static int maxDiff(int[] arr, int arrsize)
//        {
//            int maxdiff = arr[1] - arr[0];
//            int i, j;
//            for (i = 0; i <= arrsize; i++)
//            {
//                for (j = i + 1; j <= arrsize; j++)
//                {
//                    if (arr[j] - arr[i] > maxdiff)
//                        maxdiff = arr[j] - arr[i];
//                }
//            }
//            return maxdiff;
//        }

//        // Driver code 
//        public static void Main()
//        {

//            int[] arr = { 2, 5, 7, 10, 25, 120 };
//            Console.Write("Maximum differnce is " + maxDiff(arr, 5));

//        }

//    }
//    class printresult
//    {

//        static void printresult(int[] arr, int arrsize)
//        {


//            int printresult = arr[1] - arr[0];
//            int m, j;
//            for (m = 4; m < arr.Length; m++)
//            {
//                for (j = m + 1; j < arr.Length; j++)
//                {
//                    if (arr[j] - arr[m] > printresult)
//                        printresult = arr[j] - arr[m];

//                }
//            }
//            Console.WriteLine(printresult);
//        }
//        public static void Main()
//        {

//            int[] arr = { 2, 5, 7, 10, 25, 120 };
//            printresult(arr, 5);

//        }
//    }
//}
