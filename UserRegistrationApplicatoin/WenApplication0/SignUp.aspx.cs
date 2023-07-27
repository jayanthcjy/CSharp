using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLLL;

namespace WebApplication0
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Register button
        /// </summary>
        protected void BtnSave_Click(object sender, EventArgs e)
        {           
            User user = new User();
            user.FirstName=txtEmailid.Text;
            user.LastName=txtFirstName.Text;
            user.UserId=txtUserId.Text;
            user.EmailId=txtEmailid.Text;
            user.Password=txtPassword.Text;

            IBLLAuthentication bLLAuthenticationObject = new BusinessFactory().BLLAuthenticationObject();
            string result = bLLAuthenticationObject.Registration(user);
            if (result == "RegistrationSuccessfull")
            {
                Response.Redirect("WelcomePage.aspx");

            }
            else if (result== "UserAlreadyExist")
            {
                Response.Write("<script>alert('" + Literals.UserAlreadyExist + "');</script>");
            }
            else if (result== "InvalidCastException")
            {
                Response.Write("<script>alert('" + Literals.InvalidCast + "');</script>");

            }
            else if (result == "InvalidOperationException")
            {
                Response.Write("<script>alert('" + Literals.InvalidOperation + "');</script>");

            }
            else if (result == "IOException")
            {
                Response.Write("<script>alert('" + Literals.IOException + "');</script>");

            }
            else
            {
                Response.Write("<script>alert('" + Literals.RegistrationUnSuccess+ "');</script>");

            }


        }
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}