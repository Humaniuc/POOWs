using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    class Program
    {
        static void Main()
        {
            Teacher bouaru = new Teacher("Bouaru",
                new System.Collections.Generic.List<Discipline>()
                {
                    new Discipline("Matematica", 28, 152),
                    new Discipline("Informatica", 44, 512)
                });
            Teacher filip = new Teacher("Filip",
                new System.Collections.Generic.List<Discipline>()
                {
                    new Discipline("TIC", 22),
                    new Discipline("Informatica", 35, 56),
                    new Discipline("WebDesign", 18)
                });
            Teacher puiutu = new Teacher("Puiutu",
                new System.Collections.Generic.List<Discipline>()
                {
                    new Discipline("EDCO", 28, 10),
                    new Discipline("Analiza", 28, 15)
                });
            Teacher manta = new Teacher("Manta",
                new System.Collections.Generic.List<Discipline>()
                {
                    new Discipline("EGC", 28, 56),
                    new Discipline("BPC", 56, 18)
                });

            Classe classeA = new Classe(
                new System.Collections.Generic.List<Student>()
                {
                    new Student("Humaniuc"),
                    new Student("Cuinamuh"),
                    new Student("Petru"),
                    new Student("Juravle"),
                    new Student("Elvaruj"),
                    new Student("Urtep")
                },
                new System.Collections.Generic.List<Teacher>()
                {
                    bouaru, manta
                });
            Classe classeB= new Classe(
                new System.Collections.Generic.List<Student>()
                {
                    new Student("Humaniuc"),
                    new Student("Cuinamuh"),
                    new Student("Petru"),
                },
                new System.Collections.Generic.List<Teacher>()
                {
                    bouaru, manta, puiutu
                });
            Classe classeC = new Classe(
                new System.Collections.Generic.List<Student>()
                {
                    new Student("Humaniuc"),
                    new Student("Cuinamuh"),
                    new Student("Elvaruj"),
                    new Student("Urtep")
                },
                new System.Collections.Generic.List<Teacher>()
                {
                    filip, bouaru, manta
                });
            School school = new School(new List<Classe>() { classeA, classeB, classeC });
            school.Print();
        }
    }
}
