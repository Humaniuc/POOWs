using System.Collections.Generic;

namespace HotelManagerApp
{
    class Hotel
    {
        private string name;
        private string city;
        private List<Room> rooms;
        internal Hotel(string name, string city)
        {
            this.name = name;
            this.city = city;
        }
        internal Hotel(string name, string city, List<Room> rooms) : this(name, city)
        {
            this.rooms = rooms;
        }
        internal string Name
        {
            get { return name; }
            set { name = value; }
        }
        internal string City
        {
            get { return city; }
            set { city = value; }
        }

        internal List<Room> Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }

        internal void Print()
        {
            System.Console.WriteLine($"{name} from {city} has: ");
            foreach(Room r in rooms)
            {
                r.Print();
            }
        }
    }
}
