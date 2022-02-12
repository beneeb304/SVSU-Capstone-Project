using SVSU_Capstone_Project.Model;
using SVSU_Capstone_Project.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
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
            tbcSettings_SelectedIndexChanged(null, null);
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

        private void tbcSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tbcSettings.SelectedTab == tbpUsers)
            {
                //Populate user listbox with emails
                lstUser.DataSource = ItemModel.GetMany<User>().OrderBy(x => x.strEmail).Select(x => x.strEmail).ToList();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            //If a user is selected
            if(lstUser.SelectedIndex >= 0)
            {
                //Ask user to confirm action
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + lstUser.SelectedItem.ToString() + " from users?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Remove user from users

                }
            }
        }

        private void lstUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If a user is selected
            if (lstUser.SelectedIndex >= 0)
            {
                //Get user
                User user = ItemModel.Get<User>(x => x.strEmail == lstUser.SelectedItem.ToString());

                //Populate other controls
                txtUserSVSUID.Text = user.strSvsu_id;
                txtUserFName.Text = user.strFirst_name;
                txtUserLName.Text = user.strLast_name;
                txtUserEmail.Text = user.strEmail;
                txtUserPhone.Text = user.strPhone;
                txtUserPassword.Text = user.strHash;
                if (user.blnIsAdmin)
                {
                    chkUserAdmin.Checked = true;
                }
                else
                {
                    chkUserAdmin.Checked = false;
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                //Valid email
                MailAddress mailAddress = new MailAddress(txtUserEmail.Text);

                //Ask user to confirm action
                DialogResult result = MessageBox.Show("Are you sure you want to add " + txtUserEmail.Text + " as a new user?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Set user properties                        
                    User user = new User
                    {
                        strSvsu_id = txtUserSVSUID.Text,
                        strFirst_name = txtUserFName.Text,
                        strLast_name = txtUserLName.Text,
                        strEmail = mailAddress.ToString(),
                        strPhone = txtUserPhone.Text,
                        strHash = Authentication.GenerateHash(txtUserPassword.Text),
                        blnIsAdmin = chkUserAdmin.Checked
                    };

                    //Add user
                    ItemModel.Add<User>(user);

                    //Alert user
                    MessageBox.Show("Successful Add", "Alert");

                    //Clear fields
                    btnCancelUser_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill out valid user information!", "Alert");
                btnCancelUser_Click(sender, e);
            }
        }

        private void btnModifyUser_Click(object sender, EventArgs e)
        {
            //If a user is selected
            if (lstUser.SelectedIndex >= 0)
            {
                //Ask user to confirm action
                DialogResult result = MessageBox.Show("Are you sure you want to modify " + lstUser.SelectedItem.ToString() + "'s user profile?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Get user
                    User user = ItemModel.Get<User>(x => x.strEmail == lstUser.SelectedItem.ToString());

                    //Modify user
                    user.strSvsu_id = txtUserSVSUID.Text;
                    user.strFirst_name = txtUserFName.Text;
                    user.strLast_name = txtUserLName.Text;
                    user.strEmail = txtUserEmail.Text;
                    user.strPhone = txtUserPhone.Text;
                    if (user.strHash != txtUserPassword.Text)
                    {
                        user.strHash = Authentication.GenerateHash(txtUserPassword.Text);
                    }

                    if (chkUserAdmin.Checked)
                    {
                        user.blnIsAdmin = true;
                    }
                    else
                    {
                        user.blnIsAdmin = false;
                    }

                    //Save user
                    ItemModel.Update<User>(user);

                    //Alert user
                    MessageBox.Show("Successful Modification", "Alert");

                    //Clear fields
                    btnCancelUser_Click(sender, e);
                }
            }
        }

        private void btnCancelUser_Click(object sender, EventArgs e)
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
