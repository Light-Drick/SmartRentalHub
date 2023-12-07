using SmartRentalHub.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

using Google.Cloud.Firestore;
using Google.Type;
using System.Runtime.InteropServices.ComTypes;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using OpenCage.Geocode;
using GMap.NET;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using GMap.NET.MapProviders;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using static Google.Cloud.Firestore.V1.StructuredQuery.Types;

using Firebase.Storage;
using FirebaseAdmin;
using Firebase.Database;


//using System.Json;

namespace SmartRentalHub
{
    public partial class AddSpaceForm : Form
    {
        private GMapOverlay markersOverlay;
        private GeocodingHelper geocodingHelper;
        Geocoder geocoder = new Geocoder("26abc1c4541f47ba95cf68789121f788");
        private readonly List<string> suggestedSearches = new List<string>();
        
        public AddSpaceForm()
        {
            InitializeComponent();
            string username = MaintainUsername.Username;
            UsernameTbx.Text = username;
            DescriptionCheckBox1.Checked = true;
            
            gMapControl1.MouseClick += new MouseEventHandler(gMapControl1_MouseClick_1);

        }


        
        private void AddSpaceForm_Load(object sender, EventArgs e)
        {
            //connection to database
            FirestoreHelper.SetEnvironmentVariable();

            
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;

            // Use new PointLatLng constructor to set the initial position
            gMapControl1.Position = new PointLatLng(10.294154847289409, 123.88125871906306);

            // Set a default zoom level
            gMapControl1.Zoom = 50;

            markersOverlay = new GMap.NET.WindowsForms.GMapOverlay("markers");
            gMapControl1.Overlays.Add(markersOverlay);

            // Initialize the geocoding helper
            geocodingHelper = new GeocodingHelper();

            gMapControl1.ShowCenter = false; 

        }
        
       
       
        private async void AddSpaceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                /*// Iterate over all controls in the form
                foreach (Control c in this.Controls)
                {
                    // Check if the control is a textbox
                    if (c is TextBox)
                    {
                        // Check if the textbox is not empty
                        if (!string.IsNullOrWhiteSpace(((TextBox)c).Text))
                        {*/
                            // Your code here for when the textbox is filled
                            var startDate = monthCalendar1.SelectionRange.Start.ToString("dd MMM yyyy");
                            var endDate = monthCalendar1.SelectionRange.End.ToString("dd MMM yyyy");

                            AddToListOfObjects(startDate, endDate);

                            
                            ClearControls();

