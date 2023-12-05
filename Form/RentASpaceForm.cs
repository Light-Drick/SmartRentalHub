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
    public partial class RentASpaceForm : Form
    {
        public RentASpaceForm()
        {
            InitializeComponent();
        }

        private void RentASpaceForm_Load(object sender, EventArgs e)
        {
            FirestoreHelper.SetEnvironmentVariable();
        }

       internal async void GetRoomDetails()
        {
            DocumentReference docref = FirestoreHelper.database.Collection("Space for rent").Document(MaintainUsername.Username);
            DocumentSnapshot snap = await docref.GetSnapshotAsync();

            if (snap.Exists)
            {
                SpaceDetails SpaceForRent = snap.ConvertTo<SpaceDetails>();
                LocationTbx.Text= SpaceForRent.Location;
                NameOfSpaceTbx.Text = SpaceForRent.NameOfSpace;
                PhoneTbx.Text = SpaceForRent.PhoneNumber;
                TypeCmbx.Text = SpaceForRent.Type.ToString();
                PriceTbx.Text = SpaceForRent.Price;
                StartDateTbx.Text = SpaceForRent.StartDate;
                EndDateTBx.Text = SpaceForRent.EndDate;
                richTextBox1.Text = SpaceForRent.Rules.ToString(); 

            }
        }

        private void StartDateTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void EndDateTBx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
