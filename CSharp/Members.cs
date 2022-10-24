using System;
namespace CSharp
{
    public class Members
    {
        // member - private field

        private string memberName;
        private string jobTitle;
        private int salary;

        // member - public field
        public int age;

        // properties - exposes jobTitle safely - starts with a capital letter
        public string JobTitle 
        {
            get 
            { 
                return jobTitle;
            }
           set 
           {
              jobTitle = value;
           }
        }

        // public member method - can be call from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend) SharingPrivateInfo();
            else Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I'm {2}{ years old.", memberName, jobTitle, age);
        }

        private void SharingPrivateInfo() // it can be called by a public method of the class outside of the class
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        // member constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        // member - finalizer - destructor (a class can only have one destructor and it must be created inside the class; it cannot be inheritated or called it; it's gonna be called when the object is closed, deleted or runned outside of its scope )
        ~Members()
        {
            //cleanup statements
            Console.WriteLine("Deconstruction of members object");
        }
    }
}

