using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.ExceptionDemo
{
    class NullExeptionDemo
    {
        static void Main(string[] args)
        {

            try
            {

                string a = null;
                Console.WriteLine(a.Length); // Null Exaption Haii aaysa show krega 
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message); //pro run nahi hoga 

            }
            
        }
    }
}
