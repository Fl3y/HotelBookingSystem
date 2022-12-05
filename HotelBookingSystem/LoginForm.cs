using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HotelBookingSystem
{
    internal class LoginForm
    {
        public LoginForm()
        {
            Console.WriteLine("Please enter your Username");
            string? userName = Console.ReadLine();
            Console.WriteLine("Please enter your Password");
            string? passWord = Console.ReadLine();
            Console.WriteLine("Logging in, please wait");
            Login(userName, passWord);
        }

        private void Login(string? userName, string? passWord)
        {
            string connectionString = @"Server=127.0.0.1;userid=root;database=hotelsystem";
            using var con = new MySqlConnection(connectionString);
            con.Open();

            string sql = "SELECT * FROM employees";
            using var cmd = new MySqlCommand(sql, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            
            if(rdr.GetString(4).Contains(userName) && rdr.GetString(5).Contains(passWord) && userName != null && passWord != null){
                Console.WriteLine($"Welcome {userName}");
                con.Close();
                new HotelPanel();
            }
        }
    }
}
