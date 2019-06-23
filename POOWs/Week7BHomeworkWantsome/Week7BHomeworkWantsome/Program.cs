using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7BHomeworkWantsome
{
    class Program
    {
        public delegate void Print(int value);
        static void Main(string[] args)
        {
            Print printDel = PrintNumber;
            printDel(100000);
            printDel(200);

            printDel = PrintMoney;
            printDel(100000);
            printDel(200);

            PrintHelper(PrintNumber, 10000);
            PrintHelper(PrintMoney, 10000);
        }

        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }
        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }

        public static void PrintHelper(Print delegateFunc, int numToPrint)
        {
            delegateFunc(numToPrint);
        }
    }
}
