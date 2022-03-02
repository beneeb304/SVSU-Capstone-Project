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
        private void cmbDeleteCategory_SelectedIndexChanged( object sender, EventArgs e )
        {
            Category_SelectedValueChanged(cmbDeleteCategory, cmbDeleteCommodity);
        }

        private void cmbDeleteCommodity_SelectedIndexChanged( object sender, EventArgs e )
        {
            dgvDeletionDelta.DataSource = ItemModel
                .GetMany<Storage>(x => x.objCommodity == (cmbDeleteCommodity.SelectedItem as Commodity))
                .GroupBy(x => x.objCabinet.objRoom)
                .Select(x => new
                {
                    room = x.Key.strName,
                    count = x.Select(y => y.intQuantity).Sum()
                });
            dgvDeletionDelta.Columns[0].HeaderText = "Room";
            dgvDeletionDelta.Columns[1].HeaderText = "Purge Quantity";
        }

        private void btnDeleteConfirm_Click( object sender, EventArgs e )
        {
            if (dgvDeletionDelta.Rows.Count == 0)
            {
                MessageBox.Show("No items to purge");
            }
            else
            {
                ItemModel.Delete<Commodity>(cmbDeleteCommodity.SelectedItem as Commodity);
            }
        }

        private void btnConfirmReset_Click( object sender, EventArgs e )
        {
            cmbDeleteCategory.SelectedIndex = -1;
        }
    }
}
