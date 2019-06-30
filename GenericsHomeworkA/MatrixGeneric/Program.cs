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
            Matrix<int> matr = new Matrix<int>(new int[3, 4]);
            //matr.ReadMatrix(); 
            
            matr.Print();

        }


    }
}
