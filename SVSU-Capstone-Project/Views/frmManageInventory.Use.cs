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

        /* Function: btnUseCancel_Click
         * Description: Clears all fields on the user commodity page when cancel is clicked.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void btnUseCancel_Click( object sender = null, EventArgs e = null )
        {
            //Clear all fields on Use tab
            trvUseSelectByRoom.SelectedNode = null;
            nudUseDeduct.Value = 1;
        }

        private void btnUse_Click( object sender = null, EventArgs e = null )
        {
            //Check if all fields are filled out
            if (trvUseSelectByRoom.SelectedNode.Tag != null && nudUseDeduct.Value != 0)
            {
                MessageBox.Show("Please select an item and used quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ItemModel.UseItem(
                (trvUseSelectByRoom.SelectedNode.Tag as Commodity)
                .lstStorage
                .Where(x =>
                    x.objNLevel == (trvUseSelectByRoom.SelectedNode.Parent.Tag as NLevel)
                    && x.objCabinet == (trvUseSelectByRoom.SelectedNode.Parent.Parent.Tag as Cabinet)
                ).First(),
                Authentication.ActiveUser,
                Convert.ToUInt32(nudUseDeduct.Value),
                "Item Used via Manage Inventory Tab"
            );
            btnUseCancel_Click();
        }

        private void trvUseSelectByRoom_BeforeSelect( object sender, TreeViewCancelEventArgs e )
        {
            // cast Tag to TreeNodeTag
            TreeNodeTag tag = (TreeNodeTag)e.Node.Tag;

            if (!tag.selectable)
            {
                e.Cancel = true;
            }
        }

        private void trvUseSelectByRoom_AfterSelect( object sender, TreeViewEventArgs e )
        {
            Commodity selected = (Commodity)((TreeNodeTag)((TreeView)sender).SelectedNode.Tag).val;
            lblUseItemNameVal.Text = selected.ToString();
            lblUseItemCategoryVal.Text = selected.objCategory.ToString();
            lblUseItemTypeVal.Text = selected.enuCommodityType.ToString();

            if (selected.enuCommodityType == ItemType.Consumable)
            {
                var itemStorage = selected.lstStorage.Where(x => x.objNLevel == ((TreeNodeTag)trvUseSelectByRoom.SelectedNode.Parent.Tag).val as NLevel && x.objCabinet == ((TreeNodeTag)trvUseSelectByRoom.SelectedNode.Parent.Parent.Tag).val as Cabinet).First();
                lblUseAvailable.Text = "Available";
                lblUseOperatorSymb.Text = "-";
                nudUseDeduct.Value = nudUseDeduct.Minimum;
                nudUseDeduct.Maximum = itemStorage.intQuantity;
                lblUseAvailable.Text = "Remainder";
                txtUseAvailable.Text = itemStorage.intQuantity.ToString();
            }
            else
            {
                var itemUsage = ItemModel.Get<SimulatorUse>(x => x.objCommodity == selected);
                if (itemUsage == null) ItemModel.Add(new SimulatorUse() { objCommodity = selected }, out itemUsage);
                lblUseAvailable.Text = "Hours Used";
                lblUseOperatorSymb.Text = "+";
                nudUseDeduct.Value = nudUseDeduct.Minimum;
                lblUseAvailable.Text = "New Total";
                nudUseDeduct.Maximum = 1000;
                txtUseAvailable.Text = itemUsage.intHoursUsed.ToString();
            }
            nudUseDeduct_ValueChanged();
        }

        private void nudUseDeduct_ValueChanged( object sender = null, EventArgs e = null )
        {
            if (int.TryParse(txtUseAvailable.Text, out int available))
            {
                if (lblUseOperatorSymb.Text == "-")
                {
                    txtUseRemaining.Text = (available - nudUseDeduct.Value).ToString();
                }
                else
                {
                    txtUseRemaining.Text = (available + nudUseDeduct.Value).ToString();
                }
            }
            else
            {
                txtUseRemaining.Text = "";
            }
        }
    }
}
