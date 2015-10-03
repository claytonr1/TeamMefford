using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RuffCoJetReservation.DBHandlers
{
    static class DBHandler
    {
        private static SqlConnection sql;
        private static SqlDataAdapter adapter;
        private static SqlDataReader reader;

        public static DataSet ruffCoDB = new DataSet();

        //creates connection to the database. requires connection string
        public static void openConection(string connectionString)
        {
            try
            {
                sql = new SqlConnection(connectionString);
                sql.Open();
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        //closes the open connection
        public static void closeConnection()
        {
            try
            {
                sql.Close();
                sql.Dispose();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //calls loading methods and creates relations
        public static void populateDataSet()
        {
            //deletes current data if any to repopulate
            ruffCoDB.Clear();

            loadDestinations();
            loadEmployees();
            loadPlanes();
            loadGuests();
            loadReservations();

            //relations
            ruffCoDB.Relations.Add(ruffCoDB.Tables["employees"].Columns["employee_id"], ruffCoDB.Tables["guests"].Columns["empoyee_id"]);
            ruffCoDB.Relations.Add(ruffCoDB.Tables["reservations"].Columns["employee_id"], ruffCoDB.Tables["employees"].Columns["empoyee_id"]);
            ruffCoDB.Relations.Add(ruffCoDB.Tables["reservations"].Columns["reservations_id"], ruffCoDB.Tables["ReservationsGuestsXRef"].Columns["reservations_id"]);
            ruffCoDB.Relations.Add(ruffCoDB.Tables["guests"].Columns["guest_id"], ruffCoDB.Tables["ReservationsGuestsXRef"].Columns["guest_id"]);
            ruffCoDB.Relations.Add(ruffCoDB.Tables["planes"].Columns["plane_id"], ruffCoDB.Tables["reservations"].Columns["plane_id"]);

        }

        public static void loadPlanes()
        {
            try
            {
                if (ruffCoDB.Tables.Contains("planes"))
                {
                    ruffCoDB.Tables.Remove("planes");
                }
                string queryString = "SELECT * FROM planes";
                adapter = new SqlDataAdapter(queryString, sql);
                DataTable planes = new DataTable();

                ruffCoDB.Tables.Add(planes);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void loadEmployees()
        {
            try
            {
                if (ruffCoDB.Tables.Contains("employees"))
                {
                    ruffCoDB.Tables.Remove("employees");
                }
                string queryString = "SELECT * FROM employees";
                adapter = new SqlDataAdapter(queryString, sql);
                DataTable employees = new DataTable();

                adapter.Fill(employees);
                ruffCoDB.Tables.Add(employees);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void loadReservations()
        {
            try
            {
                if (ruffCoDB.Tables.Contains("reservations"))
                {
                    ruffCoDB.Tables.Remove("reservations");
                }
                string queryString = "SELECT * FROM reservations";
                adapter = new SqlDataAdapter(queryString, sql);
                DataTable reservations = new DataTable();

                adapter.Fill(reservations);
                ruffCoDB.Tables.Add(reservations);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void loadDestinations()
        {
            try
            {
                if (ruffCoDB.Tables.Contains("destinations"))
                {
                    ruffCoDB.Tables.Remove("destinations");
                }
                string queryString = "SELECT * FROM destinations";
                adapter = new SqlDataAdapter(queryString, sql);
                DataTable destinations = new DataTable();

                adapter.Fill(destinations);
                ruffCoDB.Tables.Add(destinations);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void loadGuests()
        {
            try
            {
                if (ruffCoDB.Tables.Contains("guests"))
                {
                    ruffCoDB.Tables.Remove("guests");
                }
                string queryString = "SELECT * FROM guests";
                adapter = new SqlDataAdapter(queryString, sql);
                DataTable guests = new DataTable();

                adapter.Fill(guests);
                ruffCoDB.Tables.Add(guests);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void loadReservationsGuestsXRef()
        {
            try
            {
                if (ruffCoDB.Tables.Contains("ReservationsGuestsXRef"))
                {
                    ruffCoDB.Tables.Remove("ReservationsGuestsXRef");
                }
                string queryString = "SELECT * FROM ReservationsGuestsXRef";
                adapter = new SqlDataAdapter(queryString, sql);
                DataTable ReservationsGuestsXRef = new DataTable();

                adapter.Fill(ReservationsGuestsXRef);
                ruffCoDB.Tables.Add(ReservationsGuestsXRef);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void updatePlanes()
        {
            try
            {
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void updateEmployees()
        {
            try
            {
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void updateReservations()
        {
            try
            {
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void updateDestinations()
        {
            try
            {
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void updateGuests()
        {
            try
            {
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void updateReservationsGuestsXRef()
        {
            try
            {
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
