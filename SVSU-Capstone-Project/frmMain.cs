﻿using SVSU_Capstone_Project.Model;
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
          /* Function: frmMain
           * Description: Initializes the form on program load.
           */
            InitializeComponent();
        }

        /* Function: frmMain_Load
         * Description: Shows the splash screen on load and calls the method to begin
         * a new login. Sets the main form to a MDI parent.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
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

            // Initiate Barcode Scanner object once logged in so barcodes can be used
            barcodeScanner = new BarcodeScanner();


            PageController(msiHome as ToolStripMenuItem, null);
        }

        /* Function: InitiateLogin
         * Description: Initiates frmLogin to start a new login.
         * Once logged in, set the logged in user's information onto the form.
         * Start a timer to indicate login time.
         * 
         * Local Variables
         * Form frmLogin; Login form. Passes user information back if successful.
         */
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

                //Don't let program continue here (which it does for some reason)
                return;
            }

            //Set username in label
            lblUser.Text = "User: " + Authentication.ActiveUser.strFirst_name;

            //Set user login time and current time
            lblLoggedInTime.Text = "Logged in since " + DateTime.Now.ToString("hh:mm:ss tt MM/dd/yyyy");
            lblDateTime.Text = DateTime.Now.ToString("hh:mm:ss tt MM/dd/yyyy");

            //Start time timer
            tmrTime.Start();

        }

        /* Function: PageController
         * Description: Brings up child forms within the main form's window when their
         * respective options are selected.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         * Form oldF; Stores the previous child form.
         * Form newF; Stores the new child form.
         * ToolStripMenuItem sender; Menu options for the user to select from.
         */
        private void PageController(object sender, EventArgs e)
        {
            //Instantiate two forms (old and new)
            Form oldF = ActiveMdiChild, newF = null;

            //Assign correct child form (to the new form) based on clicked menu item
            switch ((sender as ToolStripMenuItem).Name.ToString())
            {
                case "msiHome":
                    newF = new frmHome();
                    this.Text = "Saginaw Valley Nursing Inventory System | Home";
                    break;
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
                case "msiCheckInOutItems":
                    // If this is called from a barcode scan, pass the CheckedItem
                    // then clear the barcode's variables.
                    if (barcodeScanner.checkedItem != null)
                    {
                        //newF = new frmCheckInOutItems(barcodeScanner.checkedItem);
                        barcodeScanner.resetValues();
                    }
                    else
                    {
                        newF = new frmCheckInOutItems();                 
                    }
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
                    // If frmCheckInOutItems already exists but is called again
                    // due to barcode scan, reopen it so it can accept the scan.
                    if (!(oldF is frmCheckInOutItems))
                    {
                        return;
                    }
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

        /* Function: tmrTime_Tick
         * Description: Ticks the timer representing login time.
         * Updates the time to the user.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            //Set time and date
            lblDateTime.Text = DateTime.Now.ToString("hh:mm:ss tt MM/dd/yyyy");
        }

        /* Function: btnLogout_Click
         * Description: Restarts the application when a logout is initiated.
         * 
         * Local Variables
         * object sender; The object calling the method.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Alert", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
                //Restart the program
                Application.Restart();
        }

        /* Function: frmMain_KeyDown
         * Description: When specific values, @ followed by a string finishing with Enter, are entered anywhere in the form,
         * within a short amount of time, it is considered a barcode scan. A barcode scan looks for the specific item then
         * brings up that item in the CheckIn/Out form. 
         * 
         * Local Variables
         * BarcodeScanner barcodeScanner; Made global instead so it can be used anytime the program is open.
         * object sender; The object calling the method.
         * KeyEventArgs e; Message sent by the key object pressed.
         * CheckedItem checkedItem; Represents the item located by scanning a barcode.
         */
        public BarcodeScanner barcodeScanner;
        private void frmMain_KeyDown( object sender, KeyEventArgs e )
        {
            // When @ is entered by the keyboard (occurs at start of a scan), prepare for the scan.
            if (barcodeScanner.isSeqStart(e.KeyValue))
            {
                barcodeScanner.beginScan(); 
            }

            // Check if the barcodeScanner object reflects that a scan is happening.
            else if (barcodeScanner.isStartRead())
            {
                // Any key entered by the keyboard between 0-9 or A-Z is added to the barcode string.
                // Numbers need to be trimmed otherwise the letter D is put before them.
                // 40-49 are standard number keys, 96-105 are number pad number keys.
                if ((e.KeyValue >= 40 && e.KeyValue <= 49) || (e.KeyValue >= 96 && e.KeyValue <= 105))
                {
                    barcodeScanner.addToCode(e.KeyCode.ToString().Substring(1));
                }  
                else if (e.KeyValue >= 65 && e.KeyValue <= 90)
                {
                    barcodeScanner.addToCode(e.KeyCode.ToString());
                }
                
                // If Enter is entered within 50 milliseconds of the scan beginning, locate the CheckedItem based on barcode ID.
                // The barcode scanner enters the entire string read in very quickly, taking longer indicates it was likely not a scan.
                else if (e.KeyCode == Keys.Enter && (DateTime.Now.Millisecond - barcodeScanner.getBeginTime()) < 50)
                {
                    PageController(msiCheckInOutItems as ToolStripMenuItem, e);
                }

                // If the potential scan took too long for the entry to be by barcode scanner, reset the read information.
                else if ((DateTime.Now.Millisecond - barcodeScanner.getBeginTime()) > 50)
                {
                    barcodeScanner.resetValues();
                }
            }
        }
    }
}
