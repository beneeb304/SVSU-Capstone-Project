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
            // Bind Comboboxes to the database so the user has options to select on load
            List<Category> lstCategories = ItemModel.GetMany<Category>().OrderBy(x => x.strName).ToList();
            // Add Tab
            this.cmbAddCategory.DataSource = lstCategories;
            // Create Tab
            this.cmbCreateCategory.DataSource = lstCategories;
            this.cmbCreateVendor.DataSource = lstCategories;
            // Use Tab
            this.cmbUseCategory.DataSource = lstCategories;
            // Move Tab
            this.cmbMoveCategory.DataSource = lstCategories;
            // Delete Tab
            this.cmbDeleteCategory.DataSource = lstCategories;
            trvCreateSelectByCategory_Populate();
            trvCreateSelectByRoom_Populate();
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
}
