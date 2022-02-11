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
        public static InvDb dbContext = new InvDb();
        public static User Authenticate( string username, string password )
        {
            // get hash from pass
            var strHash = GenerateHash(password);
            // compare hash to hash in db
            var objUserProfile = dbContext.dsUsers.FirstOrDefault(u => u.strSvsu_id == username && u.strHash == strHash);
            // return user profile if found
            return objUserProfile;
        }
        public static string GenerateHash( string value )
        {
            // Calculate SHA256 hash
            var sha256 = System.Security.Cryptography.SHA256.Create();
            var inputBytes = Encoding.ASCII.GetBytes(value);
            var hash = sha256.ComputeHash(inputBytes);
            return Convert.ToBase64String(hash);
        }
    }
}
