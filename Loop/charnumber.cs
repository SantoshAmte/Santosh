using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Loop
{
    class charnumber3
    {
        static void Main(string[] args)
        {
                for (int i=1; i <=4; i++)
            {
                for (int j=i; j<=4; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();

            }
        }
    }

    class charnumber1
    {
        //1234
        //123
        //12
        //1
        static void Main(string[] args)
        {
            for (int i=4; i>=1; i--)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
        }
    }
    class pro2
    {
        //4321
        //432
        //43
        //4
        static void Main(string[] args)
        {

            for (int i=1; i<=4; i++)
            {
                for (int j=4; j>=i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
        }  }
    }

    class pro3
    {
        static void Main(string[] args)
        {
            for (int i=1; i<=3; i++)
            {
                for (int j=1; j>=i+2; j--)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();

            }
        }
    }
}
