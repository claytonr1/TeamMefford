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
    public DateTime returnTime { get; set; }
    public double travelDistance { get; set; }
    public double flightSpeed { get; set; } //Mph
    public double travelTime { get; set; }
    public int seatsAvailable { get; set; }

    public Flight(int id)  //creates flight using a reservation ID
    {
        try
        {
            this.resId = id;
            this.planeName = DBPlanes.getName(DBReservations.getPlane(resId));
            this.capacity = DBPlanes.getCapacity(DBReservations.getPlane(resId));
            this.departureTime = DBReservations.getDate(resId);
            this.destination = DBDestinations.getLocation(DBReservations.getDestination(resId));
            this.travelDistance = DBDestinations.getDistanceFromLR(this.destination);
            this.flightSpeed = DBPlanes.getSpeed(this.planeName);
            this.passengerCount = 0;
            this.travelTime = ((this.travelDistance * 2) / this.flightSpeed) + 1; //Travel time to and from destination with 1 extra hour for refuling and acceleration/deceleration; 
            

            List<string> flightResList = DBReservations.getReservationsByPlane(DBPlanes.getID(this.planeName));
            foreach (String s in flightResList) // "Out of all the reservations made for the plane that this Flight belongs to..." -ksm
            {
                int resNum = Convert.ToInt32(s);
                if (this.departureTime == DBReservations.getDate(resNum) && this.destination == DBDestinations.getLocation(DBReservations.getDestination(resNum)))
                {
                    this.passengerCount++; //"... Add 1 passenger for each reservation that matches this flight." -ksm
                }
            }
            this.seatsAvailable = this.capacity - this.passengerCount;

            this.returnTime = this.departureTime;
            this.returnTime.Add(TimeSpan.FromHours(travelTime));
            
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}