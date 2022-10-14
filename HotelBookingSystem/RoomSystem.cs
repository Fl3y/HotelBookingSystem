using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HotelBookingSystem
{
    public class RoomSystem
    {
        string conStr = @"Server=127.0.0.1;userid=root;database=hotelsystem";
        string decider;
        string approved;
        string name;
        Random random = new Random();
        List<int> pickedRooms = new List<int>();

        public RoomSystem(string _name) 
        {
            name = _name;
            PickRoom();  
        }

        public void PickRoom()
        {
            Console.WriteLine("Please select your Room Class");
            Console.WriteLine("1: Standart");
            Console.WriteLine("2: Premium");
            decider = Console.ReadLine();

            if(decider == "1")
            {
                using var con = new MySqlConnection(conStr);
                con.Open();
                string sql = "SELECT * FROM rooms";
                using var cmd = new MySqlCommand(sql, con);
                using MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) {
                    if (rdr.GetString(3) == "Standart") 
                    {
                        pickedRooms.Add(rdr.GetInt32(5));
                    }
                }
                rdr.Close();
                int index = random.Next(pickedRooms.Count);
                Console.WriteLine($"Sie haben Zimmer:{pickedRooms[index]}");
                Console.WriteLine("Booking is Improved?(y/n)");
                approved = Console.ReadLine();

                if(approved == "y")
                {

                    sql = $"UPDATE rooms SET isOccupied=true, occupiedBy='{name}' WHERE ZimmerNr={pickedRooms[index]};";
                    using var cmd2 = new MySqlCommand(sql, con);
                    using MySqlDataReader rdr2 = cmd2.ExecuteReader();
                    while (rdr2.Read())
                    {
                        if(rdr.GetInt32(5) == pickedRooms[index])
                        {
                            Console.WriteLine("Your order has been created");
                        }
                    }
                }
            }
;        }
    }
}
