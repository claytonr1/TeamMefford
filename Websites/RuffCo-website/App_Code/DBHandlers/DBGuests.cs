using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RuffCoJetReservationSystem.DBHandlers
{
    public static class DBGuests
    {
        public static int getIDByName(string firstName, string lastName)
        {
            try
            {
                string expression = string.Format("f_name = '{0}' AND l_name = '{1}'", firstName, lastName);
                DataRow[] result = DBHandler.ruffCoDB.Tables["guests"].Select(expression);
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
                string expression = string.Format("email = '{0}'", email);
                DataRow[] result = DBHandler.ruffCoDB.Tables["guests"].Select(expression);
                int id = Convert.ToInt32(result[0][0]);
                return id;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static bool containsEmail(string email)
        {
            try
            {
                string expression = string.Format("email = '{0}'", email);
                DataRow[] result = DBHandler.ruffCoDB.Tables["guests"].Select(expression);

                if (Convert.ToString(result[0][3]) == (email))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string getFName(int id)
        {
            try
            {
                string expression = string.Format("employee_id = {0}", id);
                DataRow[] result = DBHandler.ruffCoDB.Tables["guests"].Select(expression);
                String name = Convert.ToString(result[0]["f_name"]);
                return name;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string getFName(string email)
        {
            try
            {
                string expression = string.Format("email = '{0}'", email);
                DataRow[] result = DBHandler.ruffCoDB.Tables["guests"].Select(expression);
                String name = Convert.ToString(result[0]["f_name"]);
                return name;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string getLName(int id)
        {
            try
            {
                string expression = string.Format("guest_id = {0}", id);
                DataRow[] result = DBHandler.ruffCoDB.Tables["guests"].Select(expression);
                String name = Convert.ToString(result[0]["l_name"]);
                return name;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string getLName(string email)
        {
            try
            {
                string expression = string.Format("email = '{0}'", email);
                DataRow[] result = DBHandler.ruffCoDB.Tables["guests"].Select(expression);
                String name = Convert.ToString(result[0]["l_name"]);
                return name;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string getEmail(int id)
        {
            try
            {
                string expression = string.Format("guest_id = {0}", id);
                DataRow[] result = DBHandler.ruffCoDB.Tables["guests"].Select(expression);
                String name = Convert.ToString(result[0]["f_name"]);
                return name;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string getPhone(int id)
        {
            try
            {
                string expression = string.Format("guest_id = {0}", id);
                DataRow[] result = DBHandler.ruffCoDB.Tables["guests"].Select(expression);
                String phone = Convert.ToString(result[0]["phone"]);
                return phone;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Registers a guest in the database. Does not check for unique values, will retun false if the command does not complete.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="email">The email.</param>
        /// <param name="phone">The phone.</param>
        /// <param name="employeeID">The employee identifier.</param>
        /// <returns></returns>
        public static bool registerGuest(string firstName, string lastName, string email, string phone, int employeeID)
        {
            return DBHandler.registerGuest(firstName, lastName, email, phone, employeeID);
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

        public static void updateGuestsDataTable()
        {
            DBHandler.loadGuests();
        }
    }
}
