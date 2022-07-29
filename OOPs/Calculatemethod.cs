using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.OOPs
{
    class Calculatemethod
    {
        int X = 12;
        static int y = 45;



        void add()
        {
            Console.WriteLine("Addition is =="+(X+y));

        }


        static void Main(string[] args)
        {
            Calculatemethod k = new Calculatemethod();

            Console.WriteLine("sum=="+(k.X=y));


        }
    }


}
