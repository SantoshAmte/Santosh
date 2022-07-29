using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.CollectionDemoimp
{
    class OutkeywordDemo
    {
        //out <data type> <variable name>;
         //<method name>(out <data type> <parameter name>)



        public static void GetMultipleRandomValue(out int x, out int y)
        {
            var random = new Random();
            x = random.Next();
            y = random.Next();
        }

        public static void Main()
        {
            int random1, random2;
            GetMultipleRandomValue(out random1, out random2);

            Console.WriteLine($"{random1}, {random2}");
        }


    }



    //public static void OutParamExample(out int x)        ////   with 
    //{
    //  x = 100;
    //}





    //    Calling Method with Out Parameter


    //int a; // declare variable without initialization

    //OutParamExample(out a);// calling method with out keyword

    //Console.Write(a);// accessing out parameter value

    //public static void OutParamExample(out int x)
    //{
    //    x = 100;
    //}



    class DEMO2 

    {
        //    When to use out parameterS

        public static void GetMultipleRandomValue(out int x, out int y)
        {
            var random = new Random();
            x = random.Next();
            y = random.Next();
        }

        public static void Main()
        {
            int random1, random2;
            GetMultipleRandomValue(out random1, out random2);

            Console.WriteLine($"{random1}, {random2}");
        }


    }




}
