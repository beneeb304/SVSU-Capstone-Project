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
            cmbItemType.DataSource = Enum.GetValues(typeof(ItemType));
            cmbCategory.Enabled = false;
            cmbItemType_SelectedIndexChanged(sender, e);
        }

        private void btnPrintBarcode_Click( object sender, EventArgs e )
        {
            if(lstCommodity.SelectedIndex > -1)
            {
                
                pdgBarcode.Document = pdtBarcode;
                if (pdgBarcode.ShowDialog() == DialogResult.OK)
                {
                    pdtBarcode.Print();
                }
                
            }
        }

        private void cmbItemType_SelectedIndexChanged( object sender, EventArgs e )
        {
            var selectedType = cmbItemType.SelectedIndex;
            cmbCategory.Enabled = true;
            var category = ItemModel.GetMany<Category>().ToList();
           cmbCategory.DataSource = ItemModel.GetMany<Commodity>().Where(x => ((int)x.enuCommodityType) == selectedType).Select(x => x.objCategory.strName).Distinct().ToList();
        }

        private void cmbCategory_SelectedIndexChanged( object sender, EventArgs e )
        {
            //Clear detail dgv rows
            dgvDetails.Rows.Clear();
            lstCommodity.DataSource = null;

            //Get list
            if(cmbItemType.SelectedIndex == -1)
            {
                lstCommodity.DataSource = null;
            }
            else
            {
                lstCommodities = ItemModel.GetMany<Commodity>(x => x.objCategory.strName == cmbCategory.Text && ((int)x.enuCommodityType) == cmbItemType.SelectedIndex).OrderBy(x => x.strName).ToList();

                //Set dgv
                lstCommodity.DataSource = lstCommodities;
            }
           
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
            if (lstCommodity.DataSource != null)
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

                //Genorate and populate the barcode for the selected item
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                if (commodity.strBarCode == null)
                {
                    //Disable print barcode button
                    btnPrintBarcode.Enabled = false;
                    //Clear picturebox image
                    pcbBarcode.Image = null;
                }
                else
                {
                    //Cast barcode to picture box
                    pcbBarcode.Image = barcode.Draw(commodity.strBarCode, 115, 1);

                    //Enable print barcode button
                    btnPrintBarcode.Enabled = true;
                }

                //Add to the dgv
                foreach (Storage storage in lstStorage)
                {
                    dgvDetails.Rows.Add(storage.intQuantity, storage.objNLevel.strName, storage.objCabinet.objRoom.strName, storage.objCabinet.strName);
                }

            //Unselect cells
            dgvDetails.ClearSelection();
            }

            

        }

        private void lstCommodity_DoubleClick( object sender, EventArgs e )
        {
            if (lstCommodity.DataSource != null)
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

        private void pdtBarcode_PrintPage( object sender, System.Drawing.Printing.PrintPageEventArgs e )
        {
            Bitmap bmpBarcode = new Bitmap(pcbBarcode.Width, pcbBarcode.Height);
            pcbBarcode.DrawToBitmap(bmpBarcode, new Rectangle(0, 0, pcbBarcode.Width, pcbBarcode.Height));
            e.Graphics.DrawImage(bmpBarcode, 0, 0);
        }
    }
}
