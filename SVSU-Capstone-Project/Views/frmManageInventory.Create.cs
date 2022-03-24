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
using static SVSU_Capstone_Project.Views.TreeViewExtensions;

namespace SVSU_Capstone_Project.Views
{
    public partial class frmManageInventory : Form
    {

        /* Function: btnCreateCancel_Click
         * Description: Clears all fields on the create commodity page when cancel is clicked.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void btnCreateCancel_Click( object sender, EventArgs e )
        {
            //Clear all fields on Create tab
            cmbCreateCategory.SelectedIndex = -1;
            cmbCreateVendor.SelectedIndex = -1;
            txtCreateDescription.Text = "";
            txtCreateFeatures.Text = "";
            txtCreateItemName.Text = "";
            txtCreateBarcode.Text = "";
            txtCreateUrl.Text = "";
            txtCurrentQty.Text = "";
            nudCreateAlertQty.Value = 0;
            nudCreateCost.Value = 0;
            btnCreate.Text = "Create";
            cmbCreateType.SelectedIndex = -1;
            trvCreateSelectByCategory.SelectedNode = null;
            trvCreateSelectByRoom.SelectedNode = null;
        }

        private void trvCreateSelect_BeforeSelect( object sender, TreeViewCancelEventArgs e )
        {
            // cast Tag to TreeNodeTag
            TreeNodeTag tag = (TreeNodeTag)e.Node.Tag;

            if (!tag.selectable)
            {
                e.Cancel = true;
            }
        }

        private void trvCreateSelect_AfterSelect( object sender, TreeViewEventArgs e )
        {
            Commodity selected = ((TreeNodeTag)e.Node.Tag).val as Commodity;
            txtCreateItemName.Text = selected.strName;
            txtCreateDescription.Text = selected.strDescription;
            txtCreateFeatures.Text = selected.strFeatures;
            txtCreateUrl.Text = selected.strItemUrl;
            txtCreateBarcode.Text = selected.strBarCode;
            cmbCreateCategory.DataSource = ItemModel.GetMany<Category>();
            cmbCreateCategory.SelectedItem = selected.objCategory;
            cmbCreateVendor.DataSource = ItemModel.GetMany<Vendor>();
            cmbCreateVendor.SelectedItem = selected.objVendor;
            cmbCreateType.DataSource = Enum.GetValues(typeof(ItemType));
            cmbCreateType.SelectedItem = selected.enuCommodityType;
            nudCreateAlertQty.Value = selected.intAlert_quantity;
            nudCreateCost.Text = (selected.intCostInCents / 100.00).ToString();
            btnCreate.Text = "Modify";
        }
        private void btnCreate_Click( object sender, EventArgs e )
        {
            //Make sure fields are filled out
            if (txtCreateDescription.Text != "" || txtCreateItemName.Text != "" || cmbCreateCategory.Text != "")
            {
                Commodity selected = null;
                Action<Commodity> submit = ( x ) => ItemModel.Update(x);
                if (trvCreateSelectByCategory.SelectedNode != null) selected = ((TreeNodeTag)trvCreateSelectByCategory.SelectedNode.Tag).val as Commodity;
                if (trvCreateSelectByRoom.SelectedNode != null) selected = ((TreeNodeTag)trvCreateSelectByRoom.SelectedNode.Tag).val as Commodity;
                // If the selected node is null, then we are creating a new item
                if (selected == null)
                {
                    // Create a new item
                    selected = new Commodity();
                    submit = ( x ) => ItemModel.Add(x);
                    trvCreateSelectByCategory.PopulateCommodityTreeByCategory();
                    trvCreateSelectByRoom.PopulateCommodityTreeByRoom();
                }

                //Generate new barcode if textbox is empty
                string strBarcode = txtCreateBarcode.Text;
                bool blnExists = true;
                
                while (blnExists)
                {
                    if(strBarcode == "")
                    {
                        Random random = new Random();

                        //String that contain both alphabets and numbers
                        string strAlphaNumeric = "abcdefghijklmnopqrstuvwxyz0123456789";
                        
                        //Set to 20 characters long (plus 1 for tilde)
                        int size = 20;
                        strBarcode = "~";

                        for (int i = 0; i < size; i++)
                        {
                            //Selecting a index randomly
                            int x = random.Next(strAlphaNumeric.Length);

                            //Appending the character at the index to the random alphanumeric string.
                            strBarcode += strAlphaNumeric[x];
                        }
                    }
                    
                    if(ItemModel.Get<Commodity>(x => x.strBarCode == strBarcode) == null)
                        blnExists = false;
                }

                selected.strName = txtCreateItemName.Text;
                selected.objCategory = cmbCreateCategory.SelectedItem as Category;
                selected.enuCommodityType = (ItemType)cmbCreateType.SelectedItem;
                selected.strDescription = txtCreateDescription.Text;
                selected.strBarCode = strBarcode;
                selected.objVendor = cmbCreateVendor.SelectedItem as Vendor;
                selected.intAlert_quantity = (int)nudCreateAlertQty.Value;
                selected.strItemUrl = txtCreateUrl.Text;
                selected.intCostInCents = (int)(nudCreateCost.Value * 100);
                selected.strFeatures = txtCreateFeatures.Text;
                submit(selected);
                MessageBox.Show("Successful " + btnCreate.Text, "Alert");
                btnCreateCancel_Click(null, null);
            }
            else
            {
                MessageBox.Show("Please fill out all of the commodity fields before creating!", "Alert");
            }
        }
    }
}
