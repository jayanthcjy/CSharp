using BusinessLayer;
using BusinessModels;

namespace ConsoleApp
{
    public class Authentication
    {
        
        /// <summary>
        /// reads two inputs username and password for login
        /// </summary>
        /// <returns></returns>
        public void Login()
        {
            BALAuthentication businessObject = new BALAuthentication();

            Console.WriteLine(Literals.userName);
            Users users = new Users();
            users.userName = Console.ReadLine();

            Console.WriteLine(Literals.password);
            users.password = Console.ReadLine();

            if (businessObject.Login(users))
            {
                Console.WriteLine(Literals.welcomeMsg);
                Console.WriteLine(Literals.logout);

                Console.ReadKey();
                Console.WriteLine(Literals.logoutMsg);
            }
            else
            {
                Console.WriteLine(Literals.invalidLogin);
            }
        }
        /// <summary>
        /// Reads data from the user and validates them;
        /// </summary>
        /// <returns></returns>
        /// 
        public void Register()
        {
            Users user = new Users();
            BALAuthentication balAuth = new BALAuthentication();

            BALValidations validate = new BALValidations();
            string email;
            while (true)
            {
                Console.WriteLine(Literals.emailId);
                email = Console.ReadLine();
                if (validate.IsEmailId(email))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(Literals.invalidEmailId);
                }
            }

            string mobileNumber;
            while (true)
            {
                Console.WriteLine(Literals.mobileNumber);
                mobileNumber = Console.ReadLine();
                if (validate.IsMobileNo(mobileNumber))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(Literals.invalidMobile);
                }
            }

            string userName;
            while (true)
            {
                Console.WriteLine(Literals.userName);
                userName = Console.ReadLine();
                if (validate.IsUserName(userName))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(Literals.invalidUserName);
                }
            }

            string password;
            while (true)
            {
                Console.WriteLine(Literals.password);
                password = Console.ReadLine();
                if (validate.IsPassword(password))
                {
                    Console.WriteLine(Literals.rePassword);
                    string confirmPassword = Console.ReadLine();
                    if (confirmPassword == password)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(Literals.passwordMismatch);
                    }
                }
                else
                {
                    Console.WriteLine(Literals.invalidPassword);
                }
            }


            if (!balAuth.Register(user))
            {
                Console.WriteLine(Literals.userIdExists);
            }
            else
            {
                Console.WriteLine(Literals.success);
            }
        }

        /// <summary>
        /// reads the inputs for changing the password
        /// </summary>
        public void ForgetPassword()
        {
            BALAuthentication balAuth = new BALAuthentication();

            Console.WriteLine(Literals.userName);
            string userName=Console.ReadLine();
            Console.WriteLine(Literals.newPassword);
            string password = Console.ReadLine();

            if (balAuth.ForgetPassword(userName,password))
            {

                Console.WriteLine(Literals.passwordUpdated);
            }
            else
            {
                Console.WriteLine(Literals.invalidUser);
            }
        }
    }
}
