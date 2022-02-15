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
        
        public frmSetPassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSet_Click( object sender, EventArgs e )
        {
            //Make sure passwords match
            if (txtPassword.Text.Equals(txtRetypePassword.Text))
            {
                //Get hash
                strHash = Authentication.GenerateHash(txtPassword.Text);
                DialogResult = DialogResult.OK;
                Close();
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
