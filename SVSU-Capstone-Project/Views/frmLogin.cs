using SVSU_Capstone_Project.Model;
using SVSU_Capstone_Project.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVSU_Capstone_Project.Views
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click( object sender, EventArgs e )
        {
            //Boolean vars to check username and password
            bool blnSVSU_ID = true, blnPassword = true;

            //Check if username is blank
            if (txtSVSU_ID.Text.Length == 0)
            {
                blnSVSU_ID = false;
                erpUsername.SetError(txtSVSU_ID, "Please enter an SVSU ID");
            }

            //Check if password is blank
            if (txtPassword.Text.Length == 0)
            {
                blnPassword = false;
                erpPassword.SetError(txtPassword, "Please enter a password");
            }

            //If there are values in both textboxes, continue to check
            if (blnSVSU_ID && blnPassword)
            {                
                //Use these creds to login:
                //ID:   500004
                //Pass: Capstone424
                
                //Query db to get user's info
                var user = ItemModel.Get<User>(
                    x => x.strHash == HashPassword(txtPassword.Text)
                    && x.strSvsu_id == txtSVSU_ID.Text);

                //Check to see if username/password pair exists in database
                if (user != null)
                {
                    //If credentials passed, set LoggedInUser properties
                    frmMain.LoggedInUser.intSVSU_ID = int.Parse(user.strSvsu_id);
                    frmMain.LoggedInUser.strFName = user.strFirst_name;
                    frmMain.LoggedInUser.strLName = user.strLast_name;
                    frmMain.LoggedInUser.strEmail = user.strEmail;
                    frmMain.LoggedInUser.strPhone = user.strPhone;
                    frmMain.LoggedInUser.blnAdmin = user.blnIsAdmin;

                    //Close the form
                    Close();
                }
                else
                {
                    //If not, alert the user
                    MessageBox.Show("Incorrect SVSU ID and Password Combination!", "Alert");

                    //Empty the textboxes
                    txtSVSU_ID.Text = "";
                    txtPassword.Text = "";
                }
            }
        }

        private string HashPassword( string strPassword )
        {
            byte[] bytes = Encoding.Unicode.GetBytes(strPassword);
            byte[] hashedBytes = HashAlgorithm.Create("SHA256").ComputeHash(bytes);
            return Convert.ToBase64String(hashedBytes);
        }

        private void btnCancel_Click( object sender, EventArgs e )
        {
            //Close application
            Application.Exit();
        }

        private void txtUsername_Click( object sender, EventArgs e )
        {
            //Clear the error provider
            erpUsername.Clear();
        }

        private void txtPassword_Click( object sender, EventArgs e )
        {
            //Clear the error provider
            erpPassword.Clear();
        }
    }
}
