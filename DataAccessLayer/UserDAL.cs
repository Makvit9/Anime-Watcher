using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AnimeWatcherDataLayer
{
    public class UserDAL
    {
        // All the CRUD related to the current user 


        //1. Mathcing and Searching 

        // TODO: Create the email retrieval method


        public static bool FindUser(string username, string password)
        {
            SqlConnection connection = new SqlConnection(connectionString.myConnectionString);

            string Query = @"Select * from Users Where Username = @username and password = @password";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("username", username);
            command.Parameters.AddWithValue("password", password);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    return true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }



            return false;
        }

        public static void GetUserInfo(string Username, ref string Email,ref  string Password, ref string Salt)
        {
            SqlConnection conn = new SqlConnection(connectionString.myConnectionString);
            string Query = @"Select * from Users where Username = @Username";


            SqlCommand command = new SqlCommand(Query, conn);
            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Email = (string)reader["Email"];
                    Password = (string)reader["password"];
                    Salt = (string)reader["Salt"];
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        
        
        
        }


        public static bool IsUsernameExists(string username)
        {
            SqlConnection connection = new SqlConnection(connectionString.myConnectionString);
            string Query = "Select username from Users where username = @username";


            SqlCommand command = new SqlCommand(Query,connection);
            command.Parameters.AddWithValue("@username", username);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    return true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }

            return false;
        }

        public static bool IsEmailExists(string email)
        {
            SqlConnection connection = new SqlConnection(connectionString.myConnectionString);
            string Query = "Select email from Users where email = @email";


            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@email", email);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    return true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }

            return false;
        }


        // 2. Creating a new user in the database 


        public static void AddUser(string username , string password , string email , string salt)
        {
            SqlConnection connection = new SqlConnection(connectionString.myConnectionString);

            string Query = @"INSERT INTO Users
                             VALUES (@username , @email , @password , @salt)";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@salt", salt);
           


            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    return;
                }

                }
            catch (Exception e )
            {

                throw e ;
            }
            

        }

        public static string UpdateUsername(string newusername , string username)
        {

            SqlConnection connection = new SqlConnection(connectionString.myConnectionString);

            string Query = @"UPDATE Users 
                            SET Username = @newusername 
                            WHERE Username = @username";
            
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@newusername", newusername);


            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    return newusername;
                }
            }
            catch (Exception)
            {

                return username;
            }
            finally { connection.Close(); }

            return username;
        
        }

        public static void UpdateEmail(string newemail, string email)
        {

            SqlConnection connection = new SqlConnection(connectionString.myConnectionString);

            string Query = @"UPDATE Users 
                            SET Email  = @newEmail 
                            WHERE Email = @email";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@newEmail", newemail);


            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    return;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static void UpdatePassword(string newpassword, string password , string username) // This needs to be hashed asap
        {

            SqlConnection connection = new SqlConnection(connectionString.myConnectionString);

            string Query = @"UPDATE Users 
                            SET Password  = @newpassword 
                            WHERE password = @password and username = @username";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@newpassword", newpassword);
            command.Parameters.AddWithValue("@username", username);


            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    return;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        
        
        
        
        // Delete the user
        
        public static void DeleteUser(string username)
        {
            SqlConnection connection = new SqlConnection(connectionString.myConnectionString);

            string Query = @"DELETE FROM USERS WHERE username = @username";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@username", username);
            

            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    return;
                }

            }
            catch (Exception e)
            {

                throw e;
            }
        }



        


    }
}
