using BLLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication0
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
            protected void BtnForgetPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForgotPassword.aspx");

        }
        /// <summary>
        /// Login button 
        /// </summary>        
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserId = txtUserId.Text;
            user.Password = txtPass.Text;

            IBLLAuthentication bLLAuthenticationObject = new BusinessFactory().BLLAuthenticationObject();
            string result = bLLAuthenticationObject.Login(user);
            if (result == "LoginSuccess")
            {
                Response.Redirect("WelcomePage.aspx");
            }
            else if(result == "IncorrectPassword")
            {
                Response.Write("<script>alert('" + Literals.IncorrectPassword + "');</script>");
            }


            else if (result == "InvalidCastException")
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
                Response.Write("<script>alert('" + Literals.LoginFailed + "');</script>");
            }



        }
        protected void BtnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }
    }
}