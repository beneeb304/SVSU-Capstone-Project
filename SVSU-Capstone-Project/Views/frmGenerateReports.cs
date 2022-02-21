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
    public partial class frmGenerateReports : Form
    {
        public frmGenerateReports()
        {
            InitializeComponent();
        }

        private void pcbCalBegin_Click( object sender, EventArgs e )
        {
          
        }

        private void calBegin_DateChanged( object sender, DateRangeEventArgs e )
        {
           
        }

        private void pcbCalEnd_Click( object sender, EventArgs e )
        {
           
        }

        private void calEnd_DateChanged( object sender, DateRangeEventArgs e )
        {
            
        }

        private void frmGenerateReports_Load( object sender, EventArgs e )
        {
            // TODO: This line of code loads data into the 'invDbDataSet1.Logs' table. You can move, or remove it, as needed.
            this.simulatorUseTableAdapter.Fill(this.invDbDataSet1.SimulatorUse);
            this.logsTableAdapter.Fill(this.invDbDataSet1.Logs);
            
            this.reportViewer1.RefreshReport();

            this.reportViewer2.RefreshReport();
        }

        private void btnReportClear_Click( object sender, EventArgs e )
        {
            
        }

        private void reportViewer1_Load( object sender, EventArgs e )
        {

        }

        private void logsBindingSource_CurrentChanged( object sender, EventArgs e )
        {

        }

        private void simulatorUseBindingSource_CurrentChanged( object sender, EventArgs e )
        {

        }
    }
}
