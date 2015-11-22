using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RuffCoJetReservationSystem.DBHandlers;

/// <summary>
/// Summary description for Plane
/// </summary>
public class Plane
{
    public int id { get; set; }
    public string name { get; set; }
    public string model { get; set; }
    public double mileRange { get; set; }
    public string location { get; set; }
    public double cruiseSpeed { get; set; }

    public int fligthCount { get; set; }

    //public List<string> destList { get; set; }


	public Plane(int id)
	{
        try
        {

            this.id = id;
            this.name = DBPlanes.getName(id);
            this.model = DBPlanes.getModel(id);
            this.mileRange = DBPlanes.getRange(id);
            this.location = DBPlanes.getLocation(id);
            this.cruiseSpeed = DBPlanes.getSpeed(id);

            Dictionary<int, Flight> flights = new Dictionary<int, Flight>();  

            List<string> resList = DBReservations.getReservationsByPlane(id);
            int count = 0;

            foreach (String res in resList)  // "For each reservation that this plane has create a flight based on reservation IDs" - ksm
            {
                flights[count] = new Flight(Convert.ToInt32(res));
                count++;
            }
            count = 0;

            HashSet<Flight> knownValues = new HashSet<Flight>();
            Dictionary<int, Flight> uniqueValues = new Dictionary<int, Flight>();

            foreach (var pair in flights) // "Remove duplicate flights" -ksm
            {
                if (knownValues.Add(pair.Value))
                {
                    uniqueValues.Add(pair.Key, pair.Value);
                }
            }

            flights = uniqueValues;
            
        }
        catch(Exception ex)
        {
            throw ex;
        }
	}

    public bool isAvailable()
    {
        try
        {
            if (this.location == "Little Rock, AR")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }
}