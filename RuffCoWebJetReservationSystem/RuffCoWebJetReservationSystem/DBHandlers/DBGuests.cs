using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RuffCoJetReservation.DBHandlers
{
    static class DBGuests
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

        public static string getFName(int id)
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

        public static bool registerGuest(string firstName, string lastName, string email, string phone, int employeeID)
        {
            try
            {
                DataRow newRow = DBHandler.ruffCoDB.Tables["guests"].NewRow();

                newRow["f_name"] = firstName;
                newRow["l_name"] = lastName;
                newRow["email"] = email;
                newRow["phone"] = phone;
                newRow["employee_id"] = employeeID;

                DBHandler.ruffCoDB.Tables["guests"].Rows.Add(newRow);
                updateGuests();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
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

        public static bool updateGuests()
        {
            return DBHandler.updateGuests();
        }
    }
}
