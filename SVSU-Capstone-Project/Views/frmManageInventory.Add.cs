using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVSU_Capstone_Project.Model;
using SVSU_Capstone_Project.ViewModel;

namespace SVSU_Capstone_Project.Views
{
    public partial class frmManageInventory : Form
    {
        /* Function: txtCurrentQty_DependancyUpdated
         * Description: Updates the stored quantity of a selected commodity at a selected location with a given quantity.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * ItemModel test; Tests the new quantity as an item model within the database.
         */
        private void txtCurrentQty_DependancyUpdated( object sender = null, EventArgs e = null )
        {
            // update stored quantity
            var test = ItemModel.Get<Storage>(
                x => x.objNLevel == this.cmbAddNLevel.SelectedValue as NLevel
                && x.objCabinet == this.cmbAddCabinet.SelectedValue as Cabinet
                && x.objCommodity == this.cmbAddCommodity.SelectedValue as Commodity);
            this.txtCurrentQty.Text = test != null ? test.intQuantity.ToString() : "0";
        }

        /* Function: cmbAddRoom_SelectedValueChanged
         * Description: Reflects the datasource for the room information when a room is selected on the form.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void cmbAddRoom_SelectedValueChanged( object sender, EventArgs e )
        {
            this.cmbAddCabinet.DataSource = (this.cmbAddRoom.SelectedValue as Room).lstCabinets.OrderBy(x => x.strName).ToList();
            txtCurrentQty_DependancyUpdated();
        }

        /* Function: cmbAddCommodity_SelectedValueChanged
         * Description: Reflects the datasource for the commodity when one is selected, including its room and quantity information.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void cmbAddCommodity_SelectedValueChanged( object sender, EventArgs e )
        {
            // set room, cabinet, and nlevel to ref of selected commodity
            this.cmbAddRoom.DataSource = ItemModel.GetMany<Room>().OrderBy(x => x.strName).ToList();
            this.cmbAddCabinet.DataSource = (this.cmbAddRoom.SelectedValue as Room).lstCabinets.OrderBy(x => x.strName).ToList();
            this.cmbAddNLevel.DataSource = ItemModel.GetMany<NLevel>().OrderBy(x => x.strName).ToList();
            // set quantity to quantity of selected commodity 
            this.nudAddQty.Value = 1;
            txtCurrentQty_DependancyUpdated();
        }

        /* Function: cmbAddCategory_SelectedValueChanged
         * Description: Reflects the datasource for the category when one is selected.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void cmbAddCategory_SelectedValueChanged( object sender, EventArgs e )
        {
            this.cmbAddCommodity.SelectedIndex = -1;
            this.cmbAddCommodity.DataSource = (this.cmbAddCategory.SelectedValue as Category).lstCommodities;
        }

        /* Function: btnAddCancel_Click
         * Description: Clears all fields when the cancel button is clicked.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void btnAddCancel_Click( object sender, EventArgs e )
        {
            //Clear all fields on Add tab
            cmbAddCategory.SelectedIndex = 0;
            txtCurrentQty.Text = "";
            nudAddQty.Value = 1;
        }

        /* Function: btnAdd_Click
         * Description: Sends the quantity changes to the database for the selected commodity at the selected room, cabinet, and NLevel.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void btnAdd_Click( object sender, EventArgs e )
        {
            if (cmbAddCabinet.SelectedIndex != -1 && cmbAddNLevel.SelectedIndex != -1)
            {
                // User info has to be passed, either globally or locally
                ItemModel.RestockItem(
                    ItemModel.Get<Storage>(
                        x => x.objNLevel == this.cmbAddNLevel.SelectedValue as NLevel
                        && x.objCabinet == this.cmbAddCabinet.SelectedValue as Cabinet
                        && x.objCommodity == this.cmbAddCommodity.SelectedValue as Commodity),
                    Authentication.ActiveUser,
                    (uint)this.nudAddQty.Value,
                    "Stock Added"
                );
            }
        }
    }
}
