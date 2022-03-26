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
            if (cmbAddCommodity.SelectedIndex > -1)
            {
                this.cmbAddCabinet.DataSource = (this.cmbAddRoom.SelectedValue as Room).lstCabinets.OrderBy(x => x.strName).ToList();
                txtCurrentQty_DependancyUpdated();
            }

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
            if (cmbAddCommodity.SelectedIndex > -1)
            {
                // set room, cabinet, and nlevel to ref of selected commodity
                this.cmbAddRoom.DataSource = ItemModel.GetMany<Room>().OrderBy(x => x.strName).ToList();
                this.cmbAddCabinet.DataSource = (this.cmbAddRoom.SelectedValue as Room).lstCabinets.OrderBy(x => x.strName).ToList();
                this.cmbAddNLevel.DataSource = ItemModel.GetMany<NLevel>().OrderBy(x => x.strName).ToList();
                // set quantity to quantity of selected commodity 
                this.nudAddQty.Value = 1;
                txtCurrentQty_DependancyUpdated();
            }
            else
            {
                this.cmbAddRoom.DataSource = null;
                this.cmbAddCabinet.DataSource = null;
                this.cmbAddNLevel.DataSource = null;

            }
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

            if (cmbAddCategory.SelectedIndex > -1)
            {
                this.cmbAddCommodity.DataSource = (this.cmbAddCategory.SelectedValue as Category).lstCommodities;
            }
            this.cmbAddCommodity.SelectedIndex = -1;
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
            cmbAddCategory.SelectedIndex = -1;
            cmbAddCommodity.SelectedIndex = -1;
            txtCurrentQty.Text = "0";
            nudAddQty.Value = 1;
            if (cmbAddCategory.SelectedIndex == -1)
            {
                cmbAddCommodity.DataSource = null;
                cmbAddCabinet.DataSource = null;
                cmbAddRoom.DataSource = null;
                cmbAddNLevel.DataSource = null;
            }
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
            if (cmbAddCabinet.SelectedIndex != -1 && cmbAddNLevel.SelectedIndex != -1 && cmbAddCommodity.SelectedIndex != -1)
            {
                var storageItem = ItemModel.Get<Storage>(
                        x => x.objNLevel == this.cmbAddNLevel.SelectedValue as NLevel
                        && x.objCabinet == this.cmbAddCabinet.SelectedValue as Cabinet
                        && x.objCommodity == this.cmbAddCommodity.SelectedValue as Commodity);
                if (storageItem == null)
                {
                    ItemModel.Add(new Storage()
                    {
                        objCabinet = cmbAddCabinet.SelectedItem as Cabinet,
                        objCommodity = cmbAddCommodity.SelectedItem as Commodity,
                        objNLevel = cmbAddNLevel.SelectedItem as NLevel
                    },
                    out storageItem
                    );
                }
                // User info has to be passed, either globally or locally
                try
                {
                    ItemModel.RestockItem(
                        storageItem,
                        Authentication.ActiveUser,
                        (uint)this.nudAddQty.Value,
                        "Stock Added"
                    );

                    // notify User of success
                    MessageBox.Show("Successfully added a quantity of " + nudAddQty.Value + " " + cmbAddCommodity.Text + " in room " + cmbAddRoom.Text + ", " + cmbAddCabinet.Text + ".");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                // notify User of failure
                MessageBox.Show("Please make sure all fields are properly filled in.");
            }

            // clear fields
            btnAddCancel_Click(sender, e);
        }
    }
}
