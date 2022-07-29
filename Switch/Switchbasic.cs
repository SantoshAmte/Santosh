using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Switch
{
    class Switchbasic
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter any num to check even or odd :");
            num = Convert.ToInt32(Console.ReadLine());
            switch(num % 2)
                {
                case 0:Console.WriteLine(num + "is even number");
                    break;

                case 1:
                    Console.WriteLine(num + "is odd number");
                    break;
            }
            Console.ReadLine();
            {

            }
        }
    }

    class switchpro2
    {
        static void Main(string[] args)
        {
            int day;
            Console.WriteLine("enter the week day number:");
            day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:Console.WriteLine("monday");
                    break;
                case 2:
                       Console.WriteLine("thuesday");
                       break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }
        }
    }

    class switch3
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string operand;
            float answer;

            Console.WriteLine("enter the first intger:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter an operand(+,-,*,/): ");

            operand = Console.ReadLine();

            Console.WriteLine("enter the second intger:");

            num2 = Convert.ToInt32(Console.ReadLine());

            switch (operand)
            {
                case " - ":
                    answer = num1 - num2;
                    break;
                case " + ":
                    answer = num1 + num2;
                    break;

                case " * ":
                    answer = num1 * num2;
                    break;

                case " / ":
                    answer = num1 / num2;

                    break;

                default:
                    answer = 0;
                    break;
            }
                
        }
    }

    class tenarybasic
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("enter the nubmer ");

            i = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.WriteLine("number is odd ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("number is even ");
                Console.ReadLine();
                {
                    string result = i % 2 == 0 ? "i is even num" : "number is odd ";
                    Console.WriteLine(result);
                }
            }
        }

    }

}
