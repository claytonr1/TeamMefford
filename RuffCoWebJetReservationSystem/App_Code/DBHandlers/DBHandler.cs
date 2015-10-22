using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace RuffCoJetReservationSystem.DBHandlers
{
    public static class DBHandler
    {
        public const string EMPLOYEES_TABLE = "RuffCoEmployees";
        public const string PLANES_TABLE = "RuffCoPlanes";
        public const string RESERVATIONS_TABLE = "RuffCoReservations";
        public const string DESTINATIONS_TABLE = "RuffCoDestinations";
        public const string GUESTS_TABLE = "RuffCoGuests";
        public const string GUESTS_X_RES_TABLE = "RuffCoReservationGuestXRef";

        private static SqlConnection sql;
        private static SqlDataReader reader;
        private static SqlCommand cmd;

        private static SqlDataAdapter adapter = new SqlDataAdapter();
        private static SqlDataAdapter adapterPlanes = new SqlDataAdapter("SELECT * FROM " + PLANES_TABLE, sql);
        private static SqlDataAdapter adapterEmployees = new SqlDataAdapter("SELECT * FROM " + EMPLOYEES_TABLE, sql);
        private static SqlDataAdapter adapterGuests = new SqlDataAdapter("SELECT * FROM " + GUESTS_TABLE, sql);
        private static SqlDataAdapter adapterDestinations = new SqlDataAdapter("SELECT * FROM " + DESTINATIONS_TABLE, sql);
        private static SqlDataAdapter adapterReservations = new SqlDataAdapter("SELECT * FROM " + RESERVATIONS_TABLE, sql);
        private static SqlDataAdapter adapterGuestXRes = new SqlDataAdapter("SELECT * FROM " + GUESTS_X_RES_TABLE, sql);

        private static SqlCommandBuilder cmdBuilderPlanes = new SqlCommandBuilder(adapterPlanes);
        private static SqlCommandBuilder cmdBuilderEmployees = new SqlCommandBuilder(adapterEmployees);
        private static SqlCommandBuilder cmdBuilderGuests = new SqlCommandBuilder(adapterGuests);
        private static SqlCommandBuilder cmdBuilderDestinations = new SqlCommandBuilder(adapterDestinations);
        private static SqlCommandBuilder cmdBuilderReservations = new SqlCommandBuilder(adapterReservations);
        private static SqlCommandBuilder cmdBuilderGuestXRes = new SqlCommandBuilder(adapterGuestXRes);

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

        //calls loading methods and creates relations as well as primary keys
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

            //set primary keys
            //plane table
            DataColumn[] planeKeys = new DataColumn[1];
            DataColumn planeColumn = ruffCoDB.Tables["planes"].Columns[0];
            planeKeys[0] = planeColumn;
            ruffCoDB.Tables["planes"].PrimaryKey = planeKeys;
            //employee table
            DataColumn[] employeeKeys = new DataColumn[1];
            DataColumn employeeColumn = ruffCoDB.Tables["employees"].Columns[0];
            employeeKeys[0] = employeeColumn;
            ruffCoDB.Tables["employees"].PrimaryKey = employeeKeys;
            //reservations table
            DataColumn[] reservationsKeys = new DataColumn[1];
            DataColumn reservationsColumn = ruffCoDB.Tables["reservations"].Columns[0];
            reservationsKeys[0] = reservationsColumn;
            ruffCoDB.Tables["reservations"].PrimaryKey = reservationsKeys;
            //destinations table
            DataColumn[] destKeys = new DataColumn[1];
            DataColumn destColumn = ruffCoDB.Tables["destinations"].Columns[0];
            destKeys[0] = destColumn;
            ruffCoDB.Tables["destinations"].PrimaryKey = destKeys;
            //guests table
            DataColumn[] guestKeys = new DataColumn[1];
            DataColumn guestColumn = ruffCoDB.Tables["guests"].Columns[0];
            guestKeys[0] = guestColumn;
            ruffCoDB.Tables["guests"].PrimaryKey = guestKeys;
            //guestXReservation table
            DataColumn[] GXRKeys = new DataColumn[1];
            DataColumn GXRColumn = ruffCoDB.Tables["ReservationsGuestsXRef"].Columns[0];
            GXRKeys[0] = GXRColumn;
            ruffCoDB.Tables["ReservationsGuestsXRef"].PrimaryKey = GXRKeys;
        }

        public static void loadPlanes(int index)
        {
            try
            {
                if (ruffCoDB.Tables.Contains("planes"))
                {
                    ruffCoDB.Tables.Remove("planes");
                }
                DataTable planes = new DataTable();

                adapterPlanes.Fill(planes);
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
                DataTable employees = new DataTable();

                adapterEmployees.Fill(employees);
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
                DataTable destinations = new DataTable();

                adapterDestinations.Fill(destinations);
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
                DataTable guests = new DataTable();

                adapterGuests.Fill(guests);
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
                DataTable reservations = new DataTable();

                adapterReservations.Fill(reservations);
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
                DataTable ReservationsGuestsXRef = new DataTable();

                adapterGuestXRes.Fill(ReservationsGuestsXRef);
                ruffCoDB.Tables.Add(ReservationsGuestsXRef);
                ruffCoDB.Tables[index].TableName = "ReservationsGuestsXRef";
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public static bool updatePlanes()
        {
            try
            {
                adapterPlanes.Update(ruffCoDB, "planes");
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }
        }

        public static bool updateEmployees()
        {
            try
            {
                adapterEmployees.Update(ruffCoDB, "employees");
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }
        }

        public static bool updateReservations()
        {
            try
            {
                adapterReservations.Update(ruffCoDB, "reservations");
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }
        }

        public static bool updateDestinations()
        {
            try
            {
                adapterDestinations.Update(ruffCoDB, "destinations");
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }
        }

        public static bool updateGuests()
        {
            try
            {
                adapterGuests.Update(ruffCoDB, "guests");
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }
        }

        public static bool updateReservationsGuestsXRef()
        {
            try
            {
                adapterGuestXRes.Update(ruffCoDB, "ReservationsGuestsXRef");
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }
        }
    }
}
