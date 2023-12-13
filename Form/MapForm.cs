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
using Google.Api;
using Google.Cloud.Firestore;
using Google.Cloud.Location;
using Newtonsoft.Json;
using OpenCage.Geocode;
using ServiceStack;
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
            

            // Handle the OnMarkerClick event
            gMapControl1.OnMarkerClick += gMapControl1_OnMarkerClick;

        }



        private async void MapForm_Load(object sender, EventArgs e)
        {
            try
            {
                FirestoreHelper.SetEnvironmentVariable();

                zooming();
                // Initialize the map
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
                gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                gMapControl1.Position = new PointLatLng(10.31672, 123.89071);
                gMapControl1.ShowCenter = false;

                // Fetch locations from Firestore and add them to the map
                await GetLocationsFromFirestore();

                RoomDetailsPanel.Visible = false;

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
                
                var db = FirestoreHelper.database;


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
                        // Pass the roomData variable to the AddPinsToMap method
                        AddPinsToMap(locations, roomData);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        // Modify the AddPinsToMap method to accept a Dictionary<string, object> parameter
        public void AddPinsToMap(List<PointLatLng> locations, Dictionary<string, object> roomData)
        {
            MessageBox.Show($"Number of locations to add: {locations.Count}");
            var markers = new GMapOverlay("markers");
            foreach (var location in locations)
            {
                var marker = new GMarkerGoogle(location, GMarkerGoogleType.red_pushpin);
                // Get the latitude and longitude values from the roomData parameter
                double lat = (double)roomData["Latitude"];
                double lng = (double)roomData["Longitude"];

                // Set the tooltip text with the latitude and longitude values
                marker.ToolTipText = $"Latitude: {lat}, \nLongitude: {lng}";
                
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

        
        private async Task  YourMarker_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            // Fetch data from Firestore
            DocumentReference docRef = FirestoreHelper.database.Collection("Space for rent").Document("yourSpaceId");
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                Dictionary<string, object> space = snapshot.ToDictionary();
                string photoUrl = space["photoUrl"].ToString();
                string title = space["title"].ToString();
                string price = space["Price"].ToString();
                string owner = space["username"].ToString();

                // Update the RoomDetailsPanel with the data
                /*RoomDetailsPanel.Photo.Source = new BitmapImage(new Uri(photoUrl));
                 RoomDetailsPanel.Title.Text = title;
                 RoomDetailsPanel.Price.Text = price;
                RoomDetailsPanel.Owner.Text = owner;

                // Show the RoomDetailsPanel
                RoomDetailsPanel.Visibility = Visibility.Visible;*/
            }
            else
            {
                Console.WriteLine("No such document!");
            }
        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            // Get the marker object from the event args
            var marker = item as GMarkerGoogle;

            // Do some action with the marker
            RoomDetailsPanel.Visible = true;

            // For example, show a message box with the marker's tooltip and position
            MessageBox.Show($"You clicked {marker.ToolTipText} at {marker.Position}", "Marker Clicked");
        }

        
    }
}
