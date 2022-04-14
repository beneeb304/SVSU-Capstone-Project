using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace SVSU_Capstone_Project.Views
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            /* Function: frmSplash
             * -----------------------------------------------------------------------------
            * Description: Initializes splash screen the form on program load.
            * -----------------------------------------------------------------------------
            */
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            /* Function: frmSplash_Load
             * -----------------------------------------------------------------------------
             * Description: Start the splash screen 
             * -----------------------------------------------------------------------------
             * Parameter Dictionary (in parameter order):  
             * EventArgs e; Information passed by the sender object about the method call.
             * object sender; The object calling the method. 
             */
            tmrSplash.Start();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            /* Function: tmrSplash_Tick
            * -----------------------------------------------------------------------------
            * Description: Closes the splash screen when appropriate
            * -----------------------------------------------------------------------------
            * Parameter Dictionary (in parameter order):  
            * EventArgs e; Information passed by the sender object about the method call.
            * object sender; The object calling the method. 
            */
    
            //Close splash screen
            Close();
        }

        //Gotta have a little fun right? ;)
        //Here is another easter egg
        private void pcbSplash_DoubleClick( object sender, EventArgs e )
        {
            tmrSplash.Interval = 6000;
            _ = HeHe(pcbSplash);
        }

        public static async Task HeHe( PictureBox pcbHeHe )
        {
            await Task.Run(() =>
            {
                pcbHeHe.Image = Properties.Resources.ea;
            });
        }
    }
}
