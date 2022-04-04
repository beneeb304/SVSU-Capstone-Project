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
                }).ToList();
            if (dgvDeletionDelta.Rows.Count > 0)
            {
                dgvDeletionDelta.Columns[0].HeaderText = "Room";
                dgvDeletionDelta.Columns[1].HeaderText = "# To Purge";
            }
        }

        private void btnDeleteConfirm_Click( object sender, EventArgs e )
        {
            if (cmbDeleteCommodity.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this commodity?",
                "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Get commodity
                    Commodity commodity = ItemModel.Get<Commodity>(x => x.objCategory.strName == cmbDeleteCategory.Text &&
                        x.strName == cmbDeleteCommodity.Text);

                    //Make sure commodity isn't checked out
                    CheckedItem checkedItem = ItemModel.Get<CheckedItem>(x => x.objCommodities.uidTuid == commodity.uidTuid);
                    if (checkedItem != null)
                    {
                        MessageBox.Show("Check commodity back in before deleting", "Alert");
                    }
                    else
                    {
                        List<Storage> lstStorage = ItemModel.GetMany<Storage>(x => x.objCommodity.uidTuid == commodity.uidTuid).ToList();
                        List<Log> lstLogs = ItemModel.GetMany<Log>(x => lstStorage.Contains(x.objStorage));
                        SimulatorUse simulatorUsage = ItemModel.Get<SimulatorUse>(x => x.objCommodity.uidTuid == commodity.uidTuid);

                        ItemModel.StartTransaction();
                        if (simulatorUsage != null)
                        {
                            ItemModel.Delete<SimulatorUse>(simulatorUsage);
                        }
                        lstLogs.AsParallel().ForAll(x => ItemModel.Delete<Log>(x));
                        lstStorage.AsParallel().ForAll(x => ItemModel.Delete<Storage>(x));
                        ItemModel.Delete<Commodity>(commodity);
                        ItemModel.CommitTransaction();
                    }
                }

                cmbDeleteCategory.SelectedIndex = -1;
            }
        }

        private void btnConfirmReset_Click( object sender, EventArgs e )
        {
            cmbDeleteCategory.SelectedIndex = -1;
        }
    }
}
