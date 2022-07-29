using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Basic1
{
    class PalindromeDemo
    {
        static void Main(string[] args)
        
        {
            int n, r, sum = 0, temp;

            Console.WriteLine("Enter the Palindrome Number");
            n = int.Parse(Console.ReadLine());

            temp = n;
            while (n>0)
            {
                r = n % 10;
                sum=(sum*10)+r;
                n = n / 10;
            }

            if (temp==sum)

                Console.WriteLine("number is palimdrome ");
             else

                Console.WriteLine("number is not palindrome");
            {

            }
        }
    }
}
