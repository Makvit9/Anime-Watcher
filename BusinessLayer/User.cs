using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AnimeWatcherDataLayer;
using System.Text.RegularExpressions;
using AnimeWatcherBusinessLayer.Hash;


namespace AnimeWatcherBusinessLayer
{
    public class User 
    {

        //implementing the IHash Interface 

        static HashAlgorithmName HashName => HashAlgorithmName.SHA512;
        
        public string HashPassword(string Password, out byte[] salt)
        {
            //create the salt and fill with random bits 
            RandomNumberGenerator rnd = RandomNumberGenerator.Create();
            salt = new byte[HashSettings.KEYSIZE];
            rnd.GetBytes(salt);
            //Salt done
            var Hash = new Rfc2898DeriveBytes(Password , salt , HashSettings.ITERATIONS , HashName).GetBytes(HashSettings.KEYSIZE);


            return Convert.ToBase64String(Hash);
        }
        // End of Implementation

        void Append(string Hashed)
        {
            _password = Hashed;
        }

        private string _username;
        private string _email;
        private string _password;
        private string _salt;

        public string UserName { get { return _username; } }
        public string Email { get { return _email; } }
        public string Password { get { return _password; } }

        public string Salt { get { return _salt; } }

        // for login
        public User(string username,  string password)
        {
            _username = username;
            _password = password;
        }

        private User(string username)
        {
            _username = username;
        }
        // for signup
        public User(string username, string password, string email)
        {
            byte[] salt;
            _username = username;
            _email = email;
            _password = HashPassword(password, out salt);
            _salt = Convert.ToBase64String(salt);
        }


        private void _decrypt() // when retrieving the data from DB
        {
            
            
        }

        private void _encrypt() // Before sending to DB (called from the constructor)
        {
            
        }


        public static bool IsEmailValid(string EmailAddress)
        {
            Regex rgx = new Regex(@"^[A-Z0-9a-z._%+-]{2,63}@(?:[A-Za-z0-9-]{1,125}\.)+[A-Za-z]{2,63}$");
            
            return rgx.IsMatch(EmailAddress);

        }

        private string _convertByteArrayToString(byte[] bytes)
        {
            string DesiredString = BitConverter.ToString(bytes);
            DesiredString = DesiredString.Replace("-", "");
            return DesiredString;
        }
        //current regex "\w+[@][.][a-zA-Z]{3}"g
        // new one "\b[A-Za-z0-9._-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b"
        // also refined "^[A-Za-z0-9._-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"

        public void AddUser() // I might create a separate class for these two methods 
        {
            UserDAL.AddUser(_username, _password,_email,_salt);
        }

        public void Load()
        {

        }

        private bool _isAuthenticated() => UserDAL.FindUser(_username, _password);
                
        
        public static bool IsTheUserExists(string username) => UserDAL.IsUsernameExists(username);
        
        public static bool IsEmailExists(string email) => UserDAL.IsEmailExists(email);
            
        

        public static User IsAuthenticated(string Username , string password)
        {
            if (!UserDAL.IsUsernameExists(Username))
            { return null; }
            else
            {
                User user1 = new User(Username);
                UserDAL.GetUserInfo( Username,ref user1._email , ref user1._password ,ref user1._salt);
                if (CheckUserPassword(password, user1.Password ,user1.Salt))
                    return user1;
            }

            return null;

           // bool result = _isAuthenticated();
          //  return result;
        
        }

        private static bool CheckUserPassword(string Password, string UserPassword,string Salt)
        {
            
            byte[] userHash = Convert.FromBase64String(UserPassword);
            byte[] salt = Convert.FromBase64String(Salt);

            var Hash = new Rfc2898DeriveBytes(Password, salt, HashSettings.ITERATIONS, HashName).GetBytes(HashSettings.KEYSIZE);

            int i = 0;
            while (i < userHash.Length)
            {
                if (userHash[i] != Hash[i])
                {
                    return false;
                }
                i++;
            }
            return true;
            
        }

        public void UpdateUsername(string NewUsername )
        {
            _username = UserDAL.UpdateUsername(NewUsername,_username);
            
        }

        private void _changeUsername(string newUsername)
        {

        }

        public static void UpdateEmail(string NewEmail , string OldEmail)
        {
            UserDAL.UpdateEmail(NewEmail, OldEmail);
        }

        public static void ChangePassword(string NewPassword , User user)
        {
            UserDAL.UpdatePassword(NewPassword,user.Password , user.UserName);
        }



        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
