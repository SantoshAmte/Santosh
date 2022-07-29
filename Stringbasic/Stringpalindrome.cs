using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Stringbasic
{
    class Stringpalindrome
    {
        static void Main(string[] args)
        {
            string str = " ";
            Console.WriteLine("enter a string ");
            str = Console.ReadLine();

            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string str_reverse = new string(arr);

            if (str.Equals(str_reverse))
            {
                Console.WriteLine("its a panlindrome string ");
            }
            else
            {
                Console.WriteLine("its not a palindrome string ");
            }
            
        }
    }
}
