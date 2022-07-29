using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.Arrayex
{
    class Arraysppinit
    {
        static void Main(string[] args)
        {
            int i;
            int j = new int();
            i = 10;
            j = 20;
            String str;
            str = i.ToString();
            str = j.ToString();
        }
    }

    class stringarray
    {
        static void Main(string[] args)
        {
            string[] myarray1 = { "santosh ", "Nilesh" };
            

            Console.WriteLine(myarray1[0]);
            Console.WriteLine(myarray1 [1]);
        }
	}

    // C# program to find 4 elements
// with given sum


class GFG
	{

		// The following structure is needed
		// to store pair sums in aux[]
		class pairSum
		{

			// Index (int A[]) of first element in pair
			public int first;

			// Index of second element in pair
			public int sec;

			// Sum of the pair
			public int sum;
		}

		// Function to check if two given pairs
		// have any common element or not
		static bool noCommon(pairSum a, pairSum b)
		{
			if (a.first == b.first || a.first == b.sec ||
				a.sec == b.first || a.sec == b.sec)
				return false;

			return true;
		}

		// Following function is needed for sorting
		// pairSum array
		static int compare(pairSum a, pairSum b)
		{
			return (a.sum - b.sum);
		}

		// The function finds four
		// elements with given sum X
		static void findFourElements(int[] myArr, int sum)
		{
			int i, j;
			int length = myArr.Length;

			// Create an auxiliary array to
			// store all pair sums
			int size = (length * (length - 1)) / 2;
			pairSum[] aux = new pairSum[size];

			// Generate all possible pairs
			// from A[] and store sums
			// of all possible pairs in aux[]
			int k = 0;
			for (i = 0; i < length - 1; i++)
			{
				for (j = i + 1; j < length; j++)
				{
					aux[k] = new pairSum();
					aux[k].sum = myArr[i] + myArr[j];
					aux[k].first = i;
					aux[k].sec = j;
					k++;
				}
			}

			// Sort the aux[] array using
			// library function for sorting
			Array.Sort(aux, compare);

			// Now start two index variables
			// from two corners of array
			// and move them toward each other.
			i = 0;
			j = size - 1;
			while (i < size && j >= 0)
			{
				if ((aux[i].sum + aux[j].sum == sum) &&
					noCommon(aux[i], aux[j]))
				{
					string output = myArr[aux[i].first] + ", " +
									myArr[aux[i].sec] + ", " +
									myArr[aux[j].first] + ", " +
									myArr[aux[j].sec];
					Console.WriteLine(output);
					return;
				}
				else if (aux[i].sum + aux[j].sum < sum)
					i++;
				else
					j--;
			}
		}

		// Driver code
		static public void Main()
		{
			int[] arr = { 2,5,7,10,25,120 };
			int X = 91;

			// Function call
			findFourElements(arr, X);
		}
	}

	// This code is contributed by srastog


	// C# code to find Maximum difference


class GFGP
	{

		// The function assumes that there
		// are at least two elements in array.
		// The function returns a negative
		// value if the array is sorted in
		// decreasing order. Returns 0 if
		// elements are equal
		static int maxDiff(int[] arr, int arr_size)
		{
			int max_diff = arr[1] - arr[0];
			int i, j;
			for (i = 0; i < arr_size; i++)
			{
				for (j = i + 1; j < arr_size; j++)
				{
					if (arr[j] - arr[i] > max_diff)
						max_diff = arr[j] - arr[i];
				}
			}
			return max_diff;
		}

		// Driver code
		public static void Main()
		{

			int[] arr = {2,5,7,10,25,120 };
			Console.Write("Maximum difference is " +
									maxDiff(arr,5 ));
		}
	}

	// This code is contributed by Sam007


}
