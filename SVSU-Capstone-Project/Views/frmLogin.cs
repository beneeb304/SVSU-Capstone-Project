using SVSU_Capstone_Project.Model;
using SVSU_Capstone_Project.ViewModel;
using System;
using System.Windows.Forms;

namespace SVSU_Capstone_Project.Views
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click( object sender, EventArgs e )
        {
            User user;
            //Use Authentication ViewModel to check user's ID/password combination
            try
            {
                user = Authentication.Authenticate(txtSVSU_ID.Text, txtPassword.Text);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "No Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (UserNotFoundException ex)
            {
                erpLoginForm.SetError(txtSVSU_ID, ex.Message);
                return;
            }
            catch (PasswordInvalidException ex)
            {
                erpLoginForm.SetError(txtPassword, ex.Message);
                return;
            }
            erpLoginForm.Clear();

            //Close the form
            Close();
        }
        private void btnCancel_Click( object sender, EventArgs e )
        {
            //Close application
            Application.Exit();
        }

        private void txtSVSU_ID_Focused( object sender, EventArgs e )
        {
            //Clear the error provider
            erpLoginForm.Clear();
        }

        private void txtPassword_Focused( object sender, EventArgs e )
        {
            //Clear the error provider
            erpLoginForm.Clear();
        }

        private void btnBypass_Click( object sender, EventArgs e )
        {

            if(Authentication.SecurityBypass())
            {
                Close();
            }
            else
            {
                MessageBox.Show("Security Bypass Failed: Cannot contact DB", "Security Bypass Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
