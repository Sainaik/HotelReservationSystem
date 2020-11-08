using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public class ManageHotel
    {
        public void addHotel(string hotelName, double rate, string customerType)
        {
            Hotel hotel = new Hotel();
            hotel.HotelName = hotelName;
            hotel.Rate = rate;
            hotel.CustomerType = customerType;
            Console.WriteLine("Hotel added successfully");
        }

    }
}





