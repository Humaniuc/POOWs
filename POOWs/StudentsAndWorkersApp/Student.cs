namespace StudentsAndWorkersApp
{
    class Student : Human
    {
        private int grade;

        internal int Grade
        {
            get { return grade; }
            set
            {
                if(value < 1 || value > 10)
                {
                    System.Console.WriteLine("Grading is between 1 and 10");
                }
                else
                {
                    grade = value;
                }
            }
        }
        internal Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            Grade = grade;
        }

        internal void Print()
        {
            System.Console.WriteLine($"{FirstName} {LastName} {Grade}");
        }
    }
}
