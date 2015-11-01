using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using RuffCoJetReservationSystem.DBHandlers;


public partial class login : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //I cannot get the open connection to work, am I using the string wrong?
        //DBHandler.openConection("Data Source=claytonr1.db.5867809.hostedresource.com;Initial Catalog=claytonr1;User ID=claytonr1;Password=Interface1");
       // DBHandler.populateDataSet();
       // DBHandler.closeConnection();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       
// if (DBEmployees.getPassword(txtboxUsername.Text)==txtboxPassword.Text)  
//      {
//          CookieHandler.setUserPassword(txtboxUsername.Text, txtboxPassword.Text);
//          HttpContext.Current.Response.Redirect("Menu.aspx"); 
//      }
//      else
//      {
//          txtboxUsername.Text = "";
//          txtboxPassword.Text = "";
//          labelErrorBox.Text = " Username or Password not found";

//      }
            

    }
}