using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.OOPs
{
    class Add
    {
        
            public int pincode;
            public string city;
            public int Pincode
            {
                get { return pincode; }
                set { pincode = value; }
            }
            public string City
            {
                get { return city; }
                set { city = value; }
            }
        }
    class Person
    {
        int id;
        string name;
        Add adr;
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
        public Add Adr
        {
            get { return adr; }
            set { adr = value; }
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Id = 1;
            p.Name = "Santosh";
            p.Adr = new Add();

            p.Adr.Pincode = 431212;
            p.Adr.City = "Ambad";
            Console.WriteLine(p.Id + " " + p.Name + " " + p.Adr.Pincode + " " + p.Adr.City);
        }
    }   
}
