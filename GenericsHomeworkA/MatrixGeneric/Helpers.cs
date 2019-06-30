using System;

namespace MatrixGeneric
{
    class Helpers
    {
        public static int ReadInteger(string str)
        {
            int number;
            while (true)
            {
                Console.Write(str);
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a valid input!");
                }
            }
            return number;
        }
    }
}
