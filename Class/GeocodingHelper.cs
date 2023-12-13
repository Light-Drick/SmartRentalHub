using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SmartRentalHub
{
    internal class GeocodingHelper
    {
        public async Task<(double Lat, double Lng)> GetCoordinatesAsync(string placeName)
        {
            using (var httpClient = new HttpClient())

            {
                string apiUrl = $"https://api.opencagedata.com/geocode/v1/json?q={Uri.EscapeDataString(placeName)}&key=26abc1c4541f47ba95cf68789121f788";

                var response = await httpClient.GetStringAsync(apiUrl);

                // For simplicity, assuming a straightforward case without error handling
                double lat = 0.0, lng = 0.0;

                // Parse the response JSON and extract lat/lng
                JObject result = JObject.Parse(response);
                var geometry = result["results"]?.FirstOrDefault()?["geometry"];
                if (geometry != null)
                {
                    lat = (double)geometry["lat"];
                    lng = (double)geometry["lng"];
                }

                return (lat, lng);
            }
        }


    }
}
