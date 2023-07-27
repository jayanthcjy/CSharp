using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    /// <summary>
    /// This class is for indirectly acessing of the DataAcess methods
    /// </summary>
    public class DataFactory
    {
        DataAcess obj=new DataAcess();
        /// <summary>
        /// returning the DataAcess class object
        /// </summary>
        /// <returns></returns>
        public IDataModel DataAccessObject()
        {
            return obj;
        }
    }
}
