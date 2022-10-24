using System;


namespace CSharp
{
	// this class is a blueprint for a datatype
    public class Human

    {
		// member variables
        private string firstName; // if we don't add public it would be protected and we couldn't access outside the class except when creating with the constructor.
		private string lastName;
		private int age;
		private string eyeColor;

		// default constructor (without parameters)
		public Human()
		{
			Console.WriteLine("Constructor called. Object created");
		 }

        // parameterized constructor (we can create multiple constructors, with one or more parameters)

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }


        public Human(string firstName, string lastName, int age, string eyeColor)
		{
			this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.eyeColor = eyeColor;
        }

		// member method 
        public void IntroduceMyself()
		{
			Console.WriteLine("Hi, my name is {0} {1}. I'm {2} years old and I have {3} eyes", firstName, lastName, age, eyeColor);
		}
    }
}

