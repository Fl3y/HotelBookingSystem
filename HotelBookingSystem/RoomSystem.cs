using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace HotelBookingSystem
{
    internal class RoomSystem
    {
        string conStr = @"Server=127.0.0.1;userid=root;database=hotelsystem";
        List<string> pickedRooms = new List<string>();

        public RoomSystem() 
        {
            PickRoom();
            
        }

        public void PickRoom()
        {
            Console.WriteLine("Please select your Room Class");
            Console.WriteLine("1: Standart");
            Console.WriteLine("2: Premium");
            string decider = Console.ReadLine();

            if(decider == "1")
            {
                using var con = new MySqlConnection(conStr);
                con.Open();
                string sql = "SELECT * FROM rooms";
                using var cmd = new MySqlCommand(sql, con);
                using MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) {
                    if (rdr.GetString(4) == "Standart") 
                    {
                        pickedRooms.Append(rdr.GetString(4));
                    }
                }
                foreach(string s in pickedRooms)
                {
                    Console.WriteLine(s);
                }
            }
;        }
    }
}
