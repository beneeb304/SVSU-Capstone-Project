using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
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
            txtCreateUrl.Text = "";
            txtCurrentQty.Text = "";
            nudCreateAlertQty.Value = 0;
            nudCreateCost.Value = 0;
            btnCreate.Text = "Create";
            cmbCreateType.SelectedIndex = -1;
            cmbCreateType.Enabled = true;
            trvCreateSelectByCategory.PopulateCommodityTreeByCategory();
            trvCreateSelectByRoom.PopulateCommodityTreeByRoom();
            trvCreateSelectByCategory.SelectedNode = null;
            trvCreateSelectByRoom.SelectedNode = null;
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void trvCreateSelect_BeforeSelect( object sender, TreeViewCancelEventArgs e )
        {
            if (e.Node == null) return;

            // cast Tag to TreeNodeTag
            TreeNodeTag tag = (TreeNodeTag)e.Node.Tag;
            if (!tag.selectable)
            {
                e.Cancel = true;
            }
        }

        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void trvCreateSelect_AfterSelect( object sender, TreeViewEventArgs e )
        {
            Commodity selected = ((TreeNodeTag)e.Node.Tag).val as Commodity;
            txtCreateItemName.Text = selected.strName;
            txtCreateDescription.Text = selected.strDescription;
            txtCreateFeatures.Text = selected.strFeatures;
            txtCreateUrl.Text = selected.strItemUrl;
            cmbCreateCategory.DataSource = ItemModel.GetMany<Category>();
            cmbCreateCategory.SelectedItem = selected.objCategory;
            cmbCreateVendor.DataSource = ItemModel.GetMany<Vendor>();
            cmbCreateVendor.SelectedItem = selected.objVendor;
            cmbCreateType.DataSource = Enum.GetValues(typeof(ItemType));
            cmbCreateType.SelectedItem = selected.enuCommodityType;
            cmbCreateType.Enabled = false;
            nudCreateAlertQty.Value = selected.intAlert_quantity;
            nudCreateCost.Value = (decimal)(selected.intCostInCents / 100.00);
            btnCreate.Text = "Modify";
        }

        private void ItemNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }


        /* Function: 
         * Description: 
         * 
         * Local Variables
         * 
         */
        private void btnCreate_Click( object sender, EventArgs e )
        {
            var exists = ItemModel.Get<Commodity>(x => x.strName == txtCreateItemName.Text);
            //Make sure fields are filled out
           if(string.IsNullOrWhiteSpace(txtCreateItemName.Text))
            {
                MessageBox.Show("Item name cannot be left blank or contain only space values. Please fill in the Item name textbox.", "Alert");
            }
           else if(string.IsNullOrWhiteSpace(txtCreateDescription.Text))
            {
                MessageBox.Show("Description cannot be left blank or contain only space values. Please fill in the Description textbox.", "Alert");
            }
           else if(string.IsNullOrWhiteSpace(cmbCreateCategory.Text))
            {
                MessageBox.Show("Category dropdown cannot be left blank. Please select a category from the dropdown list.", "Alert");
            }
           else if(string.IsNullOrWhiteSpace(cmbCreateType.Text))
            {
                MessageBox.Show("Item type cannot be left blank. Please select a item type from the dropdown list.", "Alert");
            }
           else if(exists != null && btnCreate.Text == "Create")
            {
                MessageBox.Show("Item already exists in the database. Please enter a different item name.", "Alert");
            }
           else if(String.IsNullOrWhiteSpace(txtCreateFeatures.Text) && txtCreateFeatures.Text.Length > 0)
            {
                MessageBox.Show("Features cannot contain only space values.", "Alert");
            }
           else
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
                }

                selected.strName = txtCreateItemName.Text;
                selected.objCategory = cmbCreateCategory.SelectedItem as Category;
                selected.enuCommodityType = (ItemType)cmbCreateType.SelectedItem;
                selected.strDescription = txtCreateDescription.Text;
                selected.objVendor = cmbCreateVendor.SelectedItem as Vendor;
                selected.intAlert_quantity = (int)nudCreateAlertQty.Value;
                selected.strItemUrl = txtCreateUrl.Text;
                selected.intCostInCents = (int)(nudCreateCost.Value * 100);
                selected.strFeatures = txtCreateFeatures.Text;

                submit(selected);
                if(btnCreate.Text == "Create")
                {
                    MessageBox.Show($"{txtCreateItemName.Text} has been successfully created!" + "\r\n\r\n" + $"Note: {txtCreateItemName.Text} will not show in the Category/Room tree until stock is added to a Room.", $"Successful {btnCreate.Text}!");
                    btnCreateCancel_Click(null, null);
                }
                else
                {
                    MessageBox.Show($"{txtCreateItemName.Text} has been successfully modified!", $"Successful {btnCreate.Text}!");
                    btnCreateCancel_Click(null, null);
                }
                
            }
        }
    }
}
