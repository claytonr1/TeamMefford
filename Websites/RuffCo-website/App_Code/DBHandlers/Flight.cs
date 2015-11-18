using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RuffCoJetReservationSystem.DBHandlers;
/// <summary>
/// Summary description for Flight
/// </summary>
public class Flight
{
    public int resId { get; set; }
    public string planeName { get; set; }
    public int capacity { get; set; }
    public string destination { get; set; }
    public int passengerCount { get; set; }
    public DateTime departureTime { get; set; }

	public Flight(int id)  //creates flight using reservation ID
	{
        this.resId = id;
        this.planeName = DBPlanes.getName(DBReservations.getPlane(resId));
        this.capacity = DBPlanes.getCapacity(DBReservations.getPlane(resId));

        List<string> flightResList = DBReservations.getReservationsByPlane(DBReservations.getPlane(resId));
        this.passengerCount = flightResList.Count();
        foreach (String s in flightResList)
        {
            int num = Convert.ToInt32(s);
            this.departureTime = DBReservations.getDate(num);
            this.destination = Convert.ToString(DBReservations.getDestination(num));
            break;
        }

	}

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
}