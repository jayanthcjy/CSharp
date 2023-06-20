using BusinessModels;

namespace BusinessLayer
{
    public interface IBALAuth
    {
        public bool Login(Users user);
        public bool Register(Users user);   
        public bool ForgetPassword(string userName,string password);
    }
}
