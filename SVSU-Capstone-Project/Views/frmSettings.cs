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

        private void btnClearRoom_Click(object sender, EventArgs e)
        {
            //Clear fields
            txtRoomDescription.Text = "";
            txtRoomName.Text = "";
            lstRoom.SelectedIndex = -1;
        }

        private void btnClearCabinet_Click(object sender, EventArgs e)
        {
            //Clear fields
            txtCabinetDescription.Text = "";
            txtCabinetName.Text = "";
            cmbRoom.SelectedIndex = -1;
            lstCabinet.SelectedIndex = -1;
        }

        private void btnClearCategory_Click(object sender, EventArgs e)
        {
            //Clear fields
            txtCategoryDescription.Text = "";
            txtCategoryName.Text = "";
            lstCategory.SelectedIndex = -1;
        }

        private void btnClearVendor_Click(object sender, EventArgs e)
        {
            //Clear fields
            txtVendorDescription.Text = "";
            txtVendorName.Text = "";
            lstVendor.SelectedIndex = -1;
        }

        private void btnClearNLevel_Click(object sender, EventArgs e)
        {
            //Clear fields
            txtNLevelDescription.Text = "";
            txtNLevelName.Text = "";
            lstNLevel.SelectedIndex = -1;
        }

        private void tbcSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tbcSettings.SelectedTab.Name)
            {
                case "tbpUsers":
                    //Populate user listbox with emails
                    lstUser.DataSource = ItemModel.GetMany<User>().OrderBy(x => x.strEmail).Select(x => x.strEmail).ToList();
                    break;
                case "tbpRooms":
                    //Populate room listbox with room names
                    lstRoom.DataSource = ItemModel.GetMany<Room>().OrderBy(x => x.strName).Select(x => x.strName).ToList();
                    break;
                case "tbpCabinets":
                    
                    break;
                case "tbpCategories":
                    //Populate category listbox with category names
                    lstCategory.DataSource = ItemModel.GetMany<Category>().OrderBy(x => x.strName).Select(x => x.strName).ToList();
                    break;
                case "tbpVendors":
                    //Populate vendor listbox with vendor names
                    lstVendor.DataSource = ItemModel.GetMany<Vendor>().OrderBy(x => x.strName).Select(x => x.strName).ToList();
                    break;
                case "tbpNLevel":
                    //Populate N-level listbox with N-levels
                    lstNLevel.DataSource = ItemModel.GetMany<NLevel>().OrderBy(x => x.strName).Select(x => x.strName).ToList();
                    break;
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            //If a user is selected
            if(lstUser.SelectedIndex >= 0)
            {
                //Ask user to confirm action
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + 
                    lstUser.SelectedItem.ToString() + " from users?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Get user
                    User user = ItemModel.Get<User>(x => x.strEmail == lstUser.SelectedItem.ToString());

                    //Remove user
                    ItemModel.Delete<User>(user);

                    //Alert user
                    MessageBox.Show("Successful Deletion", "Alert");

                    //Clear fields
                    btnClearUser_Click(sender, e);

                    //Refresh list
                    tbcSettings_SelectedIndexChanged(sender, e);
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
                DialogResult result = MessageBox.Show("Are you sure you want to add " + 
                    txtUserEmail.Text + " as a new user?", "Confirm", MessageBoxButtons.YesNo);
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
                        strHash = "",
                        blnIsAdmin = chkUserAdmin.Checked
                    };

                    //Add user
                    ItemModel.Add<User>(user);

                    //Alert user
                    MessageBox.Show("Successful Add\r\n" 
                        + txtUserEmail.Text + " will be prompted to set their password on their fist login", "Alert");

                    //Clear fields
                    btnClearUser_Click(sender, e);

                    //Refresh list
                    tbcSettings_SelectedIndexChanged(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed\r\nPlease esnure that you fill out valid user information!", "Alert");
                btnClearUser_Click(sender, e);
            }
        }

        private void btnModifyUser_Click(object sender, EventArgs e)
        {
            //If a user is selected
            if (lstUser.SelectedIndex >= 0)
            {
                //Ask user to confirm action
                DialogResult result = MessageBox.Show("Are you sure you want to modify " + 
                    lstUser.SelectedItem.ToString() + "'s user profile?", "Confirm", MessageBoxButtons.YesNo);
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
                    btnClearUser_Click(sender, e);

                    //Refresh list
                    tbcSettings_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void btnClearUser_Click(object sender, EventArgs e)
        {
            //Clear fields
            txtUserSVSUID.Text = "";
            txtUserEmail.Text = "";
            txtUserFName.Text = "";
            txtUserLName.Text = "";
            txtUserPhone.Text = "";
            chkUserAdmin.Checked = false;
            lstUser.SelectedIndex = -1;
        }

        private void btnUserPassword_Click(object sender, EventArgs e)
        {
            //If a user is selected
            if (lstUser.SelectedIndex >= 0)
            {
                //Ask user to confirm action
                DialogResult result = MessageBox.Show("Are you sure you want to reset " + 
                    lstUser.SelectedItem.ToString() + "'s password?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Get user
                    User user = ItemModel.Get<User>(x => x.strEmail == lstUser.SelectedItem.ToString());

                    //Modify user password
                    user.strHash= "";

                    //Save user
                    ItemModel.Update<User>(user);

                    //Alert user
                    MessageBox.Show(txtUserEmail.Text + " will be prompted to change their password on next login", "Alert");

                    //Clear fields
                    btnClearUser_Click(sender, e);

                    //Refresh list
                    tbcSettings_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void lstUser_SelectedIndexChanged( object sender, EventArgs e )
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

        private void lstRoom_SelectedIndexChanged( object sender, EventArgs e )
        {
            //If a room is selected
            if (lstRoom.SelectedIndex >= 0)
            {
                //Get room
                Room room = ItemModel.Get<Room>(x => x.strName == lstRoom.SelectedItem.ToString());

                //Populate other controls
                txtRoomDescription.Text = room.strDescription;
                txtRoomName.Text = room.strName;
            }
        }

        private void btnModifyRoom_Click( object sender, EventArgs e )
        {
            //If a room is selected
            if (lstRoom.SelectedIndex >= 0)
            {
                //Ask user to confirm action
                DialogResult result = MessageBox.Show("Are you sure you want to modify " +
                    lstRoom.SelectedItem.ToString() + "?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Get room
                    Room room = ItemModel.Get<Room>(x => x.strName == lstRoom.SelectedItem.ToString());

                    //Modify room
                    room.strName = txtRoomName.Text;
                    room.strDescription = txtRoomDescription.Text;

                    //Save room
                    ItemModel.Update<Room>(room);

                    //Alert user
                    MessageBox.Show("Successful Modification", "Alert");

                    //Clear fields
                    btnClearRoom_Click(sender, e);

                    //Refresh list
                    tbcSettings_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void btnAddRoom_Click( object sender, EventArgs e )
        {
            try
            {
                //Ask user to confirm action
                DialogResult result = MessageBox.Show("Are you sure you want to add " +
                    txtRoomName.Text + " as a new room?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Set room properties                        
                    Room room = new Room
                    {
                        strDescription = txtRoomDescription.Text,
                        strName = txtRoomName.Text
                    };

                    //Add room
                    ItemModel.Add<Room>(room);

                    //Alert user
                    MessageBox.Show("Successful Add", "Alert");

                    //Clear fields
                    btnClearRoom_Click(sender, e);

                    //Refresh list
                    tbcSettings_SelectedIndexChanged(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed\r\nPlease esnure that you fill out valid user information!", "Alert");
                btnClearUser_Click(sender, e);
            }
        }

        private void btnDeleteRoom_Click( object sender, EventArgs e )
        {
            //If a room is selected
            if (lstRoom.SelectedIndex >= 0)
            {
                //Ask user to confirm action
                DialogResult result = MessageBox.Show("Are you sure you want to delete " +
                    lstRoom.SelectedItem.ToString() + " from rooms?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Get room
                    Room room = ItemModel.Get<Room>(x => x.strName == lstRoom.SelectedItem.ToString());

                    //Check if room has any items/cabinets?
                    //FIND ME

                    //Remove room
                    ItemModel.Delete<Room>(room);

                    //Alert user
                    MessageBox.Show("Successful Deletion", "Alert");

                    //Clear fields
                    btnClearRoom_Click(sender, e);

                    //Refresh list
                    tbcSettings_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void btnAddCategory_Click( object sender, EventArgs e )
        {
            try
            {
                //Ask user to confirm action
                DialogResult result = MessageBox.Show("Are you sure you want to add " +
                    txtCategoryName.Text + " as a new category?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Set room properties                        
                    Category category = new Category()
                    {
                        strDescription = txtCategoryDescription.Text,
                        strName = txtCategoryName.Text
                    };

                    //Add room
                    ItemModel.Add<Category>(category);

                    //Alert user
                    MessageBox.Show("Successful Add", "Alert");

                    //Clear fields
                    btnClearCategory_Click(sender, e);

                    //Refresh list
                    tbcSettings_SelectedIndexChanged(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed\r\nPlease esnure that you fill out valid category information!", "Alert");
                btnClearUser_Click(sender, e);
            }
        }

        private void btnModifyCategory_Click( object sender, EventArgs e )
        {
            //If a category is selected
            if (lstCategory.SelectedIndex >= 0)
            {
                //Ask user to confirm action
                DialogResult result = MessageBox.Show("Are you sure you want to modify " +
                    lstCategory.SelectedItem.ToString() + "?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Get category
                    Category category = ItemModel.Get<Category>(x => x.strName == lstCategory.SelectedItem.ToString());

                    //Modify category
                    category.strName = txtCategoryName.Text;
                    category.strDescription = txtCategoryDescription.Text;

                    //Save room
                    ItemModel.Update<Category>(category);

                    //Alert user
                    MessageBox.Show("Successful Modification", "Alert");

                    //Clear fields
                    btnClearCategory_Click(sender, e);

                    //Refresh list
                    tbcSettings_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void btnDeleteCategory_Click( object sender, EventArgs e )
        {
            //If a category is selected
            if (lstCategory.SelectedIndex >= 0)
            {
                //Ask user to confirm action
                DialogResult result = MessageBox.Show("Are you sure you want to delete " +
                    lstCategory.SelectedItem.ToString() + " from categories?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Get category
                    Category category = ItemModel.Get<Category>(x => x.strName == lstCategory.SelectedItem.ToString());

                    //Check if category has any commodities
                    Commodity commodity = ItemModel.Get<Commodity>(x => x.objCategory.ToString() == lstCategory.SelectedItem.ToString());

                    //If commodities exist, alert user and cancel. Otherwise, delete catrgory
                    if(commodity == null)
                    {
                        //Remove category
                        ItemModel.Delete<Category>(category);

                        //Alert user
                        MessageBox.Show("Successful Deletion", "Alert");
                    }
                    else
                    {
                        //Alert user
                        MessageBox.Show("Category contains commodities. Remove them before attempting deletion", "Alert");
                    }

                    //Clear fields
                    btnClearCategory_Click(sender, e);

                    //Refresh list
                    tbcSettings_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void lstCategory_SelectedIndexChanged( object sender, EventArgs e )
        {
            //If a category is selected
            if (lstCategory.SelectedIndex >= 0)
            {
                //Get category
                Category category = ItemModel.Get<Category>(x => x.strName == lstCategory.SelectedItem.ToString());

                //Populate other controls
                txtCategoryDescription.Text = category.strDescription;
                txtCategoryName.Text = category.strName;
            }
        }
    }
}
