using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuffCoJetReservation
{
    class Employee
    {
        private int ID;
        private string FName;
        private string LName;
        private string Email;
        private string PhoneNumber; //used string to allow formatting of (xxx) xxx-xxxx
        private string Username;
        private string Password;

        public Employee(){
        }

        public Employee(int _ID){
            ID = _ID;
        }

        public Employee(int _ID, string _FName, string _LName, string _Email, string _PhoneNumber, string _Username, string _Password){

        }


    }
}
