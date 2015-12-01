using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RuffCoJetReservationSystem.DBHandlers
{
    public static class DBReservations
    {
        public static List<int> getReservationsList()
        {
            try
            {
                SortedDictionary<int, string> dictionary = new SortedDictionary<int, string>();
                dictionary = getReservationsDictionary();
                List<int> list = new List<int>();
                list = dictionary.Keys.ToList();
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static SortedDictionary<int, string> getReservationsDictionary()
        {
            try
            {
                SortedDictionary<int, string> resList = new SortedDictionary<int, string>();
                DataRow[] result = DBHandler.ruffCoDB.Tables["reservations"].Select();

                for (int i = 0; i < result.Length; i++)
                {
                    resList.Add(Convert.ToInt32(result[i]["reservation_id"]), Convert.ToString(result[i]["date"]));
                }
                return resList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static SortedDictionary<int, String> getPastReservationsList()
        {
            try
            {
                DateTime now = DateTime.Now;

                string expression = string.Format("date > '{0}'", now);
                SortedDictionary<int, String> resList = new SortedDictionary<int, string>();
                DataRow[] result = DBHandler.ruffCoDB.Tables["reservations"].Select();

                for (int i = 0; i < result.Length; i++)
                {
                    resList.Add(Convert.ToInt32(result[i]["reservation_id"]), Convert.ToString(result[i]["date"]));
                }
                return resList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static SortedDictionary<int, String> getFutureReservationsList()
        {
            try
            {
                DateTime now = DateTime.Now.Date;

                string expression = string.Format("date < '{0}'", now);
                SortedDictionary<int, String> resList = new SortedDictionary<int, string>();
                DataRow[] result = DBHandler.ruffCoDB.Tables["reservations"].Select();

                for (int i = 0; i < result.Length; i++)
                {
                    resList.Add(Convert.ToInt32(result[i]["reservation_id"]), Convert.ToString(result[i]["date"]));
                }
                return resList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<String> getReservationsByDate(DateTime date)
        {
            try
            {
                List<String> resList = new List<string>();
                string expression = string.Format("date = '{0}'", date);
                DataRow[] result = DBHandler.ruffCoDB.Tables["reservations"].Select(expression);

                for (int i = 0; i < result.Length; i++)
                {
                    resList.Add(Convert.ToString(result[i]["reservation_id"]));
                }
                return resList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<String> getReservationsByPlane(int plane_id)
        {
            try
            {
                List<String> resList = new List<string>();
                string expression = string.Format("plane_id = {0}", plane_id);
                DataRow[] result = DBHandler.ruffCoDB.Tables["reservations"].Select(expression);

                for (int i = 0; i < result.Length; i++)
                {
                    resList.Add(Convert.ToString(result[i]["reservation_id"]));
                }
                return resList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<String> getReservationsByEmployee(int employee_id)
        {
            try
            {
                List<String> resList = new List<string>();
                string expression = string.Format("employee_id = {0}", employee_id);
                DataRow[] result = DBHandler.ruffCoDB.Tables["reservations"].Select(expression);

                for (int i = 0; i < result.Length; i++)
                {
                    resList.Add(Convert.ToString(result[i]["reservation_id"]));
                }
                return resList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<String> getReservationsByEmployee(string employeeEmail)
        {
            try
            {
                List<String> resList = new List<string>();
                int employee_id = DBEmployees.getID(employeeEmail);
                string expression = string.Format("employee_id = {0}", employee_id);
                DataRow[] result = DBHandler.ruffCoDB.Tables["reservations"].Select(expression);

                for (int i = 0; i < result.Length; i++)
                {
                    resList.Add(Convert.ToString(result[i]["reservation_id"]));
                }
                return resList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<String> getReservationsByDestination(int dest_id)
        {
            try
            {
                List<String> resList = new List<string>();
                string expression = string.Format("dest_id = {0}", dest_id);
                DataRow[] result = DBHandler.ruffCoDB.Tables["reservations"].Select(expression);

                for (int i = 0; i < result.Length; i++)
                {
                    resList.Add(Convert.ToString(result[i]["reservation_id"]));
                }
                return resList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<String> getGuests(int reservationID)
        {
            try
            {
                List<String> guestList = new List<string>();
                string expression = string.Format("reservation_id = {0}", reservationID);
                DataRow[] result = DBHandler.ruffCoDB.Tables["ReservationsGuestsXRef"].Select(expression);

                for (int i = 0; i < result.Length; i++)
                {
                    guestList.Add(Convert.ToString(result[i]["guest_id"]));
                }
                return guestList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static int getEmployee(int reservation_id)
        {
            string expression = string.Format("reservation_id = {0}", reservation_id);
            DataRow[] result = DBHandler.ruffCoDB.Tables["reservations"].Select(expression);
            int emplyeeID = Convert.ToInt32(result[0]["employee_id"]);

            return emplyeeID;
        }

        public static int getPlane(int reservation_id)
        {
            string expression = string.Format("reservation_id = {0}", reservation_id);
            DataRow[] result = DBHandler.ruffCoDB.Tables["reservations"].Select(expression);
            int planeID = Convert.ToInt32(result[0]["plane_id"]);

            return planeID;
        }

        public static int getDestination(int reservation_id)
        {
            string expression = string.Format("reservation_id = {0}", reservation_id);
            DataRow[] result = DBHandler.ruffCoDB.Tables["reservations"].Select(expression);
            int destID = Convert.ToInt32(result[0]["dest_id"]);

            return destID;
        }

        public static DateTime getDate(int reservation_id)
        {
            string expression = string.Format("reservation_id = {0}", reservation_id);
            DataRow[] result = DBHandler.ruffCoDB.Tables["reservations"].Select(expression);
            DateTime date = Convert.ToDateTime(result[0]["date"]);

            return date;
        }

        /// <summary>
        /// Registers a reservation without guests. Does not check for unique values, will retun false if the command does not complete.
        /// </summary>
        /// <param name="planeID">The plane identifier.</param>
        /// <param name="employeeID">The employee identifier.</param>
        /// <param name="destinationID">The destination identifier.</param>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public static bool RegisterReservation(int planeID, int employeeID, int destID, DateTime date)
        {
            return DBHandler.registerReservation(planeID, employeeID, destID, date);
        }

        /// <summary>
        /// Registers a reservation with or without guests. Does not check for unique values, will retun false if the command does not complete.
        /// </summary>
        /// <param name="planeID">The plane identifier.</param>
        /// <param name="employeeID">The employee identifier.</param>
        /// <param name="destinationID">The destination identifier.</param>
        /// <param name="date">The date.</param>
        /// <param name="hasGuests">if set to <c>true</c> [has guests].</param>
        /// <param name="guestsList">The guest's identifier list.</param>
        /// <returns></returns>
        public static bool RegisterReservation(int planeID, int employeeID, int destID, DateTime date, bool hasGuests, List<int> guestList)
        {
            return DBHandler.registerReservation(planeID, employeeID, destID, date, hasGuests, guestList);
        }

        public static bool setPlane(int reservationID, int planeID)
        {
            return false;
        }

        public static bool setEmployee(int reservationID, int employeeID)
        {
            return false;
        }

        public static bool setDestination(int reservationID, int destID)
        {
            return false;
        }

        public static bool setDate(int reservationID, DateTime date)
        {
            return false;
        }

        public static void updateGuestXResDataTable()
        {
            DBHandler.loadReservationsGuestsXRef();
        }

        public static void updateResDataTable()
        {
            DBHandler.loadReservations();
        }

        /// <summary>
        /// Clears the database table. Returns False if the command did not complete.
        /// </summary>
        /// <returns></returns>
        public static bool clearDB()
        {
            return DBHandler.clearDataTables(DBHandler.RESERVATIONS_TABLE);
        }
    }
}
