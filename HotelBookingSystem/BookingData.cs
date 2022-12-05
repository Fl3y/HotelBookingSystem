using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace HotelBookingSystem
{
    public class BookingData
    {
        string conStr = @"Server=127.0.0.1;userid=root;database=hotelsystem";
        List<string> orderLastNames = new List<string>();
        List<string> ArivalDates = new List<string>();
        List<string> LeavingDates = new List<string>();
        List<bool> hasPayed = new List<bool>();
        public BookingData() 
        {
            using var con = new MySqlConnection(conStr);
            con.Open();
            string sql = "SELECT * FROM orders";
            using var cmd = new MySqlCommand(sql, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                orderLastNames.Add(rdr.GetString(0));
                ArivalDates.Add(rdr.GetString(2));
                LeavingDates.Add(rdr.GetString(3));
                hasPayed.Add(rdr.GetBoolean(4));
            }
            for (int i = 0; i < orderLastNames.Count; i++ ) {
                Console.WriteLine(orderLastNames[i]);
                Console.WriteLine(ArivalDates[i]);
                Console.WriteLine(LeavingDates[i]);
                Console.WriteLine(hasPayed[i]);
            }
        }

    }
}
