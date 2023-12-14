using Google.Cloud.Firestore;
using SmartRentalHub.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartRentalHub
{
    public partial class NotificationForm : Form
    {
        
        public NotificationForm()
        {
            InitializeComponent();
            
        }

        private void Notificationbtn_Click(object sender, EventArgs e)
        {
            // Retrieve the user data
            var db = FirestoreHelper.database;
            DocumentReference userDocRef = db.Collection("UserData").Document(MaintainUsername.Username);
            UserData userData = userDocRef.GetSnapshotAsync().Result.ConvertTo<UserData>();

            // Update notification preferences
            userData.AccomodationPreference = AccomodationCmbx.Text;
            userData.GuestPreference = GuestCmbx.Text;
            userData.BedPreference = BedCmbx.Text;
            userData.RoomTypePreference = RoomTypeCmbx.Text;
            userData.BedroomPreference = BedroomCmbx.Text;
            userData.BathroomsPreference = BathroomsCmbx.Text;

            // Save preferences
            userDocRef.SetAsync(userData);

            MessageBox.Show("Notification preferences saved successfully!");

        }

    }
}
