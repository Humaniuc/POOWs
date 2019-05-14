using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            myStack ms = new myStack();

            ms.Push(15);
            ms.Push(10);
            ms.Push(18);
            ms.Push(7);
            ms.Push(6);
            ms.Push(23);
            ms.Print();
            ms.Pop();
            ms.Print();
        }
    }
}
