using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    public class CheckInCheckOut
    {
        public string? decider;
        private string? name;
        public CheckInCheckOut() 
        {
            Console.WriteLine("Check in and Check out Loaded");
            Console.WriteLine("Please select \n1: Check in a new visitor \n2: Check out a visitor");
            decider = Console.ReadLine();

            if(decider != null)
            {
                if(decider == "1")
                {
                    CheckIn();
                }
                else if(decider == "2") 
                {

                }
                else
                {

                }
            }
        }

        public void CheckIn()
        {
            Console.WriteLine("Please enter the last name of the Person who ordered");
            name = Console.ReadLine();
            string connectionString = @"Server=127.0.0.1;userid=root;database=hotelsystem";
            using var con = new MySqlConnection(connectionString);
            con.Open();

            string sql = "SELECT * FROM orders";
            using var cmd = new MySqlCommand(sql, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();
            
            while(rdr.Read())
            {
                if (rdr.GetString(0).Contains(name))
                {
                    
                    CheckInFound();
                }
            }
            

        }

        private void CheckInFound()
        {
            
            Console.WriteLine("An Order has been found for that name");
            Console.WriteLine("Please check if the order is correct");

            string connectionString = @"Server=127.0.0.1;userid=root;database=hotelsystem";

            using var con = new MySqlConnection(connectionString);
            con.Open();

            string sql = $"SELECT * FROM orders WHERE lastName = \"{name}\" ";

            using var cmd = new MySqlCommand(sql, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                Console.WriteLine("last Name" + rdr.GetString(0));
                Console.WriteLine("First Name" + rdr.GetString(1));
                Console.WriteLine("Date of Arrival: " + rdr.GetString(2));
                Console.WriteLine("Date of Leaving: " +rdr.GetString(3));
                Console.WriteLine("Customer hast payed?: " +rdr.GetBoolean(4));
                Console.WriteLine("Room Class: " + rdr.GetString(5));
                con.Close();
            }
            
            Console.WriteLine("If everything is correct please respond with y to get redirected to the Roomsystem");
            string ddecider; 
            ddecider= Console.ReadLine();

            if (ddecider == "y")
            {
                new RoomSystem(name);
            }
            
            

        }
    }
}
