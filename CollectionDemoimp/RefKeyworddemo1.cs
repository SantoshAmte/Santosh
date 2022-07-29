using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.CollectionDemoimp
{


    //     C# supports value type and reference type data types. By default, the value type variable is passed by value,
    //    and the reference type variable is passed by reference from one method to another method in C#. 
    class RefKeyworddemo1
    {
        // Passing Value type Variable
    
        public static void Main(string[] args)
        {
            int myNum = 10;

            // pass value type
            ProcessNumber(myNum);
            Console.WriteLine(myNum);

            Console.ReadLine();
        }

        public static void ProcessNumber(int num)
        {
            num = 100;
        }
    }


    // Passing Value Type by Reference

    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 10;
            ProcessNumber(ref myNum); //use ref to pass the parameter by reference 

            Console.WriteLine(myNum);
            Console.ReadLine();
        }

        public static void ProcessNumber(ref int num)
        {
            num = 100;
        }
    }






}

