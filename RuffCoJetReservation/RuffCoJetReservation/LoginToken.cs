using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuffCoJetReservation
{
    class LoginToken
    {
        public static string Username { get; set; }
        public static string Password { get; set; }



        public static void Login(string _Username, string _Password){

            Username = _Username;
            Password = _Password;

        }

        public string GetUsername() {
            return Username;
        }
    }
}
