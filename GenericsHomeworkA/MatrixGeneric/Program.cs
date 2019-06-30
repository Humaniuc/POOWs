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
            Matrix<int> addMatr = matr1 + matr2;
            addMatr.Print();

            System.Console.WriteLine("Diff Matrix: ");
            Matrix<int> diffMatr = matr1 - matr2;
            diffMatr.Print();

            System.Console.WriteLine("Product Matrix: ");
            Matrix<int> prodMatrix = matr1 * matr2;
            prodMatrix.Print();

            if(diffMatr)
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
