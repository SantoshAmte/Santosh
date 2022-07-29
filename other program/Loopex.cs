using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.other_program
{
    class Loopex
    {
        static void Main(string[] args)
        {
            int m = 10;  int n = 7;
            while (m%n>=0)
            {
                m = m + 1;n = n + 2;

            }
        }

    }

    class omk
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;

            label:
            i++;
            j += i;
            if (i < 10)
            {

                Console.Write(i + " ");
                goto label;

        }   }
    }
}
