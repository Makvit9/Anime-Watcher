using AnimeWatcherDataLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeWatcherBusinessLayer
{
    //This class Will contain a list of the animes associated with a certain user
    public class Account
    {
        private User _user;
        private DataTable _userAnimes;

        public User AccountUser
            {
            get { return _user; }
        }

        public DataTable UserAnimes
        {
            get { return  this._userAnimes; }
            set { this._userAnimes = value; }
        }

        public Account(User user)
        {
            _user = user;
            _userAnimes = new DataTable();
            _userAnimes = LoadData();
        }


        public  DataTable LoadData()
        {


            try
            {
                return (AnimeDAL.LoadAnime(_user.UserName));

            }
            catch (Exception)
            {

                throw;
            }

        }


        public bool IsAnimeExists(string AnimeName)
        {
            return AnimeDAL.IsAnimeExists(_user.UserName, AnimeName);
        }

        public void ADD(string AnimeName)
        {
            AnimeDAL.AddAnime(AnimeName, _user.UserName);
        }


     
        public void Delete(string AnimeName)
        {
            AnimeDAL.DeleteAnime(AnimeName);
           // LoadData();
        }



    }

}
