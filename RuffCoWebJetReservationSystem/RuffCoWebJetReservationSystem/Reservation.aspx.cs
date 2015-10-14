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

namespace RuffCoWebJetReservationSystem
{
    public partial class Reservation : System.Web.UI.Page
    {
        // the four horsemen of data access
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter adpt;
        private DataSet myDS;


        protected void Page_Load(object sender, EventArgs e)
        {
            try //catch errors including sql errors!
            {
                conn = new SqlConnection("Data Source=claytonr1.db.5867809.hostedresource.com;Persist Security Info=True;User ID=claytonr1;Password=Interface1");
                adpt = new SqlDataAdapter();
                myDS = new DataSet();
                cmd = new SqlCommand("select * from RuffCoDestinations", conn);

                adpt.SelectCommand = cmd;
                adpt.Fill(myDS);
               
            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                conn.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
