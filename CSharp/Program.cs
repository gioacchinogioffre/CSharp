using System;
using System.Collections;
namespace CSharp

{
	public class Program
	{
		static void Main(string[] args)
        {
			// create an object of my class (instance of Human)
            Human sergio = new("Sergio", "Denis", 17, "Green");
			Human jorge = new("Jorge", "Rial", 45, "red");

 			// access public variable from outside and even change them
			//sergio.firstName = "Sergio";
			//sergio.lastName = "Denis";
			//jorge.firstName = "Jorge";
			//jorge.lastName = "Rial";


            // call methods of the class
            sergio.IntroduceMyself();
            jorge.IntroduceMyself();

			Human basic = new();
			basic.IntroduceMyself();

			// BOX CLASS
			Console.WriteLine("BOX CLASS TESTING");
			Box box = new(3, 4, 5);

            box.DisplayInfo();
			Console.WriteLine("Box length is "+ box.GetLength());
			Console.WriteLine("Box height is " + box.Height);
			Console.WriteLine("Box width is " + box.Width);
			box.Width = 10;
			Console.WriteLine("Box width is " + box.Width);

			// MEMBER CLASS
			Console.WriteLine(value: "MEMBER CLASS TESTING");
			Members member1 = new Members();
			member1.Introducing(true);

			// ARRAYS
			// The elements must be of the same datatype and you must specify it when you declare it
			Console.WriteLine(value: "ARRAYS TESTING");
			int[] grades = new int[5]; // datatype[] arrayName = new datatype[amount of values]
			grades[0] = 20; // index 0 is equal to 20
			grades[1] = 15;
			grades[2] = 12;
			grades[3] = 9;
			grades[4] = 7;

			System.Console.WriteLine("grades at index 0 : {0}", grades[0]);
			
			// another way of initialazing an array
			int[] gradesOfMathStudents = {20, 32, 12, 8, 9};

			// third way
			int[] gradesOfHistoryStudents = new int[] {15, 20, 3, 17, 18, 15};

			System.Console.WriteLine("Length of Math Students is {0}",  gradesOfMathStudents.Length);

			int[] nums = new int[10];
			for(int i=0; i<10; i++)
			{
				nums[i] = i;
			}

			for(int j=0; j<nums.Length; j++)
			{
				System.Console.WriteLine("Element{0} = {1}", j, nums[j]);
			}

			int counter = 0;
			foreach(int k in nums)
			{
				System.Console.WriteLine("Element{0} = {1}", counter, k);
				counter++;
			}

			string[] bestFriends = {"Mauro", "Fede", "Lucas", "Marce", "Fran"};
			foreach(string name in bestFriends)
			{
				System.Console.WriteLine("Greetings my friend {0}", name);
			}


			// declare 2D array
			int[,] array2D = new int[,]
			 {
				{1,2,3}, //row 0
				{4,5,6}, // row 1
				{7,8,9} // row 2
			 };

			System.Console.WriteLine("Central value is {0}", array2D[1,1]); // it prints 5
			System.Console.WriteLine("Central value is {0}", array2D[2,0]); // it prints 7

			// declare 3D ARRAY
			string[,,] array3D = new string[,,]
			{
				{
					{"000", "001"},
					{"010", "011"},
					{"Hi there", "What's up"}
				},
				{
					{"100", "101"},
					{"110", "111"},
					{"Anothe oner", "Last entry"}
				}
			};

			System.Console.WriteLine("The value is {0}", array3D[0,2,0]); // it prints Hi there
			System.Console.WriteLine("Last entry is {0}", array3D[1,2,1]); // it prints Last entry

			string[,] array2Dstring = new string[3,2] // specify 3 rows and two entries per each 
			{
				{"one", "two"},
				{"three", "four"},
				{"five", "six"},
			};

			System.Console.WriteLine("Print the third {0}", array2Dstring[1,0]); // it prints three
			array2Dstring[1,1] = "chicken";
			System.Console.WriteLine(array2Dstring[1,1]);

			// getting the dimensions of an array
			int dimensions = array2Dstring.Rank;
			System.Console.WriteLine("the array has " + dimensions + " dimensions");

			foreach (int num in array2D) // we cannot change the items of the array, only access to them
			{
				System.Console.Write(num + " ");
			}

			System.Console.WriteLine("\n This is our 2D array printed using nested for loop");
			for (int i = 0; i < array2D.GetLength(0); i++)
			{
				//inner for loop
				for (int j = 0; j < array2D.GetLength(1); j++)
				{
				System.Console.Write(array2D[i, j] + "\n");
				}
			}


			// declare jagged array (array within an array)
			int[][] jaggedArray = new int[3][]; // array with 3 arrays inside
			jaggedArray[0] = new int[5]; // index 0 an array with 5 elements
			jaggedArray[1] = new int[3]; // index 1 an array with 3 elements
			jaggedArray[2] = new int[2]; // index 2 an array with 2 elements

			jaggedArray[0] = new int[] {2,3,4,5,6}; // initialize and add values to the array
			jaggedArray[1] = new int[] {1,2,3};
			jaggedArray[2] = new int[] {10,22};

			// alternative way
			int[][] jaggedArray2 = new int[][]
			{
				new int[] {2,3,4,5,6},
				new int[] {1,2,3},
			};

			System.Console.WriteLine("The last value of the first entry within the jagged array is " +jaggedArray2[0][4]);

			foreach(int[] array in jaggedArray2)
			{
				// for (int i = 0; i < array.Length; i++)
				// {
				// 	System.Console.Write(array[i]);
				// }
				foreach (int num in array)
				{
					System.Console.Write(num);
				}
			}
			System.Console.Write("\n");


			// for (int i = 0; i < jaggedArray2.Length; i++)
			// {
			// 	for (int j = 0; j < jaggedArray2[i].Length; j++)
			// 	{
			// 		System.Console.WriteLine(jaggedArray2[i][j]);
			// 	}
			// }

			// ARRAY LIST
			ArrayList myArrayList = new ArrayList(); // undefined amount of objects
			ArrayList myArrayList2 = new ArrayList(100); // defined amount of objects

			myArrayList.Add(25); 
			myArrayList.Add("Hello"); 
			myArrayList.Add(13); 
			myArrayList.Add(128); 
			myArrayList.Add(25.3); 

			// delete element with specific value from the array
			myArrayList.Remove(13);

			// delete element at specific position
			myArrayList.RemoveAt(0);

			System.Console.WriteLine(myArrayList.Count); // should be print 3

			double sum = 0;

			foreach (object obj in myArrayList)
			{
				if(obj is int)
				{
					sum += Convert.ToDouble(obj);
				}
				else if (obj is double)
				{
					sum += (double)obj;
				}
				else if (obj is string)
				{
					System.Console.WriteLine(obj);
				}
			}

			System.Console.WriteLine(sum); // should be print 153.3
		


        }


	}
}

