using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RuffCoJetReservationSystem.DBHandlers;

public partial class Menu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // This is a login check that redirects to login page if there is no valid login cookie.  
        CookieHandler.checkLogin();   
    }
    protected void btnViewExistingInformation_Click(object sender, EventArgs e)
    {

    }
    protected void btnNewReservation_Click(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        CookieHandler.clearUserPassword();
    }
    protected void btnAdmin_Click(object sender, EventArgs e)
    {
        DBReservations.clearDB();
    }
}