using SVSU_Capstone_Project.Model;
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
           * -----------------------------------------------------------------------------
           * Description: Initializes the form on program load.
           * -----------------------------------------------------------------------------
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
            /* Function: frmMain_Load
           * -----------------------------------------------------------------------------
           * Description: Once the program is booted up it will call the splash screen and 
           * initiate the login screen and set the form as the MDI parent
           * -----------------------------------------------------------------------------
           *  Parameter Dictionary (in parameter order):  
           *  EventArgs e; Information passed by the sender object about the method call.
           *  object sender; The object calling the method.
           * -----------------------------------------------------------------------------
           * Local Variables
           * FrmSplash; New splash screen container.
           */


            //Instantiate splash screen
            Form FrmSplash = new frmSplash();

            //Show as a dialog so code will not continue until the form is closed
            FrmSplash.ShowDialog();

            //Start login process
            InitiateLogin();

            //Set this form as an MDI parent
            IsMdiContainer = true;
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
            /* Function: InitiateLogin
             * -----------------------------------------------------------------------------
             * Description: This function is used to instantiate and call the login screen upon 
             * startup of the program.
             * -----------------------------------------------------------------------------
             *  Parameter Dictionary (in parameter order):  
             * -----------------------------------------------------------------------------
             * Local Variables
             * FrmLogin; New Login form container.
             */

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
            /* Function: PageController
           * -----------------------------------------------------------------------------
           * Description: This function is used to assigne the correct child form to the new
           * formed based on the clicked menu button. 
           * -----------------------------------------------------------------------------
           *  Parameter Dictionary (in parameter order):  
           *   EventArgs e; Information passed by the sender object about the method call.
           * object sender; The object calling the method.
           * -----------------------------------------------------------------------------
           * Local Variables
           * newF; New MDI form
           * oldF; Old MDI form (active form).
           */

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
                    if (!Authentication.ActiveUser.blnIsAdmin)
                    {
                        MessageBox.Show("Must be an admin to access settings!", "Alert");
                        return;
                    }
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
            /* Function: tmrTime_Tick
            * -----------------------------------------------------------------------------
            * Description: This function is used to set the current time and date
            * -----------------------------------------------------------------------------
            *  Parameter Dictionary (in parameter order):  
            *   EventArgs e; Information passed by the sender object about the method call.
            * object sender; The object calling the method. 
            * -----------------------------------------------------------------------------
            * Local Variables
            */

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
             /* Function: btnLogout_Click
             * -----------------------------------------------------------------------------
             * Description: This function is used to logout and restart the program
             * -----------------------------------------------------------------------------
             *  Parameter Dictionary (in parameter order):  
             *   EventArgs e; Information passed by the sender object about the method call.
             * object sender; The object calling the method. 
             * -----------------------------------------------------------------------------
             * Local Variables
             */
            
            //Restart the program
            Application.Restart();
        }
    }
}
