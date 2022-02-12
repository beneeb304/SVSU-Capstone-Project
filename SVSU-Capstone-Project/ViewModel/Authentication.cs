using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVSU_Capstone_Project.Model;

namespace SVSU_Capstone_Project.ViewModel
{
    public static class Authentication
    {
        private static InvDb dbContext = new InvDb();
        public static User ActiveUser { get; set; }
        /// <summary>
        /// Authenticates a user's credentials
        /// </summary>
        /// <param name="username">The user's plaintext username</param>
        /// <param name="password">The user's plaintext password</param>
        /// <returns>The user object if the credentials are valid, null otherwise</returns>
        /// <throws> ArgumentException if username or password are null or empty </throws>
        /// <throws> ArgumentException if username is not found </throws>
        /// <throws> ArgumentException if password is incorrect </throws>
        public static User Authenticate( string username, string password ) 
        {
            if( string.IsNullOrEmpty( username ) )
                throw new ArgumentException( "Username cannot be null or empty" );
            if( string.IsNullOrEmpty( password ) )
                throw new ArgumentException( "Password cannot be null or empty" );
            // get hash from pass
            var strHash = GenerateHash(password);
            // compare hash to hash in db
            var objUserProfile = dbContext.dsUsers.FirstOrDefault(u => u.strSvsu_id == username);
            // return user profile if found
            if (objUserProfile == null) throw new UserNotFoundException("User does not exist");
            if (objUserProfile.strHash != strHash) throw new PasswordInvalidException($"Password does not match for {objUserProfile.strSvsu_id}");
            ActiveUser = objUserProfile;
            return ActiveUser;
        }
        public static string GenerateHash( string value )
        {
            // Calculate SHA256 hash
            var sha256 = System.Security.Cryptography.SHA256.Create();
            var inputBytes = Encoding.ASCII.GetBytes(value);
            var hash = sha256.ComputeHash(inputBytes);
            return Convert.ToBase64String(hash);
        }
        public static bool SecurityBypass()
        {
            ActiveUser = dbContext.dsUsers.FirstOrDefault();
            if (ActiveUser == null) return false;
            else return true;
        }
    }
    public class UserNotFoundException : Exception
        {
            public UserNotFoundException( string message ) : base(message)
            {
            }
        }
        public class PasswordInvalidException : Exception
        {
            public PasswordInvalidException( string message ) : base(message)
            {
            }
        }
}
