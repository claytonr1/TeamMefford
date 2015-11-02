using System;
using System.Web;
using RuffCoJetReservationSystem.DBHandlers;

/// <summary>
/// Summary description for Cookies
/// </summary>
public static class CookieHandler
{

        public static void setUserPassword(string username, string password) //used from login button after information is validated
        {

            HttpContext.Current.Response.Cookies["Username"].Value = username;
            HttpContext.Current.Response.Cookies["Password"].Value = password;
        }

        public static void clearUserPassword() //logout button
        {
            HttpContext.Current.Response.Cookies["Username"].Value = String.Empty;
            HttpContext.Current.Response.Cookies["Password"].Value = String.Empty;
        }

        public static string getUsername() //returns string of username stored in cookie, should have a check for if "none"
        {
            string response = "none";
            try 
            {
                response = HttpContext.Current.Request.Cookies["Username"].Value;
            }
            catch (Exception)
            {
            }//if error on finding cookie, the pasword remains "none"
            return response;
        }

        public static string getPassword() //returns a string of password stored in cookie
        {
            string response = "none";
            try 
            {
                response = HttpContext.Current.Request.Cookies["Password"].Value;
            }
            catch (Exception)
            {
            }//if error on finding cookie, the pasword remains "none"
            return response;
        }

        public static void checkLogin() 
            //if this method were added as follows to the load portion of every page,
            // then it would redirect if it could not validate
            // CookieHandler.checkLogin();
        {
            if (getPassword()==DBEmployees.getPassword(getUsername())) //if password in cookie = password from username
            {
                //do nothing, aka use page
            }
            else
            {
                HttpContext.Current.Response.Redirect("login.aspx"); 
                //else redirect to login
            
            }

        }

        public static int getID()
        {
            return DBEmployees.getIDByUsername(getUsername());
        }

        public static string getUserFullName()
        {
            return DBEmployees.getFName(CookieHandler.getID()) + " " + DBEmployees.getLName(CookieHandler.getID());
        }
}

	



