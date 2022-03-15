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
            txtCreateUrl.Text = "";
            txtCurrentQty.Text = "";
            nudCreateAlertQty.Value = 0;
            nudCreateCost.Value = 0;
            btnCreate.Text = "Create";
            cmbCreateType.SelectedIndex = -1;
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
            Commodity selected = null;
            Action<Commodity> submit = ( x ) => ItemModel.Update(x);
            if (trvCreateSelectByCategory.SelectedNode != null) selected = ((TreeNodeTag)trvCreateSelectByCategory.SelectedNode.Tag).val as Commodity;
            if (trvCreateSelectByRoom.SelectedNode != null) selected = ((TreeNodeTag)trvCreateSelectByRoom.SelectedNode.Tag).val as Commodity;
            // If the selected node is null, then we are creating a new item
            if (selected == null)
            {
                // Create a new item
                selected = new Commodity();
                submit = ( x ) => ItemModel.Update(x);
            }
            selected.strName = txtCreateItemName.Text;
            selected.objCategory = cmbCreateCategory.SelectedItem as Category;
            selected.enuCommodityType = (ItemType)cmbCreateType.SelectedItem;
            selected.strDescription = txtCreateDescription.Text;
            selected.objVendor = cmbCreateVendor.SelectedItem as Vendor;
            selected.intAlert_quantity = (int)nudCreateAlertQty.Value;
            selected.strItemUrl = txtCreateUrl.Text;
            selected.intCostInCents = (int)(nudCreateCost.Value) * 100;
            selected.strFeatures = txtCreateFeatures.Text;
            submit(selected);
            btnCreateCancel_Click(null,null);
        }
    }
}
