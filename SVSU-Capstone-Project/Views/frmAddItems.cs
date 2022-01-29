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
    public partial class frmAddItems : Form
    {
        public frmAddItems()
        {
            InitializeComponent();
        }

        private void frmAddItems_Load(object sender, EventArgs e)
        {

        }

        private void btnManageLocations_Click(object sender, EventArgs e)
        {

        }

        private void PageController(object sender, EventArgs e)
        {
            //Instantiate two forms (old and new)
            Form oldF = ActiveMdiChild, newF = null;

            //If a child (old) form already exists
            if (oldF != null)
            {
                //Don't do anything if the child is already open
                if (newF.Name == oldF.Name)
                {
                    return;
                }

                //Close the current form
                oldF.Close();
            }

            //Show new child form
            newF.MdiParent = this;
            newF.FormBorderStyle = FormBorderStyle.None;
            newF.Show();
            newF.Location = new Point(0, 0);
            newF.Size = new Size(971, 492);
        }

        private void chkMultipleLocations_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMultipleLocations.Checked)
            {
                cmbLocation.Visible = false;
                cmbCabinet.Enabled = false;
                btnManageLocations.Visible = true;
            }
            else
            {
                cmbLocation.Visible = true;
                cmbCabinet.Enabled = true;
                btnManageLocations.Visible = false;
            }
        }

        private void chkNLevel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNLevel.Checked)
            {
                cmbNLevel.Enabled = true;
            }
            else
            {
                cmbNLevel.Enabled = false;
            }
        }
    }
}
