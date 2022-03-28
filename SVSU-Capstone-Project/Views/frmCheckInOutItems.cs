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
            // Checks if the form was called after a barcode scan to transfer the data.
            if (frmMain.barcodeScanner.isStartRead())
            {
                setScannedBarcode(frmMain.barcodeScanner.checkedItem);
            }
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
                    cmbChkOutCommodity.DataSource = ItemModel.GetMany<Commodity>(x => x.enuCommodityType == ItemType.Equipment && x.lstStorage.Count != 0).OrderBy(x => x.strName).ToList();
                    cmbChkOutStudent.DataSource = ItemModel.GetMany<User>().Where(x => x.blnIsAdmin == false).OrderBy(x => x.strLast_name).Select(x => x.strLast_name + ", " + x.strFirst_name + " - " + x.strEmail).ToList();
                    txtAvailableChkOutQuantity.Text = "";
                    cmbChkOutCommodity.SelectedIndex = -1;
                    cmbChkOutStudent.SelectedIndex = -1;
                    break;

                case "tbpCheckIn":
                    var checkedItems = ItemModel.GetMany<CheckedItem>().Where(x => x.objLog.enuAction == ItemAction.CheckedOut).ToList();
                    cmbChkInStudent.DataSource = ItemModel.GetMany<CheckedItem>().Where(x => (x.objLog.enuAction) == ItemAction.CheckedOut).OrderBy(x => x.objUser.strLast_name).Select(x => x.objUser.strLast_name + ", " + x.objUser.strFirst_name + " - " + x.objUser.strEmail).Distinct().ToList();
                    cmbChkInStudent.SelectedIndex = -1;
                    cmbChkInCommodity.SelectedIndex = -1;
                    break;
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
            if (cmbChkOutStudent.SelectedIndex == -1 | cmbChkOutCommodity.SelectedIndex == -1)
            {
                MessageBox.Show("Please make sure all fields are properly filled out!", "Alert");
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
                    var email = cmbChkOutStudent.Text.Split(' ').Last();
                    var objUser_tuid = ItemModel.Get<User>(x => x.strEmail == email);
                    var doesExist = ItemModel.GetMany<CheckedItem>().Where(x => x.objUser.uidTuid == objUser_tuid.uidTuid && x.objCommodities.strName == objSelectedCommodity.strName).ToList();
                    if (doesExist.Count != 0)
                    {
                        MessageBox.Show(objUser_tuid.strFirst_name + " " + objUser_tuid.strLast_name + " already has this item checked out! Please return the item, select a different item, or select a different user to continue checking out an item", "Alert");
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
                            MessageBox.Show(objUser_tuid.strFirst_name + " " + objUser_tuid.strLast_name + " has successfully checked out " + objSelectedCommodity.strName);
                            tbcCheckInOut_SelectedIndexChanged(null, null);
                            cmbChkOutCommodity_SelectedIndexChanged(sender, e);
                            btnChkOutCancel_Click(sender, e);
                        }
                    }
                }
            }
        }

        /* Function: setScannedBarcode
         * Description: When this form is called as the result of a barcode scan, take in the CheckedItem, check if it is in the checked in or 
         * checked out items, then select it in the corresponding list. Reset the values of the barcode scanner in frmMain to complete the scan.
         * 
         * Local Variables
         * CheckedItem checkedItem; The object found as a result of the barcode scan.
         */
        public void setScannedBarcode( CheckedItem checkedItem )
        {
            if (cmbChkOutCommodity.Items.Contains(checkedItem.objCommodities))
            {
                cmbChkOutCommodity.SelectedItem = checkedItem.objCommodities;
            }
            else if (cmbChkInCommodity.Items.Contains(checkedItem.objCommodities))
            {
                cmbChkInCommodity.SelectedItem = checkedItem.objCommodities;
            }
            frmMain.barcodeScanner.resetValues();
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
            cmbChkOutStudent.SelectedIndex = -1;
            txtChkOutNotes.Text = "";
            txtAvailableChkOutQuantity.Text = "";
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
            if (cmbChkInStudent.SelectedIndex == -1 || cmbChkInCommodity.SelectedIndex == -1)
            {
                MessageBox.Show("Please select make sure a student and commodity is selected to check back in!", "Alert");
            }
            else
            {
                var email = cmbChkInStudent.Text.Split(' ').Last();
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
                    cmbChkInStudent.SelectedIndex = -1;
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
                }
                else
                {
                    MessageBox.Show("Item does not appear to be checked out by this user", "Alert");
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
            if (cmbChkInStudent.SelectedIndex >= 0)
            {
                var email = cmbChkInStudent.Text.Split(' ').Last();
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
            cmbChkInStudent.SelectedIndex = -1;
            cmbChkInCommodity.SelectedIndex = -1;
        }
    }
}
