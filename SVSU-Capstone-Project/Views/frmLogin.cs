using SVSU_Capstone_Project.Model;
using SVSU_Capstone_Project.ViewModel;
using System;
using System.Windows.Forms;

namespace SVSU_Capstone_Project.Views
{
    public partial class frmLogin : Form
    {
        /* Function: frmLogin
         * Description: Initializes the form on program load.
         */
        public frmLogin()
        {
            InitializeComponent();
        }

        /* Function: btnLogin_Click
         * Description: Upon the Login button click, validate the entered credentials.
         * If both the userID and password fields are filled out and authenticate,
         * log the user into the application with those credentials.
         * 
         * Local Variables
         * object sender; The object calling the method. btnLogin in this case.
         * EventArgs e; Information passed by the sender object about the method call.
         * Authentication user; Sends the login credentials to the database to check for a match.
         */
        private void btnLogin_Click( object sender, EventArgs e )
        {
            User user;

            //Use Authentication ViewModel to check user's ID/password combination
            try
            {
                //Get user
                user = Authentication.Authenticate(txtSVSU_ID.Text, txtPassword.Text);

                //If user is flagged to change password
                if (user.strHash == "Capstone2022")
                {
                    var f = new frmSetPassword();
                    DialogResult result = f.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        //Set user password
                        user.strHash = frmSetPassword.strHash;

                        //Save user
                        ItemModel.Update<User>(user);
                        
                        //Alert user
                        MessageBox.Show("Password Set Successfully", "Alert");
                    }
                    else
                    {
                        txtPassword.Text = "";
                        txtSVSU_ID.Text = "";
                        return;
                    }
                }
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

        /* Function: btnCancel_Click
         * Description: Closes the application upon clicking the cancel button from the login form.
         * 
         * Local Variables
         * object sender; The object calling the method. btnCancel in this case.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void btnCancel_Click( object sender, EventArgs e )
        {
            //Close application
            Application.Exit();
        }

        /* Function: txtUsername_Click
         * Description: Clears the error asking for the user to enter a UserID if it is showing.
         * 
         * Local Variables
         * object sender; The object calling the method. txtUsername in this case.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void txtUsername_Click( object sender, EventArgs e )
        {
            //Clear the error provider
            erpLoginForm.Clear();
        }

        /* Function: txtPassword_Click
         * Description: Clears the error asking for the user to enter a password if it is showing.
         * 
         * Local Variables
         * object sender; The object calling the method. txtPassword in this case.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void txtPassword_Click( object sender, EventArgs e )
        {
            //Clear the error provider
            erpLoginForm.Clear();
        }

        /* Function: btnBypass_Click
         * Description: Here for development testing to get around entering credentials.
         * To be removed.
         * 
         * Local Variables
         * object sender; The object calling the method. btnBypass in this case.
         * EventArgs e; Information passed by the sender object about the method call.
         */
        private void btnBypass_Click( object sender, EventArgs e )
        {
            if (Authentication.SecurityBypass())
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
