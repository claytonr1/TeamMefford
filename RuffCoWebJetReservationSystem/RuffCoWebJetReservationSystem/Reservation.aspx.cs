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
                DBHandler.openConection("Data Source=claytonr1.db.5867809.hostedresource.com;Persist Security Info=True;User ID=claytonr1;Password=Interface1");
                DBHandler.populateDataSet();
                DBHandler.closeConnection();
                String[] destList;
                destList = DBDestinations.getDestinationsList().ToArray();
                foreach(string s in destList)
                {
                    destinationDropDownList.Items.Add(s); //automatically adds database items to dropdown list
                }
                String[] planeList;
                planeList = DBPlanes.planeList().ToArray();
                foreach(string s in planeList)
                {
                    jetsDropDownList.Items.Add(s); //automatically adds database items to dropdown list
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            String employee = Label1.Text;
            String jet = jetsDropDownList.SelectedValue;//setting values for variables based on forums selections
            String dest = destinationDropDownList.SelectedValue;
            DateTime date = Calendar1.SelectedDate;
            date.AddHours(Convert.ToInt32(hourBox.Text));
            date.AddMinutes(Convert.ToInt32(minuteBox.Text));
            if (ampmDropDownList.SelectedValue == "PM")
            {
                date.AddHours(12);
            }
            DBReservations.RegisterReservation(DBPlanes.getID(jet),DBEmployees.getID(employee),DBDestinations.getID(dest),date);
            

        }
}
}