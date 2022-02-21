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
        /* Function: frmGenerateReports
         * Description: Initializes and launches the form.
         * 
         * No Local Variables
         */
        public frmGenerateReports()
        {
            InitializeComponent();
        }

        /* Function: pcbCalBegin_Click
         * Description: Sets calBegin to visible and calEnd to invisible.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void pcbCalBegin_Click( object sender, EventArgs e )
        {
          
        }

        /* Function: calBegin_DateChanged
         * Description: Sets the selected beginning date to text to display to the user.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * DateRangeEventArgs e; Information passed by the sender object about the method call.
         */
        private void calBegin_DateChanged( object sender, DateRangeEventArgs e )
        {
           
        }

        /* Function: pcbCalEnd_Click
         * Description: Sets calBegin to invisible and calEnd to visible.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void pcbCalEnd_Click( object sender, EventArgs e )
        {
           
        }

        /* Function: calEnd_DateChanged
         * Description: Sets the selected end date to text to display to the user.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void calEnd_DateChanged( object sender, DateRangeEventArgs e )
        {
            
        }

        /* Function: frmGenerateReports_Load
         * Description: Sets the selected beginning and end dates to text to display to the user.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void frmGenerateReports_Load( object sender, EventArgs e )
        {
            // TODO: This line of code loads data into the 'invDbDataSet1.Logs' table. You can move, or remove it, as needed.
            this.simulatorUseTableAdapter1.Fill(this.invDbDataSet1.SimulatorUse);
            this.logsTableAdapter.Fill(this.invDbDataSet1.Logs);
            
            this.reportViewer1.RefreshReport();

            this.reportViewer2.RefreshReport();
        }

        /* Function: btnReportClear_Click
         * Description: Sets the beginning and ending calendars to display today's date instead of previously selected.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
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
