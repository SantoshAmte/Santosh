//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyNewFunda.OOPs
//{
//    class methodoveloding
//    {
//        void sum(int a, int b)
//        {
//            console.writeline(a + b);

//        }
//        void sum(float a, float b)
//        {
//            console.writeline(a + b);

//        }
//        static void main(string[] args)
//        {
//            methodoveloding d = new methodoveloding();
//            d.sum(12.34f, 23.89f);
//            d.sum(12, 5445);
//            console.readline();
//        }
//    }


//    class animals        //overriding
//    {
//        public void eat()
//        {
//            console.writeline("animal is eating");
//        }
//    }
//    class dog : animals
//    {
//        public void eat()
//        {
//            console.writeline("dog is eating ");
//        }

//        static void main(string[] args)
//        {
//            dog sonya = new dog();
//                       sonya.eat();

//                    }


//                }

//    // abstract class
//    abstract class animal
//    {
//        // abstract method (does not have a body)
//        public abstract void animalsound();
//        // regular method
//        public void sleep()
//        {
//            console.writeline("zzz");
//        }
//    }

//    // derived class (inherit from animal)
//    class pig : animal
//    {
//        public override void animalsound()
//        {
//            // the body of animalsound() is provided here
//            console.writeline("the pig says: wee wee");
//        }
//    }

//    class program
//    {
//        static void main(string[] args)
//        {
//            pig mypig = new pig(); // create a pig object
//            mypig.animalsound();  // call the abstract method
//            mypig.sleep();  // call the regular method
//        }
//    }
//    class enployeep
//    {
//        private int EmpAge;
//        private string EmpName;

//        public void setName(string Name)
//        {
//            this.EmpName = Name;
//        }

//        public void getName(string EmpName)
//        {
//            Console.WriteLine("this name is : " + this.EmpName);
//        }

//        public void setEmpAge(int Age)
//        {
//            this.EmpAge = Age;
//        }

//        public void getEmpAge(int EmpAge)
//        {
//            Console.WriteLine("this Age is : " + this.EmpAge);
//        }
//    }
//    class program
//    {

//        static void Main(string[] args)
//        {
//            enployeep n = new enployeep();
//            n.setName = "Santosh";
//            n.setEmpAge = 45;


//            Console.ReadLine();
//        }






//    }


//}
