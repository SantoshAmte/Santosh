using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Basic1
{
    class Factorialdemo
    {
        public  static int fact (int x)       // using by function method 
        {
            int fact = 1;
            for (int i = 1;i<=x;i++ )
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
            return x;
        }
        static void Main(string[] args)
        {
            int result = Factorialdemo.fact(23);
            Console.WriteLine(result);
        }
    }


    

    class Factorial1
    {
        static void Main(string[] args)
        {
            int i, fact = 1, number;

            Console.WriteLine("enter the number ");
            number = int.Parse(Console.ReadLine());

            for ( i = 1; i <=number; i++)
            { 
                fact = fact * fact;
            }
            Console.WriteLine("factorial " + number+fact ); 


        }
    }
class Account
    {
        public string Name;
        public float  Balance;
        public double AccountNum;

        Account()
        {
            Console.WriteLine("THIS IS DEFAULT CONTRUCTOR ");
        }

        Account(string name, float Balance, double AccountNum)
        {
            this.Name = name;
            this.Balance = Balance;
            this.AccountNum = AccountNum;

        }


        class program
        {

        }
        

           
    }
}
