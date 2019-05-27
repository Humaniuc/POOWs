using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pers = new Person("Humaniuc");
            Console.WriteLine(pers.ToString());

            pers.Age = 30;
            Console.WriteLine(pers.ToString());

            Console.ReadLine();
        }
    }
}