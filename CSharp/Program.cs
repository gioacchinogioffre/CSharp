using System;
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

			Box box = new();
			box.SetLength(3);
			box.Height = 4;
			box.width = 5;
			box.Width = 5;

            box.DisplayInfo();
			Console.WriteLine(box.GetLength());
			Console.WriteLine(box.Height);
			Console.WriteLine(box.Width);

        }
	}
}

