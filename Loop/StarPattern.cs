using System;

namespace MyNewFunda.Loop
{
    class StarPattern
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write("*");//one line 
                }
                Console.WriteLine();//next line 
            }
            Console.ReadLine();
        }
    }

    class starpattern2
    {
        static void Main(string[] args)
        {
            int n = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <=n-1; j++)
                {
                    Console.Write(" "+"*");//one line 
                }
                Console.WriteLine();//next line 
            }
            Console.ReadLine();
        }

    }

    class starpattern3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write("*");//one line 
                }
                Console.WriteLine();//next line 
            }

            Console.ReadLine();
        }

    }

    class starpattern1
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4; i++)
            {
                for (int j = i; j <= 4; j++)

                    Console.Write(" ");
                {
                    for (int j = 1; j <= i; j++)

                        Console.Write("*");

                }
                Console.WriteLine();


            }

        }
    }

    class holopattern
    {
        static void Main(string[] args)
        {
           
        }
    }
}

