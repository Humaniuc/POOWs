using System;

namespace GenericMatrix
{
    public class Matrix<T> where T : struct
    {
        private T[,] matrix;

        public uint Rows { get; set; }
        public uint Colls { get; set; }
        public T[,] Matrixx { get => matrix; set => matrix = value; }

        public Matrix()
        {
            //Rows = ReadNatural("Write number of rows: ");
            //Colls = ReadNatural("Write numeber of colls: ");
            Matrixx = new T[Rows, Colls];
        }
        public Matrix(uint rows, uint colls)
        {
            Rows = rows;
            Colls = colls;
            Matrixx = new T[Rows, Colls];
        }
        public void Print()
        {
            for (uint i = 0; i < Matrixx.GetLength(0); i++)
            {
                for (uint j = 0; j < Matrixx.GetLength(1); j++)
                {
                    Console.Write($"{this[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static uint ReadNatural(string str)
        {
            uint elem;
            while (true)
            {
                Console.WriteLine(str);
                if (uint.TryParse(Console.ReadLine(), out elem))
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

        public T this[uint row, uint col]
        {
            get
            {
                return Matrixx[row, col];
            }
            set
            {
                Matrixx[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            uint rows = matrix1.Rows > matrix2.Rows ? (uint)matrix1.Rows : (uint)matrix2.Rows;
            uint colls = matrix1.Colls > matrix2.Colls ? (uint)matrix1.Colls : (uint)matrix2.Colls;
            Matrix<T> addMatrix = new Matrix<T>(rows, colls);

            uint minR = matrix1.Rows < matrix2.Rows ? (uint)matrix1.Rows : (uint)matrix2.Rows;
            uint minC = matrix1.Colls < matrix2.Colls ? (uint)matrix1.Colls : (uint)matrix2.Colls;

            for (uint i = 0; i < minR; i++)
            {
                for (uint j = 0; j < minC; j++)
                {
                    addMatrix[i, j] = (dynamic)matrix1[i, j] + (dynamic)matrix2[i, j];
                }
            }

            if (matrix1.Rows > matrix2.Rows)
            {
                for (uint i = minR; i < rows; i++)
                {
                    for (uint j = 0; j < colls; j++)
                    {
                        addMatrix[i, j] += (dynamic)matrix1[i, j];
                    }
                }
            }
            else
            {
                for (uint i = minR; i < rows; i++)
                {
                    for (uint j = 0; j < colls; j++)
                    {
                        addMatrix[i, j] += (dynamic)matrix2[i, j];
                    }
                }
            }

            if (matrix1.Colls > matrix2.Colls)
            {
                for (uint i = 0; i < rows; i++)
                {
                    for (uint j = minC; j < colls; j++)
                    {
                        addMatrix[i, j] += (dynamic)matrix1[i, j];
                    }
                }
            }
            else
            {
                for (uint i = 0; i < rows; i++)
                {
                    for (uint j = minC; j < colls; j++)
                    {
                        addMatrix[i, j] += (dynamic)matrix2[i, j];
                    }
                }
            }

            return addMatrix;
        }
    }

}
