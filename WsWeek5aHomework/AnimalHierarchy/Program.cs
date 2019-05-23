using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>() { new Cat("Prost", 8, 'M'), new Cat("Angy", 11, 'F'), new Dog("Javert", 15, 'M'),
            new Tomcat("Tom", 18), new Kitten("Minnie", 19), new Dog("Ricu", 12, 'M'), new Frog("Crazy", 16, 'F')};

            foreach(Animal a in animals)
            {
                Console.WriteLine($"{a.Name} say {a.Speak()}, is {a.Age} years old and is {(a.Sex == 'F'? "female" : "male")}");
            }
        }
    }
}
