using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace BLLL
{
    internal class BLLAuthentication: IBLLAuthentication
    {
        /// <summary>
        /// taking the user oject from the Registration.aspx.cs and sending the object to the SaveData
        /// </summary>
        public string Registration(User user)
        {
            IDataModel dataAcessObj = new DataFactory().DataAccessObject();
            user.Password=new BLLAuthentication().Encrypt(user.Password);
            string result=dataAcessObj.SaveData(user);
            return result;     
            
        }

        /// <summary>
        /// taking the user oject from the Login.aspx.cs and sending the object to the FechData
        /// </summary>
        public string Login(User user)
        {
            IDataModel dataAcessObj = new DataFactory().DataAccessObject();

            string result = dataAcessObj.IsUserExist(user);
            if (result== "UserExist")
            {
                string encryptPassword=dataAcessObj.EncryptPassword(user);
                string decryptPassword = new BLLAuthentication().Decrypt(encryptPassword);
                if (user.Password == decryptPassword)
                {
                    return "LoginSuccess";
                }
                return "IncorrectPassword";
            }
            return result;

        }

        public void IsUserExist(User user)
        {

        }

        /// <summary>
        /// taking the user oject from the ForgotPassword.aspx.cs and sending the object to the UpdateData
        /// </summary>
        public string ForgotPassword(User user)
        {
            IDataModel dataAcessObj = new DataFactory().DataAccessObject();
            user.Password = new BLLAuthentication().Decrypt(user.Password);
            string result = dataAcessObj.UpdateData(user);
            return result;
        }

        /// <summary>
        /// Encripting the password
        /// </summary>
        public string Encrypt(string password)
        {
            int key = 10;

            string encryptPass = "";

            foreach (char c in password)
            {
                encryptPass += Convert.ToChar(Convert.ToInt32(c) ^ key);
            }
            return encryptPass;
        }
        public string Decrypt(string password)
        {
            int key = 10;

            string decryptPass = "";

            foreach (char c in password)
            {
                decryptPass += Convert.ToChar(Convert.ToInt32(c) ^ key);
            }
            return decryptPass;
        }



    }
}
