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
                return matr[row, col];
            }
            set
            {
                matr[row, col] = value;
            }
        }

        public void Print()
        {
            for(int i = 0; i < this.Rows; i++)
            {
                for(int j = 0; j < this.Colls; j++)
                {
                    Console.Write($"{this[i, j]}\t");
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
                    try
                    {
                        Console.Write($"Matr[{i},{j}]= ");
                        this[i, j] = ChangeType<T>(Console.ReadLine());
                    }
                    catch (NotFiniteNumberException e)
                    {
                        Console.WriteLine(e.Message);
                    }                    
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

        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if(matrix1.Rows != matrix2.Rows)
            {
                throw new NotPossibleOperationException("Matrix numbers of rows not eqaul");
            }
            if(matrix1.Colls != matrix2.Colls)
            {
                throw new NotPossibleOperationException("Matrix numbers of colls not eqaul");
            }

            Matrix<T> addMatrix = new Matrix<T>(matrix1.Rows, matrix1.Colls);


            for (int i = 0; i < addMatrix.Rows; i++)
            {
                for (int j = 0; j < addMatrix.Colls; j++)
                {
                    addMatrix[i, j] = (dynamic)matrix1[i, j] + (dynamic)matrix2[i, j];
                }
            }
            return addMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows)
            {
                throw new NotPossibleOperationException("Matrix numbers of rows not eqaul");
            }
            if (matrix1.Colls != matrix2.Colls)
            {
                throw new NotPossibleOperationException("Matrix numbers of colls not eqaul");
            }

            Matrix<T> diffMatrix = new Matrix<T>(matrix1.Rows, matrix1.Colls);

            for (int i = 0; i < diffMatrix.Rows; i++)
            {
                for (int j = 0; j < diffMatrix.Colls; j++)
                {
                    diffMatrix[i, j] = (dynamic)matrix1[i, j] - (dynamic)matrix2[i, j];
                }
            }
            return diffMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Colls)
            {
                throw new NotPossibleOperationException("Matrix1 numbers of rows not eqaul with matrix2 number of colls");
            }

            Matrix<T> prodMatrix = new Matrix<T>(matrix1.Rows, matrix2.Colls);

            for(int i = 0; i < matrix1.Rows; i++)
            {
                for(int j = 0; j < matrix2.Colls; j++)
                {
                    for(int k = 0; k < matrix1.Colls; k++)
                    {
                        prodMatrix[i, j] += (dynamic)matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            
            return prodMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for(int i = 0; i < matrix.Rows; i++)
            {
                for(int j = 0; j < matrix.Colls; j++)
                {
                    if(!matrix[i,j].Equals(0))
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Colls; j++)
                {
                    if (matrix[i, j].Equals(0))
                    {
                        continue;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
