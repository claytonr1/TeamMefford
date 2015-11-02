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
//using RuffCoJetReservationSystem.DBHandler;

namespace RuffCoJetReservationSystem
{
    public partial class Reservation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //CookieHandler.checkLogin(); // This is a login check that redirects to login page if there is no valid login cookie.  
            // I'll leave it disabled for now so that you don't have to
            // log in every time you test something, though the name will not populate unless you do.


            try //catch errors including sql errors!
            {
              //  DBHandler.openConection("Data Source=claytonr1.db.5867809.hostedresource.com;Persist Security Info=True;User ID=claytonr1;Password=Interface1");
                //DBHandler.populateDataSet();
               // DBHandler.closeConnection();
                
               
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //this populates the name of the current user into the Label1 textbox
            Label1.Text = CookieHandler.getUserFullName();

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

            //What data needs to be saved to be taken to the next page for a confirmation window?
            // perhaps these?
            // int EmployeeIDbeingBooked, int PlaneIDbeingBooked, int DestinationID1, int DestinationID2, int SeatNumber
             
            

        }
    }
}