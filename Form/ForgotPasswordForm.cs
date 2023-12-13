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


namespace SmartRentalHub
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void ForgotPasswordBtn_Click(object sender, EventArgs e)
        {
            //string email = EmailTbx.Text.Trim();

            // Send password reset email
            //SendPasswordResetEmail(email);
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            

        }

        /*private async void SendPasswordResetEmail(string email)
        {
            var auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
            try
            {
                await auth.SendPasswordResetEmailAsync(email);
                MessageBox.Show("Password reset email sent.");
            }
            catch (Firebase.Auth.FirebaseAuthException)
            {
                MessageBox.Show("Error sending password reset email.");
            }
        }*/

       
    }
}
