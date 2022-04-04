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
            lblUseItemNameVal.Text = "";
            lblUseItemCategoryVal.Text = "";
            lblUseItemTypeVal.Text = "";
            txtUseAvailable.Text = "";
            txtUseRemaining.Text = "";
            nudUseDeduct.Value = 1;
        }

        /* Function: btnUse_Click
         * Description: Marks simulator use upon btnUse click. Adds the amount of time used to the specified simulator.
         * 
         * Local Variables
         * Object sender; Object calling the method.
         * EventArgs e; Arguments provided by the sender object.
         * Commodity commodity; A commodity to check for null fields.
         * SimulatorUse sim; The simulator being marked used.
         * Storage storage; Storage location for the simulator.
         * Log log; Log object of the transaction.
         */
        private void btnUse_Click( object sender = null, EventArgs e = null )
        {
            //Check if all fields are filled out
            var commodity = trvUseSelectByRoom.SelectedNode?.Tag;
            
            if (trvUseSelectByRoom.SelectedNode?.Tag == null || nudUseDeduct.Value == 0)
            {
                MessageBox.Show("Please select an item and used quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (commodity != null)
            {
                var sim = ItemModel.Get<SimulatorUse>(x => x.objCommodity.uidTuid == ((TreeNodeTag)trvUseSelectByRoom.SelectedNode?.Tag).val.uidTuid);
                if(sim != null)
                {
                    var simulator = ItemModel.Get<SimulatorUse>(x => x.objCommodity.uidTuid == sim.objCommodity.uidTuid);
                    simulator.intHoursUsed = ((int)(simulator.intHoursUsed + (uint)nudUseDeduct.Value));
                    simulator.intTimesUsed = simulator.intTimesUsed + 1;
                    ItemModel.Update<SimulatorUse>(simulator);
                    var storage = ItemModel.Get<Storage>(x => x.objCommodity.uidTuid == simulator.objCommodity.uidTuid);
                    Log log = new Log
                    {
                        dtTimestamp = DateTime.Now,
                        enuAction = ItemAction.Used,
                        intQuantityChange = (int)nudUseDeduct.Value,
                        objStorage = storage,
                        objUser = Authentication.ActiveUser,
                        strNotes = $"{simulator.objCommodity.strName} has been used for {(uint)nudUseDeduct.Value} hours on {DateTime.Now}."
                    };
                    ItemModel.Add<Log>(log);

                }
                else
                {
                    ItemModel.UseItem(
                        (((TreeNodeTag)trvUseSelectByRoom.SelectedNode.Tag).val as Commodity)
                        .lstStorage
                        .Where(x =>
                            x.objNLevel == (((TreeNodeTag)trvUseSelectByRoom.SelectedNode.Parent.Tag).val as NLevel)
                            && x.objCabinet == (((TreeNodeTag)trvUseSelectByRoom.SelectedNode.Parent.Parent.Tag).val as Cabinet)
                        ).First(),
                        Authentication.ActiveUser,
                        Convert.ToUInt32(nudUseDeduct.Value),
                        "Item Used via Manage Inventory Tab",
                        () => trvUseSelectByRoom.Nodes.Remove(trvUseSelectByRoom.SelectedNode)
                        );
                }
            }
            // notify User of success
            MessageBox.Show("Item used successfully.");
            btnUseCancel_Click();
        }

        /* Function: trvUseSelectByRoom_BeforeSelect
         * Description: Ensures a tree node is selectable before action is taken.
         * 
         * Local Variables
         * Object sender; Object calling the method.
         * TreeViewCancelventArgs e; Arguments provided by the sender object.
         * TreeNodeTag tag; TreeNode object to check for selectability.
         */
        private void trvUseSelectByRoom_BeforeSelect( object sender, TreeViewCancelEventArgs e )
        {
            // cast Tag to TreeNodeTag
            TreeNodeTag tag = (TreeNodeTag)e.Node.Tag;

            if (!tag.selectable)
            {
                e.Cancel = true;
            }
        }

        /* Function: trvUseSelectByRoom_AfterSelect
         * Description: Updates fields within the form after a selectable tree node is clicked with information of the object selected.
         * 
         * Local Variables
         * Object sender; Object calling the method.
         * TreeViewCancelventArgs e; Arguments provided by the sender object.
         * Commodity selected; Object of the item selected to pull information from.
         * Storage itemStorage; The selected commodity's storage location.
         * SimulatorUse itemUsage; Used to ensure the selected commodity is an available simulator.
         * SimulatorUse sim; Simulator object to manipulate data.
         */
        private void trvUseSelectByRoom_AfterSelect( object sender, TreeViewEventArgs e )
        {
            Commodity selected = (Commodity)((TreeNodeTag)((TreeView)sender).SelectedNode.Tag).val;
            lblUseItemNameVal.Text = selected.ToString();
            lblUseItemCategoryVal.Text = selected.objCategory.ToString();
            lblUseItemTypeVal.Text = selected.enuCommodityType.ToString();

            if (selected.enuCommodityType == ItemType.Consumable)
            {
                var itemStorage = selected.lstStorage.Where(x => x.objNLevel == ((TreeNodeTag)trvUseSelectByRoom.SelectedNode.Parent.Tag).val as NLevel && x.objCabinet == ((TreeNodeTag)trvUseSelectByRoom.SelectedNode.Parent.Parent.Tag).val as Cabinet).First();
                lblUseAvailable.Text = "Available Qty";
                lblUseOperatorSymb.Text = "-";
                lblUseUsed.Text = "Used Qty";
                nudUseDeduct.Value = nudUseDeduct.Minimum;
                nudUseDeduct.Maximum = itemStorage.intQuantity;
                lblUseRemainder.Text = "New Total Qty";
                txtUseAvailable.Text = itemStorage.intQuantity.ToString();
            }
            else
            {
                var itemUsage = ItemModel.Get<SimulatorUse>(x => x.objCommodity == selected);
                if (itemUsage == null) ItemModel.Add(new SimulatorUse() { objCommodity = selected }, out itemUsage);
                var sim = ItemModel.Get<SimulatorUse>(x => x.objCommodity.uidTuid == selected.uidTuid);
                lblUseAvailable.Text = "Current Hours";
                lblUseOperatorSymb.Text = "+";
                lblUseUsed.Text = "Used Hours";
                nudUseDeduct.Value = nudUseDeduct.Value;
                lblUseRemainder.Text = "New Total Hours";
                nudUseDeduct.Maximum = 1000;
                txtUseAvailable.Text = sim.intHoursUsed.ToString();
            }
            nudUseDeduct_ValueChanged();
        }

        /* Function: nudUseDeduct_ValueChanged
         * Description: Updates use values in the form's fields.
         * 
         * Local Variables
         * Object sender; Object calling the method.
         * EventArgs e; Arguments provided by the sender object.
         */
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
