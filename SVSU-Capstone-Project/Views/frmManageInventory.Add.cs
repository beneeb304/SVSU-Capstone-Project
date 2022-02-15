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
        private void txtCurrentQty_DependancyUpdated( object sender = null, EventArgs e = null )
        {
            // update stored quantity
            var test = ItemModel.Get<Storage>(
                x => x.objNLevel == this.cmbAddNLevel.SelectedValue as NLevel
                && x.objCabinet == this.cmbAddCabinet.SelectedValue as Cabinet
                && x.objCommodity == this.cmbAddCommodity.SelectedValue as Commodity);
            this.txtCurrentQty.Text = test != null ? test.intQuantity.ToString() : "0";
        }
        private void cmbAddRoom_SelectedValueChanged( object sender, EventArgs e )
        {
            this.cmbAddCabinet.DataSource = (this.cmbAddRoom.SelectedValue as Room).lstCabinets.OrderBy(x => x.strName).ToList();
            txtCurrentQty_DependancyUpdated();
        }
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
        private void cmbAddCategory_SelectedValueChanged( object sender, EventArgs e )
        {
            this.cmbAddCommodity.SelectedIndex = -1;
            this.cmbAddCommodity.DataSource = (this.cmbAddCategory.SelectedValue as Category).lstCommodities;
        }
        private void btnAddCancel_Click( object sender, EventArgs e )
        {
            //Clear all fields on Add tab
            cmbAddCategory.SelectedIndex = 0;
            txtCurrentQty.Text = "";
            nudAddQty.Value = 1;
        }
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
