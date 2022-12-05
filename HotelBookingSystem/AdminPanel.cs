using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    internal class AdminPanel
    {
        private string AdminPassword = "admin"; 
        
        public AdminPanel()
        {
            Console.WriteLine("Welcome to the Admin Panel");
            Console.WriteLine("Please enter the Admin Password");
            string userPassword = Console.ReadLine();

            if (userPassword == AdminPassword)
            {
                Admin();
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        void Admin()
        {
            
        }
    }
}
