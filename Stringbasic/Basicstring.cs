using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Stringbasic
{
 //   class Basicstring
 //   {
 //       static void Main(string[] args)
 //       {
 //           string s = "Hello";//using keyword;
 //           string str = "Hello";//using literal 
 //           string st = new string("Hello");//using new 


 //           Console.WriteLine(str = st);
 //           Console.WriteLine(str = st);
 //           Console.WriteLine(str.GetHashCode());

 //           str = st + "c#";
 //           Console.WriteLine(str.GetHashCode());
 //           Console.WriteLine(str);


 //       }
	//}




    // C# program to illustrate encapsulation


public class Student
	{

		// private variables declared
		// these can only be accessed by
		// public methods of class
		private String studentName;
		private int studentAge;

		// using accessors to get and
		// set the value of studentName
		public String Name
		{

			get
			{
				return studentName;
			}

			set
			{
				studentName = value;
			}

		}

		// using accessors to get and
		// set the value of studentAge
		public int Age
		{

			get
			{
				return studentAge;
			}

			set
			{
				studentAge = value;
			}

		}


	}

	// Driver Class
	class GFG
	{

		// Main Method
		static public void Main()
		{

			// creating object
			Student obj = new Student();

			// calls set accessor of the property Name,
			// and pass "Ankita" as value of the
			// standard field 'value'
			obj.Name = "Ankita";

			// calls set accessor of the property Age,
			// and pass "21" as value of the
			// standard field 'value'
			obj.Age = 21;

			// Displaying values of the variables
			Console.WriteLine("Name: " + obj.Name);
			Console.WriteLine("Age: " + obj.Age);
		}
	}






	//




	// C# program to illustrate the
// concept of inheritance

namespace ConsoleApplication1
	{

		// Base class
		class GFG
		{

			// data members
			public string name;
			public string subject;

			// public method of base class
			public void readers(string name, string subject)
			{
				this.name = name;
				this.subject = subject;
				Console.WriteLine("Myself: " + name);
				Console.WriteLine("My Favorite Subject is: " + subject);
			}
		}

		// inheriting the GFG class using :
		class GeeksforGeeks : GFG
		{

			// constructor of derived class
			public GeeksforGeeks()
			{
				Console.WriteLine("GeeksforGeeks");
			}
		}

		// Driver class
		class Sudo
		{

			// Main Method
			static void Main(string[] args)
			{

				// creating object of derived class
				GeeksforGeeks g = new GeeksforGeeks();

				// calling the method of base class
				// using the derived class object
				g.readers("Kirti", "C#");
			}
		}
	}


	class pro
    {

		 
		
		static void Main(string[] args)
        {
			

            Console.WriteLine(10+45);
        }


	}











	// C# program to calculate the area
// of a square using the concept of
// data abstraction


namespace Demoabstraction
	{

		// abstract class
		abstract class Shape
		{

			// abstract method
			public abstract int area();
		}

		// square class inheriting
		// the Shape class
		class Square : Shape
		{

			// private data member
			private int side;

			// method of square class
			public Square(int x = 0)
			{
				side = x;
			}

			// overriding of the abstract method of Shape
			// class using the override keyword
			public override int area()
			{
				Console.Write("Area of Square: ");
				return (side * side);
			}
		}

		// Driver Class
		class GFG
		{

			// Main Method
			static void Main(string[] args)
			{

				// creating reference of Shape class
				// which refer to Square class instance
				Shape sh = new Square(4);

				// calling the method
				double result = sh.area();

				Console.Write("{0}", result);

			}
		}
	}

	class stringexample
    {
        static void Main(string[] args)
        {
			string s1 = "hello";
			string s2 = " kka";

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
