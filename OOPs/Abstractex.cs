using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.OOPs
{
    abstract class go
    {
        public abstract void Method1();
    }

    class Sample1 : go
    {
        public override void Method1()
        {
            Console.WriteLine(" Method1() Shankar");
        }
    }

    class sample2 : Sample1
    {
        public void Method2()
        {
            Console.WriteLine("Method2() Santosh");
        }
    }

    class Abstractex
    {
        public static void Main ( String[] args)
        {
            sample2 p = new sample2();

            p.Method1();
            p.Method2();
        }







    }
}
