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
            cmbUseCabinet.SelectedIndex = -1;
            cmbUseCategory.SelectedIndex = -1;
            cmbUseCommodity.SelectedIndex = -1;
            cmbUseNLevel.SelectedIndex = -1;
            cmbUseRoom.SelectedIndex = -1;
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
            this.cmbUseCommodity.SelectedIndex = -1;
            this.cmbUseCommodity.DataSource = (cmbUseCategory.SelectedItem as Category).lstCommodities.OrderBy(x => x.strName).ToList();
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
            this.cmbUseRoom.DataSource = (cmbUseCommodity.SelectedItem as Commodity).lstStorage.Select(x => x.objCabinet.objRoom).OrderBy(x => x.strName).ToList();
            this.cmbUseRoom.SelectedIndex = -1;
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
            this.cmbUseNLevel.DataSource = (cmbUseCabinet.SelectedItem as Cabinet).lstStorage
                .Where(x => x.objCommodity == cmbUseCommodity.SelectedItem as Commodity)
                .Select(x => x.objNLevel)
                .Distinct()
                .OrderBy(x => x.strName)
                .ToList();
        }
        private void cmbUseNLevel_SelectedValueChanged( object sender, EventArgs e )
        {
            
        }
    }
}
