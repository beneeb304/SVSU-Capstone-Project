﻿using SVSU_Capstone_Project.Views;
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
        //Global variables
        public static string strUsername;

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

            //Instantiate login screen
            Form FrmLogin = new frmLogin();

            //Show as a dialog so code will not continue until the form is closed
            FrmLogin.ShowDialog();

            //Check if the user somehow closed the login form
            if(strUsername == null)
            {
                //Close the application
                Application.Exit();
            }

            //Set username in label
            lblUser.Text = "User: " + strUsername;

            //Set user login time and current time
            lblLoggedInTime.Text = "Logged in since " + DateTime.Now.ToString("hh:mm:ss tt MM/dd/yyyy");
            lblDateTime.Text = DateTime.Now.ToString("hh:mm:ss tt MM/dd/yyyy");

            //Start time timer
            tmrTime.Start();

            //Set this form as an MDI parent
            IsMdiContainer = true;
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
                    break;
                case "msiAddItems":
                    newF = new frmAddItems();
                    break;
                case "msiManageInventory":
                    newF = new frmManageInventory();
                    break;
                case "msiGenerateReports":
                    newF = new frmCheckInOutItems();
                    break;           
                case "msiPrintBarcodes":
                    newF = new frmPrintBarcodes();
                    break;
                case "msiCheckInOutItems":
                    newF = new frmCheckInOutItems();
                    break;
                case "msiSettings":
                    newF = new frmSettings();
                    break;
                case "msiSettingsUsers":
                    newF = new frmSettingsUsers();
                    break;
                case "msiSettingsLocations":
                    newF = new frmSettingsLocations();
                    break;
                case "msiSettingsCabinets":
                    newF = new frmSettingsCabinets();
                    break;
                case "msiSettingsCategories":
                    newF = new frmSettingsCategories();
                    break;
                case "msiSettingsVendors":
                    newF = new frmSettingsVendors();
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
            newF.Size = new Size(971, 492);
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            //Set time and date
            lblDateTime.Text = DateTime.Now.ToString("hh:mm:ss tt MM/dd/yyyy");
        }
    }
}