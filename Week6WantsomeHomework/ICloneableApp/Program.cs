using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person huma = new Person("Humaniuc", 1890223, new Contact("0749666666", "human"));
            huma.Grade = 9.23;

            object human = huma.Clone();
            if(human is Person)
            {
                System.Console.WriteLine((human as Person).ToString()); 
            }
        }
    }
}
