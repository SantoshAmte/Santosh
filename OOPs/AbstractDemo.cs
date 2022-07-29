using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.OOPs
{

    public abstract class geek
    {
        // abstract method 'gfg'

        public abstract void gfg();

        //Close 'geek' inherit 
        //in child class 'geek1'

    }

    public class tatya : geek
    {
        public override void gfg()//same thevne 
        {
            Console.WriteLine("class  tatya");
        }
    }

    public class kaka : geek
    {
        public override void gfg()//same thevne (same as the previous class )
        {
            Console.WriteLine("class kaka");
        }

    }

    class AbstractDemo
    {
        static void Main(string[] args)
        {
            geek g;

            g = new tatya ();
            g.gfg();

            g = new kaka();
            g.gfg();
            

        }

    }
}
