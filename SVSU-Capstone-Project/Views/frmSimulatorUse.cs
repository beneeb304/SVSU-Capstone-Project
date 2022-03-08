using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVSU_Capstone_Project.Model;
using SVSU_Capstone_Project.ViewModel;

namespace SVSU_Capstone_Project.Views
{
    public partial class frmSimulatorUse : Form
    {
        public frmSimulatorUse()
        {
            InitializeComponent();
            //tbcSimulatorUse_SelectedIndexChanged(null, null);
        }

        private void frmSimulatorUse_Load( object sender, EventArgs e )
        {

        }

        private void tbcSimulatorUse_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tbcSimulatorUse.SelectedTab.Name)
            {
                case "tbpSimulatorUse":
                    cmbSimulatorName.DataSource = ItemModel.GetMany<SimulatorUse>().Where(x => x.objCommodity.objCategory.strName == "High Fidelity Simulator" || x.objCommodity.objCategory.strName == "Low Fidelity Simulator").ToList();
                    cmbSimulatorStudent.DataSource = ItemModel.GetMany<User>().ToList();
                    break;
            }
        }

    }
}
