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
    public partial class frmViewInventory : Form
    {
        //List for dgv
        List<Commodity> lstCommodities;
        
        public frmViewInventory()
        {
            /* Function: frmLogin
            * -----------------------------------------------------------------------------
            * Description: Initializes the form when called upon.
            * -----------------------------------------------------------------------------
            */
            InitializeComponent();
        }

        private void frmViewInventory_Load(object sender, EventArgs e)
        {
            /* Function: frmViewInventory_Load
        * -----------------------------------------------------------------------------
        * Description: This function is called whenever the view inventory form is loaded
        * -----------------------------------------------------------------------------
        *  Parameter Dictionary (in parameter order):  
        *  EventArgs e; Information passed by the sender object about the method call.
        * object sender; The object calling the method. btnLogin in this case.
        * -----------------------------------------------------------------------------
        * Local Variables
        * 
        */

            //Set datasource for each combobox
            cmbCategory.DataSource = ItemModel.GetMany<Category>().OrderBy(x => x.strName).ToList();
            cmbNLevel.DataSource = ItemModel.GetMany<NLevel>().OrderBy(x => x.strName).ToList();
            cmbRoom.DataSource = ItemModel.GetMany<Room>().OrderBy(x => x.strName).ToList();
            cmbVendor.DataSource = ItemModel.GetMany<Vendor>().OrderBy(x => x.strName).ToList();

            //Click on the category combobox
            ClickCmb(cmbCategory, e);
        }

        private void btnPrintBarcode_Click( object sender, EventArgs e )
        {
            if (dgvInventoryView.SelectedRows.Count > 0)
            {
                Commodity commodity = ItemModel.Get<Commodity>(x => x.uidTuid.ToString() == dgvInventoryView.Columns[7].HeaderCell.ToString());

                try
                {
                    //Print barcode here
                    MessageBox.Show("For testing purposes, the barcode is " + commodity.strBarCode);
                }
                catch
                {
                    MessageBox.Show("Barcode is null");
                }
            }
        }

        private void ClickCmb( object sender, EventArgs e )
        {
            //Get the clicked combobox
            var cmbCurrent = sender as ComboBox;
            
            //Empty all others
            foreach (var cmb in Controls.OfType<GroupBox>().SelectMany(groupBox => groupBox.Controls.OfType<ComboBox>()))
            {
                if (cmb != cmbCurrent)
                {
                    cmb.SelectedIndex = -1;
                }
            }
        }

        private void cmbCategory_SelectedIndexChanged( object sender, EventArgs e )
        {
            //Get list
            lstCommodities = ItemModel.GetMany<Commodity>(x => x.objCategory.strName == cmbCategory.Text).OrderBy(x => x.strName).ToList();
            
            //Set dgv
            dgvInventoryView.DataSource = lstCommodities;
        }

        private void cmbRoom_SelectedIndexChanged( object sender, EventArgs e )
        {
            
        }

        private void cmbVendor_SelectedIndexChanged( object sender, EventArgs e )
        {

        }

        private void cmbNLevel_SelectedIndexChanged( object sender, EventArgs e )
        {

        }

        private void txtSearch_TextChanged( object sender, EventArgs e )
        {            
            if(txtSearch.Text.Length > 0)
            {
                //Make temp list that is filtered
                List<Commodity> lstTemp = lstCommodities.Where(x => x.strName.IndexOf(txtSearch.Text, 0, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();

                //Set dgv with filtered datasource
                dgvInventoryView.DataSource = lstTemp;
            }
            else
            {
                //Set dgv back to normal
                dgvInventoryView.DataSource = lstCommodities;
            }
        }
    }
}
