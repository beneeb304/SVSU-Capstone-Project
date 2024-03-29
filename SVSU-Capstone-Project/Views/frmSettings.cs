﻿using Microsoft.VisualBasic.FileIO;
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
       
        private void ClearRoomFields()
        {
            /* Function: ClearRoomFields
         * Description: Clears all fields on the room settings page.
         */
            //Clear fields
            txtRoomDescription.Text = "";
            txtRoomName.Text = "";
            //lstRoom.SelectedIndex = -1;
        }

        private void ClearCabinetFields()
        {       
        /* Function: ClearCabinetFields
         * Description: Clears all fields on the cabinet settings page.
         */
         
            //Clear fields
            txtCabinetDescription.Text = "";
            txtCabinetName.Text = "";
        }
        
        private void ClearCategoryFields()
        {
          /* Function: ClearCategoryFields
         * Description: Clears all fields on the category settings page.
         */ 
            //Clear fields
            txtCategoryDescription.Text = "";
            txtCategoryName.Text = "";
            lstCategory.SelectedIndex = -1;
        }
        
        private void ClearVendorFields()
        {
            /* Function: ClearVendorFields
         * Description: Clears all fields on the vendor settings page.
         */
            //Clear fields
            txtVendorDescription.Text = "";
            txtVendorName.Text = "";
            txtVendorHomepage.Text = "";
            lstVendor.SelectedIndex = -1;
        }

        private void tbcSettings_SelectedIndexChanged( object sender, EventArgs e )
        {

        /* Function: tbcSettings_SelectedIndexChanged
         * Description: Switches the page in the settings menu when a tab is clicked.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */

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
            }
        }
       
        private void btnDeleteUser_Click( object sender, EventArgs e )
        {
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

                        //Check if user is trying to delete themself
                        if (user != Authentication.ActiveUser)
                        {
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
                        else
                            MessageBox.Show("Cannot delete yourself while logged in!", "Alert");                        
                    }
                }
                catch
                {
                    MessageBox.Show("Delete failed!", "Alert");
                }

                //Clear fields
                //ClearUserFields();
            }
            else
            {
                MessageBox.Show("Select a user to delete", "Alert");
            }
        }
       
        private void btnAddUser_Click( object sender, EventArgs e )
        {
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
             
            //Disable buttons
            btnUserUpload.Enabled = false;
            btnUserModify.Enabled = false;
            btnUserDelete.Enabled = false;
            btnMassDelete.Enabled = false;

            //Show buttons
            btnUserSave.Visible = true;
            btnUserCancel.Visible = true;

            //Enable fields
            EnableDisableUserFields(true);

            //Clear fields
            ClearUserFields();
        }
       
        private void btnModifyUser_Click( object sender, EventArgs e )
        { 
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
           
            if (lstUser.SelectedIndex >= 0)
            {
                //Disable buttons
                btnUserAdd.Enabled = false;
                btnUserUpload.Enabled = false;
                btnUserDelete.Enabled = false;
                btnMassDelete.Enabled = false;

                //Show buttons
                btnUserSave.Visible = true;
                btnUserCancel.Visible = true;

                //Enable fields
                EnableDisableUserFields(true);
                txtUserSVSUID.Enabled = false;
            }
            else
                MessageBox.Show("Select a user before modification!", "Alert");
        }
       
        private void ClearUserFields()
        {
         /* Function: ClearUserFields
         * Description: Clears all fields in the user settings page.
         */
       
            //Clear fields
            txtUserSVSUID.Text = "";
            txtUserEmail.Text = "";
            txtUserFName.Text = "";
            txtUserLName.Text = "";
            txtUserPhone.Text = "";
            chkUserAdmin.Checked = false;
            lstUser.SelectedIndex = -1;
        }
   
        private void lstUser_SelectedIndexChanged( object sender, EventArgs e )
        {
             /* Function: lstUser_SelectedIndexChanged
         * Description: Fills the fields on the user settings page with user information when a new user is selected.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * User user; Represents the user being selected.
         */
            
            //If a user is selected
            if (lstUser.SelectedIndex >= 0 && btnUserSave.Text != "Confirm Delete")
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
       
        private void lstRoom_SelectedIndexChanged( object sender, EventArgs e )
        {
            /* Function: lstRoom_SelectedIndexChanged
         * Description: Fills the fields on the room settings page when a new room is selected.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * Room room; Represents the room to pass its information from the database to the fields.
         */
            
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
       
        private void btnAddRoom_Click( object sender, EventArgs e )
        {
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

        private void btnDeleteRoom_Click( object sender, EventArgs e )
        {
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

                //Removed this in regards to Issue #206, leaving here just in case we need to revert.
                //Clear fields
                //ClearRoomFields();
            }
            else
            {
                MessageBox.Show("Select a room to delete", "Alert");
            }
        }
       
        private void btnAddCategory_Click( object sender, EventArgs e )
        {      
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
       
        private void btnModifyCategory_Click( object sender, EventArgs e )
        {
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
            
            //Disable buttons
            btnCategoryAdd.Enabled = false;
            btnCategoryDelete.Enabled = false;

            //Show buttons
            btnCategoryCancel.Visible = true;
            btnCategorySave.Visible = true;

            //Enable fields
            EnableDisableCategoryFields(true);
        }
       
        private void btnDeleteCategory_Click( object sender, EventArgs e )
        {
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
                //ClearCategoryFields();
            }
            else
            {
                MessageBox.Show("Select a category to delete", "Alert");
            }
        }
      
        private void lstCategory_SelectedIndexChanged( object sender, EventArgs e )
        {
          
             /* Function: lstCategory_SelectedIndexChanged
         * Description: Sets the fields of the category settings page to reflect information of the selected category.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * Category category; Represents a category object.
         */ 
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
        
        private void lstVendor_SelectedIndexChanged( object sender, EventArgs e )
        {
           /* Function: lstVendor_SelectedIndexChanged
         * Description: Sets the fields of the vendor settings page to reflect the information of a selected vendor.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * Vendor vendor; Represents a vendor object.
         */
            
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
            
            //If a vendor is selected
            if (lstVendor.SelectedIndex >= 0)
            {
                try
                {
                    Vendor vendors = ItemModel.Get<Vendor>(x => x.strName == lstVendor.SelectedItem.ToString());
                    //var commodities = ItemModel.GetMany<Commodity>().Where(x => x.objVendor.uidTuid == vendors.uidTuid);
                    //if(commodities != null)
                    //{
                    //    MessageBox.Show($"{vendors.strName} is currently selected on a commodity. Please remove from the commodity if you wish to delete this vendor.", "Alert");
                    //}
                    //else
                    //{
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
                    //}
                }
                catch
                {
                    MessageBox.Show("Delete failed! Make sure the vendor is not associated with any commodities.", "Alert");
                }

                //Clear fields
                //ClearVendorFields();
            }
            else
            {
                MessageBox.Show("Select a vendor to delete", "Alert");
            }
        }
      
        private void btnAddVendor_Click( object sender, EventArgs e )
        {
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
       
        private void btnModifyVendor_Click( object sender, EventArgs e )
        {
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
            
            //Disable buttons
            btnVendorAdd.Enabled = false;
            btnVendorDelete.Enabled = false;

            //Show buttons
            btnVendorCancel.Visible = true;
            btnVendorSave.Visible = true;

            //Enable fields
            EnableDisableVendorFields(true);
        }
        
        private void cmbRoom_SelectedIndexChanged( object sender, EventArgs e )
        {
           
            /* Function: cmbRoom_SelectedIndexChanged
         * Description: Reflects the fields in the room settings page to have information of the selected room.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
            
            if (cmbRoom.Text != "")
            {
                // populate the textfield with appropriate data
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
      
        private void lstCabinet_SelectedIndexChanged( object sender, EventArgs e )
        {
            /* Function: lstCabinet_SelectedIndexChanged
         * Description: Reflects the fields in the cabinet settings page to show information of the selected cabinet.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * Cabinet cabinet; Represents the selected cabinet object.
         */
            
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
       
        private void btnModifyCabinet_Click( object sender, EventArgs e )
        {
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
        
        private void btnDeleteCabinet_Click( object sender, EventArgs e )
        {
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

                //Commenting out in regards to issue #207, leaving just in case we need to revert
                //Clear fields
                //ClearCabinetFields();
            }
            else
            {
                MessageBox.Show("Select a cabinet to delete", "Alert");
            }
        }

        private void btnUpload_Click( object sender, EventArgs e )
        {        
             /* Function: btnUpload_Click
         * Description: Uploads a csv file of student information to mass upload users.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * OpenfileDialog fd; Lets the user select the file to use for the upload.
         */
            
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
        
        private List<string[]> ReadCSVFile( string strPath )
        {
          /* Function: ReadCSVFile
         * Description: Reads the file given by the user to upload multiple users at once.
         * 
         * Local Variables
         * string strPath; Path to the file given by the user.
         * List<string[]> lstRows; Holds the list read from the file to be uploaded.
         * TextFieldParser parser; Reads the information from the uploaded file to the List.
         */
            
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
       
        private void UploadStudents( List<string[]> lstRows )
        {
           /* Function: UploadStudents
         * Description: Uploads the student list from the provided csv file to the database of users.
         * 
         * Local Variables
         * List<string[]> lstRows; Passes the read-in information to the method of users.
         * int intBadCtr, intGoodctr; Counts the amount of invalid and valid uploaded users respectively.
         * User user; Passes the uploaded information as an object to the database.
         */

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

        private void EnableDisableUserFields(bool blnEnable)
        {

            /* Function: EnableDisableUserFields
       * Description: Will enable or disable appropriate user fields when needed 
       * 
       * bool blnEnable hold the status the components being passed thru
       */
     
            if (blnEnable)
            {
               // enable fields  
                txtUserEmail.Enabled = true;
                txtUserFName.Enabled = true;
                txtUserLName.Enabled = true;
                txtUserPhone.Enabled = true;
                txtUserSVSUID.Enabled = true;
                chkUserAdmin.Enabled = true;
            }
            else
            {
                  // disable fields
                txtUserEmail.Enabled = false;
                txtUserFName.Enabled = false;
                txtUserLName.Enabled = false;
                txtUserPhone.Enabled = false;
                txtUserSVSUID.Enabled = false;
                chkUserAdmin.Enabled = false;
            }
        }

        private void EnableDisableRoomFields(bool blnEnable )
        {
            /* Function: EnableDisableRoomFields
       * Description: Will enable or disable appropriate room fields when needed 
       * 
       * bool blnEnable hold the status the components being passed thru
       * 
       */
            
            if (blnEnable)
            {
                // enable fields
                txtRoomDescription.Enabled = true;
                txtRoomName.Enabled = true;
            }
            
            else
            {
                // disable fields
                txtRoomDescription.Enabled = false;
                txtRoomName.Enabled = false;
            }
        }
  
        private void EnableDisableCabinetFields( bool blnEnable )
        {
            /* Function: EnableDisableCabinetFields
            * Description: Will enable or disable appropriate cabinet fields when needed 
            * 
            * bool blnEnable hold the status the components being passed thru
            */

            if (blnEnable)
            {
                // Enable fields 
                txtCabinetDescription.Enabled = true;
                txtCabinetName.Enabled = true;
            }
            // disable fields
            else
            {
                txtCabinetDescription.Enabled = false;
                txtCabinetName.Enabled = false;
            }
        }
        
        private void EnableDisableCategoryFields( bool blnEnable )
        {
            /* Function: EnableDisableCategoryFields
            * Description: Will enable or disable appropriate category fields when needed 
            * 
            * bool blnEnable hold the status the components being passed thru
            * 
            */

            if (blnEnable)
            {
                //enable fields
                txtCategoryDescription.Enabled = true;
                txtCategoryName.Enabled = true;
            }
            else
            {
                // disable fields
                txtCategoryDescription.Enabled = false;
                txtCategoryName.Enabled = false;
            }
        }
 
        private void EnableDisableVendorFields( bool blnEnable )
        {
            /* Function: EnableDisableVendorFields
             * Description: Will enable or disable appropriate category fields when needed 
             * 
             * bool blnEnable hold the status the components being passed thru
             * 
             */

            
            if (blnEnable)
            {
                //enable fields
                txtVendorDescription.Enabled = true;
                txtVendorName.Enabled = true;
                txtVendorHomepage.Enabled = true;
            }
         
            else
            {
                // disable fields
                txtVendorDescription.Enabled = false;
                txtVendorName.Enabled = false;
                txtVendorHomepage.Enabled = false;
            }
        }
        
        private void btnUserSave_Click( object sender, EventArgs e )
        {
            /* Function: btnUserSave_Click
          * Description: This functions will save the user credentials only if the entree 
          *              meets the requirements that are placed by the system
          * Local Variables:
          * string strEmail - user inout stored for the email
          * string strID - user input stored for the user ID
          * object sender; The object calling the method.
          * EventArgs e; Information passed by the sender object about the method call.
          */

            if (btnMassDelete.Enabled)
            {
                if(lstUser.SelectedItems.Count == 0)
                    MessageBox.Show("Select users to delete!", "Alert");
                else
                {
                    List<User> lstDeleteUsers = new List<User>();

                    int intCheckCtr = 0;
                    foreach (string strUser in lstUser.SelectedItems)
                    {
                        //Get the user email
                        MailAddress mailAddress = new MailAddress(strUser);

                        //Get user
                        User user = ItemModel.Get<User>(x => x.strEmail == mailAddress.Address);

                        if (user != null)
                        {
                            //Check if user has anything checked out
                            List<CheckedItem> lstCheckedItems = ItemModel.GetMany<CheckedItem>(x => x.objUser.uidTuid == user.uidTuid).ToList();

                            //If user doesn't have anything checked out, add to list
                            if (lstCheckedItems.Count > 0)
                                intCheckCtr++;
                            else
                                lstDeleteUsers.Add(user);
                        }
                    }

                    string strCheck = "";

                    if (intCheckCtr > 0)
                        strCheck = "\r\rNote, cannot delete " + intCheckCtr + " users because they have assets checked-out!";

                    if(lstDeleteUsers.Count == 0)
                    {
                        MessageBox.Show("Cannot delete " + intCheckCtr + " users because they have assets checked-out!");
                    }
                    else
                    {
                        //Ask the user before deletion
                        DialogResult result = MessageBox.Show("Are you sure you want to delete " + lstDeleteUsers.Count + " users?" + strCheck,
                            "Alert", MessageBoxButtons.YesNo);

                        int intDeleted = 0;
                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                //Delete each user in the list
                                foreach (User user in lstDeleteUsers)
                                {
                                    ItemModel.Delete<User>(user);
                                    intDeleted++;
                                }

                                //Alert user
                                MessageBox.Show("Successfully deleted " + intDeleted + " users!", "Alert");
                            }
                            catch
                            {
                                MessageBox.Show("Something failed, check server connection!\rDeleted " + intDeleted + " users.", "Error");
                            }
                        }

                        //Refresh list
                        tbcSettings_SelectedIndexChanged(sender, e);
                        btnUserCancel_Click(sender, e);
                    }
                }
            }
            else
            {
                //Trim unique identifiers
                // stored email
                string strEmail = txtUserEmail.Text.Trim();
                // stored user ID
                string strID = txtUserSVSUID.Text.Trim();

                // if button is entered
                if (btnUserAdd.Enabled)
                {
                    // as long as data is entered
                    if (strEmail.Length > 0 && txtUserFName.Text.Trim().Length > 0 &&
                        txtUserLName.Text.Trim().Length > 0 && strID.Length > 0)
                    {
                        string strError = "";

                        //Valid email
                        if (!Regex.IsMatch(strEmail,
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
                        if (!strID.All(char.IsLetterOrDigit) || strID.Length > 8)
                            strError += "Invalid SVSU ID\r";

                        //Only empty or numeric phone
                        if (!txtUserPhone.Text.All(char.IsNumber) && txtUserPhone.Text != "")
                            strError += "Invalid phone\r";

                        // if there is an error
                        if (strError == "")
                        {
                            //Ask user to confirm action
                            DialogResult result = MessageBox.Show("Are you sure you want to add " +
                                strEmail + " as a new user?", "Confirm", MessageBoxButtons.YesNo);
                            // if yes is selected from error
                            if (result == DialogResult.Yes)
                            {
                                //Check for duplicate user
                                var emailExists = ItemModel.Get<User>(x => x.strEmail.ToLower() == strEmail.ToLower());
                                var idExists = ItemModel.Get<User>(x => x.strSvsu_id.ToLower() == strID.ToLower());

                                // if email already exist
                                if (emailExists != null)
                                {
                                    MessageBox.Show("A user already exists with the entered email.", "Alert");
                                    btnUserCancel_Click(sender, e);
                                }
                                //if ID already exist
                                else if (idExists != null)
                                {
                                    MessageBox.Show("A user alread exists with the entered SVSU ID.", "Alert");
                                    btnUserCancel_Click(sender, e);
                                }
                                else
                                {
                                    //Set user properties                        
                                    User user = new User
                                    {
                                        strSvsu_id = strID,
                                        strEmail = strEmail,
                                        strFirst_name = txtUserFName.Text.Trim(),
                                        strLast_name = txtUserLName.Text.Trim(),
                                        strPhone = txtUserPhone.Text.Trim(),
                                        blnIsAdmin = chkUserAdmin.Checked
                                    };

                                    //Add user
                                    ItemModel.Add<User>(user);

                                    //Alert user
                                    MessageBox.Show("Successfully added " + user.strFirst_name, "Alert");

                                    //Refresh list
                                    tbcSettings_SelectedIndexChanged(sender, e);

                                    //Hide buttons
                                    btnUserSave.Visible = false;
                                    btnUserCancel.Visible = false;

                                    //Enable buttons
                                    btnUserUpload.Enabled = true;
                                    btnUserModify.Enabled = true;
                                    btnUserDelete.Enabled = true;

                                    //Clear fields
                                    ClearUserFields();
                                    EnableDisableUserFields(false);
                                }
                            }
                        }
                        else
                            MessageBox.Show("Error adding user!\r\r" + strError, "Alert");
                    }
                }
                else if (btnUserModify.Enabled)
                {
                    //If a user is selected
                    if (lstUser.SelectedIndex >= 0 && strEmail != "" && txtUserFName.Text.Trim() != "" &&
                        txtUserLName.Text.Trim() != "" && strID != "")
                    {
                        try
                        {
                            string strError = "";

                            //Valid email
                            if (!Regex.IsMatch(strEmail,
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
                            if (!strID.All(char.IsLetterOrDigit) || strID.Length > 8)
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
                                    User user = ItemModel.Get<User>(x => x.strSvsu_id.ToLower() == strID.ToLower());

                                    //Check for duplicate user
                                    var emailExists = ItemModel.Get<User>(x => x.strEmail.ToLower() == strEmail.ToLower());
                                    var idExists = ItemModel.Get<User>(x => x.strSvsu_id.ToLower() == strID.ToLower());

                                    //If email exists and it's not the selected user's email
                                    if (emailExists != null && emailExists.strEmail.ToLower() != user.strEmail.ToLower())
                                    {
                                        MessageBox.Show("This email already exists", "Alert");
                                        btnUserCancel_Click(sender, e);
                                    }
                                    else if (idExists != null && idExists.strSvsu_id.ToLower() != user.strSvsu_id.ToLower())
                                    {
                                        MessageBox.Show("This SVSU ID already exists", "Alert");
                                        btnUserCancel_Click(sender, e);
                                    }
                                    else
                                    {
                                        //Modify user
                                        user.strSvsu_id = strID;
                                        user.strEmail = strEmail;
                                        user.strFirst_name = txtUserFName.Text.Trim();
                                        user.strLast_name = txtUserLName.Text.Trim();
                                        user.strPhone = txtUserPhone.Text.Trim();
                                        user.blnIsAdmin = chkUserAdmin.Checked;

                                        //Save user
                                        ItemModel.Update<User>(user);

                                        //Alert user
                                        MessageBox.Show("Successful Modification!", "Alert");

                                        //Refresh list
                                        tbcSettings_SelectedIndexChanged(sender, e);

                                        //Hide buttons
                                        btnUserSave.Visible = false;
                                        btnUserCancel.Visible = false;

                                        //Enable buttons
                                        btnUserAdd.Enabled = true;
                                        btnUserUpload.Enabled = true;
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
                            else
                                MessageBox.Show("Error modifying user!\r\r" + strError, "Alert");
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
        }

        private void btnUserCancel_Click( object sender, EventArgs e )
        {
            /* Function: btnUserCancel_Click
            * Description: This functions will clear the fields and disable fields if cancel is selected when adding a user
            * Local Variables:
            * object sender; The object calling the method.
            * EventArgs e; Information passed by the sender object about the method call.
            */

            //Hide buttons
            btnUserSave.Visible = false;
            btnUserCancel.Visible = false;

            //Enable buttons
            btnUserAdd.Enabled = true;
            btnUserUpload.Enabled = true;
            btnUserModify.Enabled = true;
            btnUserDelete.Enabled = true;
            btnMassDelete.Enabled = true;

            //Unselect listbox
            lstUser.SelectedIndex = -1;

            //Clear fields
            ClearUserFields();

            //Disable fields
            EnableDisableUserFields(false);

            if (btnMassDelete.Enabled)
            {
                //Change back to single selection mode
                lstUser.SelectionMode = SelectionMode.One;

                //Change text back
                btnUserSave.Text = "Save User";
            }
        }

        private void btnRoomSave_Click( object sender, EventArgs e )
        {
            /* Function: btnRoomSave_Click
         * Description: This functions will save the room credentials only if the entree 
         *              meets the requirements that are placed by the system
         * Local Variables:
         * string strRoomName - user input stored for the room name
         * 
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
            //Trim unique identifier
            string strRoomName = txtRoomName.Text.Trim();
            
            if (btnRoomAdd.Enabled)
            {
                if (strRoomName.Length > 0)
                {
                    try
                    {
                        //Only alphanumeric and spaces in room name
                        if (!strRoomName.All(c => char.IsLetterOrDigit(c) || c.Equals(' ')))
                            MessageBox.Show("Only alphanumeric and spaces in room name", "Alert");
                        else
                        {
                            //Ask user to confirm action
                            DialogResult result = MessageBox.Show("Are you sure you want to add " +
                                strRoomName + " as a new room?", "Confirm", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                //Cannot add duplicate room
                                Room exists = ItemModel.Get<Room>(x => x.strName.ToLower() == strRoomName.ToLower());
                                if (exists != null)
                                {
                                    MessageBox.Show("Cannot add duplicate room", "Alert");
                                    btnRoomCancel_Click(sender, e);
                                }
                                else
                                {
                                    //Set room properties                        
                                    Room room = new Room
                                    {
                                        strName = strRoomName,
                                        strDescription = txtRoomDescription.Text.Trim()
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
                if (lstRoom.SelectedIndex >= 0 && strRoomName.Length > 0)
                {
                    try
                    {
                        //Only alphanumeric and spaces in room name
                        if (!strRoomName.All(c => char.IsLetterOrDigit(c) || c.Equals(' ')))
                            MessageBox.Show("Only alphanumeric and spaces in room name", "Alert");
                        else
                        {
                            //Ask user to confirm action
                            DialogResult result = MessageBox.Show("Are you sure you want to modify " +
                            lstRoom.SelectedItem.ToString() + " to current field values?", "Confirm", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                //Cannot add duplicate room
                                Room exists = ItemModel.Get<Room>(x => x.strName.ToLower() == strRoomName.ToLower());

                                //If room exists and it's not the selected room
                                if (exists != null && exists.strName.ToLower() != lstRoom.SelectedItem.ToString().ToLower())
                                {
                                    MessageBox.Show("Cannot modify duplicate room", "Alert");
                                    btnRoomCancel_Click(sender, e);
                                }
                                else
                                {
                                    //Get room
                                    Room room = ItemModel.Get<Room>(x => x.strName == lstRoom.SelectedItem.ToString());

                                    //Modify room
                                    room.strName = strRoomName;
                                    room.strDescription = txtRoomDescription.Text.Trim();

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

        private void btnRoomCancel_Click( object sender, EventArgs e )
        {
            /* Function: btnRoomCancel_Click
            * Description: This functions will clear the fields and disable fields if cancel is selected when adding a room
            * Local Variables:
            * object sender; The object calling the method.
            * EventArgs e; Information passed by the sender object about the method call.
            */

            //Hide buttons
            btnRoomSave.Visible = false;
            btnRoomCancel.Visible = false;

            //Enable buttons
            btnRoomAdd.Enabled = true;
            btnRoomDelete.Enabled = true;
            btnRoomModify.Enabled = true;

            //Unselect listbox
            lstRoom.SelectedIndex = -1;

            //Clear fields
            ClearRoomFields();

            //Disable fields
            EnableDisableRoomFields(false);
        }
        
        private void btnCabinetSave_Click( object sender, EventArgs e )
        {
            /* Function: btnCabinetSave_Click
        * Description: This functions will save the cabinet credentials only if the entree 
        *              meets the requirements that are placed by the system
        * Local Variables:
        * string strRoomName - user input stored for the cabinet name
        * Cabinet cabinet - new cabinet component
        * 
        * object sender; The object calling the method.
        * EventArgs e; Information passed by the sender object about the method call.
        */
            //Trim unique identifier
            string strCabinetName = txtCabinetName.Text.Trim();

            if (btnCabinetAdd.Enabled)
            {
                if (strCabinetName != "" && cmbRoom.SelectedIndex >= 0)
                {
                    try
                    {
                        //Only alphanumeric and spaces in cabinet name
                        if (!strCabinetName.All(c => char.IsLetterOrDigit(c) || c.Equals(' ')))
                            MessageBox.Show("Only alphanumeric and spaces in cabinet name", "Alert");
                        else
                        {
                            //Ask user to confirm action
                            DialogResult result = MessageBox.Show("Are you sure you want to add " +
                                strCabinetName + " as a new cabinet for " + cmbRoom.SelectedItem.ToString() + "?", "Confirm", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                //Check for duplicate cabinets in the room
                                Cabinet exists = ItemModel.Get<Cabinet>(x => x.strName.ToLower() == strCabinetName.ToLower() &&
                                    x.objRoom.strName == cmbRoom.Text);
                                
                                if (exists != null)
                                {
                                    MessageBox.Show("Cannot add duplicate cabinet!", "Alert");
                                    btnCabinetCancel_Click(sender, e);
                                }
                                else
                                {
                                    //Set cabinet properties                        
                                    Cabinet cabinet = new Cabinet()
                                    {
                                        strName = strCabinetName,
                                        strDescription = txtCabinetDescription.Text.Trim(),
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
                if (lstCabinet.SelectedIndex >= 0 && cmbRoom.SelectedIndex >= 0 && strCabinetName.Length > 0)
                {
                    try
                    {
                        //Only alphanumeric and spaces in cabinet name
                        if (!strCabinetName.All(c => char.IsLetterOrDigit(c) || c.Equals(' ')))
                            MessageBox.Show("Only alphanumeric and spaces in cabinet name", "Alert");
                        else
                        {
                            //Ask user to confirm action
                            DialogResult result = MessageBox.Show("Are you sure you want to modify " +
                            lstCabinet.SelectedItem.ToString() + " in " + cmbRoom.SelectedItem.ToString() + " to current field values?", "Confirm", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                //Check for duplicate cabinets in the room
                                Cabinet exists = ItemModel.Get<Cabinet>(x => x.strName.ToLower() == strCabinetName.ToLower() &&
                                    x.objRoom.strName == cmbRoom.Text);

                                //If cabinet exists and it's not the selected cabinet
                                if (exists != null && exists.strName.ToLower() != lstCabinet.SelectedItem.ToString().ToLower())
                                {
                                    MessageBox.Show("Cannot modify duplicate cabinet", "Alert");
                                    btnCabinetCancel_Click(sender, e);
                                }
                                else
                                {
                                    //Get cabinet
                                    Cabinet cabinet = ItemModel.Get<Cabinet>(x => x.strName == lstCabinet.SelectedItem.ToString() &&
                                        x.objRoom.strName == cmbRoom.SelectedItem.ToString());

                                    //Modify cabinet
                                    cabinet.strName = strCabinetName;
                                    cabinet.strDescription = txtCabinetDescription.Text.Trim();

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

        private void btnCabinetCancel_Click( object sender, EventArgs e )
        {
            /* Function: btnCabinetCancel_Click
           * Description: This functions will clear the fields and disable fields if cancel is selected when adding a cabinet
           * Local Variables:
           * object sender; The object calling the method.
           * EventArgs e; Information passed by the sender object about the method call.
           */

            //Hide buttons
            btnCabinetCancel.Visible = false;
            btnCabinetSave.Visible = false;

            //Enable buttons
            btnCabinetAdd.Enabled = true;
            btnCabinetDelete.Enabled = true;
            btnCabinetModify.Enabled = true;
            cmbRoom.Enabled = true;

            //Unselect listbox
            lstCabinet.SelectedIndex = -1;

            //Clear fields
            ClearCabinetFields();

            //Disable fields
            EnableDisableCabinetFields(false);
        }

        private void btnCategorySave_Click( object sender, EventArgs e )
        {
            /* Function: btnCategorySave_Click
       * Description: This functions will save the category credentials only if the entree 
       *              meets the requirements that are placed by the system
       * Local Variables:
       * string strCategoryName - user input stored for the category name
       * 
       * object sender; The object calling the method.
       * EventArgs e; Information passed by the sender object about the method call.
       */
            string strCategoryName = txtCategoryName.Text.Trim();
            
            if (btnCategoryAdd.Enabled)
            {
                if (strCategoryName.Length > 0)
                {
                    try
                    {
                        //Only alphanumeric and spaces in category name
                        if (!strCategoryName.All(c => char.IsLetterOrDigit(c) || c.Equals(' ')))
                            MessageBox.Show("Only alphanumeric and spaces in category name", "Alert");
                        else
                        {
                            //Ask user to confirm action
                            DialogResult result = MessageBox.Show("Are you sure you want to add " +
                                strCategoryName + " as a new category?", "Confirm", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                //Check for duplicates
                                Category exists = ItemModel.Get<Category>(x => x.strName.ToLower() == strCategoryName.ToLower());
                                if (exists != null)
                                {
                                    MessageBox.Show("Cannot add duplicate category", "Alert");
                                    btnCategoryCancel_Click(sender, e);
                                }
                                else
                                {
                                    //Set category properties                        
                                    Category category = new Category()
                                    {
                                        strName = strCategoryName,
                                        strDescription = txtCategoryDescription.Text.Trim()
                                    };

                                    //Add category
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
                if (lstCategory.SelectedIndex >= 0 && strCategoryName.Length > 0)
                {
                    try
                    {
                        //Only alphanumeric and spaces in category name
                        if (!strCategoryName.All(c => char.IsLetterOrDigit(c) || c.Equals(' ')))
                            MessageBox.Show("Only alphanumeric and spaces in category name", "Alert");
                        else
                        {
                            //Ask user to confirm action
                            DialogResult result = MessageBox.Show("Are you sure you want to modify " +
                            lstCategory.SelectedItem.ToString() + " to current field values?", "Confirm", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                //Cannot add duplicate category
                                Category exists = ItemModel.Get<Category>(x => x.strName.ToLower() == strCategoryName.ToLower());

                                //If category exists and it's not the selected category
                                if (exists != null && exists.strName.ToLower() != lstCategory.SelectedItem.ToString().ToLower())
                                {
                                    MessageBox.Show("Cannot modify duplicate category", "Alert");
                                    btnCategoryCancel_Click(sender, e);
                                }
                                else
                                {
                                    //Make category
                                    Category category = ItemModel.Get<Category>(x => x.strName == lstCategory.SelectedItem.ToString());

                                    //Modify category
                                    category.strName = strCategoryName;
                                    category.strDescription = txtCategoryDescription.Text.Trim();

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

        private void btnCategoryCancel_Click( object sender, EventArgs e )
        {
            /* Function: btnCategoryCancel_Click
           * Description: This functions will clear the fields and disable fields if cancel is selected when adding a category
           * Local Variables:
           * object sender; The object calling the method.
           * EventArgs e; Information passed by the sender object about the method call.
           */

            //Hide buttons
            btnCategorySave.Visible = false;
            btnCategoryCancel.Visible = false;

            //Enable buttons
            btnCategoryAdd.Enabled = true;
            btnCategoryDelete.Enabled = true;
            btnCategoryModify.Enabled = true;

            //Unselect listbox
            lstCategory.SelectedIndex = -1;

            //Clear fields
            ClearCategoryFields();

            //Disable fields
            EnableDisableCategoryFields(false);
        }

        private void btnVendorSave_Click( object sender, EventArgs e )
        {
            /* Function: btnVendorSave_Click
       * Description: This functions will save the vendor credentials only if the entree 
       *              meets the requirements that are placed by the system
       * Local Variables:
       * string strVendorName - user input stored for the vendor name
       * 
       * object sender; The object calling the method.
       * EventArgs e; Information passed by the sender object about the method call.
       */

            //Trim unique identifier
            string strVendorName = txtVendorName.Text.Trim();
            
            if (btnVendorAdd.Enabled)
            {
                if (strVendorName.Length > 0)
                {
                    try
                    {
                        //Only alphanumeric and spaces in vendor name
                        if (!strVendorName.All(c => char.IsLetterOrDigit(c) || c.Equals(' ')))
                            MessageBox.Show("Only alphanumeric and spaces in vendor name", "Alert");
                        else
                        {
                            //Ask user to confirm action
                            DialogResult result = MessageBox.Show("Are you sure you want to add " +
                                strVendorName + " as a new vendor?", "Confirm", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                //Cannot add duplicate vendor
                                Vendor exists = ItemModel.Get<Vendor>(x => x.strName.ToLower() == strVendorName.ToLower());
                                if(exists != null)
                                {
                                    MessageBox.Show("Cannot add duplicate vendor", "Alert");
                                    btnVendorCancel_Click(sender, e);
                                }
                                else
                                {
                                    //Set room properties
                                    Vendor vendor = new Vendor()
                                    {
                                        strName = strVendorName,
                                        strDescription = txtVendorDescription.Text.Trim(),
                                        strHomepage = txtVendorHomepage.Text.Trim()
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
                if (lstVendor.SelectedIndex >= 0 && strVendorName.Length > 0)
                {
                    try
                    {
                        //Only alphanumeric and spaces in vendor name
                        if (!strVendorName.All(c => char.IsLetterOrDigit(c) || c.Equals(' ')))
                            MessageBox.Show("Only alphanumeric and spaces in vendor name", "Alert");
                        else
                        {
                            //Ask user to confirm action
                            DialogResult result = MessageBox.Show("Are you sure you want to modify " +
                            lstVendor.SelectedItem.ToString() + " to current field values?", "Confirm", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                //Cannot add duplicate vendor
                                Vendor exists = ItemModel.Get<Vendor>(x => x.strName.ToLower() == strVendorName.ToLower());

                                //If vendor exists and it's not the selected vendor
                                if (exists != null && exists.strName.ToLower() != lstVendor.SelectedItem.ToString().ToLower())
                                {
                                    MessageBox.Show("Cannot modify duplicate vendor", "Alert");
                                    btnVendorCancel_Click(sender, e);
                                }
                                else
                                {
                                    //Get vendor
                                    Vendor vendor = ItemModel.Get<Vendor>(x => x.strName == lstVendor.SelectedItem.ToString());

                                    //Modify category
                                    vendor.strName = strVendorName;
                                    vendor.strDescription = txtVendorDescription.Text.Trim();
                                    vendor.strHomepage = txtVendorHomepage.Text.Trim();

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

        private void btnVendorCancel_Click( object sender, EventArgs e )
        {
            /* Function: btnVendorCancel_Click
           * Description: This functions will clear the fields and disable fields if cancel is selected when adding a vendor
           * Local Variables:
           * object sender; The object calling the method.
           * EventArgs e; Information passed by the sender object about the method call.
           */

            //Hide buttons
            btnVendorSave.Visible = false;
            btnVendorCancel.Visible = false;

            //Enable buttons
            btnVendorAdd.Enabled = true;
            btnVendorDelete.Enabled = true;
            btnVendorModify.Enabled = true;

            //Unselect listbox
            lstVendor.SelectedIndex = -1;

            //Clear fields
            ClearVendorFields();

            //Disable fields
            EnableDisableVendorFields(false);
        }

        private void chkUserAdmin_Click( object sender, EventArgs e )
        {
            /* Function: chkUserAdmin_Click
       * Description: This functions will check to see if user has items checked out and not let the 
       *                admin status be changed if items are checked out buy the user
       * Local Variables:
       * 
       * object sender; The object calling the method.
       * EventArgs e; Information passed by the sender object about the method call.
       */

            if (btnUserModify.Enabled && btnUserSave.Visible)
            {
                User user = ItemModel.Get<User>(x => x.strSvsu_id == txtUserSVSUID.Text);
                // if user has items checked out prompt error message
                if (user.lstCheckedItems.Count > 0)
                {
                    MessageBox.Show("Cannot change Admin status while user has items checked out!", "Alert");
                    chkUserAdmin.Checked = !chkUserAdmin.Checked;
                }
            }
        }
        private void frmSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnMassDelete_Click( object sender, EventArgs e )
        {
            //Put the listbox on multi-select mode
            lstUser.SelectionMode = SelectionMode.MultiSimple;

            //Disable buttons
            btnUserUpload.Enabled = false;
            btnUserAdd.Enabled = false;
            btnUserModify.Enabled = false;
            btnUserDelete.Enabled = false;

            //Show buttons
            btnUserSave.Visible = true;
            btnUserCancel.Visible = true;

            //Change text
            btnUserSave.Text = "Confirm Delete";

            //Enable fields
            EnableDisableUserFields(true);

            //Clear fields
            ClearUserFields();

            //Alert user what to do
            MessageBox.Show("Select all of the users that you want to delete. Then, click to confirm your actions.", "Alert");
        }

        private void chkUserAdmin_CheckedChanged( object sender, EventArgs e )
        {

        }
    }
}
