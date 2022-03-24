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

            //Set datasource for category each combobox
            cmbCategory.DataSource = ItemModel.GetMany<Category>().OrderBy(x => x.strName).ToList();
        }

        private void btnPrintBarcode_Click( object sender, EventArgs e )
        {
            if(lstCommodity.SelectedIndex > -1)
            {
                Commodity commodity = ItemModel.Get<Commodity>(x => x.uidTuid.ToString() == lstCommodity.SelectedItem.ToString());

                //Print barcode here
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

        private void cmbCategory_SelectedIndexChanged( object sender, EventArgs e )
        {
            //Clear detail dgv rows
            dgvDetails.Rows.Clear();
            lstCommodity.DataSource = null;

            //Get list
            lstCommodities = ItemModel.GetMany<Commodity>(x => x.objCategory.strName == cmbCategory.Text).OrderBy(x => x.strName).ToList();

            //Set dgv
            lstCommodity.DataSource = lstCommodities;
        }

        private void txtSearch_TextChanged( object sender, EventArgs e )
        {
            //Get rid of current rows
            dgvDetails.Rows.Clear();
            lstCommodity.ClearSelected();

            if (txtSearch.Text.Length > 0)
            {
                //Make temp list that is filtered
                List<Commodity> lstTemp = lstCommodities.Where(x => x.strName.IndexOf(txtSearch.Text, 0, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();

                //Set listbox with filtered datasource
                lstCommodity.DataSource = lstTemp;
            }
            else
            {
                //Set listbox back to normal
                lstCommodity.DataSource = lstCommodities;
            }
        }

        private void lstCommodity_Click( object sender, EventArgs e )
        {
            //Get rid of current rows
            dgvDetails.Rows.Clear();

            //If columsn exist, don't re-add them
            if (dgvDetails.Columns.Count != 4)
            {
                dgvDetails.Columns.Add("Quantity", "Quantity");
                dgvDetails.Columns.Add("N-Level", "N-Level");
                dgvDetails.Columns.Add("Room", "Room");
                dgvDetails.Columns.Add("Cabinet", "Cabinet");
            }

            //Get the selected category and commodity
            string strCategory = cmbCategory.Text;
            string strCommodity = lstCommodity.SelectedItem.ToString();

            Commodity commodity = ItemModel.Get<Commodity>(x => x.strName == strCommodity && x.objCategory.strName == strCategory);
            List<Storage> lstStorage = ItemModel.GetMany<Storage>(x => x.objCommodity.uidTuid == commodity.uidTuid).ToList();

            //Add to the dgv
            foreach (Storage storage in lstStorage)
            {
                dgvDetails.Rows.Add(storage.intQuantity, storage.objNLevel.strName, storage.objCabinet.objRoom.strName, storage.objCabinet.strName);
            }

            //Unselect cells
            dgvDetails.ClearSelection();
        }

        private void lstCommodity_DoubleClick( object sender, EventArgs e )
        {
            string strCategory = cmbCategory.Text;
            string strCommodity = lstCommodity.SelectedItem.ToString();
            Commodity commodity = ItemModel.Get<Commodity>(x => x.strName == strCommodity && x.objCategory.strName == strCategory);
            string strMessage = "Name: " + commodity.strName + "\r" +
                "Desciption: " + commodity.strDescription + "\r" +
                "Type: " + commodity.enuCommodityType.ToString() + "\r" +
                "Features: " + commodity.strFeatures + "\r" +
                "Alert Quantity: " + commodity.intAlert_quantity + "\r" +
                "Commodoty Type: " + commodity.enuCommodityType.ToString() + "\r" +
                "Cost: " + (commodity.intCostInCents / 100.00).ToString("C") + "\r" +
                "URL: " + commodity.strItemUrl + "\r" +
                "Barcode: " + commodity.strBarCode;
            MessageBox.Show(strMessage);
        }
    }
}
