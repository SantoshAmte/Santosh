using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Prorigotest
{
    class Airthmaticprogro
    {
        static void Main(string[] args)
        {
            int a2 = Convert.ToInt32(Console.ReadLine());
            int a3 = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int diff = a3 - a2;

            for (int i = 3; i < n; i++)
            {
                a3 = a3 + diff;
            }
            Console.WriteLine(a3);
        }
    }

    class Cuckoo
    {
        int coo(int s)
        {
            if (s == 1)
            {
                s = 0;
            }
            if (s == 2)
            {
                s = 1;
            }

            return s;
        }
        static void Main(string[] args)
        {


            Cuckoo ck = new Cuckoo();
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            int cu1 = 0;
            int cu2 = 1;

            if (n == 1)
            {
                Console.WriteLine("0");
            }
            else if (n == 2)
            {
                Console.WriteLine("1");

            }
            else if (n > 2)
            {
                c = 1 * ck.coo(n - 1) + 2 * ck.coo(n - 2) + 3 * 1;

                Console.WriteLine(c);
            }
        }
    }

    class Coprime
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int gcd = 0;
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int divisor = 1; divisor <= i; divisor++)
                {
                    if (n % divisor == 0 && i % divisor == 0)
                        gcd = divisor;
                }

                if (gcd == 1)
                    c++;
            }
            Console.WriteLine(c);

        }
    }


    class Anagram
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();


            if (s1.Length == s2.Length)
            {
                char[] a1 = s1.ToCharArray();
                foreach (char ch in a1)
                {
                    //Deepa
                    int idx = s2.IndexOf('z');
                    if (idx != -1)
                    {
                        s2 = s2.Substring(0, idx) + s2.Substring(idx + 1);

                    }
                }



            }

        }
    }

    class sumofdigit
    {
        static void Main(string[] args)
        {
            int number = 123, sum = 0;

            while (number > 0)
            {
                sum = sum + (number % 10);
                number = number / 10;

            }
            Console.WriteLine("Sum of digits is {0}", sum);
            
        }
    }

    class evenodd
    {
        static void Main(string[] args)
        {
            int number, remainder;
            Console.WriteLine("enter any number value");
            number = Convert.ToInt32(Console.ReadLine());

            remainder = number % 2;

            if (remainder == 0)
                Console.WriteLine("{0} is an even number",number);
            else 
                Console.WriteLine("{0}  is an odd number ",number);

            
        }

            

    }

}
  


