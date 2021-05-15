using System;

namespace ThisKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Keyword!");

            Person person = new Person();
            person.DisplayName();
            person.DisplayName("Don","Johnson");
        }
    }

    class Person
    {
        string firstName;
        string lastName;

        public void DisplayName()
        {
            Console.WriteLine(firstName + " " + lastName);
            
        }

        public void DisplayName(string firstName, string lastName)
        {
            Console.WriteLine(firstName + " " + lastName); //retrieves values passed
            Console.WriteLine(this.firstName + " " + this.lastName); //retrieves values from this class
        }

        public Person()
        {
            firstName = "Not Yet Determined";
            lastName = string.Empty;
        }
            

    }
}
