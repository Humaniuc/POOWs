namespace HotelManagerApp
{
    class Room
    {
        private uint roomNumber;
        private uint adultsNumber;
        private uint childrenNumber;
        private Rate rate;

        internal Room(uint roomNum, Rate rate)
        {
            roomNumber = roomNum;
            this.rate = rate;
        }

        internal Room(uint roomNum, uint adultsNum, uint childrenNum, Rate rate) : this(roomNum, rate)
        {
            roomNumber = roomNum;
            adultsNumber = adultsNum;
            childrenNumber = childrenNum;
            this.Rate = rate;
        }
        internal uint RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }
        internal uint AdultsNumber
        {
            get { return adultsNumber; }
            set { adultsNumber = value; }
        }
        internal uint ChildrenNumber
        {
            get { return childrenNumber; }
            set { childrenNumber = value; }
        }
        internal Rate Rate { get; set; }

        internal double GetPriceFOrDays(uint numDays)
        {
            return numDays * rate.Amount;
        }
        internal void Print()
        {
            System.Console.WriteLine($"Room {roomNumber} with {adultsNumber} adults, {childrenNumber} children at price {rate.Amount} {rate.Currency}");
        }
    }
}
