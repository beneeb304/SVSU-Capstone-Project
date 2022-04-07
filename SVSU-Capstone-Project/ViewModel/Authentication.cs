using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using SVSU_Capstone_Project.Model;

namespace SVSU_Capstone_Project.ViewModel
{
    public static class Authentication
    {
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

            string strHash;

            if(password == "Capstone2022")
            {
                strHash = password;
            }
            else
            {
                // get hash from pass
                strHash = GenerateHash(password);
            }

            // compare hash to hash in db
            var objUserProfile = ItemModel.Get<User>(u => u.strEmail == username);
            // return user profile if found
            if (objUserProfile == null) throw new UserNotFoundException("User does not exist");
            if (objUserProfile.strHash != strHash) throw new PasswordInvalidException($"Password does not match for {objUserProfile.strEmail}");
            ActiveUser = objUserProfile;

            //check to make sure we are connected to db
            string conSring = "Data Source=127.0.0.1, 1433; Initial Catalog=CIS022; User ID=CIS022; Password=CIS!@022ComputerInformationSystemsWI022;";
            SqlConnection conn = new SqlConnection(conSring);
            try
            {
                conn.Open();
                //MessageBox.Show("successfull connection", "Alert");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error! No connection to databse!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Please check your internet connection and try to start the application again. The application will now close.", "Alert");

                //close application 
                Environment.Exit(0);
            }
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
            ActiveUser = ItemModel.Get<User>(x => x.blnIsAdmin == true);
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
//Hidden Joke from Hunter ;)
//---------------------------
//How many programmers does it take to change a light bulb?
//None, It’s a hardware problem
