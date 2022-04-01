using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVSU_Capstone_Project.ViewModel;

namespace SVSU_Capstone_Project
{
    public partial class frmSetPassword : Form
    {
        public static string strHash { get; set; }
        
        /* Function: frmSetPassword
         * Description: Initializes the form
         *
         * No Local Variables
         */
        public frmSetPassword()
        {
            InitializeComponent();
        }

        /* Function: brnCancel_Click
         * Description: Cancels the form and closes the dialog.
         *
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void btnCancel_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /* Function: btnSet_Click
         * Description: Sets the newly entered password. Ensures both fields match.
         *
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void btnSet_Click( object sender, EventArgs e )
        {
            string strPassword = txtPassword.Text.Trim();
            string strRetypePassword = txtRetypePassword.Text.Trim();

            //Make sure passwords match
            if (strPassword.Equals(strRetypePassword))
            {
                if (strPassword == "Capstone2022")
                {
                    //Don't let user use default password
                    txtPassword.Text = "";
                    txtRetypePassword.Text = "";
                    MessageBox.Show("Password cannot be same as default password!", "Alert");
                }
                else if(strPassword.Length >= 8)
                {
                    //Get hash
                    strHash = Authentication.GenerateHash(strPassword);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    //Don't let user use password
                    txtPassword.Text = "";
                    txtRetypePassword.Text = "";
                    MessageBox.Show("Password must be at least 8 characters in length!", "Alert");
                }
            }
            else
            {
                txtPassword.Text = "";
                txtRetypePassword.Text = "";
                MessageBox.Show("Passwords didn't match!", "Alert");
            }
        }
    }
}
