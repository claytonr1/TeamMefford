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
    public int capacity { get; set; }
    public double mileRange { get; set; }
    public string location { get; set; }
    public double cruiseSpeed { get; set; }
    public int passengerCount { get; set; }

    public string destination { get; set; }

	public Plane(int id)
	{
        try
        {
            this.id = id;
            this.name = DBPlanes.getName(id);
            this.model = DBPlanes.getModel(id);
            this.capacity = DBPlanes.getCapacity(id);
            this.mileRange = DBPlanes.getRange(id);
            this.location = DBPlanes.getLocation(id);
            this.cruiseSpeed = DBPlanes.getSpeed(id);
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
    //returns travel time in hrs
    double travelTime() //requires destination to be set; -ksm
    {
        try
        {
            return (DBDestinations.getDistanceFromLR(DBDestinations.getID(this.destination)) / this.cruiseSpeed);
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }
    //returns number of seats left on plane
    int seatsAvailable()
    {
        try
        {
            return this.capacity - this.passengerCount;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    DateTime departureTime()
    {
        DateTime date = new DateTime();
        try
        {
            return date;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}