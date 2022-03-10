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

        //public frmCheckInOutItems(CheckedItem checkedItem) : this()
        //{
        //    setScannedBarcode(checkedItem);
        //}


        private void tbcCheckInOut_SelectedIndexChanged( object sender, EventArgs e )
        {
            /* Function: tbcCheckInOut_SelectedIndexChanged
            * -----------------------------------------------------------------------------
            * Description: This ucntion will populate either the assets tab with data or the 
            * Consumable tab with data depending on which tab is clicked. 
            * -----------------------------------------------------------------------------
            *  Parameter Dictionary (in parameter order):  
            *  EventArgs e; Information passed by the sender object about the method call.
            *  object sender; The object calling the method. 
            * -----------------------------------------------------------------------------
            * Local Variables
            */

            switch (tbcCheckInOut.SelectedTab.Name)
            {
                case "tbpCheckOut":
                    cmbChkOutCategory.DataSource = ItemModel.GetMany<Category>(x => x.strName == "Asset").OrderBy(x => x.strName).ToList();
                    cmbChkOutCommodity.DataSource = (cmbChkOutCategory.SelectedValue as Category).lstCommodities;
                    cmbChkOutStudent.DataSource = ItemModel.GetMany<User>().OrderBy(x => x.strLast_name).ToList();
                    txtAvailableChkOutQuantity.Text = "";
                    cmbChkOutCommodity.SelectedIndex = -1;
                    cmbChkOutStudent.SelectedIndex = -1;
                    break;

                case "tbpCheckIn":
                    var checkedItems = ItemModel.GetMany<CheckedItem>().Where(x => (int)x.objLog.enuAction == 4).ToList();
                    cmbChkInCategory.DataSource = ItemModel.GetMany<Category>(x => x.strName == "Asset").OrderBy(x => x.strName).ToList();
                    cmbChkInStudent.DataSource = ItemModel.GetMany<CheckedItem>().Where(x => ((int)x.objLog.enuAction) == 4).Select(x => x.objUser.strEmail).Distinct().ToList();
                    cmbChkInStudent.SelectedIndex = -1;
                    cmbChkInCommodity.SelectedIndex = -1;
                    break;
            }
        }

             private void frmCheckInOutItems_Load( object sender, EventArgs e )
        {

        }
 
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

        //private void cmbChkOutStudent_SelectedIndexChanged( object sender, EventArgs e )
        //{
        //    if(cmbChkOutStudent.SelectedIndex >= 0)
        //    {
        //        var objSelectedCommodity = cmbChkOutCommodity.SelectedValue as Commodity;
        //    }
        //}

        private void btnChkOut_Click( object sender, EventArgs e )
        {

            if (cmbChkOutStudent.SelectedIndex == -1 | cmbChkOutCommodity.SelectedIndex == -1)
            {
                MessageBox.Show("Please make sure all fields are properly filled in!", "Alert");
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
                    var objUser_tuid = cmbChkOutStudent.SelectedValue as User;
                    var timestamp = DateTime.Now;
                    var doesExist = ItemModel.GetMany<CheckedItem>().Where(x => x.objUser.uidTuid == objUser_tuid.uidTuid && x.objCommodities.strName == objSelectedCommodity.strName).ToList();
                    if (doesExist.Count != 0)
                    {
                        MessageBox.Show(objUser_tuid.strFirst_name + " " + objUser_tuid.strLast_name + " already has this item checked out! Please return the item, select a different item, or select a different user to continue checking out an item", "Alert");
                    }
                    else if (objStorage_tuid.intQuantity > 0)
                    {
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

                        var objLog_Tuid = ItemModel.Get<Log>(
                            x => x.objStorage.uidTuid == objStorage_tuid.uidTuid && x.dtTimestamp == timestamp && x.objUser.uidTuid == objUser_tuid.uidTuid);

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

                        tbcCheckInOut_SelectedIndexChanged(null, null);
                        cmbChkOutCommodity_SelectedIndexChanged(sender, e);
                        cmbChkOutCommodity.SelectedIndex = -1;
                        cmbChkOutStudent.SelectedIndex = -1;
                        txtChkOutNotes.Text = "";
                        txtAvailableChkOutQuantity.Text = "";
                        MessageBox.Show(objSelectedCommodity.strName + " has been successful checked out for " + objUser_tuid.strFirst_name + " " + objUser_tuid.strLast_name);
                    }
                }
            }
        }

        private void btnChkOutCancel_Click( object sender, EventArgs e )
        {
            cmbChkOutCommodity.SelectedIndex = -1;
            cmbChkOutStudent.SelectedIndex = -1;
            txtChkOutNotes.Text = "";
            txtAvailableChkOutQuantity.Text = "";
        }

        //public void setScannedBarcode(CheckedItem checkedItem)
        //{
        //    if (lstCheckedIn.Items.Contains(checkedItem))
        //    {
        //        lstCheckedIn.SetSelected(lstCheckedIn.Items.IndexOf(checkedItem), true);
        //    }
        //    else
        //    {
        //        lstCheckedOut.SetSelected(lstCheckedOut.Items.IndexOf(checkedItem), true);
        //    }
        //}

        private void btnChkIn_Click( object sender, EventArgs e )
        {
            if(cmbChkInStudent.SelectedIndex == -1 || cmbChkInCommodity.SelectedIndex == -1)
            {
                MessageBox.Show("Please select make sure a student and commodity is selected to check back in!", "Alert");
            }
            else
            {
                var objSelectedStudent = cmbChkInStudent.Text;
                var objSelectedItem = cmbChkInCommodity.SelectedItem;
                var objCommodity_tuid = ItemModel.Get<Commodity>(x => x.strName == objSelectedItem);
                var doesExist = ItemModel.Get<CheckedItem>(x => x.objUser.strEmail == objSelectedStudent && x.objCommodities.strName == objSelectedItem.ToString());
                var timestamp = DateTime.Now;
                var objUser = ItemModel.Get<User>(x => x.strEmail == objSelectedStudent);
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

        private void cmbChkInStudent_SelectedIndexChanged( object sender, EventArgs e )
        {
            cmbChkInCommodity.Enabled = false;
            if(cmbChkInStudent.SelectedIndex >= 0)
            {
                string objSelectedUser = cmbChkInStudent.Text;
                cmbChkInCommodity.DataSource = ItemModel.GetMany<CheckedItem>(x => x.objUser.strEmail == objSelectedUser).Select(x => x.objCommodities.strName).ToList();
                cmbChkInCommodity.Enabled = true;
            }
        }

        private void btnChkInCancel_Click( object sender, EventArgs e )
        {
            cmbChkInStudent.SelectedIndex = -1;
            cmbChkInCommodity.SelectedIndex = -1;
        }
    }
}
