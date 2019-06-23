using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7BHomeworkWantsome
{
    namespace CustomDelegates
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

                printDel = PrintNumber;
                printDel += PrintMoney;
                printDel += PrintHexazecimal;
                printDel(1000);

                printDel -= PrintHexazecimal;
                printDel(2000);
            }

            public static void PrintNumber(int num)
            {
                Console.WriteLine("Number: {0,-12:N0}", num);
            }
            public static void PrintMoney(int money)
            {
                Console.WriteLine("Money: {0:C}", money);
            }

            public static void PrintHexazecimal(int dec)
            {
                Console.WriteLine("Hexazecimal: {0:X}", dec);
            }
            public static void PrintHelper(Print delegateFunc, int numToPrint)
            {
                delegateFunc(numToPrint);
            }
        }
    }
}
