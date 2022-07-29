using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.OOPs
{
    class Carsinfo
    {
        public int num;
        public string name;
        public string color;



        static void Main(string[] args)
        {
            Carsinfo Mahindra;
            Mahindra = new Carsinfo();

            Mahindra.num = 4589;
            Mahindra.name = "Thar";
            Mahindra.color = "Black";

            Carsinfo Nano = new Carsinfo();
            

            Nano.num = 2231;
            Nano.name = "nano2";
            Nano.color = "pink";

            Carsinfo creata = new Carsinfo();

            creata.num = 25896;
            creata.name = "creataz";
            creata.color = "white";

            Console.WriteLine(Mahindra.num+" "+Mahindra.name+" "+Mahindra.color);
            Console.WriteLine(Nano.num+ " " +Nano.name + " "+Nano.color);
            Console.WriteLine(creata.num+ " " +creata.name+ " " +creata.color);
        }


    }


    class Student
    {
        

        public int id;
        public string name;
        public int m1,m2,m3;//mark1
        public int per;

        public void AcceptDetails(int sid, string sname, int sub1, int sub2, int sub3)
        {
            id = sid;
            name = sname;
            m1 = sub1;
            m2 = sub2;
            m3 = sub3;
        }

        public void calculate()
        {
            per = (m1 + m2 + m3) / 3;
        }

        void display()
        {
            Console.WriteLine("id\t name\t \t m2 \t m3 \t per");
            Console.WriteLine(id+"     "+name+"     "+m1+"     "+m2+"     "+m3+"     "+per);
        }

        static void Main(string[] args)
        {

        }


        

      
    }
}


