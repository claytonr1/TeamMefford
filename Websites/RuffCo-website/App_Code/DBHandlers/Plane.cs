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

    public List<string> destList { get; set; }


	public Plane(int id)
	{
        try
        {
            List<Flight> flights;

            this.id = id;
            this.name = DBPlanes.getName(id);
            this.model = DBPlanes.getModel(id);
            this.mileRange = DBPlanes.getRange(id);
            this.location = DBPlanes.getLocation(id);
            this.cruiseSpeed = DBPlanes.getSpeed(id);

            List<string> resList = DBReservations.getReservationsByPlane(id);
            foreach (String s in resList)
            {
                destList.Add(s);
            }

        }
        catch(Exception ex)
        {
            throw ex;
        }
	}

    bool isAvailable()
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