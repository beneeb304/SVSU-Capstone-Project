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
            bool blnUsername = true, blnPassword = true;

            //Check if username is blank
            if (txtUsername.Text.Length == 0)
            {
                blnUsername = false;
                erpUsername.SetError(txtUsername, "Please enter a username");
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
                    //If credentials pass, close the form and set username
                    frmMain.strUsername = txtUsername.Text;
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
