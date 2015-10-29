using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class login : System.Web.UI.Page
{
    public HttpCookie cookieUsername;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       //currently broken - out of context
        HttpCookie cookieUsername = new HttpCookie(txtboxUsername.Text);
        cookieUsername.Value = DateTime.Now.ToString();
        cookieUsername.Expires = DateTime.Now.AddDays(1);
        Response.Cookies.Add(cookieUsername);

        HttpCookie cookiePassword = new HttpCookie(txtboxPassword.Text);
        cookiePassword.Value = DateTime.Now.ToString();
        cookiePassword.Expires = DateTime.Now.AddDays(1);
        Response.Cookies.Add(cookieUsername);
    }
}