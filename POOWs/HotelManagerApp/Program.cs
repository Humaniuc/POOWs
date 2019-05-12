using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerApp
{
    class Program
    {
        static void Main()
        {
            Rate r = new Rate(500, "Ron");

            r.Print();
        }
    }
}
