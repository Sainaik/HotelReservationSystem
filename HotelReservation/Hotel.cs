using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public class Hotel
    {

        public string HotelName { get; set; }
        public double Rating { get; set; } 
        public double WeekDayRate { get; set; }
        public double WeekEndRate { get; set; }

        public string CustomerType { get; set; }


        public Hotel()
        {

        }
        public Hotel(string name, double rating, double weekDayRate, double weekendRate)
        {
            this.HotelName = name;
            this.WeekDayRate = weekDayRate;
            this.WeekEndRate = weekendRate;
            this.Rating = rating;
        }
    }
}
