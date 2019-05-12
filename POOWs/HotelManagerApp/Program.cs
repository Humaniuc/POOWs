using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerApp
{
    partial class Program
    {
        static void Main()
        {
            Hotel h1 = new Hotel("Hotel 1", "Iasi");
            Rate rate = new Rate(15.6, "Euro");
            Room r1 = new Room(1, rate);
            r1.AdultsNumber = 2;
            r1.ChildrenNumber = 1;
            h1.Rooms.Add(r1);
            rate.Amount = 18;
            Room r2 = new Room(2, rate);
            r2.AdultsNumber = 2;
            r2.ChildrenNumber = 2;
            h1.Rooms.Add(r2);

            h1.Print();
        }
    }
}
