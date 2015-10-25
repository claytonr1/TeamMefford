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
//using RuffCoJetReservationSystem.DBHandler;

namespace RuffCoJetReservationSystem
{
    public partial class Reservation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}