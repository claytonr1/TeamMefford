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
    public double mileRange { get; set; }
    public string location { get; set; }
    public double cruiseSpeed { get; set; }
    public Dictionary<int, Flight> flights = new Dictionary<int, Flight>();  

	public Plane(int id)
	{
        try
        {
            this.id = id;
            this.name = DBPlanes.getName(id);
            this.mileRange = DBPlanes.getRange(id);
            this.location = DBPlanes.getLocation(id);
            this.cruiseSpeed = DBPlanes.getSpeed(id);

            List<string> resList = DBReservations.getReservationsByPlane(id);
            int count = 0;

            foreach (String res in resList)  // "For each reservation that this plane has create a flight based on reservation IDs" - ksm
            {
                flights[count] = new Flight(Convert.ToInt32(res));
                count++;
            }
            
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
            if (DBPlanes.getLocation(id) == "Little Rock, AR" && this.getFlight().seatsAvailable > 0 || flights.Count <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch
        {
            return false;
        }

    }

    public Flight getFlight() //gets the Planes current Flight or next future flight
    {
        DateTime minDate = DateTime.MaxValue;
        foreach (var pair in flights)
        {
            Flight flight = pair.Value;
            
            if (flight.departureTime < minDate)
                minDate = flight.departureTime;

        }
        foreach (var pair in flights)
        {
            Flight flight = pair.Value;
            if (flight.departureTime == minDate && DateTime.Now < flight.returnTime)
            {
                return flight;
            }
        }
        return null;
    }
    
    public void updatePlaneLocation()
    {
        try
        {
            if (this.getFlight().departureTime < DateTime.Now)
            {
                DBPlanes.setLocation(this.id, this.getFlight().destination);
            }
        }
        catch
        {

        }
    }

}
    

