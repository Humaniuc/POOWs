using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray64
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray64 simpleArray = new BitArray64();
            foreach(var i in simpleArray)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
