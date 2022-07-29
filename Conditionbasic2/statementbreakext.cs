using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Conditionbasic2
{
    class statementbreakext
    {
        // C# program to illustrate the
         // use of break statement

	

		// Main Method
		static public void Main()
		{

			// GeeksforGeeks is printed only 2 times
			// because of break statement
			for (int i = 1; i < 4; i++)
			{
				if (i == 3)
					break;

				Console.WriteLine("nothing is possible ");
			}
		}
	}

	



    class Continuestatement 
	{

		// Main Method  // use of continue statement
		public static void Main()
		{

			// This will skip 4 to print
			for (int i = 1; i <= 10; i++)
			{

				// if the value of i becomes 4 then
				// it will skip 4 and send the
				// transfer to the for loop and
				// continue with 5
				if (i == 4)
					continue;

				Console.WriteLine(i);
			}
		}
	}




class GotoStatement 
	{

		// Main Method // use of goto statement
		static public void Main()
		{
			int number = 20;
			switch (number)
			{

				case 5:
					Console.WriteLine("case 5");
					break;
				case 10:
					Console.WriteLine("case 10");
					break;
				case 20:
					Console.WriteLine("case 20");

					// goto statement transfer
					// the control to case 5
					goto case 5;

				default:
					Console.WriteLine("No match found");
					break;
			}
		}
	}

	// C# program to illustrate the
   // use of return statement

     class returnstatement 
	  {

		// creating simple addition function
		static int Addition(int a)
		{

			// add two value and
			// return the result of addition
			int add = a + a;

			// using return statement
			return add;
		}

		// Main Method
		static public void Main()
		{
			int number = 2;

			// calling addition function
			int result = Addition(number);
			Console.WriteLine("The addition is {0}", result);
		}
	}


	// C# Program to illustrate the use
    // of throw keyword


   class throwstatement // of throw keyword
	{

		// taking null in the string
		static string sub = null;

		// method to display subject name
		static void displaysubject(string sub1)
		{
			if (sub1 == null)
				throw new NullReferenceException("Exception Message");

		}

		// Main Method
		static void Main(string[] args)
		{

			// using try catch block to
			// handle the Exception
			try
			{

				// calling the static method
				displaysubject(sub);
			}

			catch (Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
		}

	}


}

