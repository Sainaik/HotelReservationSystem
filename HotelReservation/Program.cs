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
            manageHotel.addHotel("LakeWood", 500, "Regular");

        }
    }
}
