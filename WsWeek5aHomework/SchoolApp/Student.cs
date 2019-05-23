
namespace SchoolApp
{
    class Student : IPeople
    {
        private string name;
        static int id = 0;

        public string Name
        {
            get { return name; }
            set
            {
                if(value != null)
                {
                    name = value;
                }
                else
                {
                    System.Console.WriteLine("Name cannot be null");
                }
            }
        }

        public Student(string name)
        {
            Name = name;
            id++;
        }
    }
}
