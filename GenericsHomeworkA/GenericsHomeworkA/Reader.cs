using System;

namespace GenericsHomeworkA
{
    public static class Reader
    {
        public static uint ReadNatural(string str)
        {
            uint index;
            while (true)
            {
                Console.WriteLine(str);
                if (uint.TryParse(Console.ReadLine(), out index))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a positive number: ");
                }
            }
            return index;
        }
    }
}
