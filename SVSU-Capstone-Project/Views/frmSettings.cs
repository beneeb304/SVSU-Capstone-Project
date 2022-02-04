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

        private void btnCancelRoom_Click(object sender, EventArgs e)
        {
            //Clear fields
            txtRoomDescription.Text = "";
            txtRoomName.Text = "";
            lstRoom.SelectedIndex = -1;
        }

        private void btnCancelCabinet_Click(object sender, EventArgs e)
        {
            //Clear fields
            txtCabinetDescription.Text = "";
            txtCabinetName.Text = "";
            cmbRoom.SelectedIndex = -1;
            lstCabinet.SelectedIndex = -1;
        }

        private void btnCancelCategory_Click(object sender, EventArgs e)
        {
            //Clear fields
            txtCategoryDescription.Text = "";
            txtCategoryName.Text = "";
            lstCategory.SelectedIndex = -1;
        }

        private void btnCancelVendor_Click(object sender, EventArgs e)
        {
            //Clear fields
            txtVendorDescription.Text = "";
            txtVendorName.Text = "";
            lstVendor.SelectedIndex = -1;
        }

        private void btnCancelNLevel_Click(object sender, EventArgs e)
        {
            //Clear fields
            txtNLevelDescription.Text = "";
            txtNLevelName.Text = "";
            lstNLevel.SelectedIndex = -1;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtUserSVSUID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCabinet_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCabinet_Click(object sender, EventArgs e)
        {

        }

        private void btnModifyCabinet_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void tbpCabinets_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {

        }

        private void btnModifyVendor_Click(object sender, EventArgs e)
        {

        }

        private void btnAddVendor_Click(object sender, EventArgs e)
        {

        }
    }
}
