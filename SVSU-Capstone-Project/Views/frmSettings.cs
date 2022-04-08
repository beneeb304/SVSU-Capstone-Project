using Microsoft.VisualBasic.FileIO;
using SVSU_Capstone_Project.Model;
using SVSU_Capstone_Project.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVSU_Capstone_Project.Views
{
    public partial class frmSettings : Form
    {
        /* Funtion: frmSettings
         * Description: Initializes the settings form and sets the tab index to default.
         * 
         * No Local Variables.
         */
        public frmSettings()
        {
            InitializeComponent();
            tbcSettings_SelectedIndexChanged(null, null);
        }

        /* Function: ClearRoomFields
         * Description: Clears all fields on the room settings page.
         */
        private void ClearRoomFields()
        {
            //Clear fields
            txtRoomDescription.Text = "";
            txtRoomName.Text = "";
            //lstRoom.SelectedIndex = -1;
        }

        /* Function: ClearCabinetFields
         * Description: Clears all fields on the cabinet settings page.
         */
        private void ClearCabinetFields()
        {
            //Clear fields
            txtCabinetDescription.Text = "";
            txtCabinetName.Text = "";
        }

        /* Function: ClearCategoryFields
         * Description: Clears all fields on the category settings page.
         */
        private void ClearCategoryFields()
        {
            //Clear fields
            txtCategoryDescription.Text = "";
            txtCategoryName.Text = "";
            lstCategory.SelectedIndex = -1;
        }

        /* Function: ClearVendorFields
         * Description: Clears all fields on the vendor settings page.
         */
        private void ClearVendorFields()
        {
            //Clear fields
            txtVendorDescription.Text = "";
            txtVendorName.Text = "";
            txtVendorHomepage.Text = "";
            lstVendor.SelectedIndex = -1;
        }

        /* Function: btnClearNLevel_Click
         * Description: Clears all fields on the NLevel settings page.
         */
        private void ClearNLevelFields()
        {
            //Clear fields
            txtNLevelDescription.Text = "";
            txtNLevelName.Text = "";
            lstNLevel.SelectedIndex = -1;
        }

        /* Function: tbcSettings_SelectedIndexChanged
         * Description: Switches the page in the settings menu when a tab is clicked.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void tbcSettings_SelectedIndexChanged( object sender, EventArgs e )
        {
            switch (tbcSettings.SelectedTab.Name)
            {
                case "tbpUsers":
                    //Populate user listbox with emails
                    lstUser.DataSource = ItemModel.GetMany<User>().OrderBy(x => x.strLast_name).Select(x => x.strLast_name + ", " + x.strFirst_name + " - " + x.strEmail).ToList();
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

        /* Function: btnDeleteUser_Click
         * Description: Deletes a user upon request.
         * Asks the user wqith confirmation dialogue if they want to delete a user before deleting from the database.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * DialogResult result; MessageBox to confirm the deletion of a user.
         * User user; Represents the user being deleted from the database.
         */
        private void btnDeleteUser_Click( object sender, EventArgs e )
        {
            //If a user is selected
            if (lstUser.SelectedIndex >= 0)
            {
                try
                {
                    //Get the user email
                    MailAddress mailAddress = new MailAddress(lstUser.SelectedItem.ToString());

                    //Ask user to confirm action
                    DialogResult result = MessageBox.Show("Are you sure you want to delete " +
                        mailAddress.Address + " from users?", "Confirm", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        //Get user
                        User user = ItemModel.Get<User>(x => x.strEmail == mailAddress.Address);

                        //Check if user has any commodities checked out to them
                        List<CheckedItem> lstCheckedItems = ItemModel.GetMany<CheckedItem>(x => x.objUser.uidTuid == user.uidTuid).ToList();
                        
                        if (lstCheckedItems.Count == 0)
                        {
                            //Remove user
                            ItemModel.Delete<User>(user);

                            //Alert user
                            MessageBox.Show("Successful Deletion", "Alert");

                            //Refresh list
                            tbcSettings_SelectedIndexChanged(sender, e);
                        }
                        else
                        {
                            //Alert user
                            MessageBox.Show("User has items checked-out. Check them back in before attempting deletion", "Alert");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Delete failed!", "Alert");
                }

                //Clear fields
                ClearUserFields();
            }
            else
            {
                MessageBox.Show("Select a user to delete", "Alert");
            }
        }

        /* Function: btnAddUser_Click
         * Description: Adds a user to the user list.
         * Asks the user to confirm before adding the new user to the database with the given information.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * MailAddress mailAddress; Represents the new user's email.
         * DialogResult result; MessageBox to confirm the new user addition.
         * User user; Represents the new user being added to the database.
         */
        private void btnAddUser_Click( object sender, EventArgs e )
        {
            //Disable buttons
            btnUserUpload.Enabled = false;
            btnUserModify.Enabled = false;
            btnUserPassword.Enabled = false;
            btnUserDelete.Enabled = false;

            //Show buttons
            btnUserSave.Visible = true;
            btnUserCancel.Visible = true;

            //Enable fields
            EnableDisableUserFields(true);

            //Clear fields
            ClearUserFields();
        }

        /* Function: btnModifyUser_Click
         * Description: Modifies an existing user in the database.
         * Asks the user for confirmation before modifying the selected user.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * DialogResult result; MessageBox to confirm the user modification.
         * User user; Represents the user being modified in the database.
         */
        private void btnModifyUser_Click( object sender, EventArgs e )
        {
            //Disable buttons
            btnUserAdd.Enabled = false;
            btnUserUpload.Enabled = false;
            btnUserPassword.Enabled = false;
            btnUserDelete.Enabled = false;

            //Show buttons
            btnUserSave.Visible = true;
            btnUserCancel.Visible = true;

            //Enable fields
            EnableDisableUserFields(true);
            txtUserSVSUID.Enabled = false;
        }

        /* Function: ClearUserFields
         * Description: Clears all fields in the user settings page.
         */
        private void ClearUserFields()
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

        /* Function: btnUserPassword_Click
         * Description: Change a selected user's password.
         * Asks the user for confirmation before changing the password.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * DialogResult result; MessageBox to confirm the password change.
         * User user; Represents the user being modified in the database.
         */
        private void btnUserPassword_Click( object sender, EventArgs e )
        {
            //If a user is selected
            if (lstUser.SelectedIndex >= 0)
            {
                try
                {
                    //Get the user email
                    MailAddress mailAddress = new MailAddress(lstUser.SelectedItem.ToString());

                    //Get user
                    User user = ItemModel.Get<User>(x => x.strEmail == mailAddress.Address);
                    if (Authentication.ActiveUser.strEmail == "brneeb@svsu.edu" || Authentication.ActiveUser.strEmail == "mjsimon1@svsu.edu" || Authentication.ActiveUser.strEmail == "aataylo3@svsu.edu")
                    {
                        if (user.blnIsAdmin)
                        {
                            //Ask user to confirm action
                            DialogResult result = MessageBox.Show("Are you sure you want to reset " +
                                mailAddress.Address + "'s password?", "Confirm", MessageBoxButtons.YesNo);

                            if (result == DialogResult.Yes)
                            {
                                //Set password
                                string strHash = RandomPassword();
                                user.strHash = Authentication.GenerateHash(strHash);
                                user.blnPwdReset = true;

                                //Save user
                                ItemModel.Update<User>(user);

                                //Alert user
                                MessageBox.Show("Successful Reset\r\n\r\n"
                                    + txtUserEmail.Text + " will be prompted to reset their password on their next login\r\n" +
                                    "Their temporary password is " + strHash, "Alert");

                                //Refresh list
                                tbcSettings_SelectedIndexChanged(sender, e);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cannot change non-admin password", "Alert");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You dont have permission to perform this action", "Alert");
                    }

                }
                catch
                {
                    MessageBox.Show("Password reset failed!", "Alert");
                }

                //Clear fields
                ClearUserFields();
            }
            else
            {
                MessageBox.Show("Select a user to perform a password reset", "Alert");
            }
        }

        private string RandomPassword()
        {
            //Randomize user password
            Random random = new Random();

            //String that contain both alphabets and numbers
            string strAlphaNumeric = "abcdefghijklmnopqrstuvwxyz0123456789";
            string strHash = "";

            //Set to 8 characters long
            int size = 8;

            for (int i = 0; i < size; i++)
            {
                //Selecting a index randomly
                int x = random.Next(strAlphaNumeric.Length);

                //Appending the character at the index to the random alphanumeric string.
                strHash += strAlphaNumeric[x];
            }

            return strHash;
        }

        /* Function: lstUser_SelectedIndexChanged
         * Description: Fills the fields on the user settings page with user information when a new user is selected.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * User user; Represents the user being selected.
         */
        private void lstUser_SelectedIndexChanged( object sender, EventArgs e )
        {
            //If a user is selected
            if (lstUser.SelectedIndex >= 0)
            {
                //Get the user email
                MailAddress mailAddress = new MailAddress(lstUser.SelectedItem.ToString());
                
                //Get user
                User user = ItemModel.Get<User>(x => x.strEmail == mailAddress.Address);

                //Populate other controls
                txtUserSVSUID.Text = user.strSvsu_id;
                txtUserFName.Text = user.strFirst_name;
                txtUserLName.Text = user.strLast_name;
                txtUserEmail.Text = user.strEmail;
                txtUserPhone.Text = user.strPhone;
                chkUserAdmin.Checked = user.blnIsAdmin;
            }
        }

        /* Function: lstRoom_SelectedIndexChanged
         * Description: Fills the fields on the room settings page when a new room is selected.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * Room room; Represents the room to pass its information from the database to the fields.
         */
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

        /* Function: btnModifyRoom_Click
         * Description: Modifies a selected room's information in the database.
         * Asks the user for confirmation before maodfying data.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * DialogResult result; MessageBox confirmation to the user.
         * Room room; Represents the room's information.
         */
        private void btnModifyRoom_Click( object sender, EventArgs e )
        {
            if(lstRoom.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Room to modify!", "Alert");
            }
            else
            {
                //Disable buttons
                btnRoomAdd.Enabled = false;
                btnRoomDelete.Enabled = false;
                
                //Show buttons
                btnRoomCancel.Visible = true;
                btnRoomSave.Visible = true;
                
                //Enable fields
                EnableDisableRoomFields(true);
            }
            
        }

        /* Function: btnAddRoom_Click
         * Description: Adds a new room to the database with the given information.
         * Asks the user for confirmation before adding the room.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * DialogResult result; MessageBox confirmation to the user.
         * Room room; Represents the room's information.
         */
        private void btnAddRoom_Click( object sender, EventArgs e )
        {
            //Disable buttons
            btnRoomDelete.Enabled = false;
            btnRoomModify.Enabled = false;

            //Show buttons
            btnRoomCancel.Visible = true;
            btnRoomSave.Visible = true;

            //Enable fields
            EnableDisableRoomFields(true);

            //Clear fields
            ClearRoomFields();
        }

        /* Function: btnDeleteRoom_Click
         * Description: Deletes a selected room from the database.
         * Asks the user for confirmation before deleting the room.
         * Ensures all cabinets are deleted before the room.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * DialogResult result; MessageBox confirmation to the user.
         * Room room; Represents the room's information.
         * Cabinet cabinet; Represents a cabinet in a selected room.
         */
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
                catch
                {
                    MessageBox.Show("Delete failed!", "Alert");
                }

                //Clear fields
                ClearRoomFields();
            }
            else
            {
                MessageBox.Show("Select a room to delete", "Alert");
            }
        }

        /* Function: btnAddCategory_Click
         * Description: Adds a new category to the database with the given information.
         * Asks the user for confirmation before adding the room.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * DialogResult result; MessageBox confirmation to the user.
         * Cabinet cabinet; Represents a cabinet in a selected room.
         */
        private void btnAddCategory_Click( object sender, EventArgs e )
        {
            //Disable buttons
            btnCategoryDelete.Enabled = false;
            btnCategoryModify.Enabled = false;

            //Show buttons
            btnCategoryCancel.Visible = true;
            btnCategorySave.Visible = true;

            //Enable fields
            EnableDisableCategoryFields(true);

            //Clear fields
            ClearCategoryFields();
        }

        /* Function: btnModifyCategory_Click
         * Description: Modifies the selected room in the database.
         * Asks the user confirmation before modifying the room.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * DialogResult result; MessageBox confirmation to the user.
         * Cabinet cabinet; Represents a cabinet in a selected room.
         */
        private void btnModifyCategory_Click( object sender, EventArgs e )
        {
            //Disable buttons
            btnCategoryAdd.Enabled = false;
            btnCategoryDelete.Enabled = false;

            //Show buttons
            btnCategoryCancel.Visible = true;
            btnCategorySave.Visible = true;

            //Enable fields
            EnableDisableCategoryFields(true);
        }

        /* Function: btnDeleteCategory_Click
         * Description: Deletes the selected room from the database.
         * Asks the user for confirmation before deleting the database.
         * Ensures no commodities have the category selected before deleting.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * DialogResult result; MessageBox confirmation to the user.
         * Cabinet cabinet; Represents a cabinet in a selected room.
         * Commodity commodity; Represents a commodity item.
         */
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
                catch
                {
                    MessageBox.Show("Delete failed!", "Alert");
                }

                //Clear fields
                ClearCategoryFields();
            }
            else
            {
                MessageBox.Show("Select a category to delete", "Alert");
            }
        }

        /* Function: lstCategory_SelectedIndexChanged
         * Description: Sets the fields of the category settings page to reflect information of the selected category.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * Category category; Represents a category object.
         */
        private void lstCategory_SelectedIndexChanged( object sender, EventArgs e )
        {
            //If a category is selected
            if (lstCategory.SelectedIndex >= 0)
            {
                string strName = lstCategory.SelectedItem.ToString();
                
                //Get category
                Category category = ItemModel.Get<Category>(x => x.strName == strName);

                if(category != null)
                {
                    //Populate other controls
                    txtCategoryDescription.Text = category.strDescription;
                    txtCategoryName.Text = category.strName;
                }
            }
        }

        /* Function: lstVendor_SelectedIndexChanged
         * Description: Sets the fields of the vendor settings page to reflect the information of a selected vendor.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * Vendor vendor; Represents a vendor object.
         */
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

        /* Function: btnDeleteVendor_Click
         * Description: Deletes the selected vendor from the database.
         * Asks for confirmation from the user before deleting the vendor.
         * Ensures no commoditites have that vendor in use as its vendor.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * DialogResult result; MessageBox confirmation to the user.
         * Vendor vendor; Represents a vendor object.
         * VendorItem vItem; Represents all items using a selected vendor in its description.
         */
        private void btnDeleteVendor_Click( object sender, EventArgs e )
        {
            //If a vendor is selected
            if (lstVendor.SelectedIndex >= 0)
            {
                try
                {
                    Vendor vendors = ItemModel.Get<Vendor>(x => x.strName == lstVendor.SelectedItem.ToString());
                    var commodities = ItemModel.GetMany<Commodity>().Where(x => x.objVendor.uidTuid == vendors.uidTuid);
                    if(commodities != null)
                    {
                        MessageBox.Show($"{vendors.strName} is currently selected on a commodity. Please remove from the commodity if you wish to delete this vendor.", "Alert");
                    }
                    else
                    {
                        //Ask user to confirm action
                        DialogResult result = MessageBox.Show("Are you sure you want to delete " +
                            lstVendor.SelectedItem.ToString() + " from vendors?", "Confirm", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            //Get vendor
                            Vendor vendor = ItemModel.Get<Vendor>(x => x.strName == lstVendor.SelectedItem.ToString());

                            //Remove vendor
                            ItemModel.Delete<Vendor>(vendor);

                            //Alert user
                            MessageBox.Show("Successful Deletion", "Alert");

                            //Refresh list
                            tbcSettings_SelectedIndexChanged(sender, e);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Delete failed! Make sure the vendor is not associated with any commodities.", "Alert");
                }

                //Clear fields
                ClearVendorFields();
            }
            else
            {
                MessageBox.Show("Select a vendor to delete", "Alert");
            }
        }

        /* Function: btnAddVendor_Click
         * Description: Adds a new vendor to the database with the provided information.
         * Asks for confirmation from the user before adding the new vendor.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * DialogResult result; MessageBox confirmation to the user.
         * Vendor vendor; Represents a vendor object.
         */
        private void btnAddVendor_Click( object sender, EventArgs e )
        {
            //Disable buttons
            btnVendorDelete.Enabled = false;
            btnVendorModify.Enabled = false;

            //Show buttons
            btnVendorCancel.Visible = true;
            btnVendorSave.Visible = true;

            //Enable fields
            EnableDisableVendorFields(true);

            //Clear fields
            ClearVendorFields();
        }

        /* Function: btnModifyVendor_Click
         * Description: Modifies the selected vendor in the database to reflect the newly given information.
         * Asks the user for confirmation before modifying the vendor.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * DialogResult result; MessageBox confirmation to the user.
         * Vendor vendor; Represents a vendor object.
         */
        private void btnModifyVendor_Click( object sender, EventArgs e )
        {
            //Disable buttons
            btnVendorAdd.Enabled = false;
            btnVendorDelete.Enabled = false;

            //Show buttons
            btnVendorCancel.Visible = true;
            btnVendorSave.Visible = true;

            //Enable fields
            EnableDisableVendorFields(true);
        }

        /* Function: lstNLevel_SelectedIndexChanged
         * Description: Reflects the fields in the NLevel settings page to reflect the selected NLevel.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * NLevel nLevel; Represents an NLevel object.
         */
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

        /* Function: btnAddNLevel_Click
         * Description: Adds a new NLevel to the database with the provided information.
         * Asks the user for confirmation before adding the NLevel.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * DialogResult result; MessageBox confirmation to the user.
         * NLevel nLevel; Represents an NLevel object.
         */
        private void btnAddNLevel_Click( object sender, EventArgs e )
        {
            //Disable buttons
            btnNLevelDelete.Enabled = false;
            btnNLevelModify.Enabled = false;

            //Show buttons
            btnNLevelCancel.Visible = true;
            btnNLevelSave.Visible = true;

            //Enable fields
            EnableDisableNLevelFields(true);

            //Clear fields
            ClearNLevelFields();
        }

        /* Function: btnModifyNLevel_Click
         * Description: Modifies a selected NLevel in the database.
         * Asks the user for confirmation before modifying the NLevel.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * DialogResult result; MessageBox confirmation to the user.
         * NLevel nLevel; Represents an NLevel object.
         */
        private void btnModifyNLevel_Click( object sender, EventArgs e )
        {
            //Disable buttons
            btnNLevelAdd.Enabled = false;
            btnNLevelDelete.Enabled = false;

            //Show buttons
            btnNLevelCancel.Visible = true;
            btnNLevelSave.Visible = true;

            //Enable fields
            EnableDisableNLevelFields(true);
        }

        /* Function: btnDeleteNLevel_Click
         * Description: Deletes the selected NLevel from the database.
         * Asks the user for confirmation before deleting.
         * Ensures no commodity items are using the selected NLevel.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * DialogResult result; MessageBox confirmation to the user.
         * NLevel nLevel; Represents an NLevel object.
         * Storage storage; Represents the inventory to check for items using the selected NLevel.
         */
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
                catch
                {
                    MessageBox.Show("Delete failed!", "Alert");
                }

                //Clear fields
                ClearNLevelFields();
            }
            else
            {
                MessageBox.Show("Select an n-level to delete", "Alert");
            }
        }

        /* Function: cmbRoom_SelectedIndexChanged
         * Description: Reflects the fields in the room settings page to have information of the selected room.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void cmbRoom_SelectedIndexChanged( object sender, EventArgs e )
        {
            if (cmbRoom.Text != "")
            {
                lstCabinet.DataSource = ItemModel.GetMany<Cabinet>(x => x.objRoom.strName == cmbRoom.SelectedItem.ToString())
                .OrderBy(x => x.strName).Select(x => x.strName).ToList();
            }

            //If we're adding a cabinet
            if (btnCabinetAdd.Enabled)
            {
                //Clear fields
                txtCabinetDescription.Text = "";
                txtCabinetName.Text = "";
            }

        }

        /* Function: lstCabinet_SelectedIndexChanged
         * Description: Reflects the fields in the cabinet settings page to show information of the selected cabinet.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * Cabinet cabinet; Represents the selected cabinet object.
         */
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

        /* Function: btnAddCabinet_Click
         * Description: Adds a cabinet to the database with the provided information.
         * Asks the user for confirmation before adding the cabinet.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * DialogResult result; MessageBox confirmation to the user.
         * Cabinet cabinet; Represents the new cabinet as an object to pass to the database.
         */
        private void btnAddCabinet_Click( object sender, EventArgs e )
        {
            //Disable buttons
            btnCabinetDelete.Enabled = false;
            btnCabinetModify.Enabled = false;
            cmbRoom.Enabled = false;

            //Show buttons
            btnCabinetCancel.Visible = true;
            btnCabinetSave.Visible = true;

            //Enable fields
            EnableDisableCabinetFields(true);

            //Clear fields
            ClearCabinetFields();
        }

        /* Function: btnModifyCabinet_Click
         * Description: Modifies the selected cabinet to reflect new information in the database.
         * Asks the user for confirmation before modifying the cabinet.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * DialogResult result; MessageBox confirmation to the user.
         * Cabinet cabinet; Represents the cabinet being modified in the database.
         */
        private void btnModifyCabinet_Click( object sender, EventArgs e )
        {
            //Check if there are any cabinets in the room to modify
            if (ItemModel.Get<Room>(x => x.lstCabinets.Count > 0 && x.strName == cmbRoom.Text) != null)
            {
                //Disable buttons
                btnCabinetAdd.Enabled = false;
                btnCabinetDelete.Enabled = false;
                cmbRoom.Enabled = false;

                //Show buttons
                btnCabinetCancel.Visible = true;
                btnCabinetSave.Visible = true;

                //Enable fields
                EnableDisableCabinetFields(true);
            }
            else
                MessageBox.Show("Room does not contain any cabinets to modify!", "Alert");
        }

        /* Function: btnDeleteCabinet_Click
         * Description: Deletes the selected cabinet from the database.
         * Asks the user for confirmation before deleting the cabinet.
         * Ensures no commodities are using the cabinet in its information.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * DialogResult result; MessageBox confirmation to the user.
         * Cabinet cabinet; Represents the cabinet being deleted from the database.
         * Storage storage; Represents all items to see if they are using the cabinet.
         */
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
                catch
                {
                    MessageBox.Show("Delete failed!", "Alert");
                }

                //Clear fields
                ClearCabinetFields();
            }
            else
            {
                MessageBox.Show("Select a cabinet to delete", "Alert");
            }
        }

        /* Function: btnUpload_Click
         * Description: Uploads a csv file of student information to mass upload users.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * OpenfileDialog fd; Lets the user select the file to use for the upload.
         */
        private void btnUpload_Click( object sender, EventArgs e )
        {
            //Make file dialog
            OpenFileDialog fd = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Title = "Student Upload File",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv"
            };

            //Show dialog
            if (fd.ShowDialog() == DialogResult.OK)
            {
                //Read file
                UploadStudents(ReadCSVFile(fd.FileName));
            }

            //Clear fields
            ClearUserFields();

            //Refresh list
            tbcSettings_SelectedIndexChanged(sender, e);
        }

        /* Function: ReadCSVFile
         * Description: Reads the file given by the user to upload multiple users at once.
         * 
         * Local Variables
         * string strPath; Path to the file given by the user.
         * List<string[]> lstRows; Holds the list read from the file to be uploaded.
         * TextFieldParser parser; Reads the information from the uploaded file to the List.
         */
        private List<string[]> ReadCSVFile( string strPath )
        {
            //List to hold row data
            List<string[]> lstRows = new List<string[]>();

            //Read file to 2d array
            try
            {
                TextFieldParser parser = new TextFieldParser(strPath);
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    //Add to list
                    lstRows.Add(parser.ReadFields());
                }

                //Close file parser
                parser.Close();

                //Remove header row
                lstRows.RemoveAt(0);

                DialogResult result = MessageBox.Show("Attempting to add " + lstRows.Count + " students from CSV file\r\n\r\nContinue?",
                    "Alert", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    lstRows.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error reading CSV file", "Error");
            }

            return lstRows;
        }

        /* Function: UploadStudents
         * Description: Uploads the student list from the provided csv file to the database of users.
         * 
         * Local Variables
         * List<string[]> lstRows; Passes the read-in information to the method of users.
         * int intBadCtr, intGoodctr; Counts the amount of invalid and valid uploaded users respectively.
         * User user; Passes the uploaded information as an object to the database.
         */
        private void UploadStudents( List<string[]> lstRows )
        {
            int intBadCtr = 0, intGoodCtr = 0;
            string strSVSUID, strFName, strLName;
            MailAddress mailAddress;

            //Use list to add users
            foreach (string[] row in lstRows)
            {
                try
                {
                    strSVSUID = row[2].Trim();
                    strFName = row[0].Substring(row[0].IndexOf(",") + 1).Trim();
                    strLName = row[0].Substring(0, row[0].IndexOf(",")).Trim();
                    mailAddress = new MailAddress(row[3] + "@svsu.edu");

                    //Additional check to make sure email is only alphanumeric with period or hyphen
                    if (!mailAddress.ToString().All(c => char.IsLetterOrDigit(c) || c.Equals('.') || c.Equals('-') || c.Equals('@')))
                        intBadCtr++;
                    //Only alpha and hyphen first name
                    else if (!strFName.All(c => char.IsLetter(c) || c.Equals('-')))
                        intBadCtr++;
                    //Only alpha and hyphen last name
                    else if (!strLName.All(c => char.IsLetter(c) || c.Equals('-')))
                        intBadCtr++;
                    //Only alphanumeric SVSU ID
                    else if (!strSVSUID.All(char.IsLetterOrDigit))
                        intBadCtr++;
                    //Check if user already exists
                    else if (ItemModel.Get<User>(x => x.strEmail == mailAddress.ToString() || x.strSvsu_id == strSVSUID) == null)
                    {
                        //Make user
                        User user = new User()
                        {
                            //Default fields
                            blnIsAdmin = false,
                            strPhone = "",
                            strHash = "Capstone2022",

                            //Row fields
                            strSvsu_id = strSVSUID,
                            strFirst_name = strFName,
                            strLast_name = strLName,
                            strEmail = mailAddress.ToString()
                        };

                        //Add to db
                        ItemModel.Add<User>(user);
                        intGoodCtr++;
                    }
                    else
                        intBadCtr++;                    
                }
                catch (Exception)
                {
                    intBadCtr++;
                }
            }

            if (intBadCtr > 0)
            {
                MessageBox.Show("Error adding " + intBadCtr + " users from CSV file", "Error");
            }

            if (intGoodCtr > 0)
            {
                MessageBox.Show("Successfully added " + intGoodCtr + " users from CSV file", "Success");
            }
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void EnableDisableUserFields(bool blnEnable)
        {
            if (blnEnable)
            {
                txtUserEmail.Enabled = true;
                txtUserFName.Enabled = true;
                txtUserLName.Enabled = true;
                txtUserPhone.Enabled = true;
                txtUserSVSUID.Enabled = true;
                chkUserAdmin.Enabled = true;
            }
            else
            {
                txtUserEmail.Enabled = false;
                txtUserFName.Enabled = false;
                txtUserLName.Enabled = false;
                txtUserPhone.Enabled = false;
                txtUserSVSUID.Enabled = false;
                chkUserAdmin.Enabled = false;
            }
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void EnableDisableRoomFields(bool blnEnable )
        {
            if (blnEnable)
            {
                txtRoomDescription.Enabled = true;
                txtRoomName.Enabled = true;
            }
            else
            {
                txtRoomDescription.Enabled = false;
                txtRoomName.Enabled = false;
            }
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void EnableDisableCabinetFields( bool blnEnable )
        {
            if (blnEnable)
            {
                txtCabinetDescription.Enabled = true;
                txtCabinetName.Enabled = true;
            }
            else
            {
                txtCabinetDescription.Enabled = false;
                txtCabinetName.Enabled = false;
            }
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void EnableDisableCategoryFields( bool blnEnable )
        {
            if (blnEnable)
            {
                txtCategoryDescription.Enabled = true;
                txtCategoryName.Enabled = true;
            }
            else
            {
                txtCategoryDescription.Enabled = false;
                txtCategoryName.Enabled = false;
            }
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void EnableDisableVendorFields( bool blnEnable )
        {
            if (blnEnable)
            {
                txtVendorDescription.Enabled = true;
                txtVendorName.Enabled = true;
                txtVendorHomepage.Enabled = true;
            }
            else
            {
                txtVendorDescription.Enabled = false;
                txtVendorName.Enabled = false;
                txtVendorHomepage.Enabled = false;
            }
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void EnableDisableNLevelFields( bool blnEnable )
        {
            if (blnEnable)
            {
                txtNLevelDescription.Enabled = true;
                txtNLevelName.Enabled = true;
            }
            else
            {
                txtNLevelDescription.Enabled = false;
                txtNLevelName.Enabled = false;
            }
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void btnUserSave_Click( object sender, EventArgs e )
        {
            if (btnUserAdd.Enabled)
            {
                if (txtUserEmail.Text.Trim().Length > 0 && txtUserFName.Text.Trim().Length > 0 &&
                    txtUserLName.Text.Trim().Length > 0 && txtUserSVSUID.Text.Trim().Length > 0)
                {
                    string strError = "";
                    var exists = ItemModel.Get<User>(x => x.strEmail.ToLower() == txtUserEmail.Text.ToLower());
                    if(exists != null)
                    {
                        strError += "Email Already exists\r";
                    }
                    //Valid email
                    if (!Regex.IsMatch(txtUserEmail.Text,
                        @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                        RegexOptions.IgnoreCase))
                        strError += "Invalid email\r";

                    //Only letters and hyphens in firstname
                    if (!txtUserFName.Text.All(c => char.IsLetter(c) || c.Equals('-')))
                        strError += "Invalid first name\r";

                    //Only letters and hyphens in lastname
                    if (!txtUserLName.Text.All(c => char.IsLetter(c) || c.Equals('-')))
                        strError += "Invalid last name\r";

                    //Only alphanumeric SVSU ID less than 8 chars
                    if (!txtUserSVSUID.Text.All(char.IsLetterOrDigit) || txtUserSVSUID.Text.Length > 8)
                        strError += "Invalid SVSU ID\r";

                    //Only empty or numeric phone
                    if (!txtUserPhone.Text.All(char.IsNumber) && txtUserPhone.Text != "")
                        strError += "Invalid phone\r";

                    if (strError == "")
                    {
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
                                strEmail = txtUserEmail.Text,
                                strPhone = txtUserPhone.Text,
                                blnIsAdmin = chkUserAdmin.Checked,
                                blnPwdReset = true
                            };

                            string strHash = RandomPassword();
                            user.strHash = Authentication.GenerateHash(strHash);

                            var Emailexists = ItemModel.Get<User>(x => x.strEmail == user.strEmail);
                            var idExists = ItemModel.Get<User>(x => x.strSvsu_id == user.strSvsu_id);
                            if (Emailexists != null)
                            {
                                MessageBox.Show("A user already exists with the entered email.", "Alert");
                            }
                            else if (idExists != null)
                            {
                                MessageBox.Show("A user alread exists with the entered SVSU ID.", "Alert");
                            }
                            else
                            {
                                //Add user
                                ItemModel.Add<User>(user);

                                //Alert user
                                if (chkUserAdmin.Checked)
                                {
                                    MessageBox.Show("Successful Add\r\n\r\n"
                                    + txtUserEmail.Text + " will be prompted to set their password on their fist login\r\n" +
                                    "Their temporary password is " + strHash, "Alert");
                                }
                                else
                                {
                                    MessageBox.Show("Successfully Added User!", "Alert");
                                }

                                //Refresh list
                                tbcSettings_SelectedIndexChanged(sender, e);

                                //Hide buttons
                                btnUserSave.Visible = false;
                                btnUserCancel.Visible = false;

                                //Enable buttons
                                btnUserUpload.Enabled = true;
                                btnUserModify.Enabled = true;
                                btnUserPassword.Enabled = true;
                                btnUserDelete.Enabled = true;

                                //Clear fields
                                ClearUserFields();
                                EnableDisableUserFields(false);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please fill out all of the user fields before saving! You need:\r" +
                                    "A valid email\rA first name\rA last name\rAn SVSU ID", "Alert");
                        }
                    }
                    else
                        MessageBox.Show("Error adding user!\r\r" + strError, "Alert");
                }
            }
            else if (btnUserModify.Enabled)
            {
                //If a user is selected
                if (lstUser.SelectedIndex >= 0 && txtUserEmail.Text.Trim() != "" && txtUserFName.Text.Trim() != "" &&
                    txtUserLName.Text.Trim() != "" && txtUserSVSUID.Text.Trim() != "")
                {
                    try
                    {
                        string strError = "";

                        //Valid email
                        if (!Regex.IsMatch(txtUserEmail.Text,
                            @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                            RegexOptions.IgnoreCase))
                            strError += "Invalid email\r";

                        //Only letters and hyphens in firstname
                    if (!txtUserFName.Text.All(c => char.IsLetter(c) || c.Equals('-')))
                        strError += "Invalid first name\r";

                    //Only letters and hyphens in lastname
                    if (!txtUserLName.Text.All(c => char.IsLetter(c) || c.Equals('-')))
                        strError += "Invalid last name\r";

                        //Only alphanumeric SVSU ID less than 8 chars
                        if (!txtUserSVSUID.Text.All(char.IsLetterOrDigit) || txtUserSVSUID.Text.Length > 8)
                            strError += "Invalid SVSU ID\r";

                        //Only empty or numeric phone
                        if (!txtUserPhone.Text.All(char.IsNumber) && txtUserPhone.Text != "")
                            strError += "Invalid phone\r";

                        if (strError == "")
                        {
                            //Ask user to confirm action
                            DialogResult result = MessageBox.Show("Are you sure you want to modify " +
                                txtUserFName.Text + "'s user profile to current field values?", "Confirm", MessageBoxButtons.YesNo);

                            if (result == DialogResult.Yes)
                            {
                                //Get user
                                User user = ItemModel.Get<User>(x => x.strSvsu_id == txtUserSVSUID.Text);
                                
                                User exists = ItemModel.Get<User>(x => x.strEmail.ToLower() == txtUserEmail.Text.ToLower() &&
                                x.strSvsu_id != user.strSvsu_id);
                                                                
                                if (exists != null)
                                {
                                    MessageBox.Show("This email already Exists", "Alert");
                                }
                                else
                                {
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

                                    //Hide buttons
                                    btnUserSave.Visible = false;
                                    btnUserCancel.Visible = false;

                                    //Enable buttons
                                    btnUserAdd.Enabled = true;
                                    btnUserUpload.Enabled = true;
                                    btnUserPassword.Enabled = true;
                                    btnUserDelete.Enabled = true;

                                    //Clear fields
                                    ClearUserFields();
                                    EnableDisableUserFields(false);
                                }  
                            }
                            else
                            {
                                btnUserCancel_Click(sender, e);
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Modify failed\r\nPlease ensure that you fill out valid user information!", "Alert");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a user to modify before saving!", "Alert");
                }
            }
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void btnUserCancel_Click( object sender, EventArgs e )
        {
            //Hide buttons
            btnUserSave.Visible = false;
            btnUserCancel.Visible = false;

            //Enable buttons
            btnUserAdd.Enabled = true;
            btnUserUpload.Enabled = true;
            btnUserModify.Enabled = true;
            btnUserPassword.Enabled = true;
            btnUserDelete.Enabled = true;

            //Clear fields
            ClearUserFields();

            //Disable fields
            EnableDisableUserFields(false);
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void btnRoomSave_Click( object sender, EventArgs e )
        {
            if (btnRoomAdd.Enabled)
            {
                if (txtRoomName.Text.Trim().Length > 0)
                {
                    try
                    {
                        //Only alphanumeric and spaces in room name
                        if (!txtRoomName.Text.All(c => char.IsLetterOrDigit(c) || c.Equals(' ')))
                            MessageBox.Show("Only alphanumeric and spaces in room name", "Alert");
                        else
                        {
                            //Ask user to confirm action
                            DialogResult result = MessageBox.Show("Are you sure you want to add " +
                                txtRoomName.Text + " as a new room?", "Confirm", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                //Check for duplicates
                                if (lstRoom.Items.Contains(txtRoomName.Text))
                                {
                                    MessageBox.Show("Cannot add duplicate room", "Alert");
                                    btnRoomCancel_Click(sender, e);
                                }
                                else
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

                                    //Refresh list
                                    tbcSettings_SelectedIndexChanged(sender, e);

                                    //Hide buttons
                                    btnRoomSave.Visible = false;
                                    btnRoomCancel.Visible = false;

                                    //Enable buttons
                                    btnRoomAdd.Enabled = true;
                                    btnRoomDelete.Enabled = true;
                                    btnRoomModify.Enabled = true;
                                }
                            }
                            else
                            {
                                btnRoomCancel_Click(sender, e);
                            }

                            //Clear fields
                            ClearRoomFields();

                            //Disable fields
                            EnableDisableRoomFields(false);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Add failed\r\nPlease ensure that you fill out valid room information!", "Alert");

                        //Clear fields
                        ClearRoomFields();

                        //Disable fields
                        EnableDisableRoomFields(false);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill out a valid room name before saving!", "Alert");
                }
            }
            else if (btnRoomModify.Enabled)
            {
                //If a room is selected
                if (lstRoom.SelectedIndex >= 0 && txtRoomName.Text.Trim() != "")
                {
                    try
                    {
                        //Only alphanumeric and spaces in room name
                        if (!txtRoomName.Text.All(c => char.IsLetterOrDigit(c) || c.Equals(' ')))
                            MessageBox.Show("Only alphanumeric and spaces in room name", "Alert");
                        else
                        {
                            //Ask user to confirm action
                            DialogResult result = MessageBox.Show("Are you sure you want to modify " +
                            lstRoom.SelectedItem.ToString() + " to current field values?", "Confirm", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                //Check for duplicates
                                if (lstRoom.Items.Contains(txtRoomName.Text) && !lstRoom.SelectedItem.ToString().Equals(txtRoomName.Text))
                                {
                                    MessageBox.Show("Cannot modify duplicate room", "Alert");
                                    btnRoomCancel_Click(sender, e);
                                }
                                else
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

                                    //Refresh list
                                    tbcSettings_SelectedIndexChanged(sender, e);

                                    //Hide buttons
                                    btnRoomSave.Visible = false;
                                    btnRoomCancel.Visible = false;

                                    //Enable buttons
                                    btnRoomAdd.Enabled = true;
                                    btnRoomDelete.Enabled = true;
                                    btnRoomModify.Enabled = true;
                                }
                            }
                            else
                            {
                                btnRoomCancel_Click(sender, e);
                            }

                            //Clear fields
                            ClearRoomFields();

                            //Disable fields
                            EnableDisableRoomFields(false);
                        }    
                    }
                    catch
                    {
                        MessageBox.Show("Modify failed\r\nPlease ensure that you fill out valid room information!", "Alert");

                        //Clear fields
                        ClearRoomFields();

                        //Disable fields
                        EnableDisableRoomFields(false);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a room to modify before saving!", "Alert");
                }
            }
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void btnRoomCancel_Click( object sender, EventArgs e )
        {
            //Hide buttons
            btnRoomSave.Visible = false;
            btnRoomCancel.Visible = false;

            //Enable buttons
            btnRoomAdd.Enabled = true;
            btnRoomDelete.Enabled = true;
            btnRoomModify.Enabled = true;

            //Clear fields
            ClearRoomFields();
            lstRoom.SelectedIndex = -1;
            //Disable fields
            EnableDisableRoomFields(false);
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void btnCabinetSave_Click( object sender, EventArgs e )
        {
            if (btnCabinetAdd.Enabled)
            {
                if (txtCabinetName.Text.Trim() != "" && cmbRoom.SelectedIndex >= 0)
                {
                    try
                    {
                        //Only alphanumeric and spaces in cabinet name
                        if (!txtCabinetName.Text.All(c => char.IsLetterOrDigit(c) || c.Equals(' ')))
                            MessageBox.Show("Only alphanumeric and spaces in cabinet name", "Alert");
                        else
                        {
                            //Ask user to confirm action
                            DialogResult result = MessageBox.Show("Are you sure you want to add " +
                                txtCabinetName.Text + " as a new cabinet for " + cmbRoom.SelectedItem.ToString() + "?", "Confirm", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                //Check for duplicate cabinets in the room
                                if (lstCabinet.Items.Contains(txtCabinetName.Text))
                                {
                                    MessageBox.Show("Cannot add duplicate cabinet!", "Alert");
                                    btnCabinetCancel_Click(sender, e);
                                }
                                else
                                {
                                    //Set cabinet properties                        
                                    Cabinet cabinet = new Cabinet()
                                    {
                                        strDescription = txtCabinetDescription.Text,
                                        strName = txtCabinetName.Text,
                                        objRoom = ItemModel.Get<Room>(x => x.strName == cmbRoom.SelectedItem.ToString())
                                    };

                                    var selectedRoom = cmbRoom.SelectedItem;
                                    //Add cabinet
                                    ItemModel.Add<Cabinet>(cabinet);

                                    //Alert user
                                    MessageBox.Show("Successful Add", "Alert");

                                    //Refresh list
                                    tbcSettings_SelectedIndexChanged(sender, e);

                                    //Hide buttons
                                    btnCabinetSave.Visible = false;
                                    btnCabinetCancel.Visible = false;

                                    //Enable buttons
                                    btnCabinetAdd.Enabled = true;
                                    btnCabinetDelete.Enabled = true;
                                    btnCabinetModify.Enabled = true;
                                    cmbRoom.SelectedItem = selectedRoom;
                                    cmbRoom.Enabled = true;

                                    //Clear controls
                                    ClearCabinetFields();

                                    //Disable fields
                                    EnableDisableCabinetFields(false);
                                }
                            }
                            else
                            {
                                btnCabinetCancel_Click(sender, e);
                            }

                            //Clear controls
                            ClearCabinetFields();

                            //Disable fields
                            EnableDisableCabinetFields(false);

                            //Enable combo box
                            cmbRoom.Enabled = true;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Add failed\r\nPlease ensure that you fill out valid cabinet information!", "Alert");

                        //Clear controls
                        ClearCabinetFields();

                        //Disable fields
                        EnableDisableCabinetFields(false);

                        //Enable combo box
                        cmbRoom.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Please fill out all of the cabinet fields before saving!", "Alert");
                }
            }
            else if (btnCabinetModify.Enabled)
            {                
                //If a cabinet is selected
                if (lstCabinet.SelectedIndex >= 0 && cmbRoom.SelectedIndex >= 0 && txtCabinetName.Text.Trim() != "")
                {
                    try
                    {
                        //Only alphanumeric and spaces in cabinet name
                        if (!txtCabinetName.Text.All(c => char.IsLetterOrDigit(c) || c.Equals(' ')))
                            MessageBox.Show("Only alphanumeric and spaces in cabinet name", "Alert");
                        else
                        {
                            //Ask user to confirm action
                            DialogResult result = MessageBox.Show("Are you sure you want to modify " +
                            lstCabinet.SelectedItem.ToString() + " in " + cmbRoom.SelectedItem.ToString() + " to current field values?", "Confirm", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                //Check for duplicate cabinets in the room
                                if (lstCabinet.Items.Contains(txtCabinetName.Text) && !lstCabinet.SelectedItem.ToString().Equals(txtCabinetName.Text))
                                {
                                    MessageBox.Show("Cannot modify duplicate cabinet!", "Alert");
                                    btnCabinetCancel_Click(sender, e);
                                }
                                else
                                {
                                    //Get cabinet
                                    Cabinet cabinet = ItemModel.Get<Cabinet>(x => x.strName == lstCabinet.SelectedItem.ToString() &&
                                        x.objRoom.strName == cmbRoom.SelectedItem.ToString());

                                    //Modify cabinet
                                    cabinet.strName = txtCabinetName.Text;
                                    cabinet.strDescription = txtCabinetDescription.Text;

                                    //Save cabinet
                                    ItemModel.Update<Cabinet>(cabinet);

                                    //Alert user
                                    MessageBox.Show("Successful Modification", "Alert");

                                    //Refresh list
                                    tbcSettings_SelectedIndexChanged(sender, e);

                                    //Hide buttons
                                    btnCabinetSave.Visible = false;
                                    btnCabinetCancel.Visible = false;

                                    //Enable buttons
                                    btnCabinetAdd.Enabled = true;
                                    btnCabinetDelete.Enabled = true;
                                    btnCabinetModify.Enabled = true;
                                }
                            }
                            else
                            {
                                btnCabinetCancel_Click(sender, e);
                            }

                            //Clear fields
                            ClearCabinetFields();

                            //Disable fields
                            EnableDisableCabinetFields(false);

                            //Enable combo box
                            cmbRoom.Enabled = true;
                        }    
                    }
                    catch
                    {
                        MessageBox.Show("Modify failed\r\nPlease ensure that you fill out valid cabinet information!", "Alert");

                        //Clear fields
                        ClearCabinetFields();

                        //Disable fields
                        EnableDisableCabinetFields(false);

                        //Enable combo box
                        cmbRoom.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a cabinet in a room and fill out valid information to modify before saving!", "Alert");
                }
            }
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void btnCabinetCancel_Click( object sender, EventArgs e )
        {
            //Hide buttons
            btnCabinetCancel.Visible = false;
            btnCabinetSave.Visible = false;

            //Enable buttons
            btnCabinetAdd.Enabled = true;
            btnCabinetDelete.Enabled = true;
            btnCabinetModify.Enabled = true;
            cmbRoom.Enabled = true;

            //Clear fields
            ClearCabinetFields();

            //Disable fields
            EnableDisableCabinetFields(false);
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void btnCategorySave_Click( object sender, EventArgs e )
        {
            if (btnCategoryAdd.Enabled)
            {
                if (txtCategoryName.Text.Trim().Length > 0)
                {
                    try
                    {
                        //Only alphanumeric and spaces in category name
                        if (!txtCategoryName.Text.All(c => char.IsLetterOrDigit(c) || c.Equals(' ')))
                            MessageBox.Show("Only alphanumeric and spaces in category name", "Alert");
                        else
                        {
                            //Ask user to confirm action
                            DialogResult result = MessageBox.Show("Are you sure you want to add " +
                                txtCategoryName.Text + " as a new category?", "Confirm", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                //Check for duplicates
                                if (lstCategory.Items.Contains(txtCategoryName.Text))
                                {
                                    MessageBox.Show("Cannot add duplicate category", "Alert");
                                    btnCategoryCancel_Click(sender, e);
                                }
                                else
                                {
                                    //Set room properties                        
                                    Category category = new Category()
                                    {
                                        strDescription = txtCategoryDescription.Text,
                                        strName = txtCategoryName.Text
                                    };

                                    //Add cabinet
                                    ItemModel.Add<Category>(category);

                                    //Alert user
                                    MessageBox.Show("Successful Add", "Alert");

                                    //Refresh list
                                    tbcSettings_SelectedIndexChanged(sender, e);

                                    //Hide buttons
                                    btnCategorySave.Visible = false;
                                    btnCategoryCancel.Visible = false;

                                    //Enable buttons
                                    btnCategoryAdd.Enabled = true;
                                    btnCategoryDelete.Enabled = true;
                                    btnCategoryModify.Enabled = true;
                                }
                            }
                            else
                            {
                                btnCategoryCancel_Click(sender, e);
                            }

                            //Clear fields
                            ClearCategoryFields();

                            //Disable fields
                            EnableDisableCategoryFields(false);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Add failed\r\nPlease ensure that you fill out valid category information!", "Alert");

                        //Clear fields
                        ClearCategoryFields();

                        //Disable fields
                        EnableDisableCategoryFields(false);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill out all of the category fields before saving!", "Alert");
                }
            }
            else if (btnCategoryModify.Enabled)
            {
                //If a category is selected
                if (lstCategory.SelectedIndex >= 0 && txtCategoryName.Text.Trim() != "")
                {
                    try
                    {
                        //Only alphanumeric and spaces in category name
                        if (!txtCategoryName.Text.All(c => char.IsLetterOrDigit(c) || c.Equals(' ')))
                            MessageBox.Show("Only alphanumeric and spaces in category name", "Alert");
                        else
                        {
                            //Ask user to confirm action
                            DialogResult result = MessageBox.Show("Are you sure you want to modify " +
                            lstCategory.SelectedItem.ToString() + " to current field values?", "Confirm", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                if (lstCategory.Items.Contains(txtCategoryName.Text) && !lstCategory.SelectedItem.ToString().Equals(txtCategoryName.Text))
                                {
                                    MessageBox.Show("Cannot modify duplicate category", "Alert");
                                    btnCategoryCancel_Click(sender, e);
                                }
                                else
                                {
                                    //Make category
                                    Category category = ItemModel.Get<Category>(x => x.strName == lstCategory.SelectedItem.ToString());

                                    //Modify category
                                    category.strName = txtCategoryName.Text;
                                    category.strDescription = txtCategoryDescription.Text;

                                    //Save category
                                    ItemModel.Update<Category>(category);

                                    //Alert user
                                    MessageBox.Show("Successful Modification", "Alert");

                                    //Refresh list
                                    tbcSettings_SelectedIndexChanged(sender, e);

                                    //Hide buttons
                                    btnCategorySave.Visible = false;
                                    btnCategoryCancel.Visible = false;

                                    //Enable buttons
                                    btnCategoryAdd.Enabled = true;
                                    btnCategoryDelete.Enabled = true;
                                    btnCategoryModify.Enabled = true;
                                }
                            }
                            else
                            {
                                btnCategoryCancel_Click(sender, e);
                            }

                            //Clear fields
                            ClearCategoryFields();

                            //Disable fields
                            EnableDisableCategoryFields(false);
                        }    
                    }
                    catch
                    {
                        MessageBox.Show("Modify failed\r\nPlease ensure that you fill out valid category information!", "Alert");

                        //Clear fields
                        ClearCategoryFields();

                        //Disable fields
                        EnableDisableCategoryFields(false);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a cabinet to modify before saving!", "Alert");
                }
            }
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void btnCategoryCancel_Click( object sender, EventArgs e )
        {
            //Hide buttons
            btnCategorySave.Visible = false;
            btnCategoryCancel.Visible = false;

            //Enable buttons
            btnCategoryAdd.Enabled = true;
            btnCategoryDelete.Enabled = true;
            btnCategoryModify.Enabled = true;

            //Clear fields
            ClearCategoryFields();

            //Disable fields
            EnableDisableCategoryFields(false);
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void btnVendorSave_Click( object sender, EventArgs e )
        {
            if (btnVendorAdd.Enabled)
            {
                if (txtVendorName.Text.Trim().Length > 0)
                {
                    try
                    {
                        //Only alphanumeric and spaces in vendor name
                        if (!txtVendorName.Text.All(c => char.IsLetterOrDigit(c) || c.Equals(' ')))
                            MessageBox.Show("Only alphanumeric and spaces in vendor name", "Alert");
                        else
                        {
                            //Ask user to confirm action
                            DialogResult result = MessageBox.Show("Are you sure you want to add " +
                                txtVendorName.Text + " as a new vendor?", "Confirm", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                //Cannot add duplicate vendor
                                if (lstVendor.Items.Contains(txtVendorName.Text))
                                {
                                    MessageBox.Show("Cannot add duplicate vendor", "Alert");
                                    btnVendorCancel_Click(sender, e);
                                }
                                else
                                {
                                    //Set room properties
                                    Vendor vendor = new Vendor()
                                    {
                                        strDescription = txtVendorDescription.Text,
                                        strName = txtVendorName.Text,
                                        strHomepage = txtVendorHomepage.Text
                                    };

                                    //Add vendor
                                    ItemModel.Add<Vendor>(vendor);

                                    //Alert user
                                    MessageBox.Show("Successful Add", "Alert");

                                    //Refresh list
                                    tbcSettings_SelectedIndexChanged(sender, e);

                                    //Hide buttons
                                    btnVendorSave.Visible = false;
                                    btnVendorCancel.Visible = false;

                                    //Enable buttons
                                    btnVendorAdd.Enabled = true;
                                    btnVendorDelete.Enabled = true;
                                    btnVendorModify.Enabled = true;
                                }
                            }
                            else
                            {
                                btnVendorCancel_Click(sender, e);
                            }

                            //Clear controls
                            ClearVendorFields();

                            //Disable fields
                            EnableDisableVendorFields(false);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Add failed\r\nPlease ensure that you fill out valid vendor information!", "Alert");

                        //Clear controls
                        ClearVendorFields();

                        //Disable fields
                        EnableDisableVendorFields(false);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill out all of the vendor fields before saving!", "Alert");
                }
            }
            else if (btnVendorModify.Enabled)
            {
                //If a vendor is selected
                if (lstVendor.SelectedIndex >= 0 && txtVendorName.Text.Trim() != "")
                {
                    try
                    {
                        //Only alphanumeric and spaces in vendor name
                        if (!txtVendorName.Text.All(c => char.IsLetterOrDigit(c) || c.Equals(' ')))
                            MessageBox.Show("Only alphanumeric and spaces in vendor name", "Alert");
                        else
                        {
                            //Ask user to confirm action
                            DialogResult result = MessageBox.Show("Are you sure you want to modify " +
                            lstVendor.SelectedItem.ToString() + " to current field values?", "Confirm", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                //Cannot add duplicate vendor
                                if (lstVendor.Items.Contains(txtVendorName.Text) && !lstVendor.SelectedItem.ToString().Equals(txtVendorName.Text))
                                {
                                    MessageBox.Show("Cannot modify duplicate vendor", "Alert");
                                    btnVendorCancel_Click(sender, e);
                                }
                                else
                                {
                                    //Get vendor
                                    Vendor vendor = ItemModel.Get<Vendor>(x => x.strName == lstVendor.SelectedItem.ToString());

                                    //Modify category
                                    vendor.strName = txtVendorName.Text;
                                    vendor.strDescription = txtVendorDescription.Text;
                                    vendor.strHomepage = txtVendorHomepage.Text;

                                    //Save vendor
                                    ItemModel.Update<Vendor>(vendor);

                                    //Alert user
                                    MessageBox.Show("Successful Modification", "Alert");

                                    //Refresh list
                                    tbcSettings_SelectedIndexChanged(sender, e);

                                    //Hide buttons
                                    btnVendorSave.Visible = false;
                                    btnVendorCancel.Visible = false;

                                    //Enable buttons
                                    btnVendorAdd.Enabled = true;
                                    btnVendorDelete.Enabled = true;
                                    btnVendorModify.Enabled = true;
                                }
                            }
                            else
                            {
                                btnVendorCancel_Click(sender, e);
                            }

                            //Clear fields
                            ClearVendorFields();

                            //Disable fields
                            EnableDisableVendorFields(false);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Modify failed\r\nPlease ensure that you fill out valid vendor information!", "Alert");

                        //Clear fields
                        ClearVendorFields();

                        //Disable fields
                        EnableDisableVendorFields(false);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a vendor and ensure valid data to modify before saving!", "Alert");
                }
            }
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void btnVendorCancel_Click( object sender, EventArgs e )
        {
            //Hide buttons
            btnVendorSave.Visible = false;
            btnVendorCancel.Visible = false;

            //Enable buttons
            btnVendorAdd.Enabled = true;
            btnVendorDelete.Enabled = true;
            btnVendorModify.Enabled = true;

            //Clear fields
            ClearVendorFields();

            //Disable fields
            EnableDisableVendorFields(false);
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void btnNLevelSave_Click( object sender, EventArgs e )
        {
            if (btnNLevelAdd.Enabled)
            {
                if (txtNLevelName.Text.Trim().Length > 0)
                {
                    try
                    {
                        //Only alphanumeric and spaces in nlevel name
                        if (!txtNLevelName.Text.All(c => char.IsLetterOrDigit(c) || c.Equals(' ') || c.Equals('-')))
                            MessageBox.Show("Only alphanumeric and spaces in nlevel name", "Alert");
                        else
                        {
                            //Ask user to confirm action
                            DialogResult result = MessageBox.Show("Are you sure you want to add " +
                                txtNLevelName.Text + " as a new N-Level?", "Confirm", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                //Cannot add duplicate n-level
                                if (lstNLevel.Items.Contains(txtNLevelName.Text))
                                {
                                    MessageBox.Show("Cannot add duplicate N-Level", "Alert");
                                    btnNLevelCancel_Click(sender, e);
                                }
                                else
                                {
                                    //Set n-level properties                        
                                    NLevel nLevel = new NLevel()
                                    {
                                        strDescription = txtNLevelDescription.Text,
                                        strName = txtNLevelName.Text
                                    };

                                    //Add n-level
                                    ItemModel.Add<NLevel>(nLevel);

                                    //Alert user
                                    MessageBox.Show("Successful Add", "Alert");

                                    //Refresh list
                                    tbcSettings_SelectedIndexChanged(sender, e);

                                    //Hide buttons
                                    btnNLevelSave.Visible = false;
                                    btnNLevelCancel.Visible = false;

                                    //Enable buttons
                                    btnNLevelAdd.Enabled = true;
                                    btnNLevelDelete.Enabled = true;
                                    btnNLevelModify.Enabled = true;
                                }
                            }
                            else
                            {
                                btnNLevelCancel_Click(sender, e);
                            }

                            //Clear controls
                            ClearNLevelFields();

                            //Disable fields
                            EnableDisableNLevelFields(false);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Add failed\r\nPlease ensure that you fill out valid N-Level information!", "Alert");

                        //Clear controls
                        ClearNLevelFields();

                        //Disable fields
                        EnableDisableNLevelFields(false);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill out all of the N-Level fields before saving!", "Alert");
                }
            }
            else if (btnNLevelModify.Enabled)
            {
                //If a n-level is selected
                if (lstNLevel.SelectedIndex >= 0 && txtNLevelName.Text.Trim() != "")
                {
                    try
                    {
                        //Only alphanumeric and spaces in nlevel name
                        if (!txtNLevelName.Text.All(c => char.IsLetterOrDigit(c) || c.Equals(' ') || c.Equals('-')))
                            MessageBox.Show("Only alphanumeric and spaces in nlevel name", "Alert");
                        else
                        {
                            //Ask user to confirm action
                            DialogResult result = MessageBox.Show("Are you sure you want to modify " +
                            lstNLevel.SelectedItem.ToString() + " to current field values?", "Confirm", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                //Cannot add duplicate n-level
                                if (lstNLevel.Items.Contains(txtNLevelName.Text) && !lstNLevel.SelectedItem.ToString().Equals(txtNLevelName.Text))
                                {
                                    MessageBox.Show("Cannot modify duplicate N-Level", "Alert");
                                    btnNLevelCancel_Click(sender, e);
                                }
                                else
                                {
                                    //Get n-level
                                    NLevel nLevel = ItemModel.Get<NLevel>(x => x.strName == lstNLevel.SelectedItem.ToString());

                                    //Modify n-level
                                    nLevel.strName = txtNLevelName.Text;
                                    nLevel.strDescription = txtNLevelDescription.Text;

                                    //Save n-level
                                    ItemModel.Update<NLevel>(nLevel);

                                    //Alert user
                                    MessageBox.Show("Successful Modification", "Alert");

                                    //Refresh list
                                    tbcSettings_SelectedIndexChanged(sender, e);

                                    //Hide buttons
                                    btnNLevelSave.Visible = false;
                                    btnNLevelCancel.Visible = false;

                                    //Enable buttons
                                    btnNLevelAdd.Enabled = true;
                                    btnNLevelDelete.Enabled = true;
                                    btnNLevelModify.Enabled = true;
                                }
                            }
                            else
                            {
                                btnNLevelCancel_Click(sender, e);
                            }
                        }    
                    }
                    catch
                    {
                        MessageBox.Show("Modify failed\r\nPlease ensure that you fill out valid N-Level information!", "Alert");
                    }

                    //Clear fields
                    ClearNLevelFields();

                    //Disable fields
                    EnableDisableNLevelFields(false);
                }
                else
                {
                    MessageBox.Show("Please select an N-Level to modify before saving!", "Alert");
                }
            }
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void btnNLevelCancel_Click( object sender, EventArgs e )
        {
            //Hide buttons
            btnNLevelSave.Visible = false;
            btnNLevelCancel.Visible = false;

            //Enable buttons
            btnNLevelAdd.Enabled = true;
            btnNLevelDelete.Enabled = true;
            btnNLevelModify.Enabled = true;

            //Clear fields
            ClearNLevelFields();

            //Disable fields
            EnableDisableNLevelFields(false);
        }
    }
}
