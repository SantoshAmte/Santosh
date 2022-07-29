using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Basic1
{
    class Addition
    {
        static void Main(string[] args)
        {
            int a = 6, b = 9;
            int result = a + b;
            Console.WriteLine(result);
        }
    }
    class condition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("num is divisible by 2");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("num is not divisible by 2");
                Console.ReadLine();
            }

    
        }


    }
    class circul
    {
        static void Main(string[] args)
        {
            double radius, a;
            const double pi = 3.14;
            radius = 20;
            a = pi * radius * radius;
            Console.WriteLine(pi);
        }
    }

    class cube
    {
        static void Main(string[] args)
        {
            int a, cube;
            a = 12;
                cube = a * a * a;
            Console.WriteLine(cube);
        }
    } 

    class operator1
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 4;
            int x = ++a + ++b;

            int y = a++ + b++;
            Console.WriteLine(x + " " + a + "  " + b);
            Console.WriteLine(y + " " + a + "  " + b);

            int z = --a + --b;
            Console.WriteLine(z + " " + a + "  " + b);

            int m = a-- - b--;
            Console.WriteLine(m + " " + a + "  " + b);
        }
    }
class operators2
    {
        static void Main(string[] args)
        {
            int a = 10, b = 5;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
        }
  
    }
class operator3
    {
        static void Main(string[] args)
        {
            int a = 50, b = 10;
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a >  b);
            Console.WriteLine(a  < b);
        }
    }



  
class Circle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Radius: ");
            double Radious = Convert.ToDouble(Console.ReadLine());
            double Area = Math.PI * Radious * Radious;
            Console.WriteLine("Area of circle: " + Area);
            Console.ReadKey();
        }
    }


}



