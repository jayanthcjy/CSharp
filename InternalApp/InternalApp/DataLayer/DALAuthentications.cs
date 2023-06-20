using BusinessModels;
namespace DataLayer
{
    internal class DALAuthentication:IDALAuth
    {
        //internal DALAuthentication() { }
        /// <summary>
        /// Validates the user
        /// </summary>
        
        public bool FetchData(Users user)
        {
            Users userObject = DataSource.storage.Find(DataBase => DataBase.userName == user.userName);
            if(userObject != null)
            {
                if(userObject.password==user.password)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Check wheather the username present in the database ,if not present it insert into the database
        /// </summary>
        public bool SaveData(Users user)
        {
            Users userObject = DataSource.storage.Find(DataBase =>DataBase.userName == user.userName);
            if (userObject != null)
            {
                return false;
            }
            DataSource db = new DataSource();
            db.SaveData(user);
            return true;
        }

        /// <summary>
        /// take the username and password from BAL and update the password if the user exit in the database
        /// And send the response whether the password is updated or not
        /// </summary>
        public bool UpdatePassword(string userName, string newPassword)
        {
            Users userObject = DataSource.storage.Find(DataBase => DataBase.userName == userName);

            if (userObject != null) {

                userObject.password = newPassword;
                return true;
            }            

            return false;

        }
    }
}