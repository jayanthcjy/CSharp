using System;
using System.Configuration;
namespace DALayer
{
    public class Class1
    {
        public int SaveData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

            return 0;
        }
    }
}