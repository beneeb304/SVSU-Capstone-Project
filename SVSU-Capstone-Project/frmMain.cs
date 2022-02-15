using SVSU_Capstone_Project.ViewModel;
using SVSU_Capstone_Project.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVSU_Capstone_Project
{
    public partial class frmMain : Form
    {              
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Instantiate splash screen
            Form FrmSplash = new frmSplash();

            //Show as a dialog so code will not continue until the form is closed
            FrmSplash.ShowDialog();

            //Start login process
            InitiateLogin();

            //Set this form as an MDI parent
            IsMdiContainer = true;
        }

        private void InitiateLogin()
        {
            //Instantiate login screen
            Form FrmLogin = new frmLogin();

            //Show as a dialog so code will not continue until the form is closed
            FrmLogin.ShowDialog();

            //Check if the user somehow closed the login form
            if (Authentication.ActiveUser == null)
            {
                //Close the application
                Application.Exit();
            }

            //Set username in label
            lblUser.Text = "User: " + Authentication.ActiveUser.strFirst_name;

            //Set user login time and current time
            lblLoggedInTime.Text = "Logged in since " + DateTime.Now.ToString("hh:mm:ss tt MM/dd/yyyy");
            lblDateTime.Text = DateTime.Now.ToString("hh:mm:ss tt MM/dd/yyyy");

            //Start time timer
            tmrTime.Start();
        }

        private void PageController(object sender, EventArgs e)
        {
            //Instantiate two forms (old and new)
            Form oldF = ActiveMdiChild, newF = null;

            //Assign correct child form (to the new form) based on clicked menu item
            switch ((sender as ToolStripMenuItem).Name.ToString())
            {
                case "msiViewInventory":
                    newF = new frmViewInventory();
                    this.Text = "Saginaw Valley Nursing Inventory System | View Inventory";
                    break;
                case "msiManageInventory":
                    newF = new frmManageInventory();
                    this.Text = "Saginaw Valley Nursing Inventory System | Manage Inventory";
                    break;
                case "msiGenerateReports":
                    newF = new frmGenerateReports();
                    this.Text = "Saginaw Valley Nursing Inventory System | Generate Reports";
                    break;
                case "msiPrintBarcodes":
                    newF = new frmPrintBarcodes();
                    this.Text = "Saginaw Valley Nursing Inventory System | Print Barcodes";
                    break;
                case "msiCheckInOutItems":
                    newF = new frmCheckInOutItems();
                    this.Text = "Saginaw Valley Nursing Inventory System | Check In/Out Items";
                    break;
                case "msiSettings":
                    newF = new frmSettings();
                    this.Text = "Saginaw Valley Nursing Inventory System | Settings";
                    break;
            }

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
            newF.Location = new Point(0,0);
            newF.Size = new Size(969, 490);
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            //Set time and date
            lblDateTime.Text = DateTime.Now.ToString("hh:mm:ss tt MM/dd/yyyy");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Restart the program
            Application.Restart();
        }
    }
}
