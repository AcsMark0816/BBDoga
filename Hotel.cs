using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager
{
    public class Hotel
    {
        private List<Room> _rooms;
        private List<ICleanable> _cleaningList;

        public Hotel()
        {
            _rooms = new List<Room>();
            _cleaningList = new List<ICleanable>();
        }
        public void AddRoom(Room room)
        {
            _rooms.Add(room);
            
        }
        public void AddCleaning(ICleanable room)
        {
            _cleaningList.Add(room);
        }
        public int TotalIncomePerNight()
        {
            int TIncome = 0;
            foreach (Room room in _rooms)
            {
                TIncome += room.PricePerNight();
            }
            return TIncome;
        }

        public int TotalCleaningTime()
        {
            int TCleaningTime = 0;
            foreach(ICleanable i in _cleaningList)
            {
                TCleaningTime += i.CleaningMin();
            }
            return TCleaningTime;
           
        }
        public bool CheckIn(int number)
        {
            foreach(Room i in _rooms)
            {
                if (i.Number == number && i.Occupied == false)
                {
                    i.Occupied = true;
                    return true;
                }
            }
            return false;   
        }
    }
}
