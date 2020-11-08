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
            manageHotel.addHotel("LakeWood", 3,110,90, "Regular");
            manageHotel.addHotel("Bridgewood",4, 160,60, "Regular");
            manageHotel.addHotel("RidgeWood", 5,220,150, "Regular");
            manageHotel.cheapestHotel(DateTime.Parse("14/03/2020"), DateTime.Parse("16/03/2020"));

        }
    }
}
