
using System.Text.RegularExpressions;

namespace BusinessLayer
{
    /// <summary>
    /// validates the given inputs while registering
    /// </summary>
    public class BALValidations
    {
        /// <summary>
        /// validates the username
        /// </summary>
        public bool IsUserName(string userName)
        {
            if (userName == null)
                return false;
            return true;
        }

        /// <summary>
        /// validates the password
        /// </summary>
       public bool IsPassword(string password)
        {
            string pattern = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$";
            return Regex.IsMatch(password, pattern);
        }

        /// <summary>
        /// validates the emailid
        /// </summary>
        public bool IsEmailId(string emailId)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(emailId, pattern);            
        }

        /// <summary>
        /// validates the mobile number
        /// </summary>
        public bool IsMobileNo(string mobileNo)
        {
            string pattern = @"^\d{10}$";
            return Regex.IsMatch(mobileNo, pattern);             
        }
    }
}