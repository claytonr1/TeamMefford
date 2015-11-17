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
            
            try //catch errors including sql errors!
            {
                Calendar1.SelectedDate = DateTime.Now;
                //login check
                CookieHandler.checkLogin();
                CookieHandler.clearResultsCookies(); //clear cookies if second reservation or more this session
                
                //this populates the name of the current user into the Label1 textbox
                Label1.Text = CookieHandler.getUserFullName();

                if (!IsPostBack)
                {
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
            catch (Exception ex)
            {
                throw ex;
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
            CookieHandler.setCookie("jet", jetsDropDownList.SelectedValue);
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
