using BusinessModels;

namespace ConsoleApp
{
    public class ConsoleApp
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine(Literals.choice);

                int input = Int32.Parse(Console.ReadLine());

                Authentication authenticate = new Authentication();
                
                    switch (input)
                    {
                        case (int)UserChoice.Login:
                            authenticate.Login();
                            break;
                        case (int)UserChoice.SignUp:
                            authenticate.Register();
                            break;
                        case (int)UserChoice.ForgetPassword:
                            authenticate.ForgetPassword();
                            break;
                        case (int)UserChoice.CloseApp:
                            return;
                        default:
                            Console.WriteLine(Literals.invalidChoice);
                            break;
                    }
                
            }
        }
    }
}