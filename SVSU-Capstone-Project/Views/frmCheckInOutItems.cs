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

        //private void txtQuantity_Display( object sender = null, EventArgs e = null )
        //{
        //    var quantity = ItemModel.Get<Storage>(
        //       x => x.objCabinet == this.objSelectedCabinet
        //       && x.objCommodity == this.objSelectedCommodity
        //       );
        //    this.txtCurrentQty.Text = quantity != null ? quantity.intQuantity.ToString() : "0";
        //}

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

        private void tbcCheckInOut_SelectedIndexChanged(object sender,EventArgs e)
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
                    lstCheckedIn.DataSource = ItemModel.GetMany<Commodity>(x => x.objCategory.strName == "Asset").OrderBy(x => x.strName).ToList();
                    break;
                case "tbpConsumables":
                    //populate category dropdown
                    cmbCategory.DataSource = ItemModel.GetMany<Category>(x => x.strName == "Consumable").OrderBy(x => x.strName).ToList();
                    cmbCommodity.DataSource = (cmbCategory.SelectedValue as Category).lstCommodities;
                    break;
            }
        }

        private void cmbCommodity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var objSelectedCommodity = cmbCommodity.SelectedValue as Commodity;
            cmbRoom.DataSource = objSelectedCommodity.lstStorage.Select(x => x.objCabinet.objRoom).Distinct().OrderBy(x => x.strName).ToList();
        }

        private void cmbRoom_SelectedIndexChanged( object sender, EventArgs e )
        {
            var objSelectedRoom = cmbRoom.SelectedValue as Room;
            var objSelectedCommodity = cmbCommodity.SelectedValue as Commodity;
            cmbCabinet.DataSource = objSelectedCommodity.lstStorage
            .Where(x => x.objCabinet.objRoom.uidTuid == objSelectedRoom.uidTuid)
            .Select(x => x.objCabinet).Distinct()
            .OrderBy(x => x.strName).ToList();
        }

        private void cmbCabinet_SelectedIndexChanged(object sender, EventArgs e)
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
            cmbCategory.SelectedIndex = -0;
            cmbCommodity.SelectedIndex = -0;
            txtConsumableSvsuID.Text = "";
            txtConsumableNotes.Text = "";
        }

        private void frmCheckInOutItems_Load( object sender, EventArgs e )
        {

        }
    }
}
