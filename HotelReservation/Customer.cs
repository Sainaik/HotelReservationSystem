using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public enum CustomerType { regular, reward };
    public class Customer
    {
        public ManageHotel manageHotel;
        public Customer(CustomerType type)
        {
            manageHotel = new ManageHotel();
            if (type == CustomerType.regular)
            {
                Console.WriteLine("\nRegular :-\n");
                manageHotel.addHotel("Lakewood", 130, 90, 3);
                manageHotel.addHotel("Bridgewood", 160, 60, 4);
                manageHotel.addHotel("Ridgewood", 220, 150, 5);
            }
            else
            {
                Console.WriteLine("\nReward :-\n");
                manageHotel.addHotel("Lakewood", 80, 80, 3);
                manageHotel.addHotel("Bridgewood", 110, 50, 4);
                manageHotel.addHotel("Ridgewood", 100, 40, 5);
            }
        }
    }
}

