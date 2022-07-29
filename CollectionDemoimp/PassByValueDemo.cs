using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.CollectionDemoimp
{
    class PassByValueDemo
    {
         


    
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


}

