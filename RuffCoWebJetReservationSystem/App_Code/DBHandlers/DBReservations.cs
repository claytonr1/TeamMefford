﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RuffCoJetReservationSystem.DBHandlers
{
    public static class DBReservations
    {
        public static Dictionary<int, String> getReservationsList()
        {
            try
            {
                Dictionary<int, String> resList = new Dictionary<int, string>();
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

        public static bool RegisterReservation(int planeID, int employeeID, int destID, DateTime date)
        {
            try
            {
                DataRow newRow = DBHandler.ruffCoDB.Tables["reservations"].NewRow();

                newRow["plane_id"] = planeID;
                newRow["employee_id"] = employeeID;
                newRow["dest_id"] = destID;
                newRow["date"] = date;

                DBHandler.ruffCoDB.Tables["reservations"].Rows.Add(newRow);
                updateResDB();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool RegisterReservation(int planeID, int employeeID, int destID, DateTime date, bool hasGuests, List<int> guestList)
        {
            try
            {
                DataRow newRow = DBHandler.ruffCoDB.Tables["reservations"].NewRow();

                newRow["plane_id"] = planeID;
                newRow["employee_id"] = employeeID;
                newRow["dest_id"] = destID;
                newRow["date"] = date;

                DBHandler.ruffCoDB.Tables["reservations"].Rows.Add(newRow);
                updateResDB();
                
                if (hasGuests)
                {
                    if (guestList.Count != 0)
                    {
                        for (int i = 0; i < guestList.Count; i++)
                        {
                            addGuestXResRelation(Convert.ToInt32(newRow[0]), Convert.ToInt32(guestList[i]));
                        }
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
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

        public static bool addGuestXResRelation(int resID, int GuestID)
        {
            try
            {
                DataRow newRow = DBHandler.ruffCoDB.Tables["ReservationsGuestsXRef"].NewRow();

                newRow["reservation_id"] = resID;
                newRow["guest_id"] = GuestID;

                DBHandler.ruffCoDB.Tables["planes"].Rows.Add(newRow);

                updateGuestXResDB();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool updateGuestXResDB()
        {
            return DBHandler.updateReservationsGuestsXRef();
        }

        public static bool updateResDB()
        {
            return DBHandler.updateReservations();
        }
    }
}