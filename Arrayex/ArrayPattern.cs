using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Arrayex
{
    class ArrayPattern
    {
        static void Main(string[] args)
        {
            char[,] a = new char[4, 4];
            for (int i=0;i<=a.GetUpperBound(0);i++)
            {
               for (int j=0; j<=a.GetUpperBound(1);i++)
                {
                    if (i == 0||j==0||i==a.GetUpperBound(0)||j==a.GetUpperBound(1))
                    {
                        a[i, j] = '*';


                    }    
                    else
                    {
                        a[i, j] = ' ';
                    }
                }
            }
        }
    }
}
