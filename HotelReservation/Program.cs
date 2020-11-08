using HotelReservation;
using System;

namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hotel Reservation System!");
            Customer customer = new Customer(CustomerType.regular);
            customer.manageHotel.cheapestHotel(DateTime.Parse("09/11/2020"), DateTime.Parse("09/12/2020"));
            customer.manageHotel.RatedHotel(DateTime.Parse("09/11/2020"), DateTime.Parse("09/12/2020"));

            Customer customer2 = new Customer(CustomerType.reward);
            customer2.manageHotel.cheapestHotel(DateTime.Parse("09/11/2020"), DateTime.Parse("09/12/2020"));
            customer2.manageHotel.RatedHotel(DateTime.Parse("09/11/2020"), DateTime.Parse("09/12/2020"));
        }
    }
}