                       // }
                        /*else
                            MessageBox.Show("Fill up all the required information.");


                    }
                }*/
            }
            catch
            {
                MessageBox.Show("Error!");
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

        
        async void AddToListOfObjects(string start, string end)
        {
            int roomNumber = 1;
            // Concatenate username and room number
            string documentName = UsernameTbx.Text + roomNumber.ToString();


            try
            {
                //CollectionReference roomsRef = FirestoreHelper.database.Collection("Space for rent").Document(UsernameTbx.Text).Collection("Rooms");
                CollectionReference roomsRef = FirestoreHelper.database.Collection("Space for rent").Document(UsernameTbx.Text).Collection("Rooms");

                // Get the last document in the collection ordered by roomNumber
                Query query = roomsRef.OrderBy("roomNumber");
                QuerySnapshot snapshot = await query.GetSnapshotAsync();

                // If the snapshot contains any documents, get the last document and increment its roomNumber
                if (snapshot.Count > 0)
                {
                    DocumentSnapshot lastRoom = snapshot.Documents.LastOrDefault();
                    roomNumber = lastRoom.GetValue<int>("roomNumber") + 1;
                    documentName = UsernameTbx.Text + roomNumber.ToString(); // Update documentName with new roomNumber
                }




                // Convert the profile picture to a base64 string
                string roomPicBase64 = ConvertImageToBase64(pictureBox1.Image);
                roomPicBase64 += ConvertImageToBase64(pictureBox2.Image);
                roomPicBase64 += ConvertImageToBase64(pictureBox3.Image);

                // Log the base64 string in output
                Console.WriteLine($"RoomPicBase64: {roomPicBase64}");

                Dictionary<string, object> room = new Dictionary<string, object>();

                Dictionary<string, object> List1 = new Dictionary<string, object>
            {
                {"Username", UsernameTbx.Text },
                {"Name/Title of Space", NameOfSpaceTbx.Text },

                {"Accommodation", AccomodationCmbx.Text },
                 {"Room Type", RoomTypeCmbx.Text },
                 {"Guest", GuestCmbx.Text },
                 {"Bedroom", BedroomCmbx.Text },
                 {"Bed", BedCmbx.Text },
                 {"BathRoom", BathroomsCmbx.Text },

                {"Phone", PhoneNumberTbx.Text },
                {"Price", PriceTbx.Text },

               

                { "StartDate", start},
                {"EndDate", end},
                {"Rules/Conditions", RulesrichTextBox1.Text},
                {"Longitude", txtb_Long.Text},
                {"Latitude", txtb_Lat.Text},
                {"Address", AddressrichTextBox2.Text},
                {"3_Picture_Room", roomPicBase64},
            };
                // Add description to the dictionary based on the checkbox
                if (DescriptionCheckBox1.Checked)
                {
                    List1.Add("Description", DescriptionRichTextBox3.Text);
                }
                else if (!DescriptionCheckBox1.Checked)
                {
                    List1.Add("Description", DescriptionCmbx.Text);
                }



                if (!string.IsNullOrEmpty(roomPicBase64))
                {
                    /*DocumentReference docRef = FirestoreHelper.database.Collection("Space for rent").Document(UsernameTbx.Text).Collection("Rooms").Document(documentName);
                    CollectionReference subRef = docRef.Collection("Pictures"); // Get a subcollection reference
                    Dictionary<string, object> picture = new Dictionary<string, object>
                    {
                        {"url", "roomPicBase64"}
                        
                    };
                    await subRef.AddAsync(picture); // Add a document to the subcollection
                    */
                   List1.Add("Room_PIc", roomPicBase64);
                }

                List<string> checkedItems = new List<string>();
                foreach (object item in checkedListBox1.Items)
                {
                    if (checkedListBox1.GetItemChecked(checkedListBox1.Items.IndexOf(item)))
                    {
                        checkedItems.Add(item.ToString());
                    }
                }

                List1.Add("CheckedItems", checkedItems);

                room.Add("Space", List1);
                await roomsRef.AddAsync(room);


                //await roomsRef.Document(documentName).SetAsync(room);

                MessageBox.Show("Added succesfully!");

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        //getting address from lat longt
        private async Task<List<String>> GetAddressAsync(PointLatLng point)
        {
            using (var httpClient = new HttpClient())
            {
                string apiUrl = $"https://api.opencagedata.com/geocode/v1/json?q={point.Lat}+{point.Lng}&key=19cf93b05b284049a5b747095bd6b02e";

                var response = await httpClient.GetStringAsync(apiUrl);

                // For simplicity, assuming a straightforward case without error handling
                List<string> addresses = new List<string>();

                // Parse the response JSON and extract addresses
                JObject result = JObject.Parse(response);
                var results = result["results"];
                if (results != null)
                {
                    foreach (var res in results)
                    {
                        addresses.Add((string)res["formatted"]);
                    }
                }

                return addresses;
            }
        }




        private void ClearControls()
        {
            
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = String.Empty;
                }
                else if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.SelectedIndex = -1;
                }
                else if (control is CheckedListBox)
                {
                    CheckedListBox checkedListBox = (CheckedListBox)control;
                    for (int i = 0; i < checkedListBox.Items.Count; i++)
                    {
                        checkedListBox.SetItemChecked(i, false);
                    }
                }
                else if (control is RichTextBox)
                {
                    RichTextBox richTextBox = (RichTextBox)control;
                    richTextBox.Text = String.Empty;
                }
            }
        }

       
        private async void gMapControl1_MouseClick_1(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                GMapOverlay O = new GMapOverlay("O");

                // Check if there are existing markers, remove them if any
                if (gMapControl1.Overlays.Any(o => o.Id == "O"))
                {
                    GMapOverlay existingOverlay = gMapControl1.Overlays.Last(o => o.Id == "O");
                    existingOverlay.Markers.Clear();
                }
                if (markersOverlay.Markers.Count > 0)
                {
                    markersOverlay.Markers.Clear();
                }

                gMapControl1.Overlays.Add(O);

                int x = e.X, y = e.Y;
                double lat1, lon1;
                lat1 = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
                lon1 = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

                GMapMarker m = new GMarkerGoogle(new PointLatLng(lat1, lon1), GMarkerGoogleType.red_pushpin);
                O.Markers.Add(m);

                gMapControl1.UpdateMarkerLocalPosition(m);
                gMapControl1.Refresh();

                txtb_Lat.Text = Convert.ToString(lat1);
                txtb_Long.Text = Convert.ToString(lon1);

                //get address
                var addresses = await GetAddressAsync(m.Position);
                //display address
                if (addresses != null)
                {
                    AddressrichTextBox2.Text = String.Join(",", addresses.ToArray());
                }
                else
                {
                    MessageBox.Show("No address");
                }

            }

            else if (e.Button == MouseButtons.Right)
            {
                // Set the drag button to the right mouse button
                gMapControl1.DragButton = MouseButtons.Right;
            }
        }

       
            private void BrowseBtn_Click(object sender, EventArgs e)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] base64Strings = new string[openFileDialog.FileNames.Length];

                    for (int i = 0; i < openFileDialog.FileNames.Length; i++)
                    {
                        // Read the image file into a byte array
                        byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileNames[i]);

                        // Convert the byte array to a base64 string
                        string base64String = Convert.ToBase64String(imageBytes);

                        // Add the base64 string to the array
                        base64Strings[i] = base64String;
                    }

                    ConvertBase64ToImageAndDisplay(base64Strings);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                //pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                //pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BackgroundImage = null;
                //pictureBox2.BackgroundImage = null;
               //  pictureBox3.BackgroundImage = null;
            }
            }
        

        private void ConvertBase64ToImageAndDisplay(string[] base64Strings)
        {
            try
            {
                for (int i = 0; i < base64Strings.Length; i++)
                {
                    // Convert Base64 String to byte[]
                    byte[] imageBytes = Convert.FromBase64String(base64Strings[i]);

                    // Create a MemoryStream from the byte array
                    using (var ms = new MemoryStream(imageBytes))
                    {
                        // Create an Image from the MemoryStream
                        Image image = Image.FromStream(ms);

                        // Display the Image in the PictureBox
                        PictureBox pictureBox = this.Controls.Find("pictureBox" + (i + 1), true).FirstOrDefault() as PictureBox;
                        pictureBox.Image = image;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting base64 to image: {ex.Message}");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (DescriptionCheckBox1.Checked)
            {
                DescriptionRichTextBox3.Enabled = true;
                DescriptionCmbx.Enabled = false;
            }
            else
            {
                DescriptionRichTextBox3.Enabled = false;
                DescriptionCmbx.Enabled = true;
            }
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }
    }
}

