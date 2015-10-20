using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        labelCurrentPassword.Text = cookieUsername.Value;
        labelCurrentUser.Text = Server.HtmlEncode(Request.Cookies["Username"].Value);
    }
}