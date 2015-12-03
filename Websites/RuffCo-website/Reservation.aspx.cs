using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using RuffCoJetReservationSystem.DBHandlers;


namespace RuffCoJetReservationSystem
{
    public partial class Reservation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {    
                //login check
                CookieHandler.checkLogin();
                CookieHandler.clearResultsCookies(); //clear cookies if second reservation or more this session
                //this populates the name of the current user into the Label1 textbox
                Label1.Text = CookieHandler.getUserFullName();

                //destinationDropDownList.Items.Clear();
                //jetsDropDownList.Items.Clear();

                //String[] destList = DBDestinations.getDestinationsList().ToArray();
                //foreach (string s in destList)
                //{
                //    destinationDropDownList.Items.Add(s); //automatically adds database items to dropdown list -ksm
                //}

                //foreach (var pair in planes)
                //{
                //    int key = pair.Key;
                //    Plane p = pair.Value;
                //    if (p.isAvailable())
                //    {
                //        jetsDropDownList.Items.Add(p.name); //automatically adds available jets to dropdownlist -ksm 
                //    }    
                //}
                if (!IsPostBack)
                {
                    Dictionary<int, Plane> planes = (Dictionary<int, Plane>)Session["planes"];

                    String[] destList;
                    destList = DBDestinations.getDestinationsList().ToArray();
                    foreach (string s in destList)
                    {
                        destinationDropDownList.Items.Add(s); //automatically adds database items to dropdown list -ksm
                    }
                    String[] planeList;
                    planeList = DBPlanes.PlanesList().ToArray();
                    foreach (string s in planeList)
                    {
                        jetsDropDownList.Items.Add(s); //automatically adds database items to dropdown list -ksm

                    }
                }


          }

        protected void Button1_Click(object sender, EventArgs e)
        {

            String jet = jetsDropDownList.SelectedValue;
            String dest = destinationDropDownList.SelectedValue;
            DateTime date = Calendar1.SelectedDate;

            if (ampmDropDownList.SelectedValue == "PM")
            {
                int hours = Convert.ToInt32(hourBox.Text) + 12;
                TimeSpan time = new TimeSpan(hours, Convert.ToInt32(minuteBox.Text), 0);
                date = date.Date + time;
            }
            else
            {
                TimeSpan time = new TimeSpan(Convert.ToInt32(hourBox.Text), Convert.ToInt32(minuteBox.Text), 0);
                date = date.Date + time;
            }

            DBReservations.RegisterReservation(DBPlanes.getID(jet), CookieHandler.getID(), DBDestinations.getID(dest), date);

            //sets cookies for use in results page
            CookieHandler.setCookie("jet", DBPlanes.getName(DBPlanes.getID(jet)));
            CookieHandler.setCookie("dest", destinationDropDownList.SelectedValue);
            CookieHandler.setCookie("date", date.ToString());
            //change page to results
            HttpContext.Current.Response.Redirect("Results.aspx"); 
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            CookieHandler.clearUserPassword();
        }
    }
}
