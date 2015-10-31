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
        /// <summary>
        /// The main connection string
        /// </summary>
        public const string CONNECTION_STRING = "Data Source=claytonr1.db.5867809.hostedresource.com;Persist Security Info=True;User ID=claytonr1;Password=Interface1";

        public const string EMPLOYEES_TABLE = "RuffCoEmployees";
        public const string PLANES_TABLE = "RuffCoPlanes";
        public const string RESERVATIONS_TABLE = "RuffCoReservations";
        public const string DESTINATIONS_TABLE = "RuffCoDestinations";
        public const string GUESTS_TABLE = "RuffCoGuests";
        public const string GUESTS_X_RES_TABLE = "RuffCoReservationGuestXRef";

        private static SqlConnection sql = new SqlConnection(CONNECTION_STRING);
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

        /// <summary>
        /// Opens the SQL conection using CONNECTION_STRING.
        /// </summary>
        public static void openConection()
        {
            try
            {
                if (sql.State != null)
                {
                    if (sql.State != ConnectionState.Open)
                    {
                        sql.Close();
                        sql = new SqlConnection(CONNECTION_STRING);
                        sql.Open();
                    }
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Opens the SQL connection with a custom connection string.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        public static void openConection(string connectionString)
        {
            try
            {
                if (sql.State != null && sql.State != ConnectionState.Open)
                {
                    sql.Close();
                    sql = new SqlConnection(connectionString);
                    sql.Open();
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Closes the SQL connection if it is open.
        /// </summary>
        public static void closeConnection()
        {
            try
            {
                if (!(sql.State == ConnectionState.Closed))
                {
                    sql.Close();
                    sql.Dispose();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Populates the data sets. Calls loading methods and creates relations as well as primary keys
        /// </summary>
        public static void populateDataSet()
        {
            if (!(sql.State == ConnectionState.Open))
            {
                openConection();
            }

            //deletes current data if any to repopulate
            ruffCoDB.Clear();

            //load the data in appropriate orders
            loadPlanes();
            loadEmployees();
            loadDestinations();
            loadGuests();
            loadReservations();
            loadReservationsGuestsXRef();

            ////relations
            //ruffCoDB.Relations.Add(ruffCoDB.Tables["employees"].Columns["employee_id"], ruffCoDB.Tables["guests"].Columns["empoyee_id"]);
            //ruffCoDB.Relations.Add(ruffCoDB.Tables["reservations"].Columns["employee_id"], ruffCoDB.Tables["employees"].Columns["empoyee_id"]);
            //ruffCoDB.Relations.Add(ruffCoDB.Tables["reservations"].Columns["reservations_id"], ruffCoDB.Tables["ReservationsGuestsXRef"].Columns["reservations_id"]);
            //ruffCoDB.Relations.Add(ruffCoDB.Tables["guests"].Columns["guest_id"], ruffCoDB.Tables["ReservationsGuestsXRef"].Columns["guest_id"]);
            //ruffCoDB.Relations.Add(ruffCoDB.Tables["planes"].Columns["plane_id"], ruffCoDB.Tables["reservations"].Columns["plane_id"]);
            //ruffCoDB.Relations.Add(ruffCoDB.Tables["reservations"].Columns["dest_id"], ruffCoDB.Tables["destinations"].Columns["dest_id"]);

            ////set primary keys
            ////plane table
            //DataColumn[] planeKeys = new DataColumn[1];
            //DataColumn planeColumn = ruffCoDB.Tables["planes"].Columns[0];
            //planeKeys[0] = planeColumn;
            //ruffCoDB.Tables["planes"].PrimaryKey = planeKeys;
            ////employee table
            //DataColumn[] employeeKeys = new DataColumn[1];
            //DataColumn employeeColumn = ruffCoDB.Tables["employees"].Columns[0];
            //employeeKeys[0] = employeeColumn;
            //ruffCoDB.Tables["employees"].PrimaryKey = employeeKeys;
            ////reservations table
            //DataColumn[] reservationsKeys = new DataColumn[1];
            //DataColumn reservationsColumn = ruffCoDB.Tables["reservations"].Columns[0];
            //reservationsKeys[0] = reservationsColumn;
            //ruffCoDB.Tables["reservations"].PrimaryKey = reservationsKeys;
            ////destinations table
            //DataColumn[] destKeys = new DataColumn[1];
            //DataColumn destColumn = ruffCoDB.Tables["destinations"].Columns[0];
            //destKeys[0] = destColumn;
            //ruffCoDB.Tables["destinations"].PrimaryKey = destKeys;
            ////guests table
            //DataColumn[] guestKeys = new DataColumn[1];
            //DataColumn guestColumn = ruffCoDB.Tables["guests"].Columns[0];
            //guestKeys[0] = guestColumn;
            //ruffCoDB.Tables["guests"].PrimaryKey = guestKeys;
            ////guestXReservation table
            //DataColumn[] GXRKeys = new DataColumn[1];
            //DataColumn GXRColumn = ruffCoDB.Tables["ReservationsGuestsXRef"].Columns[0];
            //GXRKeys[0] = GXRColumn;
            //ruffCoDB.Tables["ReservationsGuestsXRef"].PrimaryKey = GXRKeys;

            closeConnection();
        }

        /// <summary>
        /// Loads or reloads the planes table.
        /// </summary>
        public static void loadPlanes()
        {
            try
            {
                if (ruffCoDB.Tables.Contains("planes"))
                {
                    ruffCoDB.Tables.Remove("planes");
                }

                DataTable planes = new DataTable();

                planes.TableName = "planes";
                adapterPlanes.Fill(planes);
                ruffCoDB.Tables.Add(planes);
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Loads or reloads the employees.
        /// </summary>
        public static void loadEmployees()
        {
            try
            {
                if (ruffCoDB.Tables.Contains("employees"))
                {
                    ruffCoDB.Tables.Remove("employees");
                }

                DataTable employees = new DataTable();

                employees.TableName = "employees";
                adapterEmployees.Fill(employees);
                ruffCoDB.Tables.Add(employees);
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Loads or reloads the destinations.
        /// </summary>
        public static void loadDestinations()
        {
            try
            {
                if (ruffCoDB.Tables.Contains("destinations"))
                {
                    ruffCoDB.Tables.Remove("destinations");
                }

                DataTable destinations = new DataTable();

                destinations.TableName = "destinations";
                adapterDestinations.Fill(destinations);
                ruffCoDB.Tables.Add(destinations);
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Loads or reloads the guests.
        /// </summary>
        public static void loadGuests()
        {
            try
            {
                if (ruffCoDB.Tables.Contains("guests"))
                {
                    ruffCoDB.Tables.Remove("guests");
                }

                DataTable guests = new DataTable();

                guests.TableName = "guests";
                adapterGuests.Fill(guests);
                ruffCoDB.Tables.Add(guests);
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Loads or reloads the reservations.
        /// </summary>
        public static void loadReservations()
        {
            try
            {
                if (ruffCoDB.Tables.Contains("reservations"))
                {
                    ruffCoDB.Tables.Remove("reservations");
                }

                DataTable reservations = new DataTable();

                reservations.TableName = "reservations";
                adapterReservations.Fill(reservations);
                ruffCoDB.Tables.Add(reservations);
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Loads or reloads the reservations guests x reference.
        /// </summary>
        public static void loadReservationsGuestsXRef()
        {
            try
            {
                if (ruffCoDB.Tables.Contains("ReservationsGuestsXRef"))
                {
                    ruffCoDB.Tables.Remove("ReservationsGuestsXRef");
                }

                DataTable ReservationsGuestsXRef = new DataTable();

                ReservationsGuestsXRef.TableName = "ReservationsGuestsXRef";
                adapterGuestXRes.Fill(ReservationsGuestsXRef);
                ruffCoDB.Tables.Add(ReservationsGuestsXRef);
            }
            catch (SqlException e)
            {
                throw e;
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
            try
            {
                if (!(sql.State == ConnectionState.Open))
                {
                    openConection();
                }

                cmd = new SqlCommand("INSERT INTO " + EMPLOYEES_TABLE + " (f_name,l_name,email,phone,user_name,password) VALUES (@fName, @lName, @email, @phone, @username, @password);", sql);
                cmd.Parameters.Add("@fName", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@lName", SqlDbType.VarChar, 45);
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 254);
                cmd.Parameters.Add("@phone", SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 45);
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 200);

                cmd.Parameters["@fName"].Value = firstName;
                cmd.Parameters["@lName"].Value = lastName;
                cmd.Parameters["@email"].Value = email;
                cmd.Parameters["@phone"].Value = phone;
                cmd.Parameters["@username"].Value = username;
                cmd.Parameters["@password"].Value = password;

                cmd.ExecuteNonQuery();

                closeConnection();

                loadEmployees();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
                throw e;
            }
        }

        /// <summary>
        /// Registers a reservation without guests. Does not check for unique values, will retun false if the command does not complete.
        /// </summary>
        /// <param name="planeID">The plane identifier.</param>
        /// <param name="employeeID">The employee identifier.</param>
        /// <param name="destinationID">The destination identifier.</param>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public static bool registerReservation(int planeID, int employeeID, int destinationID, DateTime date)
        {
            try
            {
                if (!(sql.State == ConnectionState.Open))
                {
                    openConection();
                }
                cmd = new SqlCommand("INSERT INTO " + RESERVATIONS_TABLE + " (plane_id,employee_id,dest_id,date) VALUES (@planeID, @employeeID, @destID, @date);", sql);
                cmd.Parameters.Add("@planeID", SqlDbType.Int);
                cmd.Parameters.Add("@employeeID", SqlDbType.Int);
                cmd.Parameters.Add("@destID", SqlDbType.Int);
                cmd.Parameters.Add("@date", SqlDbType.DateTime);

                cmd.Parameters["@planeID"].Value = planeID;
                cmd.Parameters["@employeeID"].Value = employeeID;
                cmd.Parameters["@destID"].Value = destinationID;
                cmd.Parameters["@date"].Value = date;

                cmd.ExecuteNonQuery();

                closeConnection();

                loadReservations();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
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
        public static bool registerReservation(int planeID, int employeeID, int destinationID, DateTime date, bool hasGuests, List<int> guestsIDList)
        {
            try
            {
                if (!(sql.State == ConnectionState.Open))
                {
                    openConection();
                }

                cmd = new SqlCommand("INSERT INTO " + RESERVATIONS_TABLE + " (plane_id,employee_id,dest_id,date) VALUES (@planeID, @employeeID, @destID, @date);", sql);
                cmd.Parameters.Add("@planeID", SqlDbType.Int);
                cmd.Parameters.Add("@employeeID", SqlDbType.Int);
                cmd.Parameters.Add("@destID", SqlDbType.Int);
                cmd.Parameters.Add("@date", SqlDbType.DateTime);

                cmd.Parameters["@planeID"].Value = planeID;
                cmd.Parameters["@employeeID"].Value = employeeID;
                cmd.Parameters["@destID"].Value = destinationID;
                cmd.Parameters["@date"].Value = date;
                cmd.ExecuteNonQuery();

                if (hasGuests && (guestsIDList != null))
                {
                    SortedDictionary<int, string> resList = DBReservations.getReservationsList();
                    int resID = resList.Last().Key;

                    for (int i = 1; i < guestsIDList.Count; i++)
                    {
                        int guestID = guestsIDList.ElementAt(i);

                        cmd = new SqlCommand("INSERT INTO " + GUESTS_X_RES_TABLE + " (reservation_id, guest_id) VALUES (@resID, @guestID);", sql);
                        cmd.Parameters.Add("@resID", SqlDbType.Int);
                        cmd.Parameters.Add("@guestID", SqlDbType.Int);

                        cmd.Parameters["@resID"].Value = resID;
                        cmd.Parameters["@guestID"].Value = guestID;

                        cmd.ExecuteNonQueryAsync();
                    }

                    loadReservationsGuestsXRef();
                }

                closeConnection();

                loadReservations();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Adds a plane to the database. Does not check for unique values, will retun false if the command does not complete.
        /// </summary>
        /// <param name="planeName">Name of the plane.</param>
        /// <param name="model">The model.</param>
        /// <param name="capacity">The capacity.</param>
        /// <param name="mileRange">The mile range.</param>
        /// <param name="currentLocation">The current location.</param>
        /// <param name="cruiseSpeed">The cruise speed.</param>
        /// <returns></returns>
        public static bool addPlane(string planeName, string model, int capacity, double mileRange, string currentLocation, double cruiseSpeed)
        {
            try
            {
                if (!(sql.State == ConnectionState.Open))
                {
                    openConection();
                }

                cmd = new SqlCommand("INSERT INTO " + PLANES_TABLE + " (name, model, capacity, mile_range, current_location, cruise_speed) VALUES (@name, @model, @capacity, @range, @location, @speed);", sql);
                cmd.Parameters.Add("@name", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@model", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@capacity", SqlDbType.Int);
                cmd.Parameters.Add("@range", SqlDbType.Int);
                cmd.Parameters.Add("@location", SqlDbType.VarChar, 40);
                cmd.Parameters.Add("@speed", SqlDbType.Float, 2);

                cmd.Parameters["@name"].Value = planeName;
                cmd.Parameters["@model"].Value = model;
                cmd.Parameters["@capacity"].Value = capacity;
                cmd.Parameters["@range"].Value = mileRange;
                cmd.Parameters["@location"].Value = currentLocation;
                cmd.Parameters["@speed"].Value = cruiseSpeed;

                cmd.ExecuteNonQuery();

                closeConnection();

                loadGuests();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Adds a destination to the database. Does not check for unique values, will retun false if the command does not complete.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="distanceFromLR">The distance from lr.</param>
        /// <returns></returns>
        public static bool addDestination(string location, double distanceFromLR)
        {
            try
            {
                if (!(sql.State == ConnectionState.Open))
                {
                    openConection();
                }

                cmd = new SqlCommand("INSERT INTO " + DESTINATIONS_TABLE + " (location, distance_from_LR) VALUES (@location, @distFromLR);", sql);
                cmd.Parameters.Add("@location", SqlDbType.VarChar, 40);
                cmd.Parameters.Add("@distFromLR", SqlDbType.Float, 2);

                cmd.Parameters["@location"].Value = location;
                cmd.Parameters["@distFromLR"].Value = distanceFromLR;

                cmd.ExecuteNonQuery();

                closeConnection();

                loadDestinations();
                return true;
            }
            catch (Exception)
            {
                return false;
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
            try
            {
                if (!(sql.State == ConnectionState.Open))
                {
                    openConection();
                }

                cmd = new SqlCommand("INSERT INTO " + GUESTS_TABLE + " (f_name,l_name,email,phone,employee_id) VALUES (@fName, @lName, @email, @phone, @employeeID);", sql);
                cmd.Parameters.Add("@fName", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@lName", SqlDbType.VarChar, 45);
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 254);
                cmd.Parameters.Add("@phone", SqlDbType.VarChar, 10);
                cmd.Parameters.Add("@employeeID", SqlDbType.Int);

                cmd.Parameters["@fName"].Value = firstName;
                cmd.Parameters["@lName"].Value = lastName;
                cmd.Parameters["@email"].Value = email;
                cmd.Parameters["@phone"].Value = phone;
                cmd.Parameters["@employeeID"].Value = employeeID;

                cmd.ExecuteNonQuery();

                closeConnection();

                loadGuests();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
