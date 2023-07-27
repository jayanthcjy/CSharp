using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLLL;

namespace WebApplication0
{
    public partial class ForgetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Reset password button method
        /// </summary>        
         protected void BtnSave_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserId=txtUserId.Text;
            user.Password=txtNewPass.Text;

            if (user.Password == txtConfirmPassword.Text)
            {

                IBLLAuthentication bLLAuthenticationObject = new BusinessFactory().BLLAuthenticationObject();
                string result = bLLAuthenticationObject.ForgotPassword(user);
                if (result == "UpdateSuccess")
                {
                    Response.Redirect("Login.aspx");
                }
                
                    else if (result == "UserNotExist")
                {
                    Response.Write("<script>alert('" + Literals.UserNotExist + "');</script>");

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
                    Response.Write("<script>alert('" + Literals.PasswordUpdatedNotSuccess + "');</script>");

                }
            }
            else
            {
                Response.Write("<script>alert('"+Literals.PasswordsNotSame+"');</script>");


            }
        }
    }
}