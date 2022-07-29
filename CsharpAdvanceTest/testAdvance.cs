﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.CsharpAdvanceTest
{
    class testAdvance
    {
     
    
        class Exam1
        {//9.	WAP to find Area of Square, Rectangle, and Circle using Method Overloading
            public void Area(double radius)
            {
                double pi = 3.14;
                double result = pi * radius * radius;
                Console.WriteLine("Area of a circle = " + result);

            }

            public void Area(int Side)
            {

                int result = Side * Side;
                Console.WriteLine("Area of a square = " + result);
            }
            public void Area(int length, int breath)
            {
                int result = length * breath;
                Console.WriteLine("area of reactangle= " + result);
            }
            static void Main(string[] args)
            {
                Exam1 t = new Exam1();
                t.Area(1.5);
                t.Area(5);
                t.Area(6, 7);

            }
        }
        class Exam2
        {

            double Volume(double r)
            {
                double volume = (4 / 3.0) * (22 / 7.0) * r * r * r;
                return volume;
            }

            double Volume(double h, double r)
            {
                double volume = (22 / 7) * r * r * h;
                return volume;
            }

            double Volume(double l, double b, double h)
            {
                double volume = l * b * h;
                return volume;
            }
            static void Main(string[] args)
            {
                Exam2 e = new Exam2();
                e.Volume(5);
                e.Volume(5, 3);
                e.Volume(2, 3, 4);
                Console.WriteLine("sphere volume= " + e.Volume(5));
                Console.WriteLine("cylinder volume= " + e.Volume(5, 3));
                Console.WriteLine("cuboid volume= " + e.Volume(2, 3, 4));
            }
        }
        public interface Cake  //que no 4
        {
            void bake();
        }
        class Strawberry : Cake
        {
            public void bake()
            {
                Console.WriteLine("bake the strawberry cake");
            }
        }
        public class Blackforest : Cake
        {
            public void bake()
            {
                Console.WriteLine("bake the Blackforest cake");
            }
        }
        class Exam3
        {
            static void Main(string[] args)
            {
                Cake c = new Strawberry();
                c.bake();
                Cake d = new Blackforest();
                d.bake();
            }
        }
        public interface Icecream //que no 5

        {
            void eat();
        }
        public interface Juice
        {
            void drink();
        }
        class Mastani : Icecream, Juice
        {
            public void eat()
            {
                Console.WriteLine("eat icecream");
            }
            public void drink()
            {
                Console.WriteLine("drink juice");
            }
        }
        class Exam4
        {
            static void Main(string[] args)
            {
                Icecream i = new Mastani();
                Juice j = new Mastani();
                i.eat();
                j.drink();
            }


        }
        class vehicle
        {
            public int vid;
            public string name;
            public int Vid
            {
                get { return vid; }
                set { vid = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }
        class Person
        {
            int id;
            string name;
            vehicle v;
            public int Id
            {
                get { return id; }
                set { id = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public vehicle V
            {
                get { return v; }
                set { v = value; }
            }
            static void Main(string[] args)
            {
                Person p = new Person();
                p.Id = 1;
                p.Name = "saurabh";
                p.V = new vehicle();

                p.V.Vid = 412412;
                p.V.Name = "bmw";
                Console.WriteLine(p.Id + " " + p.Name + " " + p.V.Vid + " " + p.V.Name);

                Person p1 = new Person();
                p1.Id = 2;
                p1.Name = "prasad";
                p1.V = new vehicle();

                p1.V.Vid = 413413;
                p1.V.Name = "aura";
                Console.WriteLine(p1.Id + " " + p1.Name + " " + p1.V.Vid + " " + p1.V.Name);
            }
        }

    }

    class Account   //que no 8 create class account with member variable 
    {
        public string Name;
        public float Balance;
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

            Console.WriteLine("this is a  para constructor");
            Console.WriteLine(name +" "+Balance +" "+ AccountNum);
        }


        class program
        {
            Account a = new Account("Santosh", 1000000, 50102003654);
            
        }
        //Console.ReadLine();



    }



}



