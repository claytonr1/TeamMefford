using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RuffCoJetReservationSystem.DBHandlers
{
    public static class DBPlanes
    {
        public static List<string> PlanesList()
        {
            try
            {
                Dictionary<int, string> dictionary = new Dictionary<int, string>();
                dictionary = PlanesDictionary();
                List<string> list = new List<string>();
                list = dictionary.Values.ToList();
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Dictionary<int, string> PlanesDictionary()
        {
            try
            {
                Dictionary<int, string> planeList = new Dictionary<int, string>();
                DataRow[] result = DBHandler.ruffCoDB.Tables["planes"].Select();

                for (int i = 0; i < result.Length; i++)
                {
                    planeList.Add(Convert.ToInt32(result[i][0]), Convert.ToString(result[i]["name"]));
                }
                return planeList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static int getID(string name)
        {
            try
            {
                string expression = string.Format("name = '{0}'", name);
                DataRow[] result = DBHandler.ruffCoDB.Tables["planes"].Select(expression);
                int id = Convert.ToInt32(result[0][0]);
                return id;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public static String getName(int plane_id)
        {
            try
            {
                string expression = string.Format("id = {0}", plane_id);
                DataRow[] result = DBHandler.ruffCoDB.Tables["planes"].Select(expression);
                string name = Convert.ToString(result[0][1]);
                return name;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static String getModel(int plane_id)
        {
            try
            {
                string expression = string.Format("id = {0}", plane_id);
                DataRow[] result = DBHandler.ruffCoDB.Tables["planes"].Select(expression);
                string model = Convert.ToString(result[0][2]);
                return model;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static String getModel(string name)
        {
            try
            {
                string expression = string.Format("name = {0}", name);
                DataRow[] result = DBHandler.ruffCoDB.Tables["planes"].Select(expression);
                string model = Convert.ToString(result[0][2]);
                return model;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static int getCapacity(int plane_id)
        {
            try
            {
                string expression = string.Format("id = {0}", plane_id);
                DataRow[] result = DBHandler.ruffCoDB.Tables["planes"].Select(expression);
                int cap = Convert.ToInt32(result[0][3]);
                return cap;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static int getCapacity(string name)
        {
            try
            {
                string expression = string.Format("name = {0}", name);
                DataRow[] result = DBHandler.ruffCoDB.Tables["planes"].Select(expression);
                int cap = Convert.ToInt32(result[0][3]);
                return cap;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static double getRange(int plane_id)
        {
            try
            {
                string expression = string.Format("plane_id = {0}", plane_id);
                DataRow[] result = DBHandler.ruffCoDB.Tables["planes"].Select(expression);
                double range = Convert.ToDouble(result[0][4]);
                return range;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static double getRange(string name)
        {
            try
            {
                string expression = string.Format("name = {0}", name);
                DataRow[] result = DBHandler.ruffCoDB.Tables["planes"].Select(expression);
                double range = Convert.ToDouble(result[0][4]);
                return range;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static String getLocation(int plane_id)
        {
            try
            {
                string expression = string.Format("plane_id = {0}", plane_id);
                DataRow[] result = DBHandler.ruffCoDB.Tables["planes"].Select(expression);
                string location = Convert.ToString(result[0][5]);
                return location;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static String getLocation(string name)
        {
            try
            {
                string expression = string.Format("name = {0}", name);
                DataRow[] result = DBHandler.ruffCoDB.Tables["planes"].Select(expression);
                string location = Convert.ToString(result[0][5]);
                return location;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static double getSpeed(int plane_id)
        {
            try
            {
                string expression = string.Format("plane_id = {0}", plane_id);
                DataRow[] result = DBHandler.ruffCoDB.Tables["planes"].Select(expression);
                double speed = Convert.ToDouble(result[0][6]);
                return speed;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static double getSpeed(string name)
        {
            try
            {
                string expression = string.Format("name = {0}", name);
                DataRow[] result = DBHandler.ruffCoDB.Tables["planes"].Select(expression);
                double speed = Convert.ToDouble(result[0][6]);
                return speed;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static ArrayList getReservations(int plane_id)
        {
            ArrayList reservation_ids = new ArrayList();
            string expression = string.Format("plane_id = {0}", plane_id);
            DataRow[] result = DBHandler.ruffCoDB.Tables["reservations"].Select(expression);

            foreach(DataRow row in result)
            {
                reservation_ids.Add(Convert.ToInt32(row[0]));
            }

            return reservation_ids;
        }

        public static bool addPlane(string name, string model, int capacity, double mile_range, string currentLocation, double cruiseSpeed)
        {
            return DBHandler.addPlane(name, model, capacity, mile_range, currentLocation, cruiseSpeed);
        }

        public static bool setName(int id, string name)
        {
            return false;
        }

        public static bool setModel(int id, string model)
        {
            return false;
        }

        public static bool setCapacity(int id, int capacity)
        {
            return false;
        }

        public static bool setRange(int id, double range)
        {
            return false;
        }

        public static bool setLocation(int id, string location)
        {
            return false;
        }

        public static bool setSpeed(int id, double speed)
        {
            return false;
        }

        public static void updatePlanesDataSet()
        {
            DBHandler.loadPlanes();
        }

        /// <summary>
        /// Clears the database table. Returns False if the command did not complete.
        /// </summary>
        /// <returns></returns>
        public static bool clearDB()
        {
            return DBHandler.clearDataTables(DBHandler.PLANES_TABLE);
        }
    }
}
