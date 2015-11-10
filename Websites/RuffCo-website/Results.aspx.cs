using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Results : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CookieHandler.checkLogin();
        labelName.Text = CookieHandler.getUserFullName();
        labelJet.Text = CookieHandler.getCookieValue("jet");
        labelDate.Text = CookieHandler.getCookieValue("date");
        labelDestination.Text = CookieHandler.getCookieValue("dest");
    }
}