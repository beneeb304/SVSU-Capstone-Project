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
            mtxCreateCost.Text = "";
        }

        /* Function: txtCreateItemName_TextChanged
        * Description:
        * 
        * Local Variables
        * object sender; The object calling the method.
        * EventArgs e; Information passed by the sender object about the method call.
        */
        private void txtCreateItemName_Leave( object sender, EventArgs e )
        {
            // Check if the item name is already in use if also not blank
            var filteredItem = txtCreateItemName.Text != "" ? ItemModel.Get<Commodity>(x => x.strName == txtCreateItemName.Text) : null;
            if (filteredItem != null)
            {
                MessageBox.Show("Item name already in use. Please choose a different name or modify item.");
                btnCreate.Text = "Modify";
                cmbCreateCategory.SelectedItem = filteredItem.objCategory;
            }
        }
        private void trvCreateSelectByCategory_Populate()
        {
            trvCreateSelectByCategory.Nodes.Clear();
            var lstCategories = ItemModel.GetMany<Category>();
            lstCategories.ForEach(cat =>
            {
                var node = new TreeNode(cat.strName) { Tag = cat };
                cat.lstCommodities.ForEach(comm => { node.Nodes.Add(new TreeNode($"{comm.strName} ({comm.lstStorage.Sum(x => x.intQuantity)})") { Tag = comm }); });
                trvCreateSelectByCategory.Nodes.Add(node);
            });
        }

        private void trvCreateSelectByRoom_Populate()
        {
            trvCreateSelectByRoom.Nodes.Clear();
            var lstRooms = ItemModel.GetMany<Room>();
            lstRooms.OrderBy(x => x.strName).ToList().ForEach(room =>
            {
                var roomNode = new TreeNode(room.strName) { Tag = room };
                room.lstCabinets.OrderBy(x => x.strName).ToList().ForEach(cab =>
                {
                    var cabinetNode = new TreeNode(cab.strName) { Tag = cab };
                    cab.lstStorage.GroupBy(x => x.objNLevel).ToList().ForEach(grp =>
                    {
                        var nlevelNode = new TreeNode(grp.Key.strName) { Tag = grp.Key };
                        grp.ToList().ForEach(stor =>
                        {
                            nlevelNode.Nodes.Add(new TreeNode($"{stor.objCommodity.strName} ({stor.intQuantity})") { Tag = stor.objCommodity });
                        });
                        cabinetNode.Nodes.Add(nlevelNode);
                    });
                    roomNode.Nodes.Add(cabinetNode);
                });
                trvCreateSelectByRoom.Nodes.Add(roomNode);
            });
        }
    }
}
