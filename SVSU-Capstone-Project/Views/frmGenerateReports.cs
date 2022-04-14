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

        /* Function: frmGenerateReports_Load
         * Description: Sets the selected beginning and end dates to text to display to the user.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void frmGenerateReports_Load( object sender, EventArgs e )
        {
            //Load data for first tab
            tbcReports_SelectedIndexChanged(sender, e);
        }


        public void tbcReports_SelectedIndexChanged( object sender, EventArgs e )
        {
            switch (tbcReports.SelectedTab.Name)
            {
                case "tabActivityLog":
                    // TODO: This line of code loads data into the 'invDbDataset1.Logs' table. You can move, or remove it, as needed.
                    this.logsTableAdapter.Fill(this.invDbDataSet1.Logs);

                    //Set Activity Log page margins and orientation to display all data when report is printed.
                    System.Drawing.Printing.PageSettings activityLog = new System.Drawing.Printing.PageSettings();
                    activityLog.Landscape = true;
                    activityLog.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
                    reportViewer1.SetPageSettings(activityLog);

                    this.reportViewer1.RefreshReport();
                    break;
                case "tabSimulatorUse":

                    // TODO: This line of code loads data into the 'invDbDataSet1.SimulatorUse' table. You can move, or remove it, as needed.
                    this.simulatorUseTableAdapter1.Fill(this.invDbDataSet1.SimulatorUse);

                    //Set Simulator uses page margins and orientation to display all data when report is printed.
                    System.Drawing.Printing.PageSettings simulatorUses = new System.Drawing.Printing.PageSettings();
                    simulatorUses.Landscape = true;
                    simulatorUses.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
                    reportViewer2.SetPageSettings(simulatorUses);

                    this.reportViewer2.RefreshReport();
                    break;
                case "tabLowStock":

                    // TODO: This line of code loads data into the 'invDbDataSet1.LowStock' table. You can move, or remove it, as needed.
                    this.lowStockTableAdapter.Fill(this.invDbDataSet1.LowStock);

                    this.reportViewer3.RefreshReport();
                    break;
                case "tabDynamicItems":

                    // TODO: This line of code loads data into the 'invDbDataSet1.DynamicItemsTable' table. You can move, or remove it, as needed.
                    this.dynamicItemsTableAdapter.Fill(this.invDbDataSet1.DynamicItemsTable);

                    //Set Dynamic Items page margins and orientation to display all data when report it printed.
                    System.Drawing.Printing.PageSettings dynamicItems = new System.Drawing.Printing.PageSettings();
                    dynamicItems.Landscape = true;
                    dynamicItems.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
                    reportViewer4.SetPageSettings(dynamicItems);

                    this.reportViewer4.RefreshReport();
                    break;
            }
        }
    }
}
//Lamar, is there a way to make this page load faster? -Everyone, especially Ben
//Dear Everyone, you could have easily created the reports for them in whatever way you guys wanted, yet no one offered to help with them, but there is a lot of opinions out there... Interesting. -Lamar
