namespace HotelManager
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hotel Ize = new Hotel();
            Ize.AddRoom(new SingleRoom(101, 15000));
            Ize.AddRoom(new DoubleRoom(202, 22000,true));
            Ize.AddRoom(new DoubleRoom(201, 22000, false));
            Ize.AddRoom(new Suite(301, 20000, 3));

            
          
            
            
        }
    }
}
