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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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

            PageController(msiHome as ToolStripMenuItem, null);


            //checking if user will be afk
            Thread trackerThread = new Thread(timerLogOut);
            trackerThread.Start();
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
            lblLoggedInTime.Text = "Login time: " + DateTime.Now.ToString("hh:mm:ss tt MM/dd/yyyy");
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









        /* Function: timerLogOut
         * Description: Logs you out of the application when you havent moved the mouse in awhile.
         * 
         * Local Variables
         * None
         */
        private void timerLogOut()
        {
            while(true)
            {
                int x = MousePosition.X;  
                int y = MousePosition.Y;

                

            }


        }


        private void Application_Idle(Object sender, EventArgs e )
        {
            MessageBox.Show("You are in the application.idle event");
        }












        private void pcbHeHe_DoubleClick( object sender, EventArgs e )
        {
            HeHe(pcbHeHe);
        }

        public static async Task HeHe(PictureBox pcbHeHe)
        {
            await Task.Run(() =>
            {
                pcbHeHe.Image = Properties.Resources.cardinal;
                Task.Delay(2000).Wait();
                pcbHeHe.Image = Properties.Resources.HeHe;
            });
            
        }
    }
}
//Hunter was here hehe XP
// Brett wasn't here :O
