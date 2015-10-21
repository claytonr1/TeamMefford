using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RuffCoJetReservationSystem.DBHandlers
{
    public static class DBEmployees
    {
        static RuffCoDataSet.employeesDataTable employees = new RuffCoDataSet.employeesDataTable();

        public static int getIDByName(string firstName, string lastName)
        {
            try
            {
                string expression = string.Format("f_name = '{0}' AND l_name = '{1}'", firstName, lastName);
                DataRow[] result = DBHandler.ruffCoDB.Tables["employees"].Select(expression);
                int id = Convert.ToInt32(result[0]["employee_id"]);
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
                string expression = string.Format("username = '{0}'", username);
                DataRow[] result = DBHandler.ruffCoDB.Tables["employees"].Select(expression);
                int id = Convert.ToInt32(result[0]["employee_id"]);
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
                DataRow[] result = DBHandler.ruffCoDB.Tables["employees"].Select(expression);
                int id = Convert.ToInt32(result[0]["employee_id"]);
                return id;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static bool containsUsername(string username)
        {
            try
            {
                string expression = string.Format("user_name = '{0}'", username);
                DataRow[] result = DBHandler.ruffCoDB.Tables["employees"].Select(expression);

                if (Convert.ToString(result[0]["user_name"]) == (username))
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

        public static bool containsEmail(string email)
        {
            try
            {
                string expression = string.Format("email = '{0}'", email);
                DataRow[] result = DBHandler.ruffCoDB.Tables["employees"].Select(expression);

                if (Convert.ToString(result[0]["email"]) == (email))
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

        public static string getUserName(int id)
        {
            try
            {
                string expression = string.Format("employee_id = {0}", id);
                DataRow[] result = DBHandler.ruffCoDB.Tables["employees"].Select(expression);
                String username = Convert.ToString(result[0]["user_name"]);
                return username;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string getUserName(string email)
        {
            try
            {
                string expression = string.Format("email = '{0}'", email);
                DataRow[] result = DBHandler.ruffCoDB.Tables["employees"].Select(expression);
                String username = Convert.ToString(result[0]["user_name"]);
                return username;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string getPassword(string username)
        {
            try
            {
                string expression = string.Format("username = '{0}'", username);
                DataRow[] result = DBHandler.ruffCoDB.Tables["employees"].Select(expression);
                string password = Convert.ToString(result[0]["password"]);
                return password;
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
                string expression = string.Format("employee_id = {0}", id);
                DataRow[] result = DBHandler.ruffCoDB.Tables["employees"].Select(expression);
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
                DataRow[] result = DBHandler.ruffCoDB.Tables["employees"].Select(expression);
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
                string expression = string.Format("employee_id = {0}", id);
                DataRow[] result = DBHandler.ruffCoDB.Tables["employees"].Select(expression);
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
                DataRow[] result = DBHandler.ruffCoDB.Tables["employees"].Select(expression);
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
                string expression = string.Format("employee_id = {0}", id);
                DataRow[] result = DBHandler.ruffCoDB.Tables["employees"].Select(expression);
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
                string expression = string.Format("employee_id = {0}", id);
                DataRow[] result = DBHandler.ruffCoDB.Tables["employees"].Select(expression);
                String phone = Convert.ToString(result[0]["phone"]);
                return phone;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool registerEmployee(string firstName, string lastName, string email, string phone, string username, string password)
        {
            try
            {
                DataRow newRow = DBHandler.ruffCoDB.Tables["employees"].NewRow();

                newRow["f_name"] = firstName;
                newRow["l_name"] = lastName;
                newRow["email"] = email;
                newRow["phone"] = phone;
                newRow["user_name"] = username;
                newRow["password"] = password;

                DBHandler.ruffCoDB.Tables["employees"].Rows.Add(newRow);
                updateEmployees();

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

        public static bool setUsername()
        {
            return false;
        }

        public static bool setPassword()
        {
            return false;
        }

        public static bool updateEmployees()
        {
            return DBHandler.updateEmployees();
        }
    }
}
