using System.Collections.Generic;

namespace HotelManagerApp
{
    class HotelManager
    {
        private List<Hotel> hotels = new List<Hotel>();

        internal void AddHotel(Hotel h)
        {
            hotels.Add(h);
        }
        internal void DeleteHotel(Hotel h)
        {
            hotels.Remove(h);
        }

        internal void FindRoomsLowerThanPrice(double priceLower)
        {
            foreach(Hotel h in hotels)
            {
                foreach(Room r in h.Rooms)
                {
                    if(priceLower > r.Rate.Amount)
                    {
                        r.Print();
                    }
                }
            }
        }
    }
}
