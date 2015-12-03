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
            return true;
        }

    }

    public Flight getFlight() //gets the Planes current Flight or next future flight
    {
        Dictionary<int, Flight> f = new Dictionary<int, Flight>();

        f = flights;

        DateTime minDate = DateTime.MaxValue;
        
        foreach (var pair in f)
        {

            Flight flight = pair.Value;
            foreach (var p in f)
            {
                Flight fl = pair.Value;

                if (fl.departureTime < minDate)
                    minDate = fl.departureTime;
            }
            if (flight.departureTime == minDate && DateTime.Now < flight.returnTime)
            {
                return flight;
            }

        }
        return null;
    }
    
    public void updatePlaneLocation()
    {
            foreach(var pair in flights)
            {
                try
                {
                    Flight flight = this.getFlight();
                    if (flight.departureTime < DateTime.Now && flight.returnTime > DateTime.Now)
                    {
                        DBPlanes.setLocation(this.id, flight.destination);
                    }
                    else
                    {
                        DBPlanes.setLocation(this.id, "Little Rock, AR");
                    }
                }
                catch
                {
                    DBPlanes.setLocation(this.id, "Little Rock, AR");
                }
            }
     }
}


    

