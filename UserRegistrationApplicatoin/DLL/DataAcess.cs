using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Common;
using System.Runtime.Remoting.Messaging;
using System.Linq.Expressions;
using System.IO;
using BLLL;
using System.CodeDom;

namespace DLL
{
    /// <summary>
    /// In this class we are doing the database operations
    /// </summary>
    internal class DataAcess : IDataModel
    {
        /// <summary>
        /// Inserting the data of a user into database if he is new user
        /// </summary>
        /// <returns></returns>
        public string SaveData(User user)
        {

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                string query1 = "SELECT * FROM PersonDetails WHERE UserId=@UserId ";
                connection.Open();
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                cmd1.Parameters.AddWithValue("UserId", user.UserId);
                SqlDataReader reader = cmd1.ExecuteReader();

                if (!reader.HasRows)
                {
                    reader.Close();
                    string query2 = "INSERT INTO PersonDetails VALUES(@FirstName,@LastName, @EmailId , @UserId , @encryptPassword)";
                    SqlCommand cmd2 = new SqlCommand(query2, connection);
                    cmd2.Parameters.AddWithValue("FirstName", user.FirstName);
                    cmd2.Parameters.AddWithValue("LastName", user.LastName);
                    cmd2.Parameters.AddWithValue("EmailId", user.EmailId);
                    cmd2.Parameters.AddWithValue("UserId", user.UserId);
                    cmd2.Parameters.AddWithValue("encryptPassword", user.Password);

                    int result = (int)cmd2.ExecuteNonQuery();

                    if (result == 1)
                    {
                        return "RegistrationSuccessfull";//Registration successfull
                    }

                }
                else
                {
                    return "UserAlreadyExist";//user alreay exist
                }

            }

            catch (InvalidCastException)
            {

                return "InvalidCastException";

            }
            catch (System.IO.IOException)
            {
                return "IOException";
            }
            catch (InvalidOperationException)
            {
                return "InvalidOperationException";

            }
            catch (SqlException ex)
            {
                return ex.ToString();
            }

            return "RegistrationNotSuccessfull";//Registration unsuccessfull something went wrong
        }


        /// <summary>
        /// Checking whether user is exist or not
        /// </summary>
        public string IsUserExist(User user)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query1 = "SELECT * FROM PersonDetails WHERE UserId= @UserId ";
                    connection.Open();
                    SqlCommand cmd1 = new SqlCommand(query1, connection);
                    cmd1.Parameters.AddWithValue("UserId", user.UserId);

                    SqlDataReader reader = cmd1.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return "UserExist";
                    }
                    return "UserNotExist";
                }
            }
            catch (InvalidCastException)
            {
                return "InvalidCastException";

            }
            catch (InvalidOperationException)
            {
                return "InvalidOperationException";

            }
            catch (System.IO.IOException)
            {
                return "IOException";
            }
            catch (SqlException ex)
            {
                return ex.ToString();
            }

        }
        /// <summary>
        /// Reseting the user password
        /// </summary>
        /// <returns></returns>
        public string UpdateData(User user)
        {
            try
            {

                string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query1 = "SELECT * FROM PersonDetails WHERE UserId=@UserId ";
                    connection.Open();
                    SqlCommand cmd1 = new SqlCommand(query1, connection);
                    cmd1.Parameters.AddWithValue("UserId", user.UserId);
                    SqlDataReader reader = cmd1.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Close();
                        string query2 = "UPDATE PersonDetails SET Password= @Password WHERE UserId=@UserId  ";

                        SqlCommand cmd2 = new SqlCommand(query2, connection);
                        cmd2.Parameters.AddWithValue("UserId", user.UserId);
                        cmd2.Parameters.AddWithValue("Password", user.Password);
                        int result = (int)cmd2.ExecuteNonQuery();
                        if (result == 1)
                        {
                            return "UpdateSuccess";
                        }

                    }
                    else
                    {
                        return "UserNotExist";//user does not exist
                    }
                }
            }
            catch (InvalidCastException)
            {
                return "InvalidCastException";

            }
            catch (InvalidOperationException)
            {
                return "InvalidOperationException";
            }
            catch (System.IO.IOException)
            {
                return "IOException";
            }
            catch (SqlException ex)
            {
                return ex.ToString();
            }

            return "NotUpdated";//Password not update something went wrong
        }

        /// <summary>
        /// returning the encryptPassword of specific user
        /// </summary>
        public string EncryptPassword(User user)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query1 = "SELECT * FROM PersonDetails WHERE UserId=@UserId ";
                connection.Open();
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                cmd1.Parameters.AddWithValue("UserId", user.UserId);
                SqlDataReader reader = cmd1.ExecuteReader();
                string encryptPassword = "";
                if (reader.HasRows)
                {
                    reader.Read();
                    encryptPassword = reader["Password"].ToString();
                }
                return encryptPassword;

            }
        }


    }
}
