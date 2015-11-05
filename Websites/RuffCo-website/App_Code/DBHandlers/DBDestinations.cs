using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RuffCoJetReservationSystem.DBHandlers
{
    public static class DBDestinations
    {
        /// <summary>
        /// Gets the destinations list as a list of values only. The ID is the key and the destination name is the value.
        /// NOTE: This function is dependant getDestinationDictionary()
        /// </summary>
        /// <returns></returns>
        /// 
        public static List<String> getDestinationsList()  
        {  
            try  
            {  
                Dictionary<int, string> dictionary = new Dictionary<int, string>();  
                dictionary = getDestinationsDictionary();  
                List<string> list = new List<string>();  
                list = dictionary.Values.ToList();  
                return list;  
            }  
            catch (Exception)  
            {  
                return null;  
            }  
        }
        /// <summary>
        /// Gets the destinations list as a dictionary. The ID is the key and the destination name is the value.
        /// </summary>
        /// <returns></returns>
        ///
        public static Dictionary<int, String> getDestinationsDictionary()
        {
            try
            {
                Dictionary<int, String> destList = new Dictionary<int, string>();
                DataRow[] result = DBHandler.ruffCoDB.Tables["destinations"].Select();

                for (int i = 0; i < result.Length; i++)
                {
                    destList.Add(Convert.ToInt32(result[i][0]), Convert.ToString(result[i]["location"]));
                }
                return destList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the identifier for a location.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <returns></returns>
        public static int getID(string location)
        {
            try
            {
                string expression = string.Format("location = '{0}'", location);
                DataRow[] result = DBHandler.ruffCoDB.Tables["destinations"].Select(expression);
                int id = Convert.ToInt32(result[0][0]);
                return id;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        /// <summary>
        /// Gets the location.
        /// </summary>
        /// <param name="id">The destination ID.</param>
        /// <returns></returns>
        public static string getLocation(int id)
        {
            try
            {
                string expression = string.Format("dest_id = {0}", id);
                DataRow[] result = DBHandler.ruffCoDB.Tables["destinations"].Select(expression);
                String dest = Convert.ToString(result[0][1]);
                return dest;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the distance from Little Rock.
        /// </summary>
        /// <param name="id">The destination ID.</param>
        /// <returns></returns>
        public static double getDistanceFromLR(int id)
        {
            try
            {
                string expression = string.Format("dest_id = {0}", id);
                DataRow[] result = DBHandler.ruffCoDB.Tables["destinations"].Select(expression);
                double distance = Convert.ToDouble(result[0][2]);
                return distance;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        /// <summary>
        /// Gets the distance from Little Rock.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <returns></returns>
        public static double getDistanceFromLR(string location)
        {
            try
            {
                string expression = string.Format("location = '{0}'", location);
                DataRow[] result = DBHandler.ruffCoDB.Tables["destinations"].Select(expression);
                double distance = Convert.ToDouble(result[0][2]);
                return distance;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        /// <summary>
        /// Adds a destination to the database.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="distanceFromLR">The distance from Little Rock.</param>
        /// <returns>True if succesful</returns>
        public static bool addDestination(string location, double distanceFromLR)
        {
            return DBHandler.addDestination(location, distanceFromLR);
        }

        /// <summary>
        /// Loads or reloads the destinations.
        /// </summary>
        public static void loadDestinations()
        {
            DBHandler.loadDestinations();
        }
    }
}
