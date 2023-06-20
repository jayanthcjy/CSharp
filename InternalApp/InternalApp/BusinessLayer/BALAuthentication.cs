using BusinessModels;
using DataLayer;

namespace BusinessLayer
{
    /// <summary>
    /// Businesslayer authentication class
    /// </summary>
    public class BALAuthentication:IBALAuth
    {
        /// <summary>
        /// get values from ui and send it into dataacceesslayer for login
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Login(Users user)
        {
            DALFactory fact = new DALFactory();
            IDALAuth Idata = fact.DALFactoryObject();

            //DALAuthentication validate = new();
            return Idata.FetchData(user);
        }
        /// <summary>
        /// get values from ui and send it into dataAccessLayer for Registering
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Register(Users user)
        {
            DALFactory fact = new();
            IDALAuth Idata = fact.DALFactoryObject();
            //DALAuthentication validate = new();
            return Idata.SaveData(user);
        }

        /// <summary>
        /// taking the username and password from user and updating the passsword in database
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ForgetPassword(string userName, string password)
        {
            DALFactory fact = new();
            IDALAuth Idata = fact.DALFactoryObject();

            return Idata.UpdatePassword(userName,password);
        }
    }
}
