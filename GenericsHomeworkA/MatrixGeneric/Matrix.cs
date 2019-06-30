using System;
using System.ComponentModel;

namespace MatrixGeneric
{
    public class Matrix<T> where T : struct, IConvertible
    {
        private T[,] matr;
        public int Rows { get; set; }
        public int Colls { get; set; }
        public Matrix(int rows, int colls)
        {
            Rows = rows;
            Colls = colls;
            matr = new T[Rows, Colls];
        }
        public Matrix(T[,] matrix)
        {           
            Rows = matrix.GetLength(0);
            Colls = matrix.GetLength(1);
            matr = matrix;
        }

        public T this[int row, int col]
        {
            get
            {
                return this[row, col];
            }
            set
            {
                this[row, col] = value;
            }
        }

        public void Print()
        {
            for(int i = 0; i < this.Rows; i++)
            {
                for(int j = 0; j < this.Colls; j++)
                {
                    Console.Write($"{this[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public T[,] ReadMatrix() 
        {
            for(int i = 0; i < this.Rows; i++)
            {
                for(int j = 0; j < this.Colls; j++)
                {
                    Console.Write($"Matr[{i},{j}]= ");
                    this[i, j] = ChangeType<T>(Console.ReadLine());
                }
            }
            return matr;
        }

        private static T ChangeType<T>(object value)
        {
            return (T)ChangeType(typeof(T), value);
        }

        public static object ChangeType(Type t, object value)
        {
            TypeConverter tc = TypeDescriptor.GetConverter(t);
            return tc.ConvertFrom(value);
        }
    }
}
