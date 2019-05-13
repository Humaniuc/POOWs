using System;

namespace StudentsAndWorkersApp
{
    abstract class Human
    {
        private string firstName;
        private string lastName;

        internal string FirstName
        {
            get { return firstName; }
            set
            {
                if (value != null)
                {
                    firstName = value;
                }
                else
                {
                    Console.WriteLine("FirstName is mandatory");
                }
            }
        }
        internal string LastName
        {
            get { return lastName; }
            set
            {
                if (value != null)
                {
                    lastName = value;
                }
                else
                {
                    Console.WriteLine("LastName is mandatory");
                }
            }
        }

        internal Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        internal void Print()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
