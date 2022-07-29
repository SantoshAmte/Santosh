using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.OOPs
{
    public class BaseClass
    {
          int num;
        public BaseClass()
        {
            Console.WriteLine("in BaseClass()");
        }
        public BaseClass(int i)
        {
            num = i;
            Console.WriteLine("in BaseClass(int i)");
        }

        public int GetNum()
        {
            return num;
        }
    }
    public class DerivedClass : BaseClass
    {
        public DerivedClass() : base()
        {
        }

        public DerivedClass(int i) : base(i)
        {
        }
        static void Main()
        {
            DerivedClass md = new DerivedClass();
            DerivedClass md1 = new DerivedClass(1);
        }
    }
}
