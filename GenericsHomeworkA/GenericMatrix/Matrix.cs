using System;

namespace GenericMatrix
{
    public class Matrix<T> where T : struct
    {
        public uint Rows { get; set; }
        public uint Colls { get; set; }
        public T[,] Matrixx { get; set; }
        public Matrix()
        {
            Rows = ReadNatural("Write number of rows: ");
            Colls = ReadNatural("Write numeber of colls: ");
            Matrixx = new T[Rows, Colls];
        }
        public void Print()
        {
            for(int i = 0; i < Matrixx.GetLength(0); i++)
            {
                for(int j = 0; j < Matrixx.GetLength(1); j++)
                {
                    Console.Write($"{Matrixx[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public static uint ReadNatural(string str)
        {
            uint elem;
            while(true)
            {
                Console.WriteLine(str);
                if(uint.TryParse(Console.ReadLine(), out elem))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a natural number!");
                }
            }
            return elem;
        }


    }  
}
