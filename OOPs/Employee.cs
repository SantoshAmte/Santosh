using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.OOPs
{
    class Employee
    {

        int id;
        string name;
        double salary;


        Employee(int id,string name,double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;

        }

        void display()
        {
            Console.Write(id+" "+name+"  "+salary);
        }

        static void Main(string[] args)
        {
            Employee e = new Employee (2, "Prasad",85850);
            e.display();
        }



    }
}
