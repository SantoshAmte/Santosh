using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Stringbasic
{
    class Stringdemo1
    {

        static void Main(string[] args)
        {
            string s1 = "Namaste";

            char[] ch = { 's','a', 'f', 'e' };

            string s2 = new string(ch);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }


    class string2
    {
        static void Main(string[] args)
        {
            string name;
            name = "Santosh";
            string id;
            id = "123.4f";
            string mark;
            mark  = "89";
            string subject;
            subject = "marahi";

            ////////////////////////////////////////////////////////////
            Console.WriteLine("i'm santosh :  {0}" , name );
            Console.WriteLine("id {0}",id);
            Console.WriteLine("mark  {0}", mark);
            Console.WriteLine("sub   {0}",subject);
        }
    }


    class srting3
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine("enter name ");
            string n = Console.ReadLine();

            for (int i = 0; i <n.Length; i++)
            {
                if (n[i]=='p'||n[i]=='a'||n[i]=='h'||n[i]=='m'||n[i]=='s')
                {
                    ++i;

                }
            }

        }
    }
}
