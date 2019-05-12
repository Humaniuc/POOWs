using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerApp
{
    partial class Program
    {
        static void Main()
        {
            HotelManager hm = new HotelManager();

            Room r1 = new Room(1, 2, 1, new Rate(50.9, "Euro"));
            Room r2 = new Room(2, 2, 2, new Rate(68, "Ron"));
            Room r3 = new Room(3, 1, 3, new Rate(40, "Dollar"));
            Hotel h1 = new Hotel("Hotel 1", "Iasi", new System.Collections.Generic.List<Room>() { r1, r2, r3});
            hm.AddHotel(h1);
            r1 = new Room(1, 2, 1, new Rate(51.9, "Euro"));
            r2 = new Room(2, 2, 2, new Rate(70, "Ron"));
            r3 = new Room(3, 2, 1, new Rate(80, "Dollar"));
            Hotel h2 = new Hotel("Hotel 1", "Iasi", new System.Collections.Generic.List<Room>() { r1, r2, r3 });
            hm.AddHotel(h2);

            h1.Print();
            h2.Print();

            System.Console.WriteLine("Rooms lower than price:");
            hm.FindRoomsLowerThanPrice(60);

            System.Console.ReadLine();
        }
    }
}
