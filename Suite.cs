using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager
{
    public class Suite : Room
    {
        private int _roomCount;
        public int RoomCount
        {
            get { return _roomCount; }
            set { _roomCount = value; }
        }
        public Suite(int number,int basePrice, int roomCount) : base(number, basePrice)
        {
            _roomCount = roomCount;
        }
        
        public override int PricePerNight()
        {
            BasePrice *= _roomCount;
            return BasePrice + AddTax(BasePrice);
        }
        public override string Describe()
        {
            return $"Room number: {Number}, Base price:{PricePerNight()}, Occupied: {Occupied}, Room count: {_roomCount}";
        }
        public int CleaningMin()
        {
            return 20 * _roomCount;
        }
    }
}
