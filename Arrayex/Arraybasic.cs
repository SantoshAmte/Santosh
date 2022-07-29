using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Arrayex
{
    class Arraybasic
    {
        static void Main(string[] args)
        {
            char[] c = { 'a', 'b' ,'d', 'e' };

            char[] ch1 = new char[4];
            for( int i=0; i<ch1.Length;i++)
            {
                ch1[1] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("///////////////////////////////");

            for(int i = 0; i<ch1.Length;i++)
            {
                Console.Write(ch1[i] + " ");

            }
            Console.WriteLine();
            Console.WriteLine("///////////////////////////////");

            foreach(int a in ch1)
            {
                Console.WriteLine(ch1);
            }
            Console.WriteLine("/////////////////////////////");
            

        }


    }
    class Arrayeven
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 6, 8, 3, 2 };

            for(int i = 0; i<a.Length;i++)
            {

                if (a [i]%2==0)

                {
                    Console.WriteLine(a [i]);
                }
            }
        }
    }
    class Arrayodd
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 6, 8, 3, 2 };

            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] % 2 == 1)

                {
                    Console.WriteLine(a[i]);
                }
            }
        }
    }

    class Sumofeven
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter value a Number:");
            int Number = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 2; i <= Number; i += 2)
            {
                sum += i;
            }
            Console.Write(sum);
            Console.ReadLine();
        }
    }
    class sumarray
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            int sum = 0;
            Array.ForEach(array, i => sum += i);

            Console.WriteLine(sum);
        }
    }
    
}


