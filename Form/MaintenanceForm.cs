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

namespace SmartRentalHub
{
    public partial class MaintenanceForm : Form
    {
        public MaintenanceForm()
        {
            InitializeComponent();
            
        }

        private async void SubmitMaintenanceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string ownerUsername = OwnerUserNameTbx.Text;

                // Get the user's document from the "Space for rent" collection
                DocumentReference docRef = FirestoreHelper.database.Collection("Space for rent").Document(ownerUsername);
                DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

                if (snapshot.Exists)
                {
                    // Get a reference to the Firestore database
                    CollectionReference MaintenanceRef = FirestoreHelper.database.Collection("Space for rent").Document(ownerUsername).Collection("Maintenance request");

                    // Get the current highest number
                    Query query = MaintenanceRef.OrderByDescending("__name__").Limit(1);
                    QuerySnapshot querySnapshot = await query.GetSnapshotAsync();
                    DocumentSnapshot lastDocument = querySnapshot.Documents[0];
                    string lastDocumentName = lastDocument.Id;


                    // Parse the number from the document name and increment it
                    int number = int.Parse(lastDocumentName.Replace("maintenance_", ""));
                    number++;

                    // Create the new document with the incremented number
                    DocumentReference newDocument = MaintenanceRef.Document("maintenance_" + number);

                    MaintenanceCollection();
                }

                else
                {
                    // If the user does not exist, show a message to reenter the username
                    MessageBox.Show("Please reenter the owner username because that username is not an owner"
                        +" of any spaces for rent. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void MaintenanceForm_Load(object sender, EventArgs e)
        {
        }

        private void MaintenanceCollection()
        {
            // Get a reference to the Firestore database
            CollectionReference MaintenanceRef = FirestoreHelper.database.Collection("Space for rent").Document(OwnerUserNameTbx.Text).Collection("Maintenance request");

            // Create a new document with a generated ID
            DocumentReference newDocument = MaintenanceRef.Document();

            // Create the data for the new document
            Dictionary<string, object> maintenanceDetails = new Dictionary<string, object>
            {
                { "Name of Renter", NameOfRenterTbx.Text},
                { "Phone Number", PhoneNumberTbx.Text},
                { "Date", dateTimePicker1.Value},
                { "Priority Level", PrioLevelCmbx.Text},
                { "More Details", DetailsrichTextBox1.Text}
             };

            // Set the data of the new document
            newDocument.SetAsync(maintenanceDetails);

            MessageBox.Show("Maintenance Request added succesfully.");
        }

    }
}
