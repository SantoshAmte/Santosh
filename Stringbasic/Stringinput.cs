using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Stringbasic
{
    class Stringinput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String ");//count in int value 
            String str = Console.ReadLine();
            int i = str.Length;
            Console.WriteLine(i);
            Console.WriteLine("................");

            string newUpper = str.ToUpper();
            Console.WriteLine(newUpper);
            Console.WriteLine("\\\\\\\\\\\\");

            string newLower = newUpper.ToLower();
            Console.WriteLine(newLower);
            Console.WriteLine("\\\\\\\\\\\\\\");

            char[] ch = str.ToCharArray();
            Console.WriteLine(string.Join(" ", ch));
            Console.WriteLine("//////////////");

            string substringnew = str.Substring(2);
            Console.WriteLine(substringnew);

            string sub2 = str.Substring(3, 6);//starindex,numberofchar
            Console.WriteLine(sub2);


            Console.WriteLine(str[0] + " " + str[str.Length - 1]);


            Console.WriteLine("..................");
            string[] words = str.Split(" ");
            foreach (string st in words)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine("////////////////////");

            Console.WriteLine(str.IndexOf('i'));

            Console.WriteLine(str.LastIndexOf('i'));
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no  to reverse");
            int Number = int.Parse(Console.ReadLine());
            int Reverse = 0;
            while (Number > 0)
            {
                int remainder = Number % 10;
                Reverse = (Reverse * 10)+remainder;
                Number = Number / 10;
            }
            Console.WriteLine("Reverse is {0}", Reverse);
            Console.ReadLine();
        }
    }
}