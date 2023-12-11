using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Google.Cloud.Firestore;
using Google.Cloud.Location;
using Newtonsoft.Json;
using OpenCage.Geocode;
using SmartRentalHub.Class;

namespace SmartRentalHub
{
    public partial class MapForm : Form
    {
        public event EventHandler ShowMap;

        private GMapOverlay markersOverlay;
        private GeocodingHelper geocodingHelper;
        Geocoder geocoder = new Geocoder("26abc1c4541f47ba95cf68789121f788");
        private readonly List<string> suggestedSearches = new List<string>();
        
        public MapForm()
        {
            InitializeComponent();

            //GMapProviders.GoogleMap.ApiKey = @"AIzaSyA_ltg1q16Xf_cSIw7S64HDMQ_hAUDU2cI";
            // gMapControl1.MapProvider = GMapProviders.GoogleMap;

            //firestore connection
            FirestoreHelper.SetEnvironmentVariable();



        }


        private async void MapForm_Load(object sender, EventArgs e)
        {
            try
            {
                zooming();
                // Initialize the map
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
                gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                gMapControl1.Position = new PointLatLng(10.31672, 123.89071);
                gMapControl1.ShowCenter = false;

                // Fetch locations from Firestore and add them to the map
                await GetLocationsFromFirestore();

                Get_All_Documents_Lat_Longt_From_Collection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in MapForm_Load: {ex.Message}");
            }
        }


        private void zooming()
        {
            // Set the zoom level and max zoom level
            gMapControl1.Zoom = 15; // You can adjust this value as needed
            gMapControl1.MaxZoom = 100; // You can adjust this value as needed

            // Enable zooming by scroll
            gMapControl1.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;

            // Enable dragging the map with the Left mouse button
            gMapControl1.DragButton = MouseButtons.Left;

            //zoom in at the cursor
            gMapControl1.MouseWheelZoomType = MouseWheelZoomType.MousePositionWithoutCenter;
        }


        public async Task GetLocationsFromFirestore()
        {
            List<PointLatLng> locations = new List<PointLatLng>();

            try
            {
                CollectionReference spaceForRentRef = FirestoreHelper.database.Collection("Space for rent");
                QuerySnapshot ownersSnapshot = await spaceForRentRef.GetSnapshotAsync();

                foreach (DocumentSnapshot ownerSnapshot in ownersSnapshot.Documents)
                {
                    CollectionReference roomsRef = spaceForRentRef.Document(ownerSnapshot.Id).Collection("Rooms");
                    QuerySnapshot roomsSnapshot = await roomsRef.GetSnapshotAsync();

                    foreach (DocumentSnapshot roomSnapshot in roomsSnapshot.Documents)
                    {
                        Dictionary<string, object> roomData = roomSnapshot.ToDictionary();
                        if (roomData.ContainsKey("Latitude") && roomData.ContainsKey("Longitude"))
                        {
                            double lat, lng;
                            if (double.TryParse(roomData["Latitude"].ToString(), out lat) && double.TryParse(roomData["Longitude"].ToString(), out lng))
                            {
                                locations.Add(new PointLatLng(lat, lng));

                            }
                        }
                    }
                }

                AddPinsToMap(locations);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        public void AddPinsToMap(List<PointLatLng> locations)
        {
            MessageBox.Show($"Number of locations to add: {locations.Count}");
            var markers = new GMapOverlay("markers");
            foreach (var location in locations)
            {
                var marker = new GMarkerGoogle(location, GMarkerGoogleType.red_pushpin);
                markers.Markers.Add(marker);
                
            }
            gMapControl1.Overlays.Add(markers);
            gMapControl1.Refresh();
        }

        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            gMapControl1.DragButton = MouseButtons.Right;

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            zooming();
        }


        private async void Get_All_Documents_Lat_Longt_From_Collection()
        {
            // Get a reference to the Firestore database
            CollectionReference spaceForRentRef = FirestoreHelper.database.Collection("Space for rent");

            // Get all documents (i.e., all owners) in the "Space for rent" collection
            QuerySnapshot ownersSnapshot = await spaceForRentRef.GetSnapshotAsync();

            foreach (DocumentSnapshot ownerSnapshot in ownersSnapshot)
            {
                if (ownerSnapshot.Exists)
                {
                    // Get the "Rooms" collection for this owner
                    CollectionReference roomsRef = ownerSnapshot.Reference.Collection("Rooms");

                    // Get all documents (i.e., all rooms) in this owner's "Rooms" collection
                    QuerySnapshot roomsSnapshot = await roomsRef.GetSnapshotAsync();

                    foreach (DocumentSnapshot roomSnapshot in roomsSnapshot)
                    {
                        if (roomSnapshot.Exists)
                        {
                            SpaceDetails spaceDetails = roomSnapshot.ConvertTo<SpaceDetails>();
                            // Debugging lines
                            Console.WriteLine("Document ID: " + roomSnapshot.Id);
                            Console.WriteLine("SpaceDetails object: " + JsonConvert.SerializeObject(spaceDetails));

                            richTextBox1.Text += "Name/Title of Space: " + roomSnapshot.Id + "\n";
                            richTextBox1.Text += "Latitude: " + spaceDetails.Latitude + "\n";
                            richTextBox1.Text += "Longitude: " + spaceDetails.Longitude + "\n\n";
                            richTextBox1.Text += "Address: " + spaceDetails.Address + "\n\n";
                            richTextBox1.Text += "Accommodation: " + spaceDetails.Accommodation + "\n\n";
                            richTextBox1.Text += "Room Type: " + spaceDetails.RoomType + "\n\n";
                            richTextBox1.Text += "Guests: " + spaceDetails.Guest + "\n\n";
                            richTextBox1.Text += "Bed: " + spaceDetails.Bed + "\n\n";
                            richTextBox1.Text += "Bedroom: " + spaceDetails.Bedroom + "\n\n";


                        }
                    }
                }
            }

            MessageBox.Show("All Latitude and Longitude data retrieved successfully.");
        }

    }
}
