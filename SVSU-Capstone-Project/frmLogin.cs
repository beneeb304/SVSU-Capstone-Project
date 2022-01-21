using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVSU_Capstone_Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Boolean vars to check username and password
            bool blnUsername = true, blnPassword = true;

            //Check if username is blank
            if(txtUsername.Text.Length == 0)
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
            if(blnUsername && blnPassword)
            {
                //If credentials don't pass, alert user and empty textboxes


                //If credentials pass, close the form and set username
                frmMain.strUsername = txtUsername.Text;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Close application
            Application.Exit();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            //Clear the error provider
            erpUsername.Clear();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            //Clear the error provider
            erpPassword.Clear();
        }
    }
}
