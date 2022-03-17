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
        private bool blnEventBlock = false;
        public frmManageInventory()
        {
            InitializeComponent();
            trvUseSelectByRoom.PopulateCommodityTreeByRoom(); 
        }

        private void tbcInventory_Selected( object sender, TabControlEventArgs e )
        {
            List<Category> lstCategories = ItemModel.GetMany<Category>().OrderBy(x => x.strName).ToList();
            List<Vendor> lstVendors = ItemModel.GetMany<Vendor>().OrderBy(x => x.strName).ToList();
            switch (e.TabPage.Name)
            {
                case ("tbpAddItems"):
                    this.cmbAddCategory.DataSource = lstCategories;
                    break;
                case ("tbpCreateItem"):
                    this.cmbCreateCategory.DataSource = lstCategories;
                    this.cmbCreateType.DataSource = Enum.GetValues(typeof(ItemType));
                    this.cmbCreateVendor.DataSource = lstVendors;
                    trvCreateSelectByCategory.PopulateCommodityTreeByCategory();
                    trvCreateSelectByRoom.PopulateCommodityTreeByRoom();
                    break;
                case ("tbpUseItem"):
                    trvUseSelectByRoom.PopulateCommodityTreeByRoom(); 
                    break;
                case ("tbpMoveItem"):
                    this.cmbMoveCategory.DataSource = lstCategories;
                    break;
                case ("tbpDeleteItem"):
                    this.cmbDeleteCategory.DataSource = lstCategories;
                    break;
            }
        }

        private void nonTriggeringCall( Action predicate )
        {
            // This is a non-triggering call to prevent the event from firing twice
            blnEventBlock = true;
            predicate();
            blnEventBlock = false;
        }

        private void Category_SelectedValueChanged( ComboBox cmbCategory, ComboBox cmbCommodity )
        {
            if (blnEventBlock) return;
            if (cmbCategory.SelectedIndex != -1)
                nonTriggeringCall(() => cmbCommodity.DataSource = (cmbCategory.SelectedItem as Category).lstCommodities.OrderBy(x => x.strName).ToList());
            else
                cmbCommodity.DataSource = null;
            cmbCommodity.SelectedIndex = -1;
        }


        private void Commodity_SelectedValueChanged( ComboBox cmbCommodity, ComboBox cmbRoom )
        {
            if (blnEventBlock) return;
            if (cmbCommodity.SelectedIndex != -1)
                nonTriggeringCall(() => cmbRoom.DataSource = ItemModel.GetMany<Storage>(x => x.objCommodity == (cmbCommodity.SelectedItem as Commodity)).Select(x => x.objCabinet.objRoom).Distinct().OrderBy(x => x.strName).ToList());
            else
                cmbRoom.DataSource = null;
            cmbRoom.SelectedIndex = -1;
        }

        private void Room_SelectedValueChanged( ComboBox cmbRoom, ComboBox cmbCabinet, ComboBox cmbCommodity )
        {
            if (blnEventBlock) return;
            if (cmbRoom.SelectedIndex != -1 && cmbCommodity.SelectedIndex != -1)
                // cabinets which are in the selected room and have the selected commodity
                nonTriggeringCall(() => cmbCabinet.DataSource = ItemModel.GetMany<Storage>(x => x.objCommodity == (cmbCommodity.SelectedItem as Commodity) && x.objCabinet.objRoom == (cmbRoom.SelectedItem as Room)).Select(x => x.objCabinet).OrderBy(x => x.strName).ToList());
            else
                cmbCabinet.DataSource = null;
            cmbCabinet.SelectedIndex = -1;
        }

        private void Cabinet_SelectedValueChanged( ComboBox cmbCabinet, ComboBox cmbCommodity, ComboBox cmbNLevel )
        {
            if (blnEventBlock) return;
            if (cmbCabinet.SelectedIndex != -1)
                nonTriggeringCall(() => cmbNLevel.DataSource = ItemModel.GetMany<Storage>(x =>
                    x.objCabinet == (cmbCabinet.SelectedItem as Cabinet) &&
                    x.objCommodity == (cmbCommodity.SelectedItem as Commodity)
                )
                .Select(x => x.objNLevel).Distinct().ToList());
            else
                cmbNLevel.DataSource = null;
            cmbNLevel.SelectedIndex = -1;
        }
        private void NLevel_SelectedValueChanged( ComboBox cmbCommodity, ComboBox cmbCabinet, ComboBox cmbNLevel, TextBox txtAvailable = null, NumericUpDown nudChange = null, TextBox txtRemainder = null )
        {
            if (blnEventBlock) return;
            var objStorage = ItemModel.GetMany<Storage>(x =>
                x.objCabinet == (cmbCabinet.SelectedItem as Cabinet) &&
                x.objCommodity == (cmbCommodity.SelectedItem as Commodity) &&
                x.objNLevel == (cmbNLevel.SelectedItem as NLevel)
            ).FirstOrDefault();
            if (cmbNLevel.SelectedIndex != -1 || objStorage != null)
            {
                if (txtAvailable != null)
                    txtAvailable.Text = objStorage.intQuantity.ToString();
                if (nudChange != null)
                {
                    nudChange.Maximum = Math.Max(objStorage.intQuantity, 1);
                    nudChange.Value = 1;
                }
                if (txtRemainder != null)
                    txtRemainder.Text = (objStorage.intQuantity - nudChange.Value).ToString();
            }
            else
            {
                if (txtAvailable != null)
                    txtAvailable.Text = "N/A";
                if (nudChange != null)
                {
                    nudChange.Maximum = 1;
                    nudChange.Value = 1;
                }
                if (txtRemainder != null)
                    txtRemainder.Text = "";
            }
        }
    }

    public static class TreeViewExtensions
    {
        public struct TreeNodeTag
        {
            public bool selectable;
            public ContextEntity val;
        }
        public static void PopulateCommodityTreeByCategory( this TreeView treeView )
        {
            treeView.Nodes.Clear();
            var lstCategories = ItemModel.GetMany<Category>();
            lstCategories.ForEach(cat =>
            {
                var node = new TreeNode(cat.strName) { Tag = new TreeNodeTag { val = cat, selectable = false } };
                cat.lstCommodities.ForEach(comm => { node.Nodes.Add(new TreeNode($"{comm.strName} ({comm.lstStorage.Sum(x => x.intQuantity)})") { Tag = new TreeNodeTag { val = comm, selectable = true } }); });
                treeView.Nodes.Add(node);
            });
        }

        public static void PopulateCommodityTreeByRoom( this TreeView treeView )
        {
            treeView.Nodes.Clear();
            var lstRooms = ItemModel.GetMany<Room>();
            lstRooms.OrderBy(x => x.strName).ToList().ForEach(room =>
            {
                var roomNode = new TreeNode(room.strName) { Tag = new TreeNodeTag { val = room, selectable = false } };
                room.lstCabinets.OrderBy(x => x.strName).ToList().ForEach(cab =>
                {
                    var cabinetNode = new TreeNode(cab.strName) { Tag = new TreeNodeTag { val = cab, selectable = false } };
                    cab.lstStorage.GroupBy(x => x.objNLevel).ToList().ForEach(grp =>
                    {
                        var nlevelNode = new TreeNode(grp.Key.strName) { Tag = new TreeNodeTag { val = grp.Key, selectable = false } };
                        grp.ToList().ForEach(stor =>
                        {
                            nlevelNode.Nodes.Add(new TreeNode($"{stor.objCommodity.strName} ({stor.intQuantity})") { Tag = new TreeNodeTag { val = stor.objCommodity, selectable = true } });
                        });
                        cabinetNode.Nodes.Add(nlevelNode);
                    });
                    roomNode.Nodes.Add(cabinetNode);
                });
                treeView.Nodes.Add(roomNode);
            });
        }
    }
}
