using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    internal class MainMenu
    {
        public bool wantLogIn = false;

        public MainMenu() 
        {
            Start();
        }

        private void Start()
        {
            Console.WriteLine("Welcome to the Booking System! \n How can we help you today?");

            Console.WriteLine("Press 1 to place a new Room Order");

            Console.WriteLine("Press 2 to login into the Hotel Panel");

            OrderOrLogin();


        }
        private string OrderOrLogin()
        {

            string? decider;

            decider = Console.ReadLine();

            if (decider == "1")
            {
                Console.WriteLine("new Room Order");
            }
            else if (decider == "2")
            {
                Console.WriteLine("Login");
                wantLogIn = true;
            }
            else if (decider != null && decider != "1" && decider != "2")
            {
                Console.WriteLine("Please enter one of the options available on your screen");
                OrderOrLogin();
            }
            if (decider == null)
            {
                Console.WriteLine("Please enter a valid Entry");
                OrderOrLogin();
            }

            return decider;
        }
    }
}
