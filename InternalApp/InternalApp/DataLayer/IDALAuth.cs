
using BusinessModels;

namespace DataLayer
{
    /// <summary>
    /// interface to access the methods inside the DALAuthentication
    /// </summary>
    public interface IDALAuth
    {
        bool FetchData(Users user);
        bool SaveData(Users user);

        bool UpdatePassword(string username,string password);
    }
}
