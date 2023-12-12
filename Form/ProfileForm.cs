using SmartRentalHub.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//firebase
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


using Firebase.Storage;
using Google.Cloud.Firestore;
using System.Security.Cryptography;


namespace SmartRentalHub
{
    public partial class PersonalinfoForm : Form
    {
        public event EventHandler GoBackToAccountForm;

        string username = MaintainUsername.Username;

        public PersonalinfoForm()
        {
            InitializeComponent();
            UsernameTbx.Text = username;
            Noteditmode();
            LoadUserProfileDetails();

            //FirestoreConnection();
            FirestoreHelper.SetEnvironmentVariable();
            AccountBtn.Click += AccountBtn_Click;


        }

        private void FirestoreConnection()
        {
            //FirestoreDb db = FirestoreDb.Create("LMS1VyX1JR4htGVjwLf8");
            //FirestoreHelper.SetEnvironmentVariable();
        }

        internal async Task<UserData> RetrieveUserProfile(string Username)
        {
            try 
            {
                // Connect to Firestore
                //var db = FirestoreHelper.database;

                // Get the user's document
                DocumentReference docRef = FirestoreHelper.database.Collection("UserData").Document(Username);
                DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

                if (snapshot.Exists)
                {
                    // Convert the DocumentSnapshot to a UserProfile object
                    UserData userdata = snapshot.ConvertTo<UserData>();
                    return userdata;
                }
                else
                {
                    Console.WriteLine("User does not exist!");
                    return null;
                }
            }
            
                 catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving user profile: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
                return null;
            }
        }
            

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            
            LoadUserProfileDetails();

        }
        
        private async void LoadUserProfileDetails()
        {
            //get user details in firestore
            UserData userdata = await RetrieveUserProfile(UsernameTbx.Text);

            // Check if userdata is not null before accessing its properties
            if (userdata != null)
            {
                // Update the form fields with the user profile details
                FirstNameTbx.Text = userdata.Firstname;
                LastNameTbx.Text = userdata.Lastname;
                AddressTbx.Text = userdata.Address;
                PhoneNumberTbx.Text = userdata.PhoneNumber;
                EmailTbx.Text = userdata.Email;



                // Load the profile picture
                var base64ProfilePic = userdata.ProfilePic;
                Console.WriteLine($"Retrieved base64ProfilePic: {base64ProfilePic}"); // to see if base64ProfilePic was retrieved in output
                
                if (!string.IsNullOrEmpty(base64ProfilePic))
                {
                    // Convert and display the profile picture
                    ConvertBase64ToImageAndDisplay(base64ProfilePic);
                }
                else
                {
                    // If no profile picture is set, display a default picture
                    ProfilePic.Image = Properties.Resources.default_pic;
                }
            }
            else
            {
                Console.WriteLine("User profile not found!");
            }
        }



       
        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image Files (*.jpg) | *.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(ofd.FileName);
                ProfilePic.Image = img.GetThumbnailImage(224, 148, null, new IntPtr());
            }
        }


        private void ConvertBase64ToImageAndDisplay(string base64String)
        {
            try
            {
                // Convert Base64 String to byte[]
                byte[] imageBytes = Convert.FromBase64String(base64String);

                // Create a MemoryStream from the byte array
                using (var ms = new MemoryStream(imageBytes))
                {
                    // Create an Image from the MemoryStream
                    Image image = Image.FromStream(ms);

                    // Display the Image in the ProfilePic PictureBox
                    ProfilePic.Image = image;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting base64 to image: {ex.Message}");
            }
        }



        private string ConvertImageToBase64(Image image)
        {
            if (image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Create a copy of the image to avoid potential issues
                    using (Bitmap copy = new Bitmap(image))
                    {
                        copy.Save(ms, ImageFormat.Jpeg);
                    }

                    byte[] imageBytes = ms.ToArray();

                    // Convert the byte array to a base64 string
                    return Convert.ToBase64String(imageBytes);
                }
            }
            return null;
        }
        //ProfilePic

        private async void UpdateDetails()
        {
            DocumentReference docref = FirestoreHelper.database.Collection("UserData").Document(UsernameTbx.Text);

            // Convert the profile picture to a base64 string
            string profilePicBase64 = ConvertImageToBase64(ProfilePic.Image);

            // Log the base64 string in output
            Console.WriteLine($"ProfilePicBase64: {profilePicBase64}");

            // Create a dictionary to store updated data
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"Firstname", FirstNameTbx.Text },
                {"Lastname", LastNameTbx.Text },
                {"Email", EmailTbx.Text },
                {"Address", AddressTbx.Text },
                {"PhoneNumber", PhoneNumberTbx.Text }


            }; 
            
            if (!string.IsNullOrEmpty(profilePicBase64))
            {
                data.Add("ProfilePic", profilePicBase64);
            }

            // Update the Firestore document
            DocumentSnapshot snap = await docref.GetSnapshotAsync();
            if (snap.Exists)
            {
                await docref.UpdateAsync(data);
                MessageBox.Show("User details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Noteditmode();
            }


        }

        private void Noteditmode()
        {
            BrowseBtn.Enabled = false;
            btnUpdate.Enabled = false;
            BrowseBtn.Hide();
            btnUpdate.Hide();
            Editbtn.Enabled = true;
            Editbtn.Show();
            UsernameTbx.ReadOnly = true;
            FirstNameTbx.ReadOnly = true;
            LastNameTbx.ReadOnly = true;
            AddressTbx.ReadOnly = true;
            PhoneNumberTbx.ReadOnly = true;
            EmailTbx.ReadOnly = true;
        }
            private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDetails();
        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            
            // Raise the event when the button is clicked
            GoBackToAccountForm?.Invoke(this, EventArgs.Empty);
        }

        private void Editmode()
        {
            BrowseBtn.Enabled = true;
            btnUpdate.Enabled = true;
            BrowseBtn.Show();
            btnUpdate.Show();
            Editbtn.Enabled = false;
            Editbtn.Hide();
            UsernameTbx.ReadOnly = false;
            FirstNameTbx.ReadOnly = false;
            LastNameTbx.ReadOnly = false;
            AddressTbx.ReadOnly = false;
            PhoneNumberTbx.ReadOnly = false;
            EmailTbx.ReadOnly = false;
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            Editmode();
        }

        
    }


}
