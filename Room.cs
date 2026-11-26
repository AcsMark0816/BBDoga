using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager
{
    public abstract class Room
    {
        private int _number;
        private int _basePrice;
        private bool _occupied;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        public int BasePrice
        {
            get { return _basePrice; }
            set { _basePrice = value; }
        }
        public bool Occupied
        {
            get { return _occupied; }
            set { _occupied = value; }
        }

        protected int AddTax(int basePrice)
        {
            return basePrice * basePrice * 4 / 100;
        }
        public abstract int PricePerNight();
        
        public virtual string Describe()
        {
            return $"Room number: {_number}, Base price:{PricePerNight}, Occupied: {_occupied}";
        }

        public Room(int number,int basePrice)
        {
            _number = number;
            _basePrice = basePrice;
            _occupied = false;
        }
        
        

      
    }
    
}
