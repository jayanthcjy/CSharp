using BLLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    /// <summary>
    /// interface methods that are should be implemented for the Data Acess class
    /// </summary>
    public interface IDataModel
    {
        string SaveData(User user);
        string UpdateData(User user);

        string EncryptPassword(User user);
         string IsUserExist(User user);


    }
}
