using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVSU_Capstone_Project.Views
{
    public partial class frmManageInventory : Form
    {
        public frmManageInventory()
        {
            InitializeComponent();
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            //Clear all fields on Add tab
            cmbAddCabinet.SelectedIndex = -1;
            cmbAddCategory.SelectedIndex = -1;
            cmbAddCommodity.SelectedIndex = -1;
            cmbAddNLevel.SelectedIndex = -1;
            cmbAddRoom.SelectedIndex = -1;
            txtCurrentQty.Text = "";
            nudAddQty.Value = 1;
        }

        private void btnCreateCancel_Click(object sender, EventArgs e)
        {
            //Clear all fields on Create tab
        }

        private void btnDeleteCancel_Click(object sender, EventArgs e)
        {
            //Clear all fields on Delete tab
            cmbDeleteCabinet.SelectedIndex = -1;
            cmbDeleteCategory.SelectedIndex = -1;
            cmbDeleteCommodity.SelectedIndex = -1;
            cmbDeleteNLevel.SelectedIndex = -1;
            cmbDeleteRoom.SelectedIndex = -1;
        }

        private void chkDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelete.Checked)
            {
                cmbDeleteCabinet.SelectedIndex = -1;
                cmbDeleteNLevel.SelectedIndex = -1;
                cmbDeleteRoom.SelectedIndex = -1;
                cmbDeleteCabinet.Enabled = false;
                cmbDeleteNLevel.Enabled = false;
                cmbDeleteRoom.Enabled = false;
                lblDelete.Text = "Deleting this commodity will delete it from all rooms, cabinets, and NLevels. It's quantity MUST be zero before deleting.";
            }
            else
            {
                cmbDeleteCabinet.Enabled = true;
                cmbDeleteNLevel.Enabled = true;
                cmbDeleteRoom.Enabled = true;
                lblDelete.Text = "Deleting this commodity will delete it from the selected Room, Cabinet, Nurse Level.";
            }
        }
    }
}
