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

        /* Function: btnUseCancel_Click
         * Description: Clears all fields on the user commodity page when cancel is clicked.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void btnUseCancel_Click( object sender, EventArgs e )
        {
            //Clear all fields on Use tab
            cmbUseCategory.SelectedIndex = -1;
            nudUseDeduct.Value = 0;
        }

        private void btnUse_Click( object sender, EventArgs e )
        {
            //Check if all fields are filled out
            if (cmbUseCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ItemModel.UseItem(ItemModel.Get<Storage>(x =>
               x.objCabinet == (cmbUseCabinet.SelectedItem as Cabinet) &&
               x.objCommodity == (cmbUseCommodity.SelectedItem as Commodity) &&
               x.objNLevel == (cmbUseNLevel.SelectedItem as NLevel)),
                Authentication.ActiveUser,
                Convert.ToUInt32(nudUseDeduct.Value),
                "Item Used via Manage Inventory Tab"
            );

        }

        /* Function: cmbUseCategory_SelectedValueChanged
         * Description: Reflects the datasource of the fields on the use page when a category is selected.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void cmbUseCategory_SelectedValueChanged( object sender, EventArgs e )
        {
            Category_SelectedValueChanged(cmbUseCategory, cmbUseCommodity);
        }

        /* Function: cmbUseCommodity_SelectedValueChanged
         * Description:
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void cmbUseCommodity_SelectedValueChanged( object sender, EventArgs e )
        {
            Commodity_SelectedValueChanged(cmbUseCommodity, cmbUseRoom);
        }

        private void cmbUseRoom_SelectedValueChanged( object sender, EventArgs e )
        {
            Room_SelectedValueChanged(cmbUseRoom, cmbUseCabinet, cmbUseCabinet);
        }

        /* Function: cmbUseCabinet_SelectedValueChanged
         * Description:
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void cmbUseCabinet_SelectedValueChanged( object sender, EventArgs e )
        {
            Cabinet_SelectedValueChanged(cmbUseCabinet, cmbUseCommodity, cmbUseNLevel);
        }
        private void cmbUseNLevel_SelectedValueChanged( object sender, EventArgs e )
        {
            NLevel_SelectedValueChanged(cmbUseCommodity, cmbUseCabinet, cmbUseNLevel, txtUseAvailable, nudUseDeduct);
        }

        private void nudUseDeduct_ValueChanged( object sender, EventArgs e )
        {
            var remaining = Convert.ToInt32(txtUseAvailable.Text) - Convert.ToInt32(nudUseDeduct.Value);
            txtUseRemaining.Text = remaining.ToString();
        }
    }
}
