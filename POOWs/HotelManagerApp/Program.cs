using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerApp
{
    class Program
    {
        static void Main()
        {

        }
    }

    class Room
    {
        private uint roomNumber;
        private uint adultsNumber;
        private uint childrenNumber;
        private Rate rate;

        internal uint RoomNumber
        {
            get
            {
                return roomNumber;
            }
        }
    }
}
