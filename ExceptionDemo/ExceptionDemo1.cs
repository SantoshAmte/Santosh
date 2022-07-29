using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.ExceptionDemo
{
    class ExceptionDemo1
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the frist number : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            int num2 = int.Parse(Console.ReadLine());


            try
            {
                int result = num1 / num2;

                Console.WriteLine(result);


            }
            catch (IndexOutOfRangeException  )
            {
                Console.WriteLine("result is incorrect : ");
                
            }
            

            Console.WriteLine("h");
        }  
    }




    class baseclass
    {
        public void show ()
        {
            Console.WriteLine("base class");
        }

        class derived : baseclass
        {
            new  public void show  ()
            {
                Console.WriteLine("drived class ");


            }
        }

        class program
        {
            static void Main(string[] args)
            {
                baseclass obj = new derived();
                obj.show();
                

            }
        }
       
    }
}
