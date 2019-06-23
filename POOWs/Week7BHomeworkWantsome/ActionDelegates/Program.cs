using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegates
{
    class Program
    {
        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            Action<int> printActionDel = ConsolePrint;
            printActionDel(10);

            Action<int> printActionAnonym = delegate (int i)
            {
                Console.WriteLine(i);
            };
            printActionAnonym(11);

            Action<int> printActionLambda = i => Console.WriteLine(i);
            printActionLambda(12);
        }
    }
}
