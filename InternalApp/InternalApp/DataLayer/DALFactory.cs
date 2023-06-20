
namespace DataLayer
{
    public class DALFactory
    {
        /// <summary>
        /// Method used to create an object for DALAuthentication
        /// </summary>
        /// <returns></returns>
        
        DALAuthentication obj=new DALAuthentication();
        public IDALAuth DALFactoryObject()
        {
            return  obj;
        }
    }
}
