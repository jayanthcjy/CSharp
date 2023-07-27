using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLL
{
    /// <summary>
    /// BLLAuthentication methods
    /// </summary>
    public interface IBLLAuthentication
    {
        string Login (User user);
        string Registration (User user);
        string ForgotPassword(User user);
        string Encrypt(string password);

    }
}
