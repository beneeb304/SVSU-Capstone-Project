using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            //this.Load += frmManageInventory_Load;
            // codefirst example
            // this.cmbAddCategory.DataBindings.Add("Items", this, "activeCategories", false, DataSourceUpdateMode.OnPropertyChanged);
            // this.cmbAddCategory.SelectedValueChanged += (e,v) => {itemFeatures = v.toString();};
        }

        // //Data Binding Example || ReadOnly
        // public Category[] activeCategories
        // {
        //     get
        //     {
        //         return ItemModel.GetMany<Category>((c) => c.blnActive == true).ToArray();
        //     }
        // }
        //
        // // Data Binding Example || ReadWrite
        // public string itemFeatures
        // {
        //     get
        //     {
        //         return ItemModel.Get<Commodity>(i => i.strName == "Selected Item").strFeatures;
        //     }
        //     set
        //     {
        //         // set value
        //         var x = ItemModel.Get<Commodity>(i => i.strName == "Selected Item");
        //         x.strFeatures = value;
        //         ItemModel.Update<Commodity>(x);
        //     }
        // }

        //private void frmManageInventory_Load( object sender, EventArgs e )
        //{
        //    this.cmbAddCategory.Items.AddRange(ItemModel.GetMany<Category>(( c ) => true).Select(c => c.strName).ToArray());
        //    this.cmbAddCategory.SelectedIndex = 0;
        //    var x = ItemModel.GetMany<Commodity>((c) => c.objCategory.strName == "Probe").ToList();
        //    this.cmbAddCabinet.Items.AddRange(ItemModel.GetMany<Cabinet>(( c ) => c.objRoom.strName == "abc").Select(c => c.strName).ToArray());
        //    this.cmbAddCabinet.SelectedIndex = 0;
        //    this.cmbAddCommodity.Items.AddRange(ItemModel.GetMany<Commodity>(( c ) => c.objCategory.strName == this.cmbAddCategory.SelectedText).Select(c => c.strName).ToArray());
        //    var q = new List<string>() { "abc", "def" };
        //}
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
