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
            calBegin.Visible = true;
            calEnd.Visible = false;
        }

        private void calBegin_DateChanged( object sender, DateRangeEventArgs e )
        {
            txtBeginDate.Text = calBegin.SelectionStart.ToString();
        }

        private void pcbCalEnd_Click( object sender, EventArgs e )
        {
            calBegin.Visible = false;
            calEnd.Visible = true;
        }

        private void calEnd_DateChanged( object sender, DateRangeEventArgs e )
        {
            txtEndDate.Text = calEnd.SelectionStart.ToString();
        }

        private void frmGenerateReports_Load( object sender, EventArgs e )
        {
            txtBeginDate.Text = calBegin.SelectionStart.ToString();
            txtEndDate.Text = calEnd.SelectionStart.ToString();
            
        }

        private void btnReportClear_Click( object sender, EventArgs e )
        {
            calBegin.SelectionStart = calBegin.TodayDate;
            calEnd.SelectionStart = calEnd.TodayDate;
        }
    }
}
