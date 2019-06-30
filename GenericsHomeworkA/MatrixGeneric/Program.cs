using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = Helpers.ReadInteger("Matrix1: Write number of rows: ");
            int colls = Helpers.ReadInteger("Matrix1: Write number of colls: ");
            Matrix<int> matr1 = new Matrix<int>(new int[rows, colls]);
            matr1.ReadMatrix();

            rows = Helpers.ReadInteger("Matrix2: Write number of rows: ");
            colls = Helpers.ReadInteger("Matrix2: Write number of colls: ");
            Matrix<int> matr2 = new Matrix<int>(rows, colls);
            matr2.ReadMatrix();

            System.Console.WriteLine("Matrix1: ");
            matr1.Print();
            System.Console.WriteLine("Matrix2: ");
            matr2.Print();

            System.Console.WriteLine("Add Matrix: ");
            try
            {
                Matrix<int> addMatr = matr1 + matr2;
                addMatr.Print();
            }
            catch (NotPossibleOperationException e)
            {
                System.Console.WriteLine(e.Message);
            }

            System.Console.WriteLine("Diff Matrix: ");
            try
            {
                Matrix<int> diffMatr = matr1 - matr2;
                diffMatr.Print();
            }
            catch (NotPossibleOperationException e)
            {
                System.Console.WriteLine(e.Message);
            }

            System.Console.WriteLine("Product Matrix: ");
            try
            {
                Matrix<int> prodMatrix = matr1 * matr2;
                prodMatrix.Print();
            }
            catch (NotPossibleOperationException e)
            {
                System.Console.WriteLine(e.Message);
            }

            if(matr1)
            {
                System.Console.WriteLine("Matrix with non zero elements");
            }
            else
            {
                System.Console.WriteLine("Matrix with zero elements");
            }
        }


    }
}
