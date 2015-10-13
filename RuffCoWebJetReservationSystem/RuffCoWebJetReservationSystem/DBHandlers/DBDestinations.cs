using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RuffCoJetReservation.DBHandlers
{
    static class DestinationsDB
    {
        public static List<String> getDestinationsList()
        {
            try
            {
                
                List<String> destList = new List<string>();
                DataRow[] result = DBHandler.ruffCoDB.Tables["destinations"].Select();

                for (int i = 0; i < result.Length; i++)
                {
                    destList.Add(Convert.ToString(result[i]["location"]));
                }
                return destList;
            }
            catch (Exception)
            {
                return null;
            }
        }

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

        public static bool addDestination(string location, double distanceFromLR)
        {
            try
            {
                DataRow newRow = DBHandler.ruffCoDB.Tables["destinations"].NewRow();

                newRow["location"] = location;
                newRow["distance_from_LR"] = distanceFromLR;

                DBHandler.ruffCoDB.Tables["destinations"].Rows.Add(newRow);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool updateDestDB()
        {
            return DBHandler.updateDestinations();
        }
    }
}
