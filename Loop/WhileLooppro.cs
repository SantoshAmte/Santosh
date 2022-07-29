using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Loop
{
    class Whileevenodd
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Armstrong
    {
        static void Main(string[] args)
            {

            int n, r, sum = 0, temp;
            Console.Write("Enter the Number= ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Armstrong Number.");
            else
                Console.Write("Not Armstrong Number.");
        }
    }
    



    class magicnum
    {
        static void Main(string[] args)
        {
            int magicnumber = 5;

            while (magicnumber>0)
            {
                Console.WriteLine("enter the number");

                int num = int.Parse(Console.ReadLine());
                if (num < magicnumber)
                {
                    Console.WriteLine("number is less than magicnumber pls try again...");
                    continue;
                }
                else if (num > magicnumber)
                {
                    Console.WriteLine("number is grater pls try again");
                    continue;
                }
                else
                {
                    Console.WriteLine("congrats  number is match....");
                }


            }
        }
    }

    class binarypeo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the binary number ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int p = 0;
            while(num>0)
            {
                int r = num % 10;
                int power = (int)( Math.Pow(2, p));
                sum = sum + (power * r);
                num = num / 10;
                p++;
            }
            Console.WriteLine(sum);
        }
    }

    class evenodd
    {
        static void Main(string[] args)
        {
            int i=0;
            while (i <= 10)
            {
                i++;
                if (i % 2 ==0)
                {
                    Console.WriteLine(i+"num is even");
                }
                    else
                {
                    Console.WriteLine(i*i);
                }
            }

        }

      
    }

}
    


