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

        public frmCheckInOutItems(CheckedItem checkedItem) : this()
        {
            setScannedBarcode(checkedItem);
        }

        private void ListBoxClicked( object sender, EventArgs e )
        {
            /* Function: ListBoxClicked
              * -----------------------------------------------------------------------------
              * Description: This function is used to set wehter an object is checked in or out
              * and will set the statue accordingly. If it is checked in, the checked out button 
              * will appear to allow user to check it out. If the item is checked out, the 
              * checked in button will appear to allow user to check it in.
              * -----------------------------------------------------------------------------
              *  Parameter Dictionary (in parameter order):  
              *  EventArgs e; Information passed by the sender object about the method call.
              *  object sender; The object calling the method.
              * -----------------------------------------------------------------------------
              * Local Variables
              */

            // if the item is checked in allow user to check out the item by check out btn
            if ((sender as ListBox).Name.ToString() == "lstIn")
            {
                btnCheckIn.Enabled = false;
                btnCheckOut.Enabled = true;
            }
            // if the item is checked out allow user to check in the item by check in btn
            else if ((sender as ListBox).Name.ToString() == "lstOut")
            {
                btnCheckIn.Enabled = true;
                btnCheckOut.Enabled = false;
            }
        }

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
                case "tbpAssets":
                    //populate checked in assets listbox
                    lstCheckedOut.DataSource = ItemModel.GetMany<CheckedItem>().Where(x => ((int)x.objLog.enuAction) == 4).Select(x => x.objLog.objStorage.objCommodity.strName).ToList();

                    lstCheckedIn.DataSource = ItemModel.GetMany<Commodity>(x => x.objCategory.strName == "Asset").OrderBy(x => x.strName).ToList();
                    cmbAssetsStudents.DataSource = ItemModel.GetMany<User>().OrderBy(x => x.strLast_name).ToList();
                    //lstCheckedOut.DataSource = ItemModel.GetMany<CheckedItem>().Where(x => ((int)x.objLog.enuAction) == 4).OrderBy(x => x.objCommodities.strName).ToList();
                    break;
                case "tbpConsumables":
                    //populate category dropdown
                    cmbCategory.DataSource = ItemModel.GetMany<Category>(x => x.strName == "Consumable").OrderBy(x => x.strName).ToList();
                    cmbCommodity.DataSource = (cmbCategory.SelectedValue as Category).lstCommodities;
                    cmbStudents.DataSource = ItemModel.GetMany<User>().OrderBy(x => x.strLast_name).ToList();
                    cmbCommodity.SelectedIndex = 0;
                    cmbStudents.SelectedIndex = -1;
                    break;

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
                    //cmbChkInStudent.DataSource = ItemModel.GetMany<User>().Where(x => x.uidTuid == checkedItems)
                   cmbChkInStudent.DataSource = ItemModel.GetMany<CheckedItem>().Where(x => ((int)x.objLog.enuAction) == 4).Select(x => x.objUser.strEmail).Distinct().ToList();
                    cmbChkInStudent.SelectedIndex = -1;
                    cmbChkInCommodity.SelectedIndex = -1;
                    break;
            }
        }

        private void cmbCommodity_SelectedIndexChanged( object sender, EventArgs e )
        {
            /* Function: cmbCommodity_SelectedIndexChanged
             * -----------------------------------------------------------------------------
             * Description: This fucntion will populate the data within the consumables
             * table depending on the commodity index slected. All fields below it will be populated 
             * and sorted by name
             * -----------------------------------------------------------------------------
             *  Parameter Dictionary (in parameter order):  
             *  EventArgs e; Information passed by the sender object about the method call.
             *  object sender; The object calling the method.
             * -----------------------------------------------------------------------------
             * Local Variables
             * objSelectedCommodity; used to store the selected value of the commodity
             */
            // stores the selected index stored in the commodity combo box
            var objSelectedCommodity = cmbCommodity.SelectedValue as Commodity;
            // set the data fields in order by name
            cmbRoom.DataSource = objSelectedCommodity.lstStorage.Select(x => x.objCabinet.objRoom).Distinct().OrderBy(x => x.strName).ToList();

        }

        private void cmbRoom_SelectedIndexChanged( object sender, EventArgs e )
        {
            /* Function: cmbRoom_SelectedIndexChanged
           * -----------------------------------------------------------------------------
           * Description: This fucntion will populate the data within the consumables
           * table depending on the room index selected. All fields below it will be populated 
           * and sorted by name
           * -----------------------------------------------------------------------------
           *  Parameter Dictionary (in parameter order):  
           *  EventArgs e; Information passed by the sender object about the method call.
           *  object sender; The object calling the method. 
           * -----------------------------------------------------------------------------
           * Local Variables
           * objSelectedRoom; used to store the selected value or the room 
           */

            // stores the seleceted room object
            var objSelectedRoom = cmbRoom.SelectedValue as Room;
            var objSelectedCommodity = cmbCommodity.SelectedValue as Commodity;
            cmbCabinet.DataSource = objSelectedCommodity.lstStorage
            .Where(x => x.objCabinet.objRoom.uidTuid == objSelectedRoom.uidTuid)
            .Select(x => x.objCabinet).Distinct()
            .OrderBy(x => x.strName).ToList();
        }

        private void cmbCabinet_SelectedIndexChanged( object sender, EventArgs e )
        {
            var objSelectedCommodity = cmbCommodity.SelectedValue as Commodity;
            var quantity = ItemModel.Get<Storage>(
                 x => x.objCabinet == (cmbCabinet.SelectedValue as Cabinet)
                 && x.objCommodity == (cmbCommodity.SelectedValue as Commodity)
               );


            this.txtCurrentQty.Text = quantity != null ? quantity.intQuantity.ToString() : "0";

            //Populate N-Level dropdown
            cmbNLevel.DataSource = objSelectedCommodity.lstStorage.Select(x => x.objNLevel.strName).Distinct().ToList();
        }

        private void btnCancel_Click( object sender, EventArgs e )
        {
            clearFields();
        }

        private void clearFields()
        {
            cmbCategory.SelectedIndex = 0;
            cmbCommodity.SelectedIndex = -1;
            txtConsumableNotes.Text = "";
            cmbStudents.SelectedIndex = 0;
            nudAddQty.Value = 1;
        }

        private void frmCheckInOutItems_Load( object sender, EventArgs e )
        {
            lstCheckedIn.SelectedIndex = -1;
            lstCheckedOut.SelectedIndex = -1;
        }

        private void btnHandOut_Click( object sender, EventArgs e )
        {
            var quantity = ItemModel.Get<Storage>(
                 x => x.objCabinet == (cmbCabinet.SelectedValue as Cabinet)
                 && x.objCommodity == (cmbCommodity.SelectedValue as Commodity)
               );

            if (cmbCommodity.SelectedIndex >= 0 && cmbRoom.SelectedIndex >= 0 && cmbCabinet.SelectedIndex >= 0 &&
                cmbNLevel.SelectedIndex >= 0 && cmbStudents.SelectedIndex >= 0 && nudAddQty.Value < quantity.intQuantity)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Are tou sure you want to check out " +
                        cmbCommodity.SelectedItem.ToString() + "?", "Confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        var objCommodity_Tuid = cmbCommodity.SelectedValue as Commodity;
                        var objStorage_Tuid = ItemModel.Get<Storage>(
                            x => x.objCommodity.uidTuid == objCommodity_Tuid.uidTuid
                                );


                        var objUser_Tuid = cmbStudents.SelectedValue as User;



                        Log log = new Log()
                        {
                            enuAction = ItemAction.CheckedOut,
                            dtTimestamp = DateTime.Now,
                            strNotes = txtConsumableNotes.Text,
                            intQuantityChange = (int)nudAddQty.Value * -1,
                            objStorage = objStorage_Tuid,
                            objUser = objUser_Tuid
                        };

                        ItemModel.Add<Log>(log);

                        var objLog_Tuid = ItemModel.Get<Log>(
                            x => x.objStorage.uidTuid == objStorage_Tuid.uidTuid);

                        CheckedItem checkedItem = new CheckedItem()
                        {
                            objCommodities = objCommodity_Tuid,
                            objLog = objLog_Tuid,
                            objUser = objUser_Tuid
                        };

                        ItemModel.Add<CheckedItem>(checkedItem);

                        Storage storage = ItemModel.Get<Storage>(x => x.uidTuid == objStorage_Tuid.uidTuid);

                        storage.intQuantity = storage.intQuantity + log.intQuantityChange;

                        ItemModel.Update<Storage>(storage);

                        MessageBox.Show("Item successfully handed out!", "Alert");
                        lstCheckedIn.SelectedIndex = -1;
                        lstCheckedOut.SelectedIndex = -1;
                        clearFields();
                        tbcCheckInOut_SelectedIndexChanged(null, null);
                        cmbCommodity_SelectedIndexChanged(sender, e);
                    }
                }
                catch
                {
                    MessageBox.Show("Please ensure that all fields are filled in!", "Alert");
                }
            }
        }

        //Can delete after checkout tab functions properly
        private void btnCheckOut_Click( object sender, EventArgs e )
        {
            var objCommodity_tuid = lstCheckedIn.SelectedValue as Commodity;
            var objStorage_tuid = ItemModel.Get<Storage>(x => x.objCommodity.uidTuid == objCommodity_tuid.uidTuid);
            var objUser_tuid = cmbAssetsStudents.SelectedValue as User;
            var timestamp = DateTime.Now;
            if (objStorage_tuid.intQuantity > 0)
            {
                Log log = new Log()
                {
                    enuAction = ItemAction.CheckedOut,
                    dtTimestamp = timestamp,
                    strNotes = txtAssetNotes.Text,
                    intQuantityChange = -1,
                    objStorage = objStorage_tuid,
                    objUser = objUser_tuid
                };

                ItemModel.Add<Log>(log);

                var objLog_Tuid = ItemModel.Get<Log>(
                    x => x.objStorage.uidTuid == objStorage_tuid.uidTuid && x.dtTimestamp == timestamp && x.objUser.uidTuid == objUser_tuid.uidTuid);

                CheckedItem checkedItem = new CheckedItem()
                {
                    objCommodities = objCommodity_tuid,
                    objLog = objLog_Tuid,
                    objUser = objUser_tuid
                };

                ItemModel.Add<CheckedItem>(checkedItem);

                Storage storage = ItemModel.Get<Storage>(x => x.uidTuid == objStorage_tuid.uidTuid);
                storage.intQuantity = storage.intQuantity - 1;
                ItemModel.Update<Storage>(storage);

                var checkedOut = ItemModel.Get<Log>(x => x.objStorage.uidTuid == objStorage_tuid.uidTuid);
                var item = ItemModel.Get<Storage>(x => x.uidTuid == checkedOut.objStorage.uidTuid);

                //lstCheckedOut.Items.Add(item.objCommodity.strName);
                
            }
        }
        //Can delete after checkout tab functions properly
        private void lstCheckedIn_SelectedIndexChanged( object sender, EventArgs e )
        {
            cmbAssetsStudents.Enabled = true;
            txtAssetNotes.Enabled = true;
            lstCheckedOut.SelectedIndex = -1;
        }
        //Can delete after checkout tab functions properly
        private void lstCheckedOut_SelectedIndexChanged( object sender, EventArgs e )
        {

            txtAssetNotes.Enabled = false;
            cmbAssetsStudents.Enabled = false;
            txtAssetNotes.Text = "";
            cmbAssetsStudents.SelectedIndex = -1;
            lstCheckedIn.SelectedIndex = -1;
        }
        //Can delete after checkout tab functions properly
        private void btnCheckIn_Click( object sender, EventArgs e )
        {
            //lstCheckedIn.SelectedIndex = -1;
            //lstCheckedOut.SelectedIndex = -1;

            var objselectedItem = ItemModel.Get<CheckedItem>(x => x.objCommodities.strName == lstCheckedOut.SelectedValue.ToString());
            var objLog = ItemModel.GetMany<Log>();


            //var checkedItem = ItemModel.GetMany<CheckedItem>().Where(x => x.objCommodities.strName == objselectedItem).ToList();
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

        private void btnChkOut_Click( object sender, EventArgs e )
        {
            var objSelectedCommodity = cmbChkOutCommodity.SelectedValue as Commodity;
            var quantity = ItemModel.Get<Storage>(
                x => x.objCommodity.uidTuid == objSelectedCommodity.uidTuid
                );
            if (numChkOutQuantity.Value > quantity.intQuantity)
            {
                MessageBox.Show("Please select a quantity that is below or equal to the number of available quantity!", "Alert");
            }
            else if(cmbChkOutStudent.SelectedIndex == -1 | cmbChkOutCommodity.SelectedIndex == -1)
            {
                MessageBox.Show("Please make sure all fields are properly filled in!", "Alert");
            }
            else
            {
                var objStorage_tuid = ItemModel.Get<Storage>(x => x.objCommodity.uidTuid == objSelectedCommodity.uidTuid);
                var objUser_tuid = cmbChkOutStudent.SelectedValue as User;
                var timestamp = DateTime.Now;
                if (objStorage_tuid.intQuantity > 0)
                {
                    Log log = new Log()
                    {
                        enuAction = ItemAction.CheckedOut,
                        dtTimestamp = timestamp,
                        strNotes = txtAssetNotes.Text,
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
                    numChkOutQuantity.Value = 1;
                    txtAvailableChkOutQuantity.Text = "";
                    MessageBox.Show(objSelectedCommodity.strName + " has been successful checked out for " + objUser_tuid.strFirst_name + " " + objUser_tuid.strLast_name);
                }
            }
        }

        private void btnChkOutCancel_Click( object sender, EventArgs e )
        {
            cmbChkOutCommodity.SelectedIndex = -1;
            cmbChkOutStudent.SelectedIndex = -1;
            txtChkOutNotes.Text = "";
            numChkOutQuantity.Value = 1;
            txtAvailableChkOutQuantity.Text = "";
        }

        public void setScannedBarcode(CheckedItem checkedItem)
        {
            if (lstCheckedIn.Items.Contains(checkedItem))
            {
                lstCheckedIn.SetSelected(lstCheckedIn.Items.IndexOf(checkedItem), true);
            }
            else
            {
                lstCheckedOut.SetSelected(lstCheckedOut.Items.IndexOf(checkedItem), true);
            }
        }

        private void btnChkIn_Click( object sender, EventArgs e )
        {

        }

        private void cmbChkInStudent_SelectedIndexChanged( object sender, EventArgs e )
        {
            cmbChkInCommodity.Enabled = false;
            if(cmbChkInStudent.SelectedIndex >= 0)
            {
                string objSelectedUser = cmbChkInStudent.Text;
                //cmbChkInCommodity.DataSource = ItemModel.GetMany<CheckedItem>().Where(x => x.objUser.strFirst_name + " " + x.objUser.strLast_name == objSelectedUser.ToString() && ((int)x.objLog.enuAction == 4)).Distinct().Select(x => x.objCommodities.strName).ToList();
                cmbChkInCommodity.DataSource = ItemModel.GetMany<CheckedItem>(x => x.objUser.strEmail == objSelectedUser);
                cmbChkInCommodity.Enabled = true;
            }
        }

        private void cmbChkInCommodity_SelectedIndexChanged( object sender, EventArgs e )
        {
            cmbChkInCommodity.DataSource = ItemModel.GetMany<CheckedItem>(x => x.objUser.strEmail == cmbChkInStudent.Text).SelectMany(x => x.objCommodities.strName).ToList();
            //cmbChkInCommodity.DataSource = ItemModel.GetMany<CheckedItem>(x => x.objUser.strEmail == cmbChkInStudent.Text).ToList();


            //var commodity = cmbChkInCommodity.SelectedValue as CheckedItem;
            //try
            //{
            //    CheckedItem checkedItem = ItemModel.Get<CheckedItem>(x => x.objCommodities.uidTuid == commodity.uidTuid);
            //    lblTesting.Text = checkedItem.uidTuid.ToString();
            //}
            //catch
            //{
            //    lblTesting.Text = "Null";
            //}

        }

        private void cmbChkInCategory_SelectedIndexChanged( object sender, EventArgs e )
        {

        }
    }
}
