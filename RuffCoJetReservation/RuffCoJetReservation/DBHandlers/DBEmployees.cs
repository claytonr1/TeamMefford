using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RuffCoJetReservation.DBHandlers
{
    static class DBEmployees
    {
        public static int getIDByName(string firstName, string lastName)
        {
            try
            {
                string expression = string.Format("f_name = {0} AND l_name = {1}", firstName, lastName);
                DataRow[] result = DBHandler.ruffCoDB.Tables["employees"].Select(expression);
                int id = Convert.ToInt32(result[0][0]);
                return id;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static int getIDByUsername(string username)
        {
            try
            {
                string expression = string.Format("username = {0}", username);
                DataRow[] result = DBHandler.ruffCoDB.Tables["employees"].Select(expression);
                int id = Convert.ToInt32(result[0][0]);
                return id;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static int getID(string email)
        {
            try
            {
                string expression = string.Format("email = {0}", email);
                DataRow[] result = DBHandler.ruffCoDB.Tables["employees"].Select(expression);
                int id = Convert.ToInt32(result[0][0]);
                return id;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static bool containsUsername(string username)
        {
            return false;
        }

        public static bool containsEmail(string email)
        {
            return false;
        }

        public static string getUserName(int id)
        {
            return null;
        }

        public static string getUserName(string email)
        {
            return null;
        }

        public static string getPassword(string username)
        {
            return null;
        }

        public static string getFName(int id)
        {
            return null;
        }

        public static string getFName(string email)
        {
            return null;
        }

        public static string getLName(string email)
        {
            return null;
        }

        public static string getEmail(int id)
        {
            return null;
        }

        public static string getPhone(int id)
        {
            return null;
        }

        public static bool registerEmployee(string firstName, string lastName, string email, string phone, string username, string password)
        {
            return false;
        }

        public static bool setFName()
        {
            return false;
        }

        public static bool setLName()
        {
            return false;
        }

        public static bool setEmail()
        {
            return false;
        }

        public static bool setPhone()
        {
            return false;
        }

        public static bool setUsername()
        {
            return false;
        }

        public static bool setPassword()
        {
            return false;
        }
    }
}
