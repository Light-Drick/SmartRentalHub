using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SmartRentalHub
{
    public partial class ForgotPasswordForm : Form
    {
        private string userEmail;
        private string generatedCode;

        public ForgotPasswordForm()
        {
            InitializeComponent();
            BeginNewPassword(false);
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {


        }


        private async void SubmitBtn_Click(object sender, EventArgs e)
        {
            //string email = EmailTbx.Text.Trim();

            // Send password reset email
            //SendPasswordResetEmail(email);
            
            string email = EmailTbx.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email.");
                return;
            }

            var db = FirestoreDb.Create("smartrental-hub");


            var userRef = db.Collection("UserData").WhereEqualTo("Email", email);
            var querySnapshot = await userRef.GetSnapshotAsync();

            if (querySnapshot.Count == 0)
            {
                MessageBox.Show("User not found with this email.");
                return;
            }


            generatedCode = GenerateRandomCode();
            SendCodeToEmail(email, generatedCode);
            userEmail = email;

            Timer timer = new Timer();
            timer.Interval = 5 * 60 * 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            MessageBox.Show("Code sent successfully. Check your email.");
            BeginNewPassword(true);
        }

        private void ResetPassBtn_Click(object sender, EventArgs e)
        {
            string newPassword = EnterNewPassTbx.Text.Trim();
            string confirmNewPassword = ReEnterNewPassTbx.Text.Trim();

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmNewPassword))
            {
                MessageBox.Show("Please enter a new password and confirm it.");
                return;
            }

            // Check if the new password and confirm new password match.
            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("New password and confirm new password do not match.");
                return;
            }

            // Update the user's password in Firestore.
            var db = FirestoreDb.Create("smartrental-hub"); // Replace with your Firestore project ID.
            var userRef = db.Collection("UserData").WhereEqualTo("Email", userEmail);
            var querySnapshot = userRef.GetSnapshotAsync().Result;

            if (querySnapshot.Count == 0)
            {
                MessageBox.Show("User not found with this email.");
                return;
            }

            var user = querySnapshot.Documents[0].ConvertTo<UserData>();

            // Update the password without changing other fields.
            DocumentReference userDocRef = db.Collection("UserData").Document(user.Username);
            user.Password = Security.Encrypt(newPassword); // Assuming your custom encryption method is named "Encrypt."
            userDocRef.SetAsync(user);

            MessageBox.Show("Password reset successful.");
            this.Close();
            LogInForm login = new LogInForm();
            login.Show();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            LogInForm newLogin = new LogInForm();
            this.Hide();
            newLogin.Show();

        }

        private void BeginNewPassword(bool isVisible)
        {
            CodeLabel.Visible = isVisible;
            ActCodeTbx.Visible = isVisible;
            EnterPassLabel.Visible = isVisible;
            EnterNewPassTbx.Visible = isVisible;
            RenterNewPassLabel.Visible = isVisible;
            ReEnterNewPassTbx.Visible = isVisible;
            SubmitBtn.Visible = !isVisible;
            ResetPassBtn.Visible = isVisible;
        }

        private string GenerateRandomCode()
        {
            Random random = new Random();
            int code = random.Next(100000, 999999);
            return code.ToString();
        }

        private void SendCodeToEmail(string email, string code)
        {

            string yourEmail = "kyledowiromero@gmail.com";


            string yourAppPassword = "morw prqi gbyk domc";

            using (var client = new SmtpClient("smtp.gmail.com"))
            {
                client.Port = 587;
                client.Credentials = new NetworkCredential(yourEmail, yourAppPassword);
                client.EnableSsl = true;

                var message = new MailMessage(yourEmail, email)
                {
                    Subject = "Password Reset Code",
                    Body = $"Your password reset code is: {code} and is only available for 5 minutes"
                 
                };

                client.Send(message);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            MessageBox.Show("Code expired. Please request a new one.");
            ResetForm();
            BeginNewPassword(false);
        }

        private void ResetForm()
        {
            EmailTbx.Clear();
            userEmail = null;
            generatedCode = null;
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
