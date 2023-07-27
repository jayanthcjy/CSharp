using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLL
{
    
    public class BusinessFactory
    {
        BLLAuthentication obj=new BLLAuthentication();
        
        /// <summary>
        /// returing the BLLAuthentication object
        /// </summary>
        /// <returns></returns>
        public IBLLAuthentication BLLAuthenticationObject()
        {
            return obj;
        }
    }
}
