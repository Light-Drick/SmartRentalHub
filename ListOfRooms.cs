using Google.Cloud.Firestore;
using SmartRentalHub.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartRentalHub
{
    public partial class ListOfRooms : Form
    {
        public ListOfRooms()
        {
            InitializeComponent();
            FirestoreHelper.SetEnvironmentVariable();
        }



        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            /*byte[] imageData = SpaceDetails.RoomPic();

            // Convert byte array to image
            using (var ms = new MemoryStream(imageData))
            {
                var image = Image.FromStream(ms);

                // Create a new PictureBox control
                var pictureBox = new PictureBox
                {
                    Image = image,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Cursor = Cursors.Hand,
                    Size = new Size(100, 100) // Set the size as needed
                };

                // Add a click event handler
                pictureBox.Click += (s, e) =>
                {
                    MessageBox.Show("Image clicked!");
                };

                // Add the PictureBox to the FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(pictureBox);
            }*/
        }

        /*internal async Task<SpaceDetails> RetrieveRoomDetails()
       {
          try
           {
               var db = FirestoreHelper.database;

               // Get the room documents
               Query roomQuery = db.Collection("Rooms");
               QuerySnapshot roomSnapshot = await roomQuery.GetSnapshotAsync();


               if (roomSnapshot.Count > 0)
               {
                   // Convert the DocumentSnapshots to a list of SpaceDetails objects
                   List<SpaceDetails> roomDetails = roomSnapshot.Documents
                       .Select(doc => doc.ConvertTo<SpaceDetails>())
                       .ToList();

                   return roomDetails;
               }
               else
               {
                   Console.WriteLine("No rooms found!");
                   return new List<SpaceDetails>();
               }
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Error retrieving room details: {ex.Message}");
               Console.WriteLine(ex.StackTrace);
               return new List<SpaceDetails>();
           }


       }*/





    }
}



