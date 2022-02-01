using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVSU_Capstone_Project.Views
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnModifyCancel_Click(object sender, EventArgs e)
        {
            //Clear fields
            txtUserSVSUID.Text = "";
            txtUserEmail.Text = "";
            txtUserFName.Text = "";
            txtUserLName.Text = "";
            txtUserPassword.Text = "";
            txtUserPhone.Text = "";
            chkUserAdmin.Checked = false;
            lstUser.SelectedIndex = -1;
        }
    }
}
