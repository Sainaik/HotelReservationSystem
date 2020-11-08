using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public class ManageHotel
    {
        Dictionary<string, Hotel> hotelDictionary = new Dictionary<string, Hotel>();
        public void addHotel(string hotelName, double weekDayRate, double weekEndRate, string customerType)
        {
            Hotel hotel = new Hotel();
            hotel.HotelName = hotelName;
            hotel.WeekDayRate = weekDayRate;
            hotel.WeekEndRate = weekEndRate;
            hotel.CustomerType = customerType;
            Console.WriteLine($"Hotel {hotelName} added  successfully");
            hotelDictionary.Add(hotelName, hotel);
        }


        public void cheapestHotel(DateTime date1, DateTime date2)
        {
            double minRate = 0;
            double hotelRate;
            int numberOfDays = (date2 - date1).Days;
            Hotel hotelWithMinimumRate = null;

            foreach (Hotel hotel in hotelDictionary.Values)
            {
                hotelRate = numberOfDays * hotel.WeekDayRate;
                if (minRate == 0 || minRate > hotelRate)
                {
                    minRate = hotelRate;
                    hotelWithMinimumRate = hotel;
                }
            }
            Console.WriteLine($"\nCheapest Hotel { hotelWithMinimumRate.HotelName} having Total Rate : {hotelWithMinimumRate.WeekDayRate * numberOfDays} ");
        }

    }
}





