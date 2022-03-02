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
        public frmManageInventory()
        {
            InitializeComponent();
            // Bind Comboboxes to the database so the user has options to select on load
            // Add Tab
            this.cmbAddCategory.DataSource = ItemModel.GetMany<Category>().OrderBy(x => x.strName).ToList();
            // Create Tab
            this.cmbCreateCategory.DataSource = ItemModel.GetMany<Category>().OrderBy(x => x.strName).ToList();
            this.cmbCreateVendor.DataSource = ItemModel.GetMany<Vendor>().OrderBy(x => x.strName).ToList();
            // Use Tab
            this.cmbUseCategory.DataSource = ItemModel.GetMany<Category>().OrderBy(x => x.strName).ToList();
            // Move Tab
            this.cmbMoveCategory.DataSource = ItemModel.GetMany<Category>().OrderBy(x => x.strName).ToList();

        }

        private void Category_SelectedValueChanged( ComboBox cmbCategory, ComboBox cmbCommodity )
        {
            if (cmbCategory.SelectedIndex != -1)
                cmbCommodity.DataSource = (cmbCategory.SelectedItem as Category).lstCommodities.OrderBy(x => x.strName).ToList();
            cmbCommodity.SelectedIndex = -1;
        }


        private void Commodity_SelectedValueChanged( ComboBox cmbCommodity, ComboBox cmbRoom )
        {
            if (cmbCommodity.SelectedIndex != -1)
                cmbRoom.DataSource = (cmbCommodity.SelectedItem as Commodity).lstStorage.Select(x => x.objCabinet.objRoom).OrderBy(x => x.strName).ToList();
            cmbRoom.SelectedIndex = -1;
        }

        private void Room_SelectedValueChanged( ComboBox cmbRoom, ComboBox cmbCabinet, ComboBox cmbCommodity )
        {
            if (cmbRoom.SelectedIndex != -1 && cmbCommodity.SelectedIndex != -1)
                // cabinets which are in the selected room and have the selected commodity
                cmbCabinet.DataSource = (cmbCommodity.SelectedItem as Commodity).lstStorage.Where(x => x.objCabinet.objRoom == (cmbRoom.SelectedItem as Room)).Select(x => x.objCabinet).OrderBy(x => x.strName).ToList();
            cmbCabinet.SelectedIndex = -1;
        }

        private void Cabinet_SelectedValueChanged( ComboBox cmbCabinet, ComboBox cmbCommodity, ComboBox cmbNLevel )
        {
            if (cmbCabinet.SelectedIndex != -1)
                cmbNLevel.DataSource = ItemModel.GetMany<Storage>(x =>
                    x.objCabinet == (cmbCabinet.SelectedItem as Cabinet) &&
                    x.objCommodity == (cmbCommodity.SelectedItem as Commodity)
                )
                .Select(x => x.objNLevel).Distinct().ToList();
            cmbNLevel.SelectedIndex = -1;
        }
        private void NLevel_SelectedValueChanged( ComboBox cmbCommodity, ComboBox cmbCabinet, ComboBox cmbNLevel, TextBox txtAvailable = null, NumericUpDown nudChange = null )
        {
            if (cmbNLevel.SelectedIndex != -1)
            {
                var availiableQuantity = ItemModel.Get<Storage>(x =>
                    x.objCabinet == (cmbCabinet.SelectedItem as Cabinet) &&
                    x.objCommodity == (cmbCommodity.SelectedItem as Commodity) &&
                    x.objNLevel == (cmbNLevel.SelectedItem as NLevel)
                ).intQuantity;

                if (txtAvailable != null)
                    txtAvailable.Text = availiableQuantity.ToString();
                if (nudChange != null)
                {
                    nudChange.Maximum = availiableQuantity;
                    nudChange.Value = 1;
                }
            }
        }


    }
}
