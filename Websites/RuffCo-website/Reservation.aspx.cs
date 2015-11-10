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
                //login check
                CookieHandler.checkLogin(); 
                
                //this populates the name of the current user into the Label1 textbox
                Label1.Text = CookieHandler.getUserFullName();

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
            catch (Exception ex)
            {
                throw ex;
            }

            

            /* The way I wrote it only allows for booking of the current user, should this be switched to something   
             * like this?
             * 
             * dropdown menu of all employee names on employeetable
             * 
             * int IDtoBook = dropdownmenu.selectedvalue;
             * 
             * Label1 = DBEmployees.getFName(IDtoBook) + 
             * " " + DBEmployees.getLName(IDtoBook);
             * 
             */
            


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*
            //What data needs to be saved to be taken to the next page for a confirmation window?
            // perhaps these?
            // int EmployeeIDbeingBooked, int PlaneIDbeingBooked, int DestinationID1, int DestinationID2, int SeatNumber
                // I don't need this any more, can delete --NM
             */
     
            //Commented out unesessary code.
            //String employee = Label1.Text;//setting values for variables based on forums selections -ksm
            

            
            String jet = jetsDropDownList.SelectedValue;
            String dest = destinationDropDownList.SelectedValue;
            DateTime date = Calendar1.SelectedDate;

            //sets cookies for use in results page
            CookieHandler.setCookie("jet", jetsDropDownList.SelectedValue);
            CookieHandler.setCookie("dest", destinationDropDownList.SelectedValue);
            CookieHandler.setCookie("date", Calendar1.SelectedDate.ToString());


            //date.AddHours(Convert.ToInt32(hourBox.Text));
            //date.AddMinutes(Convert.ToInt32(minuteBox.Text));
            //if (ampmDropDownList.SelectedValue == "PM")
            //{
            //    date.AddHours(12);
            //}
            //DBReservations.RegisterReservation(DBPlanes.getID(jet), DBEmployees.getID(employee), DBDestinations.getID(dest), date);

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

            //change page to results
            HttpContext.Current.Response.Redirect("Results.aspx"); 
        }
    }
}
