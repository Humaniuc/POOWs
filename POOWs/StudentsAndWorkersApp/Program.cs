using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Human", "Petru", 10));
            students.Add(new Student("Humaniuc", "Urtep", 5));
            students.Add(new Student("Juravle", "Cuinamuh", 9));
            students.Add(new Student("Jur", "Pet", 2));
            students.Add(new Student("Huma", "Coria", 8));
            students.Add(new Student("Ciunamuh", "Urtep", 6));
            students.Add(new Student("Human", "Coria", 10));
            students.Add(new Student("Petru", "Juravle", 6));
            students.Add(new Student("Juravle", "Humaniuc", 8));
            students.Add(new Student("Elvaruj", "Urtep", 7));

            IEnumerable<Student> ording = students.OrderByDescending(Student => Student.Grade);
            foreach(Student s in ording)
            {
                s.Print();
            }
            System.Console.WriteLine();

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Human", "Petru", 10, 8));
            workers.Add(new Worker("Humaniuc", "Urtep", 5, 7));
            workers.Add(new Worker("Juravle", "Cuinamuh", 9, 9));
            workers.Add(new Worker("Jur", "Pet", 2, 7));
            workers.Add(new Worker("Huma", "Coria", 8, 6));
            workers.Add(new Worker("Ciunamuh", "Urtep", 6, 4));
            workers.Add(new Worker("Human", "Coria", 10, 3));
            workers.Add(new Worker("Petru", "Juravle", 6, 5));
            workers.Add(new Worker("Juravle", "Humaniuc", 8, 7));
            workers.Add(new Worker("Elvaruj", "Urtep", 7, 6));

            IEnumerable<Worker> ordings = workers.OrderByDescending(Worker => Worker.MoneyPerHour);
            foreach(Worker w in ordings)
            {
                w.Print();
            }
            System.Console.WriteLine();


            IEnumerable<Human> humans = students;
            humans = humans.Concat(workers);
            humans = humans.OrderByDescending(Human => Human.FirstName);

            foreach(Human h in humans)
            {
                h.Print();
            }
            
        }      
    }
}
