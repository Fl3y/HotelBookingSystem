using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    public class Program
    {
        public static void Main(String[] args)
        {
            MainMenu mm = new MainMenu();
            if(mm.wantLogIn == true)
            {
                new LoginForm();
            }
        }
    }
}