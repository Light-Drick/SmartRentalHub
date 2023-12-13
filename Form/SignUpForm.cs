using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//firebase
/*using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
*/

using GoogleApi.Entities.Translate.Detect.Response;
using Google.Type;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SmartRentalHub
{
    public partial class SignUpForm : Form
    {
        #region ConnectionToFirebaseDatabase
       /* IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "SeWHh7b6gcCV2QZqk5vVa3t3gX72UaAxKdjLI9FW",
            BasePath = "https://smartrental-hub-default-rtdb.firebaseio.com/"

        };

        IFirebaseClient client;
       */
        #endregion

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #region Clear
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

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            LogInForm login = new LogInForm();
            login.ShowDialog();
            this.Hide();
            Close();
        }


        private async void SignUpBtn_Click(object sender, EventArgs e)
        {
            #region firestore
            var db = FirestoreHelper.database;

            if (await CheckIfUserAlreadyExistAsync ())
            {
                MessageBox.Show("Username already exists!");
                
            }

            else
            {
                var data = GetWriteData();
                DocumentReference docRef = db.Collection("UserData").Document(data.Username);
                await docRef.SetAsync(data);
                MessageBox.Show("Success");

                return;
            }
            #endregion

            #region database
            /*try
            {
                var userdata = new UserData
                {
                    Firstname = FirstNameTbx.Text,
                    Lastname = LastNameTbx.Text,
                    PhoneNumber = PhoneNumberTbx.Text,
                    Email = EmailTbx.Text,
                    Password = PasswordTbx.Text,
                    Username = UsernameTbx.Text,
                };

                // Check if all fields are filled
                if (string.IsNullOrWhiteSpace(userdata.Firstname) ||
                    string.IsNullOrWhiteSpace(userdata.Lastname) ||
                    string.IsNullOrWhiteSpace(userdata.PhoneNumber) ||
                    string.IsNullOrWhiteSpace(userdata.Email) ||
                    string.IsNullOrWhiteSpace(userdata.Password) ||
                    string.IsNullOrWhiteSpace(userdata.Username))
                    MessageBox.Show("You need to fill up everything!");
                

                else
                {
                    // Check if username is already taken
                    if (await CheckIfUserAlreadyExistAsync())
                    {
                        MessageBox.Show("Username is already taken!");
                    }
                    else
                    {
                        SetResponse registrationResponse = await client.SetTaskAsync("User Profile/" + UsernameTbx.Text, userdata);
                        UserData result = registrationResponse.ResultAs<UserData>();
                        MessageBox.Show(result.Username + " is registered now!");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or show a message box
                MessageBox.Show("An error occurred: " + ex.Message);
            }*/
            #endregion
        }


        //firestore
         private UserData GetWriteData()
         {

             string firstname = FirstNameTbx.Text.Trim();
             string lastname = LastNameTbx.Text.Trim();
             string username = UsernameTbx.Text.Trim();
             string password = Security.Encrypt(PasswordTbx.Text);
             string phoneNumber = PhoneNumberTbx.Text.Trim();
             string email = EmailTbx.Text.Trim();
             string address = AddressTbx.Text.Trim();   

             return new UserData()
             {
                 Username = username,
                 Password = password,
                 Email = email,
                 Firstname = firstname,
                 Lastname = lastname,
                 PhoneNumber = phoneNumber,
                 Address = address
             };
         }




        private async Task<bool> CheckIfUserAlreadyExistAsync()
        {
            string username = UsernameTbx.Text.Trim();

            var db = FirestoreHelper.database;

            DocumentReference docRef = db.Collection("UserData").Document(username);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                return true;
            }
            return false;
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            //firebase
            /*client = new FireSharp.FirebaseClient(config);

            if (client != null)
                MessageBox.Show("Connection is good");

            else
                MessageBox.Show("Connection is not good");
            */
        }
    }

}
