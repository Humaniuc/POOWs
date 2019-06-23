using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDelegates
{
    class Program
    {
        public delegate int SomeOperation(int i, int j);

        static int Sum(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            SomeOperation add = Sum;
            int result = add(10, 10);
            Console.WriteLine(result);

            Func<int, int, int> addFunc = Sum;
            result = addFunc(10, 10);
            Console.WriteLine(result);

            Func<int> getRandomNumber = delegate ()
            {
                Random rnd = new Random();
                return rnd.Next(1, 100);
            };
            Console.WriteLine("Random number: " + getRandomNumber());

            Func<int> getRndNumber = () => new Random().Next(1, 100);
            Console.WriteLine("Random number: " + getRndNumber());

            Func<int, int, int> Suma = (x, y) => x + y;
            Console.WriteLine("Sum = " + Suma(12, 23));
        }
    }
}
