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
          /* Function: frmLogin
         * -----------------------------------------------------------------------------
         * Description: Initializes the form on program load.
         * -----------------------------------------------------------------------------
         */
            InitializeComponent();
            
        }


        private void btnLogin_Click( object sender, EventArgs e )
        {
                /* Function: btnLogin_Click
            * -----------------------------------------------------------------------------
            * Description: Upon the Login button click, validate the entered credentials.
            * If both the userID and password fields are filled out and authenticate,
            * log the user into the application with those credentials.
            * -----------------------------------------------------------------------------
            *  Parameter Dictionary (in parameter order):  
            *  EventArgs e; Information passed by the sender object about the method call.
            * object sender; The object calling the method. btnLogin in this case.
            * -----------------------------------------------------------------------------
            * Local Variables
            * User user; Holds potential user data to match a login with the user storage.
            * String userEmail; Checks if the user's attempted login only contains the username, not the full email. Adds the email domain if missing.
            */

            //Get rid of errorprovider
            erpLoginForm.Clear();

            User user;

            //Use Authentication ViewModel to check user's ID/password combination
            try
            {
                //Check for @ in the login (note: if domain is not svsu, this will not work)
                string userEmail = txtEmail.Text.Trim();
                if (!userEmail.Contains("@"))
                {
                    userEmail += "@svsu.edu";
                }
                
                //Get user
                user = Authentication.Authenticate(userEmail, txtPassword.Text);
                                
                //If user isn't admin and somehow got this far, don't let them login
                if(user.blnIsAdmin == false)
                {
                    //Set user back to null
                    Authentication.ActiveUser = null;
                    throw new UserNotFoundException("Must be admin to login");
                }
                //If user is flagged to change password
                else if (user.blnPwdReset == true)
                {
                    var f = new frmSetPassword();
                    DialogResult result = f.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        //Set user password
                        user.strHash = frmSetPassword.strHash;
                        user.blnPwdReset = false;

                        //Save user
                        ItemModel.Update<User>(user);
                        
                        //Alert user
                        MessageBox.Show("Password Set Successfully", "Alert");
                    }
                    else
                    {
                        txtPassword.Text = "";
                        txtEmail.Text = "";
                        return;
                    }
                }
                else if(user != null)
                {
                    Log log = new Log
                    {
                        enuAction = ItemAction.UserLogin,
                        dtTimestamp = DateTime.Now,
                        intQuantityChange = 0,
                        objStorage = null,
                        objUser = Authentication.ActiveUser,
                        strNotes = $"{Authentication.ActiveUser} logged into the system on {DateTime.Now}."
                    };
                    ItemModel.Add<Log>(log);
                    var homeLoad = new frmHome();
                    homeLoad.populateTables();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "No Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (UserNotFoundException ex)
            {
                erpLoginForm.SetError(txtEmail, ex.Message);
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
                /* Function: btnCancel_Click
           * -----------------------------------------------------------------------------
           * Description: Closes the application upon clicking the cancel button from the login form.
           * -----------------------------------------------------------------------------
           * Parameter Dictionary (in parameter order):  
           * EventArgs e; Information passed by the sender object about the method call.
           * object sender; The object calling the method. btnCancel in this case.
           */

            //Close form
            Close();
        }


        private void txtUsername_Click( object sender, EventArgs e )
        {
            /* Function: txtUsername_Click
             * Description: Clears the error asking for the user to enter a UserID if it is showing.
             * -----------------------------------------------------------------------------
             * Parameter Dictionary (in parameter order):  
             * EventArgs e; Information passed by the sender object about the method call.
             * object sender; The object calling the method. txtUsername in this case.
             */

            //Clear the error provider
            erpLoginForm.Clear();
        }

        private void txtPassword_Click( object sender, EventArgs e )
        {
            /* Function: txtPassword_Click
         * -----------------------------------------------------------------------------
         * Description: Clears the error asking for the user to enter a password if it is showing.
         * -----------------------------------------------------------------------------
         * Parameter Dictionary (in parameter order):
         * EventArgs e; Information passed by the sender object about the method call.
         * object sender; The object calling the method. txtPassword in this case.            
         */

            //Clear the error provider
            erpLoginForm.Clear();
        }

        private void frmLogin_KeyPress( object sender, KeyPressEventArgs e )
        {
            if (e.KeyChar == (char)13)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
