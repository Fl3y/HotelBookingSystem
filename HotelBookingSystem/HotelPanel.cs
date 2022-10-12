using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    internal class HotelPanel
    {
        public HotelPanel()
        {
            Console.WriteLine("Welcome to the Hotelpanel");
            Console.WriteLine("Please select a number to proceed");
            Console.WriteLine("1: Enter a new Order");
            Console.WriteLine("2: Edit or delete an existing Order");
            Console.WriteLine("3: CheckIn or CheckOut");
            Console.WriteLine("4: Room system");
            Console.WriteLine("5: Admin Panel");
            Console.WriteLine("6: Log Out");
            string? decider = Console.ReadLine();
            Decider(decider);
        }

        void Decider(string? decider)
        {
            if(decider == "1")
            {
                new BookingMenu();
            }
            else if(decider == "2")
            {
                new BookingData();
            }
            else if(decider == "3")
            {
                new CheckInCheckOut();
            }
            else if(decider == "4")
            {
                new RoomSystem();
            }
            else if(decider == "5")
            {
                new AdminPanel();
            }
            else if (decider == "6")
            {
                new MainMenu();
            }
            else
            {
                Console.WriteLine("Please enter a valid Number");
                string? decide = Console.ReadLine();
                Decider(decide);
            }
        }

    }
}
