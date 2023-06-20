
namespace BusinessLayer
{
    public class BALFactory
    {
        BALAuthentication obj = new BALAuthentication();
        public IBALAuth BALFactoryObj()
        {
            return obj;
        }


    }
}
