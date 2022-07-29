using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Conditionbasic2
{
    class Condition1cs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("enter number is an even number");

            }

            else
            {
                Console.WriteLine("enter number is an odd number");
            }
        }
    }

    class PositiveNegativeZero
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("num is positive");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("num is negative");
                Console.ReadLine();

            }

        }

    }

    class condition1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the third number");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("num1 is greater");
                    Console.ReadLine();
                }
                
            }
            else if (num2 > num3)
            {
                Console.WriteLine("num2 is greater");

            }
            else
            {
                Console.WriteLine("num3 is greater");
            }


        }
    }


    class condition2                                      // using && operator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the third number");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num1 is greatest among three nos");
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine("num2 is greatest among three nos");
            }
            else
            {
                Console.WriteLine("num3 is greatest among three nos");
            }
        }
    }


    class blood
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the weight");
            int weight = int.Parse(Console.ReadLine());
            if (age > 25)
            {
                if (weight >= 50)
                {
                    Console.WriteLine("person is eligible for blood donation");
                }
                else
                {
                    Console.WriteLine("person is not eligible for blood donation due to less weight");

                }
            }
            else
            {
                Console.WriteLine("person not eligible for blood donation");
            }
        }


    }

    class blood2
    {
        static void Main(string[] args)        // using && logical operator
        {
            Console.WriteLine("enter the age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the weight");
            int weight = int.Parse(Console.ReadLine());
            if (age > 18 && weight >= 50)
            {
                Console.WriteLine("person is eligible for blood donation");
            }
            else
            {
                Console.WriteLine("person is not eligible for blood donation");
            }
        }
    }



    class Alpha1
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());

            // Alphabet checking condition using && , || operator
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + "     " + "is an Alphabet. ");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + "     " + "is  Digit. ");
            }
            else
            {
                Console.WriteLine(ch + "       " + "is symbol ");
            }

            Console.ReadLine();
        }
    }

    class numisdivisible
    {
        
            static void Main(string[] args)
            {
                int num;
                num = 110;

                Console.WriteLine("Number: " + num);

                // checking if the number is divisible by 3 and 5
                if (num % 5 == 0 && num % 11 == 0)
                {
                    Console.WriteLine("Divisible by 5 and 11");
                }
                else
                {
                    Console.WriteLine("Not divisible by 5 and 11");
                }
                Console.ReadLine();
            }
        
    }
}


