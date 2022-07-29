using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.OOPs
{
    class Claculatemethodoverloading
    {

            public void Area(double radius)
            {
                double pi = 3.14;
                double result = pi * radius * radius;
                Console.WriteLine("Area of a circle = " + result);

            }

            public void Area(int Side)
            {

                int result = Side * Side;
                Console.WriteLine("Area of a square = " + result);
            }
            public void Area(int length, int breath)
            {
                int result = length * breath;
                Console.WriteLine("area of reactangle= " + result);
            }
            public void Area(double basee, double height)
            {
                double result = (basee * height) / 2;
                Console.WriteLine("area of triangle =  " + result);
            }
            static void Main(string[] args)
            {
                Claculatemethodoverloading t = new Claculatemethodoverloading();
                t.Area(1.5);
                t.Area(5);
                t.Area(6, 7);
                t.Area(2.5, 6);
            }
        
    }
}
