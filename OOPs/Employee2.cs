using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.OOPs
{
    class Employee2
    {
        private int id;
        private string name;
        private double salary;

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
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
    class Employee2Info
    {
        static void Main(string[] args)
        {
           Employee2 p = new Employee2();
            p.Id = 2525;
            p.Name = "Pramod";
            p.Salary = 50000;
            Console.WriteLine(p.Id + " " + p.Name + " " + p.Salary);
        }
    }
}

