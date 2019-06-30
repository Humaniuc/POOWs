using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace GenericMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> matrix1 = new Matrix<int>(3, 4);
            Matrix<int> matrix2 = new Matrix<int>(4, 3);

            for (uint i = 0; i < matrix1.Rows; i++)
            {
                for(uint j = 0; j < matrix1.Colls; j++)
                {
                    matrix1[i, j] = ReadInteger($"matrix1[{i}, {j}]= ");
                }
            }

            for (uint i = 0; i < matrix2.Rows; i++)
            {
                for (uint j = 0; j < matrix2.Colls; j++)
                {
                    matrix2[i, j] = ReadInteger($"matrix2[{i}, {j}]= ");
                }
            }

            matrix1.Print();
            matrix2.Print();

            uint rows = matrix1.Rows > matrix2.Rows ? (uint)matrix1.Rows : (uint)matrix2.Rows;
            uint colls = matrix1.Colls > matrix2.Colls ? (uint)matrix1.Colls : (uint)matrix2.Colls;
            Matrix<int> addMatrix = new Matrix<int>(rows, colls);

            addMatrix = matrix1 + matrix2;

            addMatrix.Print();
        }

        public static int ReadInteger(string str)
        {
            int elem;
            while (true)
            {
                Console.Write(str);
                if (int.TryParse(Console.ReadLine(), out elem))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not an integer number!");
                }
            }
            return elem;
        }
    }
}
