using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager
{
    public class DoubleRoom : Room
    {
        private bool _hasBalcony;
        public bool HasBalcony
        {
            get { return _hasBalcony; }
            set { _hasBalcony = value; }
        }
        public DoubleRoom(int number, int basePrice, bool hasBalcony) : base(number, basePrice)
        {
            _hasBalcony = hasBalcony;
        }
        public override int PricePerNight()
        {
            int price = BasePrice + AddTax(BasePrice);
            if (_hasBalcony == true)
            {
                price += 5000; 
            }
            return price;
        }

        public int CleaningMin()
        {
            if(_hasBalcony == true)
            {
                return 40;
            }
            else
            {
                return 30;
            }
            ;
        }

    }
}
