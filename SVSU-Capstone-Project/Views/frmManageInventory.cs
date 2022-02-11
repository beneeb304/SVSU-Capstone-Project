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
        public frmManageInventory()
        {
            InitializeComponent();

            // Bind Events before datasource is set to prevent null reference exception
            this.cmbAddCategory.SelectedValueChanged += cmbAddCategory_SelectedValueChanged;
            this.cmbAddCommodity.SelectedValueChanged += cmbAddCommodity_SelectedValueChanged;
            this.cmbAddRoom.SelectedValueChanged += cmbAddRoom_SelectedValueChanged;
            this.cmbAddCabinet.SelectedValueChanged += updateStoredQuantity;
            this.cmbAddNLevel.SelectedValueChanged += updateStoredQuantity;

            this.cmbAddCategory.DataSource = ItemModel.GetMany<Category>().OrderBy(x => x.strName).ToList();
        }

        private void cmbAddRoom_SelectedValueChanged( object sender, EventArgs e )
        {
            this.cmbAddCabinet.DataSource = (this.cmbAddRoom.SelectedValue as Room).lstCabinets.OrderBy(x => x.strName).ToList();
            updateStoredQuantity();
        }

        private void cmbAddCommodity_SelectedValueChanged( object sender, EventArgs e )
        {
            // set room, cabinet, and nlevel to ref of selected commodity
            this.cmbAddRoom.DataSource = ItemModel.GetMany<Room>().OrderBy(x => x.strName).ToList();
            this.cmbAddCabinet.DataSource = (this.cmbAddRoom.SelectedValue as Room).lstCabinets.OrderBy(x => x.strName).ToList();
            this.cmbAddNLevel.DataSource = ItemModel.GetMany<NLevel>().OrderBy(x => x.strName).ToList();
            // set quantity to quantity of selected commodity 
            this.nudAddQty.Value = 1;
            updateStoredQuantity();
        }

        private void updateStoredQuantity( object sender = null, EventArgs e = null )
        {
            // update stored quantity
            var test = ItemModel.Get<Storage>(
                x => x.objNLevel == this.cmbAddNLevel.SelectedValue as NLevel
                && x.objCabinet == this.cmbAddCabinet.SelectedValue as Cabinet
                && x.objCommodity == this.cmbAddCommodity.SelectedValue as Commodity);
            this.txtCurrentQty.Text = test != null ? test.intQuantity.ToString() : "0";
        }

        private void cmbAddCategory_SelectedValueChanged( object sender, EventArgs e )
        {
            this.cmbAddCommodity.SelectedIndex = -1;
            this.cmbAddCommodity.DataSource = (this.cmbAddCategory.SelectedValue as Category).lstCommodities;
        }

        private void btnAddCancel_Click( object sender, EventArgs e )
        {
            //Clear all fields on Add tab
            cmbAddCabinet.SelectedIndex = -1;
            cmbAddCategory.SelectedIndex = -1;
            cmbAddCommodity.SelectedIndex = -1;
            cmbAddNLevel.SelectedIndex = -1;
            cmbAddRoom.SelectedIndex = -1;
            txtCurrentQty.Text = "";
            nudAddQty.Value = 1;
        }

        private void btnCreateCancel_Click( object sender, EventArgs e )
        {
            //Clear all fields on Create tab
            cmbCreateCategory.SelectedIndex = -1;
            cmbCreateVendor.SelectedIndex = -1;
            txtCreateDescription.Text = "";
            txtCreateFeatures.Text = "";
            txtCreateItemName.Text = "";
            txtCreateUrl.Text = "";
            txtCurrentQty.Text = "";
            nudCreateAlertQty.Value = 0;
            mtxCreateCost.Text = "";
        }

        private void btnDeleteCancel_Click( object sender, EventArgs e )
        {
            //Clear all fields on Delete tab
            cmbDeleteCabinet.SelectedIndex = -1;
            cmbDeleteCategory.SelectedIndex = -1;
            cmbDeleteCommodity.SelectedIndex = -1;
            cmbDeleteNLevel.SelectedIndex = -1;
            cmbDeleteRoom.SelectedIndex = -1;
        }

        private void chkDelete_CheckedChanged( object sender, EventArgs e )
        {
            if (chkDelete.Checked)
            {
                cmbDeleteCabinet.SelectedIndex = -1;
                cmbDeleteNLevel.SelectedIndex = -1;
                cmbDeleteRoom.SelectedIndex = -1;
                cmbDeleteCabinet.Enabled = false;
                cmbDeleteNLevel.Enabled = false;
                cmbDeleteRoom.Enabled = false;
                lblDelete.Text = "Deleting this commodity will delete it from all rooms, cabinets, and NLevels. It's quantity MUST be zero before deleting.";
            }
            else
            {
                cmbDeleteCabinet.Enabled = true;
                cmbDeleteNLevel.Enabled = true;
                cmbDeleteRoom.Enabled = true;
                lblDelete.Text = "Deleting this commodity will delete it from the selected Room, Cabinet, Nurse Level.";
            }
        }

        private void txtCreateItemName_TextChanged( object sender, EventArgs e )
        {

        }
    }
}
