using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;

namespace HotelBookingSystem
{
    internal class BookingMenu
    {
        string forName;
        string lastName;
        string birthDate;
        string mailAdress;
        string phoneNumber;
        string street;
        string houseNumber;
        string town;
        string state;
        string country;
        string dateOfArival;
        string leavingDate;
        string decider;

        public BookingMenu()
        {
            Console.WriteLine("Welcome to the booking Menu");
            Console.WriteLine("Please fill out this form to place the order or cancel the order by writting cancel");
            NewOrder();
        }

        private void NewOrder()
        {
            Console.WriteLine("Please enter the Forname");
            forName = Console.ReadLine();
            Console.WriteLine("Please enter the Lastname");
            lastName = Console.ReadLine();
            Console.WriteLine("Please enter the birthdate");
            birthDate = Console.ReadLine();
            Console.WriteLine("Please enter the Mail-Adress");
            mailAdress = Console.ReadLine();
            Console.WriteLine("Please enter the phone number");
            phoneNumber = Console.ReadLine();
            Console.WriteLine("Please enter the street");
            street = Console.ReadLine();
            Console.WriteLine("Please enter House Number");
            houseNumber = Console.ReadLine();
            Console.WriteLine("Please enter the town");
            town = Console.ReadLine();
            Console.WriteLine("Please enter the state");
            state = Console.ReadLine();
            Console.WriteLine("Please enter the Country");
            country = Console.ReadLine();
            Console.WriteLine("Enter the date of Arival");
            dateOfArival = Console.ReadLine();
            Console.WriteLine("Please enter the date of Leaving");
            leavingDate = Console.ReadLine();
            Console.WriteLine("Please confirm the data is correct");
            Console.WriteLine($"Forname:{forName}, Lastname:{lastName}, Birthdate:{birthDate}");
            Console.WriteLine($"E-mail:{mailAdress}, Phone Number: {phoneNumber}");
            Console.WriteLine($"Street:{street}, Housenumber:{houseNumber}, Town:{town}");
            Console.WriteLine($"state:{state}, country:{country}");
            Console.WriteLine($"Date of arrival: {dateOfArival}, Leaving Date:{leavingDate}");
            Console.WriteLine("If everything is correct, please respond with y, else respond with n");
            decider = Console.ReadLine();
            Console.WriteLine(decider);

            if (decider == "y")
            {
                BookRoom(lastName);
            }
            if (decider == "n")
            {
                    NewOrder();
            }
            


        }

        public void BookRoom(string bookerName)
        {
            new RoomSystem(lastName);
        }

    }
}
