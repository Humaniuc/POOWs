using System.Collections.Generic;

namespace SchoolApp
{
    class School
    {
        private List<Classe> classes = new List<Classe>();

        internal List<Classe> Classes { get; set; }

        public School(List<Classe> classes)
        {
            this.classes = classes;
        }

        public void Print()
        {
            foreach(Classe c in classes)
            {
                System.Console.WriteLine("Teachers: ");
                foreach(Teacher t in c.Teachers)
                {
                    System.Console.Write($"{t.Name} ");
                }
                System.Console.WriteLine();
                System.Console.WriteLine("Students: ");
                foreach(Student s in c.Students)
                {
                    System.Console.WriteLine($"{s.Name}");
                }
                System.Console.WriteLine();
            }
        }
    }
}
