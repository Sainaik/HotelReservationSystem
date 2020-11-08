using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public class Hotel
    {

        public string HotelName { get; set; }
        public double Rating { get; set; } 
        public double Rate { get; set; } 
        public string CustomerType { get; set; }


        public Hotel()
        {

        }
        public Hotel(string name, double rating, double rate)
        {
            this.HotelName = name;
            this.rate = rate;
            this.rating = rating;
        }
    }
}
