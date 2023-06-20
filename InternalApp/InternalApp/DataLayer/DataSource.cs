using BusinessModels;

namespace DataLayer
{
    internal class DataSource
    {

        public static List<Users> storage = new List<Users>();

        /// <summary>
        /// Method used to add data to the list
        /// </summary>        
        public void SaveData(Users user)
        {
            storage.Add(user);
        }
    }
}
