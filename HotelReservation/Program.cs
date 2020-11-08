using HotelReservation;
using System;

namespace HotelReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hotel Reservation System!");
            ManageHotel manageHotel = new ManageHotel();
            manageHotel.addHotel("LakeWood", 700,1000, "Regular");
            manageHotel.addHotel("Hollywood", 2000,2500, "Regular");
            manageHotel.addHotel("BeachWood", 1000,1500, "Regular");
            manageHotel.cheapestHotel(DateTime.Parse("14/03/2020"), DateTime.Parse("16/03/2020"));

        }
    }
}
