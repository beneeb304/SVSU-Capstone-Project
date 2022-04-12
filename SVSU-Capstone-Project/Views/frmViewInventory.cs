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

        private void cmbItemType_SelectedIndexChanged( object sender, EventArgs e )
        {
            /* Function: cmbItemType_SelectedIndexChanged
            * -----------------------------------------------------------------------------
            * Description: This function is called whenever the selected index is changed within the itemntype list
            * -----------------------------------------------------------------------------
            *  Parameter Dictionary (in parameter order):  
            *  EventArgs e; Information passed by the sender object about the method call.
            * object sender; The object calling the method. btnLogin in this case.
            * -----------------------------------------------------------------------------
            * Local Variables
            * var category - enable command btn category
            * var selectedType - stores the item index
            */

            // stores the item index
            var selectedType = cmbItemType.SelectedIndex;
            // enable command btn category
            cmbCategory.Enabled = true;
            // stores the category for the item
            var category = ItemModel.GetMany<Category>().ToList();

            cmbCategory.DataSource = ItemModel.GetMany<Commodity>().Where(x => ((int)x.enuCommodityType) == selectedType).Select(x => x.objCategory.strName).Distinct().ToList();
           // set category to first one in the list
            cmbCategory.SelectedIndex = -1;
           // clear text 
            txtSearch.Text = "";
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void cmbCategory_SelectedIndexChanged( object sender, EventArgs e )
        {
            /* Function: cmbCategory_SelectedIndexChanged
            * -----------------------------------------------------------------------------
            * Description: This function is called whenever the selected index is changed within the Categorytype list
            * -----------------------------------------------------------------------------
            *  Parameter Dictionary (in parameter order):  
            *  EventArgs e; Information passed by the sender object about the method call.
            * object sender; The object calling the method. btnLogin in this case.
            * -----------------------------------------------------------------------------
            * Local Variables
            * var category - enable command btn category
            * var selectedType - stores the item index
            */

            txtSearch.Text = "";
            //Clear detail dgv rows
            dgvDetails.Rows.Clear();

            lstCommodity.DataSource = null;

            //Get list
            if(cmbItemType.SelectedIndex == -1)
            {
                lstCommodity.DataSource = null;
            }
            else if(cmbItemType.SelectedIndex >= 0 && cmbCategory.SelectedIndex == -1)
            {
                lstCommodities = ItemModel.GetMany<Commodity>(x => (int)x.enuCommodityType == cmbItemType.SelectedIndex).OrderBy(x => x.strName).ToList();
                lstCommodity.DataSource = lstCommodities;
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
            /* Function: txtSearch_TextChanged
            * -----------------------------------------------------------------------------
            * Description: This function is called whenever the text is changed within the search box to searc as characters are being typed 
            * -----------------------------------------------------------------------------
            *  Parameter Dictionary (in parameter order):  
            *  EventArgs e; Information passed by the sender object about the method call.
            *  object sender; The object calling the method. btnLogin in this case.
            * -----------------------------------------------------------------------------
            * Local Variables
            */


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


        private void lstCommodity_DoubleClick( object sender, EventArgs e )
        {
            /* Function: lstCommodity_DoubleClick
            * -----------------------------------------------------------------------------
            * Description: This function is called whenever the commodity is double clicked to populate 
            *               it will search according to proper search fields and display the proper details 
            *               according to how search is performed
            * -----------------------------------------------------------------------------
            *  Parameter Dictionary (in parameter order):  
            *  EventArgs e; Information passed by the sender object about the method call.
            *  object sender; The object calling the method. btnLogin in this case.
            * -----------------------------------------------------------------------------
            * Local Variables
            * var comm - variable used to store commodity 
            * string strCategory - Stores the category via text input
            * string strCommodity - Stores the category via selected item
            * string strMessage - display message to be dipslayed with commodity details
            */

            // 
            if (lstCommodity.SelectedIndex != -1)
            {
                var comm = ItemModel.Get<Commodity>(x => x.strName == lstCommodity.SelectedItem.ToString());
                if(comm.enuCommodityType == ItemType.Simulator)
                {
                    // Stores the category via text input
                    string strCategory = cmbCategory.Text;
                    //Stores the category via selected item
                    string strCommodity = lstCommodity.SelectedItem.ToString();
                    Commodity commodity = ItemModel.Get<Commodity>(x => x.strName == strCommodity);

                    if(commodity != null)
                    {
                      SimulatorUse simulator = ItemModel.Get<SimulatorUse>(x => x.objCommodity.uidTuid == commodity.uidTuid);
                        if(simulator != null)
                        {
                            // display message to be dipslayed with commodity details
                            string strMessage = "Name: " + commodity.strName + "\r" +
                            "Desciption: " + commodity.strDescription + "\r" +
                            "Type: " + commodity.enuCommodityType.ToString() + "\r" +
                            "Features: " + commodity.strFeatures + "\r" +
                            "Alert Quantity: " + commodity.intAlert_quantity + "\r" +
                            "Commodity Category: " + commodity.objCategory.strName + "\r" +
                            "Cost: " + (commodity.intCostInCents / 100.00).ToString("C") + "\r" +
                            "URL: " + commodity.strItemUrl + "\r" +
                            "Hours Used: " + simulator.intHoursUsed + "\r" +
                            "Times Used: " + simulator.intTimesUsed;
                            MessageBox.Show(strMessage, "Commodity Details");
                        }
                        else
                        {
                            //display message to be dipslayed with commodity details
                            string strMessage = "Name: " + commodity.strName + "\r" +
                            "Desciption: " + commodity.strDescription + "\r" +
                            "Type: " + commodity.enuCommodityType.ToString() + "\r" +
                            "Features: " + commodity.strFeatures + "\r" +
                            "Alert Quantity: " + commodity.intAlert_quantity + "\r" +
                            "Commodity Category: " + commodity.objCategory.strName + "\r" +
                            "Cost: " + (commodity.intCostInCents / 100.00).ToString("C") + "\r" +
                            "URL: " + commodity.strItemUrl;
                            MessageBox.Show(strMessage, "Commodity Details");
                        }
                    }
                }
                else
                {
                
                    // get commodity via selected index
                    string strCommodity = lstCommodity.SelectedItem.ToString();
                    // create commoditu
                    Commodity commodity = ItemModel.Get<Commodity>(x => x.strName == strCommodity);
                    // get category
                    Category category = ItemModel.Get<Category>(x => x.uidTuid == commodity.objCategory.uidTuid);
                    // store category message
                    string strCategory = category.strName;
                    // display message with details
                    string strMessage = "Name: " + commodity.strName + "\r" +
                            "Desciption: " + commodity.strDescription + "\r" +
                            "Type: " + commodity.enuCommodityType.ToString() + "\r" +
                            "Features: " + commodity.strFeatures + "\r" +
                            "Alert Quantity: " + commodity.intAlert_quantity + "\r" +
                            "Commodity Type: " + commodity.objCategory.strName + "\r" +
                            "Cost: " + (commodity.intCostInCents / 100.00).ToString("C") + "\r" +
                            "URL: " + commodity.strItemUrl;
                    MessageBox.Show(strMessage, "Commodity Details");
                }
            }
        }

        private void btnCategoryReset_Click( object sender, EventArgs e )
        {
            /* Function: btnCategoryReset_Click
            * -----------------------------------------------------------------------------
            * Description: This function will reset the category index to the first index
            * -----------------------------------------------------------------------------
            *  Parameter Dictionary (in parameter order):  
            *  EventArgs e; Information passed by the sender object about the method call.
            *  object sender; The object calling the method. btnLogin in this case.
            * -----------------------------------------------------------------------------
            * Local Variables
            */
            cmbCategory.SelectedIndex = -1;
        }

        private void lstCommodity_SelectedIndexChanged( object sender, EventArgs e )
        {
            /* Function: lstCommodity_SelectedIndexChanged
          * -----------------------------------------------------------------------------
          * Description: This function is called whenever commmodity list is changed. It will 
          *             clear out hte details rows and add the new ones as long as the columns
          *             do not exist.
          * -----------------------------------------------------------------------------
          *  Parameter Dictionary (in parameter order):  
          *  EventArgs e; Information passed by the sender object about the method call.
          *  object sender; The object calling the method. btnLogin in this case.
          * -----------------------------------------------------------------------------
          * Local Variables:
          * Category category - sets the category
          * Commodity commodity - sets the commodity
          * var comm - variable used to store commodity 
          * string strCategory - Stores the category via text input
          * string strCommodity - Stores the category via selected item
          * string strMessage - display message to be dipslayed with commodity details
          * List<Storage> lstStorage - set the storage list
          */

            if (lstCommodity.SelectedIndex != -1)
            {

                //Get rid of current rows
                dgvDetails.Rows.Clear();

                //If column exist, don't re-add them
                if (dgvDetails.Columns.Count != 4)
                {
                    dgvDetails.Columns.Add("Quantity", "Quantity");
                    dgvDetails.Columns.Add("N-Level", "N-Level");
                    dgvDetails.Columns.Add("Room", "Room");
                    dgvDetails.Columns.Add("Cabinet", "Cabinet");
                }

                //Get the selected category and commodity
                string strCommodity = lstCommodity.SelectedItem.ToString();
                // set commodity
                Commodity commodity = ItemModel.Get<Commodity>(x => x.strName == strCommodity);
                // set category
                Category category = ItemModel.Get<Category>(x => x.uidTuid == commodity.objCategory.uidTuid);
                // stores the category name 
                string strCategory = category.strName;
                // set the storage lost
                List<Storage> lstStorage = ItemModel.GetMany<Storage>(x => x.objCommodity.uidTuid == commodity.uidTuid).ToList();

                //Add to the dgv
                foreach (Storage storage in lstStorage)
                {
                    dgvDetails.Rows.Add(storage.intQuantity, storage.objNLevel.strName, storage.objCabinet.objRoom.strName, storage.objCabinet.strName);
                }

                //Unselect cells
                dgvDetails.ClearSelection();
            }
        }
    }
}
