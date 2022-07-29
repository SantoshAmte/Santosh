using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Switch
{
    class Stringsinswitch    //C# | How to use strings in switch statement

	{

		// Main Method
		static public void Main()
		{
			string str = "one";

			// passing string "str" in
			// switch statement
			switch (str)
			{

				case "one":
					Console.WriteLine("It is 1");
					break;

				case "two":
					Console.WriteLine("It is 2");
					break;

				default:
					Console.WriteLine("Nothing");
					break;
			}
		}
	}
	class switch2
    {
        //main method 
        static void Main(string[] args)
        {
          
                string subject = "C#";

                // passing string "subject" in 
                // switch statement
                switch (subject)
                {

                    case "Java":
                        Console.WriteLine("Subject is Java");
                        break;

                    case "C++":
                        Console.WriteLine("Subject is C++");
                        break;

                    default:
                        Console.WriteLine("Subject is C#");
                        break;
                }
            
        }
    }

}

