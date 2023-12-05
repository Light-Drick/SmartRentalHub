using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using SmartRentalHub.Class;


/*using FireSharp.Config;
using FireSharp.Interfaces;
*/using FireSharp.Response;

//using Firebase;

namespace SmartRentalHub
{
    public partial class LogInForm : Form
    {
        //firestore
        FirestoreDb db = FirestoreDb.Create("LMS1VyX1JR4htGVjwLf8");

        //database
        #region ConnectionToFirebaseDatabase
        /*IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "SeWHh7b6gcCV2QZqk5vVa3t3gX72UaAxKdjLI9FW",
            BasePath = "https://smartrental-hub-default-rtdb.firebaseio.com/"

        };

        IFirebaseClient client;
        */
        #endregion



        public LogInForm()
        {
            InitializeComponent();
           
        }



        private void LogInBtn_Click(object sender, EventArgs e)
        {
            #region Firestore 
            try
            {   // Check if the Enter key was pressed or the login button was clicked
                if (e is KeyPressEventArgs keyPressEventArgs && keyPressEventArgs.KeyChar == (char)Keys.Enter || e is EventArgs)
                {
                    string username = UsernameTbx.Text.Trim();
                    string password = PasswordTbx.Text;

                    var db = FirestoreHelper.database;

                    DocumentReference docRef = db.Collection("UserData").Document(username);
                    UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();

                    if (password != null)
                    {
                        if (data != null && password == Security.Decrypt(data.Password))
                        {
                            MessageBox.Show("Log in successful");
                            // Create an instance of the other form
                            HomeForm home = new HomeForm();

                            // Show the other form
                            home.Show();

                            this.Hide();

                            // After successful login
                            //MaintainUsername.Username["Username"] = "user's username";
                            MaintainUsername.Username = UsernameTbx.Text;

                        }
                    }
                    else
                        MessageBox.Show("Log in unsuccessful");
                }
            }
            catch
            {

                MessageBox.Show("Log in unsuccessful");
            }
        }

            #endregion
        

       


        private void ForgotPasswordBtn_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotpass = new ForgotPasswordForm();
            forgotpass.Show();
            this.Hide();
        }




        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            SignUpForm signup = new SignUpForm();
            this.Hide();

            signup.Show();


        }

        #region ClearBtn
        private void ClearTextBoxes()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = control as TextBox;
                    textBox.Clear();
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        #endregion

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void UsernameTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Call your login button click event handler
                LogInBtn_Click(sender, e);
            }
        }
    }
} 
