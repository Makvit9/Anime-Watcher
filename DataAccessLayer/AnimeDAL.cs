using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeWatcherDataLayer
{
    public class AnimeDAL
    {
        // Here all the CRUD related to Anime 
        //List<object> AnimeData = new List<object>();


        public static DataTable FindAnime(string AnimeName)
        {
            SqlConnection connection = new SqlConnection(connectionString.myConnectionString);

            DataTable dt = new DataTable();

            string Query = @" 
                            SELECT 
                            * from Animes
                            WHERE name like @AnimeName";



            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("AnimeName", AnimeName + "%");

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                connection.Close();
            }

        }


        public static bool IsAnimeExists(string username, string AnimeName)
        {
            SqlConnection connection = new SqlConnection(connectionString.myConnectionString);

            bool isFound = false;

            string Query = @"SELECT * FROM Watches 
                             INNER JOIN Animes 
                             ON ANimes.AnimeID = Watches.AnimeID 
                             INNER JOIN USERs 
                             ON Users.UserID = Watches.UserID 
                             WHERE Users.Username = @username and Animes.Name = @AnimeName";




            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("username", username);
            command.Parameters.AddWithValue("AnimeName", AnimeName);


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


                isFound = false;
            }
            finally
            {

                connection.Close();
            }
            return isFound;
        }



        public static void AnimeList(string AnimeName)
        {
            


            SqlConnection connection = new SqlConnection(connectionString.myConnectionString);

            string Query = @"Select * from Animes where Name = @AnimeName";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@AnimeName", AnimeName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();


            }
            catch (Exception)
            {

                throw;
            }


           
        }


        public static DataTable LoadAnime(string Username)
        {
            SqlConnection connection = new SqlConnection(connectionString.myConnectionString);

            DataTable dt = new DataTable();

            string Query = @" 
                            SELECT 
                            Animes.Name , Animes.Genre , Animes.NumberOfEpisode , 
                            Watches.StartingDate  , Animes.PicturePath 
                            FROM Watches
                            INNER JOIN Animes
                            on Animes.AnimeID = Watches.AnimeID
                            INNER JOIN Users
                            on Users.UserID = Watches.UserID
                            WHERE Users.Username = @Username";



            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("Username", Username);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                connection.Close();
            }

        }


        public static void AddAnime(string AnimeName , string Username)
        {
            SqlConnection connection = new SqlConnection(connectionString.myConnectionString);

            string Query = @"
                             INSERT INTO Watches (Watches.AnimeID, watches.UserID , StartingDate )
                             VALUES
                            ((  
                            SELECT Animes.AnimeID   
                            FROM Animes
                            WHERE Animes.Name = @AnimeName 
                            ),
                            (
                            SELECT Users.UserID FROM Users
                            WHERE Username = @Username
                            ),
                            GETDATE()
                            )";
        
        
        SqlCommand command = new SqlCommand(Query,connection);
            command.Parameters.AddWithValue("@AnimeName ", AnimeName);
            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();
                int AffectedRows = command.ExecuteNonQuery();
                if (AffectedRows > 0) { return; }
            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }
        
        }



        public static bool DeleteAnime(string AnimeName)
        {

            SqlConnection connection = new SqlConnection(connectionString.myConnectionString);

            string Query = "DELETE watches " +
                "FROM Watches " +
                "INNER JOIN Animes " +
                "ON Animes.AnimeID = Watches.AnimeID " +
                "WHERE Animes.Name = @AnimeName";


            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("AnimeName", AnimeName);

            try
            {
                connection.Open();
                int AffectedRows = command.ExecuteNonQuery();
                return (AffectedRows > 0);
            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }



        }



    }
}
