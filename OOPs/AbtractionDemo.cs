using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.OOPs
{
    abstract class person   //class 
    {
        public string  FirstName;
        public string LastName;
        public int Age;
        public string CompanyName;

        public abstract void PrintDemo();  //abstract method 
        
    } 


    class student : person   //inherit student class 
    {

        public int RollNo;
        public int fees;

        public override void PrintDemo()  //using by abstract method  
        {

            Console.WriteLine(" Student name is :{0}", this.FirstName);
            Console.WriteLine(" Student last name is :{0}", this.LastName);
            Console.WriteLine(" Student Age is :{0}", this.Age);
            Console.WriteLine(" Student company  name  is :{0}", this.CompanyName);
            Console.WriteLine(" Student Roll No  is :{0}", this.RollNo);
            Console.WriteLine(" Student Fess is :{0}", this.fees);

        }
    }
        class teacher : person  //inherit by persone class 
        {
        public string Qulification;
        public int salary;


        public override void PrintDemo()
        {
            Console.WriteLine("teacher first name is : {0}",this.FirstName);
            Console.WriteLine("teacher last name is : {0}",this.LastName);
            Console.WriteLine("teacher age is : {0}",this.Age);
            Console.WriteLine("teacher company name  is : {0}",this.CompanyName);
            Console.WriteLine("teacher  qulification   is : {0}",this.Qulification);
            Console.WriteLine("teacher salary  is : {0}",this.salary);
 
        }

        }

    class AbtractionDemo
    {
        static void Main(string[] args)
        {
            student santosh = new student();

            santosh.FirstName = "Santosh";
            santosh.LastName = "Amte";
            santosh.Age = 23;
            santosh.CompanyName = "serrela";
            santosh.RollNo = 7;
            santosh.fees = 123122;

            santosh.PrintDemo();   //imp  last time mension in  

                /////////////////////////////////////////////////////
            teacher t = new teacher();
            t.FirstName = "Vaishali ";
            t.LastName = "bhagile ";
            t.Age = 35;
            t.PrintDemo();



            Console.ReadLine();

             




        }

    }
        


    


}