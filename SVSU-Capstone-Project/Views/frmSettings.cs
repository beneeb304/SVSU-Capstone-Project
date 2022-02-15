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
            lstCabinet.DataSource = null;
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
            txtVendorHomepage.Text = "";
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
                    cmbRoom.DataSource = ItemModel.GetMany<Room>().OrderBy(x => x.strName).Select(x => x.strName).ToList();
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
                try
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

                        //Refresh list
                        tbcSettings_SelectedIndexChanged(sender, e);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Delete failed!", "Alert");
                }

                //Clear fields
                btnClearUser_Click(sender, e);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if(txtUserEmail.Text.Length > 0)
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
                            strHash = "Capstone2022",
                            blnIsAdmin = chkUserAdmin.Checked
                        };

                        //Add user
                        ItemModel.Add<User>(user);

                        //Alert user
                        MessageBox.Show("Successful Add\r\n\r\n"
                            + txtUserEmail.Text + " will be prompted to set their password on their fist login\r\n" +
                            "Their temporary password is 'Capstone2022'", "Alert");
                        
                        //Refresh list
                        tbcSettings_SelectedIndexChanged(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add failed\r\nPlease ensure that you fill out valid user information!", "Alert");
                }

                //Clear fields
                btnClearUser_Click(sender, e);
            }
        }

        private void btnModifyUser_Click(object sender, EventArgs e)
        {
            //If a user is selected
            if (lstUser.SelectedIndex >= 0)
            {
                try
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
                        user.blnIsAdmin = chkUserAdmin.Checked;

                        //Save user
                        ItemModel.Update<User>(user);

                        //Alert user
                        MessageBox.Show("Successful Modification", "Alert");

                        //Refresh list
                        tbcSettings_SelectedIndexChanged(sender, e);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Modify failed\r\nPlease ensure that you fill out valid user information!", "Alert");
                }

                //Clear fields
                btnClearUser_Click(sender, e);
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
                try
                {
                    //Ask user to confirm action
                    DialogResult result = MessageBox.Show("Are you sure you want to reset " +
                        lstUser.SelectedItem.ToString() + "'s password?", "Confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //Get user
                        User user = ItemModel.Get<User>(x => x.strEmail == lstUser.SelectedItem.ToString());

                        //Modify user password
                        user.strHash = "Capstone2022";

                        //Save user
                        ItemModel.Update<User>(user);

                        //Alert user
                        MessageBox.Show("Successful Reset\r\n\r\n"
                            + txtUserEmail.Text + " will be prompted to reset their password on their next login\r\n" +
                            "Their temporary password is 'Capstone2022'", "Alert");

                        //Refresh list
                        tbcSettings_SelectedIndexChanged(sender, e);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Password reset failed!", "Alert");
                }

                //Clear fields
                btnClearUser_Click(sender, e);
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
                chkUserAdmin.Checked = user.blnIsAdmin;
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
                try
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

                        //NEED TO MAKE strName UNIQUE OR ADD DUPLICATE CHECK HERE

                        //Save room
                        ItemModel.Update<Room>(room);

                        //Alert user
                        MessageBox.Show("Successful Modification", "Alert");

                        //Refresh list
                        tbcSettings_SelectedIndexChanged(sender, e);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Modify failed\r\nPlease ensure that you fill out valid room information!", "Alert");
                }

                //Clear fields
                btnClearRoom_Click(sender, e);
            }
        }

        private void btnAddRoom_Click( object sender, EventArgs e )
        {
            if(txtRoomName.Text.Length > 0)
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
                        
                        //NEED TO MAKE strName UNIQUE OR ADD DUPLICATE CHECK HERE

                        //Add room
                        ItemModel.Add<Room>(room);

                        //Alert user
                        MessageBox.Show("Successful Add", "Alert");

                        //Refresh list
                        tbcSettings_SelectedIndexChanged(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add failed\r\nPlease ensure that you fill out valid room information!", "Alert");
                }

                //Clear fields
                btnClearRoom_Click(sender, e);
            }
        }

        private void btnDeleteRoom_Click( object sender, EventArgs e )
        {
            //If a room is selected
            if (lstRoom.SelectedIndex >= 0)
            {
                try
                {
                    //Ask user to confirm action
                    DialogResult result = MessageBox.Show("Are you sure you want to delete " +
                        lstRoom.SelectedItem.ToString() + " from rooms?", "Confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //Get room
                        Room room = ItemModel.Get<Room>(x => x.strName == lstRoom.SelectedItem.ToString());

                        //Check if room has any cabinets
                        Cabinet cabinet = ItemModel.Get<Cabinet>(x => x.objRoom.strName == lstRoom.SelectedItem.ToString());

                        //If room has cabinets, alert user and cancel. Otherwise, delete room
                        if (cabinet == null)
                        {
                            //Remove room
                            ItemModel.Delete<Room>(room);

                            //Alert user
                            MessageBox.Show("Successful Deletion", "Alert");
                        }
                        else
                        {
                            //Alert user
                            MessageBox.Show("Room contains cabinets. Remove them before attempting deletion", "Alert");
                        }

                        //Refresh list
                        tbcSettings_SelectedIndexChanged(sender, e);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Delete failed!", "Alert");
                }

                //Clear fields
                btnClearRoom_Click(sender, e);
            }
        }

        private void btnAddCategory_Click( object sender, EventArgs e )
        {
            if(txtCategoryName.Text.Length > 0)
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

                        //NEED TO MAKE strName UNIQUE OR ADD DUPLICATE CHECK HERE

                        //Add cabinet
                        ItemModel.Add<Category>(category);

                        //Alert user
                        MessageBox.Show("Successful Add", "Alert");

                        //Refresh list
                        tbcSettings_SelectedIndexChanged(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add failed\r\nPlease ensure that you fill out valid category information!", "Alert");
                }

                //Clear fields
                btnClearCategory_Click(sender, e);
            }
        }

        private void btnModifyCategory_Click( object sender, EventArgs e )
        {
            //If a category is selected
            if (lstCategory.SelectedIndex >= 0)
            {
                try
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

                        //NEED TO MAKE strName UNIQUE OR ADD DUPLICATE CHECK HERE

                        //Save category
                        ItemModel.Update<Category>(category);

                        //Alert user
                        MessageBox.Show("Successful Modification", "Alert");

                        //Refresh list
                        tbcSettings_SelectedIndexChanged(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Modify failed\r\nPlease ensure that you fill out valid category information!", "Alert");
                }

                //Clear fields
                btnClearCategory_Click(sender, e);
            }
        }

        private void btnDeleteCategory_Click( object sender, EventArgs e )
        {
            //If a category is selected
            if (lstCategory.SelectedIndex >= 0)
            {
                try
                {
                    //Ask user to confirm action
                    DialogResult result = MessageBox.Show("Are you sure you want to delete " +
                        lstCategory.SelectedItem.ToString() + " from categories?", "Confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //Get category
                        Category category = ItemModel.Get<Category>(x => x.strName == lstCategory.SelectedItem.ToString());

                        //Check if category has any commodities
                        Commodity commodity = ItemModel.Get<Commodity>(x => x.objCategory.strName.ToString() == lstCategory.SelectedItem.ToString());

                        //If commodities exist, alert user and cancel. Otherwise, delete catrgory
                        if (commodity == null)
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

                        //Refresh list
                        tbcSettings_SelectedIndexChanged(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete failed!", "Alert");
                }

                //Clear fields
                btnClearCategory_Click(sender, e);
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

        private void lstVendor_SelectedIndexChanged( object sender, EventArgs e )
        {
            //If a vendor is selected
            if (lstVendor.SelectedIndex >= 0)
            {
                //Get category
                Vendor vendor = ItemModel.Get<Vendor>(x => x.strName == lstVendor.SelectedItem.ToString());

                //Populate other controls
                txtVendorDescription.Text = vendor.strDescription;
                txtVendorName.Text = vendor.strName;
                txtVendorHomepage.Text = vendor.strHomepage;
            }
        }

        private void btnDeleteVendor_Click( object sender, EventArgs e )
        {
            //If a vendor is selected
            if (lstVendor.SelectedIndex >= 0)
            {
                try
                {
                    //Ask user to confirm action
                    DialogResult result = MessageBox.Show("Are you sure you want to delete " +
                        lstVendor.SelectedItem.ToString() + " from vendors?", "Confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //Get vendor
                        Vendor vendor = ItemModel.Get<Vendor>(x => x.strName == lstVendor.SelectedItem.ToString());

                        //Check if vendor has any vendor items
                        VendorItem vItem = ItemModel.Get<VendorItem>(x => x.objVendor.strName.ToString() == lstVendor.SelectedItem.ToString());

                        //If vendor items exist, alert user and cancel. Otherwise, delete vendor
                        if (vItem == null)
                        {
                            //Remove vendor
                            ItemModel.Delete<Vendor>(vendor);

                            //Alert user
                            MessageBox.Show("Successful Deletion", "Alert");
                        }
                        else
                        {
                            //Alert user
                            MessageBox.Show("Vendor contains commodities. Remove them before attempting deletion", "Alert");
                        }

                        //Refresh list
                        tbcSettings_SelectedIndexChanged(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete failed!", "Alert");
                }

                //Clear fields
                btnClearCategory_Click(sender, e);
            }
        }

        private void btnAddVendor_Click( object sender, EventArgs e )
        {
            if (txtVendorName.Text.Length > 0)
            {
                try
                {
                    //Ask user to confirm action
                    DialogResult result = MessageBox.Show("Are you sure you want to add " +
                        txtVendorName.Text + " as a new vendor?", "Confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //Set room properties                        
                        Vendor vendor = new Vendor()
                        {
                            strDescription = txtVendorDescription.Text,
                            strName = txtVendorName.Text,
                            strHomepage = txtVendorHomepage.Text
                        };

                        //NEED TO MAKE strName UNIQUE OR ADD DUPLICATE CHECK HERE

                        //Add vendor
                        ItemModel.Add<Vendor>(vendor);

                        //Alert user
                        MessageBox.Show("Successful Add", "Alert");

                        //Refresh list
                        tbcSettings_SelectedIndexChanged(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add failed\r\nPlease ensure that you fill out valid vendor information!", "Alert");
                }

                //Clear controls
                btnClearVendor_Click(sender, e);
            }
        }

        private void btnModifyVendor_Click( object sender, EventArgs e )
        {
            //If a vendor is selected
            if (lstVendor.SelectedIndex >= 0)
            {
                try
                {
                    //Ask user to confirm action
                    DialogResult result = MessageBox.Show("Are you sure you want to modify " +
                        lstVendor.SelectedItem.ToString() + "?", "Confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //Get vendor
                        Vendor vendor = ItemModel.Get<Vendor>(x => x.strName == lstVendor.SelectedItem.ToString());

                        //Modify category
                        vendor.strName = txtVendorName.Text;
                        vendor.strDescription = txtVendorDescription.Text;
                        vendor.strHomepage = txtVendorHomepage.Text;

                        //NEED TO MAKE strName UNIQUE OR ADD DUPLICATE CHECK HERE

                        //Save vendor
                        ItemModel.Update<Vendor>(vendor);

                        //Alert user
                        MessageBox.Show("Successful Modification", "Alert");

                        //Refresh list
                        tbcSettings_SelectedIndexChanged(sender, e);
                    }       
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Modify failed\r\nPlease ensure that you fill out valid vendor information!", "Alert");
                }

                //Clear fields
                btnClearVendor_Click(sender, e);
            }
        }

        private void lstNLevel_SelectedIndexChanged( object sender, EventArgs e )
        {
            //If a N-Level is selected
            if (lstNLevel.SelectedIndex >= 0)
            {
                //Get n-level
                NLevel nLevel = ItemModel.Get<NLevel>(x => x.strName == lstNLevel.SelectedItem.ToString());

                //Populate other controls
                txtNLevelDescription.Text = nLevel.strDescription;
                txtNLevelName.Text = nLevel.strName;
            }
        }

        private void btnAddNLevel_Click( object sender, EventArgs e )
        {
            if (txtNLevelName.Text.Length > 0)
            {
                try
                {
                    //Ask user to confirm action
                    DialogResult result = MessageBox.Show("Are you sure you want to add " +
                        txtNLevelName.Text + " as a new N-Level?", "Confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //Set n-level properties                        
                        NLevel nLevel = new NLevel()
                        {
                            strDescription = txtNLevelDescription.Text,
                            strName = txtNLevelName.Text
                        };

                        //NEED TO MAKE strName UNIQUE OR ADD DUPLICATE CHECK HERE

                        //Add n-level
                        ItemModel.Add<NLevel>(nLevel);

                        //Alert user
                        MessageBox.Show("Successful Add", "Alert");

                        //Refresh list
                        tbcSettings_SelectedIndexChanged(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add failed\r\nPlease ensure that you fill out valid N-Level information!", "Alert");
                }

                //Clear controls
                btnClearNLevel_Click(sender, e);
            }
        }

        private void btnModifyNLevel_Click( object sender, EventArgs e )
        {
            //If a n-level is selected
            if (lstNLevel.SelectedIndex >= 0)
            {
                try
                {
                    //Ask user to confirm action
                    DialogResult result = MessageBox.Show("Are you sure you want to modify " +
                        lstNLevel.SelectedItem.ToString() + "?", "Confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //Get n-level
                        NLevel nLevel = ItemModel.Get<NLevel>(x => x.strName == lstNLevel.SelectedItem.ToString());

                        //Modify n-level
                        nLevel.strName = txtNLevelName.Text;
                        nLevel.strDescription = txtNLevelDescription.Text;

                        //NEED TO MAKE strName UNIQUE OR ADD DUPLICATE CHECK HERE

                        //Save n-level
                        ItemModel.Update<NLevel>(nLevel);

                        //Alert user
                        MessageBox.Show("Successful Modification", "Alert");

                        //Refresh list
                        tbcSettings_SelectedIndexChanged(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Modify failed\r\nPlease ensure that you fill out valid N-Level information!", "Alert");
                }

                //Clear fields
                btnClearNLevel_Click(sender, e);
            }
        }

        private void btnDeleteNLevel_Click( object sender, EventArgs e )
        {
            //If a n-level is selected
            if (lstNLevel.SelectedIndex >= 0)
            {
                try
                {
                    //Ask user to confirm action
                    DialogResult result = MessageBox.Show("Are you sure you want to delete " +
                        lstNLevel.SelectedItem.ToString() + " from N-Levels?", "Confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //Get n-level
                        NLevel nLevel = ItemModel.Get<NLevel>(x => x.strName == lstNLevel.SelectedItem.ToString());

                        //Check if n-level has any commodities
                        Storage storage = ItemModel.Get<Storage>(x => x.objNLevel.strName.ToString() == lstNLevel.SelectedItem.ToString());

                        //If n-level items exist, alert user and cancel. Otherwise, delete n-level
                        if (storage == null)
                        {
                            //Remove n-level
                            ItemModel.Delete<NLevel>(nLevel);

                            //Alert user
                            MessageBox.Show("Successful Deletion", "Alert");
                        }
                        else
                        {
                            //Alert user
                            MessageBox.Show("N-Level contains commodities. Remove them before attempting deletion", "Alert");
                        }

                        //Refresh list
                        tbcSettings_SelectedIndexChanged(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete failed!", "Alert");
                }

                //Clear fields
                btnClearNLevel_Click(sender, e);
            }
        }

        private void cmbRoom_SelectedIndexChanged( object sender, EventArgs e )
        {
            if (cmbRoom.Text != "")
            {
                lstCabinet.DataSource = ItemModel.GetMany<Cabinet>(x => x.objRoom.strName == cmbRoom.SelectedItem.ToString())
                .OrderBy(x => x.strName).Select(x => x.strName).ToList();
            }
        }

        private void lstCabinet_SelectedIndexChanged( object sender, EventArgs e )
        {
            //If a cabinet is selected
            if (lstCabinet.SelectedIndex >= 0)
            {
                //Get cabinet
                Cabinet cabinet = ItemModel.Get<Cabinet>(x => x.strName == lstCabinet.SelectedItem.ToString());

                //Populate other controls
                txtCabinetDescription.Text = cabinet.strDescription;
                txtCabinetName.Text = cabinet.strName;
            }
        }

        private void btnAddCabinet_Click( object sender, EventArgs e )
        {
            if (txtCabinetName.Text.Length > 0 && cmbRoom.SelectedItem.ToString().Length > 0)
            {
                try
                {
                    //Ask user to confirm action
                    DialogResult result = MessageBox.Show("Are you sure you want to add " +
                        txtCabinetName.Text + " as a new cabinet for " + cmbRoom.SelectedItem.ToString() + "?", "Confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //Set cabinet properties                        
                        Cabinet cabinet = new Cabinet()
                        {
                            strDescription = txtCabinetDescription.Text,
                            strName = txtCabinetName.Text,
                            objRoom = ItemModel.Get<Room>(x => x.strName == cmbRoom.SelectedItem.ToString())
                        };

                        //NEED TO CHECK FOR DUPLICATE CABINETS IN THIS ROOM BEFORE ADDING

                        //Add cabinet
                        ItemModel.Add<Cabinet>(cabinet);

                        //Alert user
                        MessageBox.Show("Successful Add", "Alert");

                        //Refresh list
                        tbcSettings_SelectedIndexChanged(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add failed\r\nPlease ensure that you fill out valid cabinet information!", "Alert");
                }

                //Clear controls
                btnClearCabinet_Click(sender, e);
            }
        }

        private void btnModifyCabinet_Click( object sender, EventArgs e )
        {
            //If a cabinet is selected
            if (lstCabinet.SelectedIndex >= 0)
            {
                try
                {
                    //Ask user to confirm action
                    DialogResult result = MessageBox.Show("Are you sure you want to modify " +
                        lstCabinet.SelectedItem.ToString() + " in " + cmbRoom.SelectedItem.ToString() + "?", "Confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //Get cabinet
                        Cabinet cabinet = ItemModel.Get<Cabinet>(x => x.strName == lstCabinet.SelectedItem.ToString() &&
                            x.objRoom.strName == cmbRoom.SelectedItem.ToString());

                        //Modify cabinet
                        cabinet.strName = txtCabinetName.Text;
                        cabinet.strDescription = txtCabinetDescription.Text;

                        //NEED TO CHECK FOR DUPLICATE CABINETS IN THIS ROOM BEFORE MODIFYING

                        //Save cabinet
                        ItemModel.Update<Cabinet>(cabinet);

                        //Alert user
                        MessageBox.Show("Successful Modification", "Alert");

                        //Refresh list
                        tbcSettings_SelectedIndexChanged(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Modify failed\r\nPlease ensure that you fill out valid cabinet information!", "Alert");
                }

                //Clear fields
                btnClearCabinet_Click(sender, e);
            }
        }

        private void btnDeleteCabinet_Click( object sender, EventArgs e )
        {
            //If a cabinet is selected
            if (lstCabinet.SelectedIndex >= 0)
            {
                try
                {
                    //Ask user to confirm action
                    DialogResult result = MessageBox.Show("Are you sure you want to delete " +
                        lstCabinet.SelectedItem.ToString() + " from cabinets?", "Confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //Get cabinet
                        Cabinet cabinet = ItemModel.Get<Cabinet>(x => x.strName == lstCabinet.SelectedItem.ToString() && 
                            x.objRoom.strName == cmbRoom.SelectedItem.ToString());

                        //Check if cabinet has any commodities
                        Storage storage = ItemModel.Get<Storage>(x => x.objCabinet.strName.ToString() == lstCabinet.SelectedItem.ToString() 
                            && x.objCabinet.objRoom.strName == cmbRoom.Text);

                        //If cabinet items exist, alert user and cancel. Otherwise, delete n-level
                        if (storage == null)
                        {
                            //Remove cabinet
                            ItemModel.Delete<Cabinet>(cabinet);

                            //Alert user
                            MessageBox.Show("Successful Deletion", "Alert");
                        }
                        else
                        {
                            //Alert user
                            MessageBox.Show("Cabinet contains commodities. Remove them before attempting deletion", "Alert");
                        }

                        //Refresh list
                        tbcSettings_SelectedIndexChanged(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete failed!", "Alert");
                }

                //Clear fields
                btnClearCabinet_Click(sender, e);
            }
        }
    }
}
