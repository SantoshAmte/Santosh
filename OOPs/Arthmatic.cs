using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.OOPs
{
    class Arthmatic
    {
             // overloading
            void Calculate()
            {
                int x = 3;
                int y = 7;
                Console.WriteLine("addn " + x + y);
            }
            public void Calculate(int x, int y)
            {
                Console.WriteLine("subn is " + (x - y));
            }
            public void Calculate(double x, double y)
            {
                Console.WriteLine("multi is " + (x * y));
            }
            public void Calculate(float x, float y)
            {
                Console.WriteLine("div is " + (x / y));
            }
            static void Main(string[] args)
            {
                Arthmatic t = new Arthmatic();
                t.Calculate(3, 7);
                t.Calculate(5, 7);
                t.Calculate(3.5, 2);
                t.Calculate(55, 5);

            }
        
    }
}
