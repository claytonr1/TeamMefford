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
        public const string EMPLOYEES_TABLE = "RuffCoEmployees";
        public const string PLANES_TABLE = "RuffCoPlanes";
        public const string RESERVATIONS_TABLE = "RuffCoReservations";
        public const string DESTINATIONS_TABLE = "RuffCoDestinations";
        public const string GUESTS_TABLE = "RuffCoGuests";
        public const string GUESTS_X_DEST_TABLE = "RuffCoReservationGuestXRef";

        private static SqlConnection sql;
        private static SqlDataAdapter adapter = new SqlDataAdapter();
        private static SqlDataReader reader;
        private static SqlCommand cmd;

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

            //load the data in appropriate orders
            loadPlanes(0);
            loadEmployees(1);
            loadDestinations(2);
            loadGuests(3);
            loadReservations(4);
            loadReservationsGuestsXRef(5);

            //relations
            ruffCoDB.Relations.Add(ruffCoDB.Tables["employees"].Columns["employee_id"], ruffCoDB.Tables["guests"].Columns["empoyee_id"]);
            ruffCoDB.Relations.Add(ruffCoDB.Tables["reservations"].Columns["employee_id"], ruffCoDB.Tables["employees"].Columns["empoyee_id"]);
            ruffCoDB.Relations.Add(ruffCoDB.Tables["reservations"].Columns["reservations_id"], ruffCoDB.Tables["ReservationsGuestsXRef"].Columns["reservations_id"]);
            ruffCoDB.Relations.Add(ruffCoDB.Tables["guests"].Columns["guest_id"], ruffCoDB.Tables["ReservationsGuestsXRef"].Columns["guest_id"]);
            ruffCoDB.Relations.Add(ruffCoDB.Tables["planes"].Columns["plane_id"], ruffCoDB.Tables["reservations"].Columns["plane_id"]);
            ruffCoDB.Relations.Add(ruffCoDB.Tables["reservations"].Columns["dest_id"], ruffCoDB.Tables["destinations"].Columns["dest_id"]);

        }

        public static void loadPlanes(int index)
        {
            try
            {
                if (ruffCoDB.Tables.Contains("planes"))
                {
                    ruffCoDB.Tables.Remove("planes");
                }
                cmd = new SqlCommand("SELECT * FROM " + PLANES_TABLE, sql);
                adapter.SelectCommand = cmd;
                DataTable planes = new DataTable();

                adapter.Fill(planes);
                ruffCoDB.Tables.Add(planes);
                ruffCoDB.Tables[index].TableName = "planes";
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public static void loadEmployees(int index)
        {
            try
            {
                if (ruffCoDB.Tables.Contains("employees"))
                {
                    ruffCoDB.Tables.Remove("employees");
                }
                cmd = new SqlCommand("SELECT * FROM " + EMPLOYEES_TABLE, sql);
                adapter.SelectCommand = cmd;
                DataTable employees = new DataTable();

                adapter.Fill(employees);
                ruffCoDB.Tables.Add(employees);
                ruffCoDB.Tables[index].TableName = "employees";
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public static void loadDestinations(int index)
        {
            try
            {
                if (ruffCoDB.Tables.Contains("destinations"))
                {
                    ruffCoDB.Tables.Remove("destinations");
                }
                cmd = new SqlCommand("SELECT * FROM " + DESTINATIONS_TABLE, sql);
                adapter.SelectCommand = cmd;
                DataTable destinations = new DataTable();

                adapter.Fill(destinations);
                ruffCoDB.Tables.Add(destinations);
                ruffCoDB.Tables[index].TableName = "destinations";
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public static void loadGuests(int index)
        {
            try
            {
                if (ruffCoDB.Tables.Contains("guests"))
                {
                    ruffCoDB.Tables.Remove("guests");
                }
                cmd = new SqlCommand("SELECT * FROM " + GUESTS_TABLE, sql);
                adapter.SelectCommand = cmd;
                DataTable guests = new DataTable();

                adapter.Fill(guests);
                ruffCoDB.Tables.Add(guests);
                ruffCoDB.Tables[index].TableName = "guests";
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public static void loadReservations(int index)
        {
            try
            {
                if (ruffCoDB.Tables.Contains("reservations"))
                {
                    ruffCoDB.Tables.Remove("reservations");
                }
                cmd = new SqlCommand("SELECT * FROM " + RESERVATIONS_TABLE, sql);
                adapter.SelectCommand = cmd;
                DataTable reservations = new DataTable();

                adapter.Fill(reservations);
                ruffCoDB.Tables.Add(reservations);
                ruffCoDB.Tables[index].TableName = "reservations";
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public static void loadReservationsGuestsXRef(int index)
        {
            try
            {
                if (ruffCoDB.Tables.Contains("ReservationsGuestsXRef"))
                {
                    ruffCoDB.Tables.Remove("ReservationsGuestsXRef");
                }
                cmd = new SqlCommand("SELECT * FROM " + GUESTS_X_DEST_TABLE, sql);
                adapter.SelectCommand = cmd;
                DataTable ReservationsGuestsXRef = new DataTable();

                adapter.Fill(ReservationsGuestsXRef);
                ruffCoDB.Tables.Add(ReservationsGuestsXRef);
                ruffCoDB.Tables[index].TableName = "ReservationsGuestsXRef";
            }
            catch (SqlException e)
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
