using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.OOPs
{
    class Methdoverloading
    {
 
            public int Add(int a, int b)
            {
                int sum = a + b;
                return sum;
            }

            public int Add(int a, int b, int c)
            {
            int sum = a + b + c;
                return sum;
            }

            public static void Main(String[] args)
            {
  
                Methdoverloading ob = new Methdoverloading();

                int sum1 = ob.Add(1, 2);
                Console.WriteLine("sum of the two"+ "integer value : " + sum1);
           
                int sum2 = ob.Add(1, 2, 3);
                Console.WriteLine("sum of the Three " + "integer value : " + sum2);
                
            }
        
    }
}
