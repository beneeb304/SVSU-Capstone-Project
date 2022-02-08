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

            if (txtUsername.Text.Length == 0)
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

            if (blnUsername && blnPassword)
            {
                //Hash password
                string strHashedPassword = HashPassword(txtPassword.Text);

                //Check to see if username/password pair exists in database
                if (true)
                {
                    //GET User's info FROM DATABASE QUERY

                    //If credentials pass, close the form and set username
                    frmMain.LoggedInUser.intSVSU_ID = int.Parse(txtSVSU_ID.Text);
                    frmMain.LoggedInUser.strFName = "John";
                    frmMain.LoggedInUser.strLName = "Doe";
                    frmMain.LoggedInUser.strEmail = "jdoe@svsu.edu";
                    frmMain.LoggedInUser.strPhone = "989-765-4321";
                    frmMain.LoggedInUser.blnAdmin = true;

                    Close();
                }
                else
                {
                    //If not, alert the user and empty the textboxes
                    //txtUsername.Text = "";
                    //txtPassword.Text = "";
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
