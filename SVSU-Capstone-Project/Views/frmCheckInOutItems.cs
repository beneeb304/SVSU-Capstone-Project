using SVSU_Capstone_Project.Model;
using SVSU_Capstone_Project.ViewModel;
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
    public partial class frmCheckInOutItems : Form
    {
       
        public frmCheckInOutItems()
        {
            /* Function: frmCheckInOutItems
             * -----------------------------------------------------------------------------
             * Description: Initializes the form when called upon
             * -----------------------------------------------------------------------------
             */

            InitializeComponent();
            // checked in/out status set to null
            tbcCheckInOut_SelectedIndexChanged(null, null);
        }

        private void tbcCheckInOut_SelectedIndexChanged( object sender, EventArgs e )
        {
            /* Function: tbcCheckInOut_SelectedIndexChanged
            * -----------------------------------------------------------------------------
            * Description: This function will populate either the assets tab with data or the 
            * Consumable tab with data depending on which tab is clicked. 
            * -----------------------------------------------------------------------------
            *  Parameter Dictionary (in parameter order):  
            *  EventArgs e; Information passed by the sender object about the method call.
            *  object sender; The object calling the method. 
            * -----------------------------------------------------------------------------
            * Local Variables
            * object sender; Object calling the method, in this case the form's tabs.
            * EventArgs e; Arguments passed by the calling object.
            * CheckedItem checkedItems; Temporary CheckedItem to fill the controls of the form.
            */

            switch (tbcCheckInOut.SelectedTab.Name)
            {
                case "tbpCheckOut":
                    lstStudents.DataSource = ItemModel.GetMany<User>().Where(x => x.blnIsAdmin == false).OrderBy(x => x.strLast_name).Select(x => x.strLast_name + ", " + x.strFirst_name + " - " + x.strEmail).ToList();
                    lstStudents.SelectedIndex = -1;
                    cmbChkOutCommodity.DataSource = ItemModel.GetMany<Commodity>(x => x.enuCommodityType == ItemType.Equipment && x.lstStorage != null && x.lstStorage.Count != 0).OrderBy(x => x.strName).ToList();
                    txtAvailableChkOutQuantity.Text = "";
                    cmbChkOutCommodity.SelectedIndex = -1;
                    txtStudentSearch.Text = "";
                    break;

                case "tbpCheckIn":
                    var checkedItems = ItemModel.GetMany<CheckedItem>().Where(x => x.objLog.enuAction == ItemAction.CheckedOut).ToList();
                    lstStudentChkIn.DataSource = ItemModel.GetMany<CheckedItem>().Where(x => (x.objLog.enuAction) == ItemAction.CheckedOut).OrderBy(x => x.objUser.strLast_name).Select(x => x.objUser.strLast_name + ", " + x.objUser.strFirst_name + " - " + x.objUser.strEmail).Distinct().ToList();
                    lstStudentChkIn.SelectedIndex = -1;
                    cmbChkInCommodity.SelectedIndex = -1;
                    txtStudentChkIn.Text = "";
                    break;
            }
        }


        private void txtStudentSearch_TextChanged(object sender, EventArgs e)
        {
            var lstStudent = ItemModel.GetMany<User>().Where(x => x.blnIsAdmin == false).ToList();
            lstStudents.ClearSelected();

            string strTemp;

            if(txtStudentSearch.Text.Length > 0)
            {
                lstStudents.DataSource = null;
                lstStudents.Items.Clear();

                List<User> lstTemp = lstStudent.Where(x => x.strEmail.IndexOf(txtStudentSearch.Text, 0, StringComparison.CurrentCultureIgnoreCase) != -1 ||
                x.strFirst_name.IndexOf(txtStudentSearch.Text, 0, StringComparison.CurrentCultureIgnoreCase) != -1 ||
                x.strLast_name.IndexOf(txtStudentSearch.Text, 0, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();

                foreach (User user in lstTemp)
                {
                    strTemp = user.strFirst_name.Trim() + " " + user.strLast_name.Trim() + " - " + user.strEmail.Trim();
                    lstStudents.Items.Add(strTemp);
                }
            }
            else
            {
                lstStudents.DataSource = ItemModel.GetMany<User>().Where(x => x.blnIsAdmin == false).OrderBy(x => x.strLast_name).Select(x => x.strLast_name + ", " + x.strFirst_name + " - " + x.strEmail).ToList();
            }
        }

        private void txtStudentChkInSearch_TextChanged( object sender, EventArgs e )
        {
            var lstStudent = ItemModel.GetMany<CheckedItem>().Where(x => (x.objLog.enuAction) == ItemAction.CheckedOut).ToList();
            
            lstStudentChkIn.ClearSelected();

            string strTemp;

            if (txtStudentChkIn.Text.Length > 0)
            {
              
                lstStudentChkIn.DataSource = null;
                lstStudentChkIn.Items.Clear();

                List<CheckedItem> lstTemp = lstStudent.Where(x => x.objUser.strEmail.IndexOf(txtStudentChkIn.Text, 0, StringComparison.CurrentCultureIgnoreCase) != -1 ||
                x.objUser.strFirst_name.IndexOf(txtStudentChkIn.Text, 0, StringComparison.CurrentCultureIgnoreCase) != -1 ||
                x.objUser.strLast_name.IndexOf(txtStudentChkIn.Text, 0, StringComparison.CurrentCultureIgnoreCase) != -1).Distinct().ToList();




                foreach (CheckedItem user in lstTemp)
                {
                    strTemp = user.objUser.strFirst_name.Trim() + " " + user.objUser.strLast_name.Trim() + " - " + user.objUser.strEmail.Trim();;
                    if(lstStudentChkIn.Items.Contains(strTemp))
                    {
                        //Do Nothing.
                    }
                    else
                    {
                        lstStudentChkIn.Items.Add(strTemp);
                    }
                    
                }
            }
            else
            {
                lstStudentChkIn.DataSource = ItemModel.GetMany<CheckedItem>().Where(x => (x.objLog.enuAction) == ItemAction.CheckedOut).OrderBy(x => x.objUser.strLast_name).Select(x => x.objUser.strLast_name + ", " + x.objUser.strFirst_name + " - " + x.objUser.strEmail).Distinct().ToList();
                lstStudentChkIn.SelectedIndex = -1;
                cmbChkInCommodity.SelectedIndex = -1;
            }
        }

        /* Function: cmbChkOutCommodity_SelectedIndexChanged
         * Description: When a commodity is selected from the CheckOut combobox, update the quantity text field
         * with the quantity of that commodity from the database.
         * 
         * Local Variables
         * object sender; Object control that called the function, in this case cmbChkOutCommodity.
         * EventArgs e; Arguments passed by the Object sender.
         * Commodity objSelectedCommodity; Represents the commodity selected in the combobox.
         * Storage quantity; Represents the commodity in specific storage so the quantity can be displayed.
         */
        private void cmbChkOutCommodity_SelectedIndexChanged( object sender, EventArgs e )
        {
            if (cmbChkOutCommodity.SelectedIndex >= 0)
            {
                var objSelectedCommodity = cmbChkOutCommodity.SelectedValue as Commodity;
                var quantity = ItemModel.Get<Storage>(
                x => x.objCommodity.uidTuid == objSelectedCommodity.uidTuid
                );
                txtAvailableChkOutQuantity.Text = quantity.intQuantity.ToString();
            }
        }


        /* Function: btnChkOut_Click
         * Description: Checks out a commodity item to a specific user. Ensures that the commodity is eligible to be checked out,
         * and the user is eligible to checkout an item. A successful checkout it created then logged before sending it to the database.
         * 
         * Local Variables
         * object sender; Object control that called the function, in this case btnChkOut.
         * EventArgs e; Arguments passed by the Object sender.
         * Commodity objSelectedCommodity; Represents the commodity selected in the combobox.
         * Storage quantity; Represents the commodity in specific storage so the quantity can be displayed.
         * Storage objStorage_tuid; The selected inventory commodity based on storage ID.
         * String email; Email string of the user checking out the commodity.
         * User objUser_tuid; User object of the user checking out the commodity looked up via email.
         * CheckedItem doesExist; Used to determine if the selected commodity has been checked out by the user already.
         * DialogueResult result; Prompts the user to confirm the checkout.
         * DateTime timestamp; The time of checkout.
         * Log log; Logs the transaction as a Log object.
         * Log objLog_Tuid; To send the log object as an ItemModel.
         * CheckedItem checkedItem; To store the details of the checkout and add it to the database.
         * Storage storage; Updates the quantity to the user after a checkout.
         */
        private void btnChkOut_Click( object sender, EventArgs e )
        {
            // Ensure both a commodity and user are selected, and display alerts based on the combination. If both are selected, attempt the checkout.
            if (lstStudents.SelectedIndex == -1 && cmbChkOutCommodity.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a user and an item!", "Alert");
            }
            else if (lstStudents.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a user!", "Alert");
            }
            else if (cmbChkOutCommodity.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item!", "Alert");
            }
            else
            {
                var objSelectedCommodity = cmbChkOutCommodity.SelectedValue as Commodity;
                var quantity = ItemModel.Get<Storage>(
                    x => x.objCommodity.uidTuid == objSelectedCommodity.uidTuid);
                if (quantity.intQuantity <= 0)
                {
                    MessageBox.Show("The item selected does not have any items available for checkout!", "Alert");
                }
                else
                {
                    var objStorage_tuid = ItemModel.Get<Storage>(x => x.objCommodity.uidTuid == objSelectedCommodity.uidTuid);
                    var email = lstStudents.Text.Split(' ').Last();
                    var objUser_tuid = ItemModel.Get<User>(x => x.strEmail == email);
                    var doesExist = ItemModel.GetMany<CheckedItem>().Where(x => x.objUser.uidTuid == objUser_tuid.uidTuid && x.objCommodities.strName == objSelectedCommodity.strName).ToList();
                    if (doesExist.Count != 0)
                    {
                        MessageBox.Show(objUser_tuid.strFirst_name + " " + objUser_tuid.strLast_name + " already has this item checked out! Please return the item, select a different item, or select a different user to continue checking out an item.", "Alert");
                    }
                    else if (objStorage_tuid.intQuantity > 0)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to check out " +
                            objSelectedCommodity.strName + " for " + objUser_tuid.strFirst_name +
                            " " + objUser_tuid.strLast_name + "?", "Confirm", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            var timestamp = DateTime.Now;
                            Log log = new Log()
                            {
                                enuAction = ItemAction.CheckedOut,
                                dtTimestamp = timestamp,
                                strNotes = txtChkOutNotes.Text,
                                intQuantityChange = -1,
                                objStorage = objStorage_tuid,
                                objUser = objUser_tuid
                            };

                            ItemModel.Add<Log>(log);

                            var objLog_Tuid = ItemModel.Get<Log>(x=> x.uidTuid == log.uidTuid);

                            CheckedItem checkedItem = new CheckedItem()
                            {
                                objCommodities = objSelectedCommodity,
                                objLog = objLog_Tuid,
                                objUser = objUser_tuid
                            };

                            ItemModel.Add<CheckedItem>(checkedItem);

                            Storage storage = ItemModel.Get<Storage>(x => x.uidTuid == objStorage_tuid.uidTuid);
                            storage.intQuantity = storage.intQuantity - 1;
                            ItemModel.Update<Storage>(storage);
                            MessageBox.Show(objUser_tuid.strFirst_name + " " + objUser_tuid.strLast_name + " has successfully checked out " + objSelectedCommodity.strName + ".");
                            tbcCheckInOut_SelectedIndexChanged(null, null);
                            cmbChkOutCommodity_SelectedIndexChanged(sender, e);
                            btnChkOutCancel_Click(sender, e);
                        }
                    }
                }
            }
        }

        /* Function: btnChkOutCancel_Click
         * Description: Cancels any filled out fields on the form and sets them all back to their default state.
         * 
         * Local Variables
         * Object sender; Object that calls this method, in this case btnChkOutCancel.
         * EventArgs e; Arguments provided by the sender object.
         */
        private void btnChkOutCancel_Click( object sender, EventArgs e )
        {
            cmbChkOutCommodity.SelectedIndex = -1;
            lstStudents.SelectedIndex = -1;
            txtChkOutNotes.Text = "";
            txtAvailableChkOutQuantity.Text = "";
            txtStudentSearch.Text = "";
        }

        /* Function: btnChkIn_Click
         * Description: Marks a commoditiy checked out by a user to returned. Logs the transaction.
         * 
         * Local Variables
         * Object sender; Object that calls this method, in this case btnChkIn.
         * EventArgs e; Arguments provided by the sender object.
         * String email; Email string of the user checking in the commodity.
         * CheckedItem objSelectedItem; Represents the commodity selected in the combobox.
         * Commodity objCommodity_tuid; Used to look up the commodity in the database by ID.
         * CheckedItem doesExist; Used to determine if the selected commodity has been checked out by the user already.
         * DateTime timestamp; The time of checkin.
         * User objUser; User checking in the item.
         * Storage objStorage_tuid; The selected inventory commodity based on storage ID.
         * Storage storage; Updates the quantity to the user after a checkin.
         * Log log; Logs the transaction as a Log object.
         */
        private void btnChkIn_Click( object sender, EventArgs e )
        {
            if (lstStudentChkIn.SelectedIndex == -1 || cmbChkInCommodity.SelectedIndex == -1)
            {
                MessageBox.Show("Please select make sure a student and commodity is selected to check back in!", "Alert");
            }
            else
            {
                var email = lstStudentChkIn.Text.Split(' ').Last();
                var objSelectedItem = cmbChkInCommodity.SelectedItem;
                var objCommodity_tuid = ItemModel.Get<Commodity>(x => x.strName == objSelectedItem);
                var doesExist = ItemModel.Get<CheckedItem>(x => x.objUser.strEmail == email && x.objCommodities.strName == objSelectedItem.ToString());
                var timestamp = DateTime.Now;
                var objUser = ItemModel.Get<User>(x => x.strEmail == email);
                var objStorage_tuid = ItemModel.Get<Storage>(x => x.objCommodity.uidTuid == objCommodity_tuid.uidTuid);
                if (doesExist != null)
                {
                    Storage storage = ItemModel.Get<Storage>(x => x.objCommodity.uidTuid == doesExist.objCommodities.uidTuid);
                    storage.intQuantity = storage.intQuantity + 1;
                    ItemModel.Update<Storage>(storage);
                    lstStudentChkIn.SelectedIndex = -1;
                    cmbChkInCommodity.SelectedIndex = -1;

                    Log log = new Log()
                    {
                        enuAction = ItemAction.CheckedIn,
                        dtTimestamp = timestamp,
                        strNotes = objUser.strFirst_name + " " + objUser.strLast_name + " has returned " + objSelectedItem,
                        intQuantityChange = +1,
                        objStorage = objStorage_tuid,
                        objUser = objUser
                    };

                    ItemModel.Add<Log>(log);
                    MessageBox.Show(doesExist.objCommodities.strName + " has been successfully checked back in!", "Alert");
                    ItemModel.Delete<CheckedItem>(doesExist);
                    tbcCheckInOut_SelectedIndexChanged(null, null);
                    cmbChkInStudent_SelectedIndexChanged(sender, e);
                    txtStudentChkIn.Text = "";
                }
                else
                {
                    MessageBox.Show("Item does not appear to be checked out by this user.", "Alert");
                }
            }
        }

        /* Function: cmbChkInStudent_SelectedIndexChanged
         * Description: When a student is selected in the CheckIn page, the students email is used to pull
         * which items were checked out by that user. 
         * 
         * Local Variables
         * Object sender; Object that calls this method, in this case cmbChkInStudent.
         * EventArgs e; Arguments provided by the sender object.
         * String email; Email of the user selected.
         */
        private void cmbChkInStudent_SelectedIndexChanged( object sender, EventArgs e )
        {
            cmbChkInCommodity.Enabled = false;
            if (lstStudentChkIn.SelectedIndex >= 0)
            {
                var email = lstStudentChkIn.Text.Split(' ').Last();
                cmbChkInCommodity.DataSource = ItemModel.GetMany<CheckedItem>(x => x.objUser.strEmail == email).Select(x => x.objCommodities.strName).ToList();
                cmbChkInCommodity.Enabled = true;
            }
        }

        /* Function: btnChkInCancel_Click
         * Description: Cancels any filled out fields in the form and sets them back to their default state.
         * 
         * Local Variables
         * Object sender; Object that calls this method, in this case btnChkInCancel.
         * EventArgs e; Arguments provided by the sender object.
         */
        private void btnChkInCancel_Click( object sender, EventArgs e )
        {
            cmbChkInCommodity.SelectedIndex = -1;
            lstStudentChkIn.SelectedIndex = -1;
            txtStudentChkIn.Text = "";
        }
    }
}
