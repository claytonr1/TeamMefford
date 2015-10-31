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
        /// <summary>
        /// Returns a list of Tuples for each employee that contains ID, first name, and last name.
        /// </summary>
        /// <returns></returns>
        public static List<Tuple<int, string, string>> emplyeeList()
        {
            try
            {
                List<Tuple<int, string, string>> empList = new List<Tuple<int,string,string>>();
                DataRow[] result = DBHandler.ruffCoDB.Tables["employees"].Select();

                for (int i = 0; i < result.Length; i++)
                {
                    Tuple<int, string, string> empRow = new Tuple<int, string, string>(Convert.ToInt32(result[i]["employee_id"]), Convert.ToString(result[i]["f_name"]), Convert.ToString(result[i]["l_name"]));
                    empList.Add(empRow);
                }
                return empList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the identifier by using first and last name. Not reliable.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the identifier by username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the identifier from email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Determines whether the specified username is in use.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Determines whether the specified email is in use.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the username.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the username associated with the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the password for the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the first name associated with the specified ID.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the first name associated with the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the last name associated with the specified ID.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the last name associated with the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the email associated with the specified ID.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the phone associated with the specified ID.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Registers a new employee in the database. Does not check for unique values, will retun false if the command does not complete.
        /// </summary>
        /// <param name="firstName">first name.</param>
        /// <param name="lastName">last name.</param>
        /// <param name="email">email.</param>
        /// <param name="phone">phone number.</param>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        /// <returns></returns>
        public static bool registerEmployee(string firstName, string lastName, string email, string phone, string username, string password)
        {
            return DBHandler.registerEmployee(firstName, lastName, email, phone, username, password);
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

        public static void loadEmployees()
        {
            DBHandler.loadEmployees();
        }
    }
}
