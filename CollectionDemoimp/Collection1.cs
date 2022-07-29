using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.CollectionDemoimp
{
    class Collection1
    {
        
        // non generic
            private object ob;
            public object Ob { get => ob; set => ob = value; }

    }
        class KK<T>// generic
        {
            private T ob;
            public T Ob { get => ob; set => ob = value; }

        }
    class Test
    {


        static void Main(string[] args)
        {
            KK<string> obj = new KK<string>();
            obj.Ob = "kkkk";
            string s = obj.Ob;


            Collection1 c = new Collection1();
        }
}   }
  


