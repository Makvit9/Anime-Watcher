using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net.Http.Headers;
using AnimeWatcherDataLayer;

namespace AnimeWatcherBusinessLayer
{
    public class Anime
    {
        private string _name;
        private int _numberOfEpisodes;
        private string _path;
        private DateTime _releaseDate;
        private byte[] _Picture;
        //private User _user = new User("Makvit9" , "1111" );

        public string Name { get { return _name; } }
        public string Path { get { return _path; } }
        public int NumberOfEpisodes { get { return _numberOfEpisodes; } }
        public DateTime ReleaseDate { get { return _releaseDate; } }
    
        

        public Anime()
        {
            //_user = new User("Makvit9" , "1111");
            
        }

        public Anime(string name)
        {
            _name = name;
        }



        //public static DataTable AddPictureToTable(DataTable Dt)
        //{

        //    Dt.Columns.Add("Picture", Type.GetType("System.Byte[]"));
        //    Dt.Columns.Add("Add", Type.GetType("System.Boolean"));

        //    foreach (DataRow row in Dt.Rows)
        //    {
        //        row["Picture"] = File.ReadAllBytes(row["PicturePath"].ToString());
        //        row["Add"] = DataLayer.FindAnime( "Makvit9", row["Name"].ToString());
        //    }



        //    //Dt.Columns.RemoveAt(Dt.Rows.Count - 2);

        //    return Dt;

        //}

        public DataTable FindAnime(string AnimeName)
        {
            try
            {
                return (AnimeDAL.FindAnime(AnimeName));
            }
            catch (Exception)
            {

                throw;
            }
        }



    }

    }

