using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Loopbasic
{
    class forbasis
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <=10; i++)
            {
                Console.WriteLine(i);

            }
        }
    }

    class forloop2
    {
        static void Main(string[] args)
        {
            for (int i=121; i<=229; i++)
            {
                if (i%2 ==0)
                Console.WriteLine(i);
            }
           
        }
        
    }
    class evenloop
    {
        static void Main(string[] args)
        {
            int i = 229;

            while (i <= 521)
            {
                if (i % 2 != 0)


                {

                    Console.WriteLine(i + " ");
                }
                i++;

            }
  
        
        }
    }
    class useofbreak
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;

                if (i == 4)
                {
                    break;
                }
            }
        }
    }


  
 class table2
    {
        static void Main(string[] args)
        {
            int n, i, t = 0;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("table is ");
            for (i = 1; i <= 10; i++)
            {
                t = n * i;
                Console.WriteLine(n+"*"+i+"="+t);
            }
            
           
        }
    }
    class factor
    {
        static void Main(string[] args)
        {
            int  num =  9;
            int  fact = 1;

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;   //logic
            }
                    Console.WriteLine(fact);
                    Console.ReadLine();
                
            
   
        }
    }

    class factorial
    {
        static void Main(string[] args)
        {
            int number, factorial = 1;
            Console.WriteLine("enter the number");
            number = Convert.ToInt32(Console.ReadLine());

            if (number <0)
                Console.WriteLine("cant find the factorial of negative number");

            else if (number <= 1)
                Console.WriteLine("{0}! = {1}",number , factorial);
            else
            {


                for (int counter = number; counter >= 2; counter--) ;
            }

        }
    }

    class for1
    {
        static void Main(string[] args)
        {
            for (int i =15; i<=25; i++)
            {
                Console.WriteLine(i);

            }
        }
    }

    class for2
    {
        static void Main(string[] args)
        {
            for (int i = 350; i <= 400; i++)
            {
                Console.WriteLine(i);

            }

        }      
    }

    class oddloop
    {
        static void Main(string[] args)
        {
            for (int i = 15; i <=30; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);

            }
        }
    }

    class oddloop2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);

            }
        }
    }
    class even1
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <=10; i++)

            {
                   if (i % 2 == 0)
                   sum = sum + i;

            }
               Console.WriteLine(sum);
        }
    }

    class fibonachi1
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");    
            for (i = 2; i < number; ++i)     
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
    
    
  class magicnum
    {
        static void Main(string[] args)
        {
            int magicnumber = 88;

            for(; ; )
            {
                Console.WriteLine("enter the number");

                int num = int.Parse(Console.ReadLine());
                if (num < magicnumber)
                {
                    Console.WriteLine("number is less than magicnumber pls try again...");
                    continue;
                }
                else if (num > magicnumber)
                {
                    Console.WriteLine("number is grater pls try again");
                    continue;
                }
                else
                {
                    Console.WriteLine("congrats  number is match....");
                }


            }
        }
    }  
}





    
