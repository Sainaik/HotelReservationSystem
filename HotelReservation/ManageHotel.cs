using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HotelReservation
{
    public class ManageHotel
    {
        Dictionary<string, Hotel> hotelDictionary = new Dictionary<string, Hotel>();
        public void addHotel(string hotelName, double rating, double weekDayRate, double weekEndRate, string customerType)
        {
            Hotel hotel = new Hotel();
            hotel.HotelName = hotelName;
            hotel.Rating = rating;
            hotel.WeekDayRate = weekDayRate;
            hotel.WeekEndRate = weekEndRate;
            hotel.CustomerType = customerType;
            Console.WriteLine($"Hotel {hotelName} added  successfully");
            hotelDictionary.Add(hotelName, hotel);
        }


        public void cheapestHotel(DateTime checkInDate, DateTime checkOutDate)
        {

            Dictionary<Hotel, double> mapHotelToTotalRate = new Dictionary<Hotel, double>();

            foreach (Hotel hotel in hotelDictionary.Values)
            {
                double hotelRate = 0;
                DateTime dateIterator = checkInDate;

                while (checkOutDate >= dateIterator)
                {
                    string day = dateIterator.DayOfWeek.ToString();

                    hotelRate += (day.Equals("Saturday")) ? hotel.WeekEndRate : hotel.WeekDayRate;

                    dateIterator = dateIterator.AddDays(1);
                }

                mapHotelToTotalRate.Add(hotel, hotelRate);
            }

            var minValue = mapHotelToTotalRate.Values.Min();


            var records = from hotel in mapHotelToTotalRate
                          where hotel.Value == minValue
                          orderby hotel.Key.Rating descending
                          select hotel;

            Console.WriteLine("\nAvailable Cheap Hotels : ");
            foreach (var record in records.Take(1))
            {
                Console.WriteLine("\nHotel: " + record.Key.HotelName + "\n  -->Rating: " + record.Key.Rating + "\n  -->Total Rate: " + mapHotelToTotalRate[record.Key]);
            }
        }



    }
}





