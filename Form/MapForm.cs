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
using OpenCage.Geocode;


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
            
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyA_ltg1q16Xf_cSIw7S64HDMQ_hAUDU2cI";
            gMapControl1.MapProvider = GMapProviders.GoogleMap;



        }

        private void MapForm_Load(object sender, EventArgs e)
        {

            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;

            // Use new PointLatLng constructor to set the initial position
            gMapControl1.Position = new PointLatLng(10.294154847289409, 123.88125871906306);

            // Set a default zoom level
            gMapControl1.Zoom = 20;

            markersOverlay = new GMap.NET.WindowsForms.GMapOverlay("markers");
            gMapControl1.Overlays.Add(markersOverlay);

            // Initialize the geocoding helper
            geocodingHelper = new GeocodingHelper();
        }

        private async void LoadMapBtn_Click(object sender, EventArgs e)
        {

            string placeName = NameTbx.Text.Trim();
            var coordinates = await geocodingHelper.GetCoordinatesAsync(placeName);

            // Check if there are existing markers, remove them if any
            if (markersOverlay.Markers.Count > 0)
            {
                markersOverlay.Markers.Clear();
            }
            if (gMapControl1.Overlays.Any(o => o.Id == "O"))
            {
                GMapOverlay existingOverlay = gMapControl1.Overlays.Last(o => o.Id == "O");
                existingOverlay.Markers.Clear();
            }

            // Add a marker to the map at the specified location
            GMapMarker marker = new GMarkerGoogle(new GMap.NET.PointLatLng(coordinates.Lat, coordinates.Lng), GMarkerGoogleType.red_pushpin);
            markersOverlay.Markers.Add(marker);

            // Set the map center and zoom to the marker
            gMapControl1.Position = marker.Position;
            gMapControl1.Zoom = 15;

            // Refresh the map
            gMapControl1.Refresh();
            LatitudeTbx.Text = Convert.ToString(coordinates.Lat);
            LongitudeTbx.Text = Convert.ToString(coordinates.Lng);

        }

        private void zooming()
        {
            // Set the zoom level and max zoom level
            gMapControl1.Zoom = 10; // You can adjust this value as needed
            gMapControl1.MaxZoom = 18; // You can adjust this value as needed

            // Enable zooming by scroll
            gMapControl1.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;

            // Enable dragging the map with the Left mouse button
            gMapControl1.DragButton = MouseButtons.Left;
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
