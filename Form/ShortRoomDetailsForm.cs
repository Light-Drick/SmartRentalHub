using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
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
    public partial class ShortRoomDetailsForm : Form
    {
        public ShortRoomDetailsForm()
        {
            InitializeComponent();

            //MaintainUsername.Username;
        }

        private void ShortRoomDetailsForm_Load(object sender, EventArgs e)
        {
            FirestoreHelper.SetEnvironmentVariable();
        }

        private async Task RetrieveShortRoomDetails()
        {
            try
            {
                var db = FirestoreHelper.database;


                // Query the Space for rent collection for the document that matches the marker's tooltip
                string collectionName = "Space for rent";
                string nameSpaceOfTitle = "Name/Title of Space";
                string pricePerNight = "Price per night";
                string ownerUsername = "username";
               
                /*string fieldValue = marker.ToolTipText;
                Query query = db.Collection(collectionName).WhereEqualTo(fieldName, fieldValue).Limit(1);
                QuerySnapshot querySnapshot = await query.GetSnapshotAsync();

                // Check if the query result has any documents
                if (querySnapshot.Count > 0)
                {
                    // Get the first document from the query result
                    DocumentSnapshot documentSnapshot = querySnapshot[0];

                    // Convert the document data to a Room object
                    Room room = documentSnapshot.ConvertTo<Room>();

                    // Get the owner username from the document data
                    string ownerUsername = documentSnapshot["owner"] as string; // or room.owner

                    // Do something with the owner username
                    // For example, show a message box with the owner username
                    MessageBox.Show($"The owner username is {ownerUsername}", "Owner Username");*/
                }
            

            
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
