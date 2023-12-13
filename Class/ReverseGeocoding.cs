using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace SmartRentalHub
{
    internal class ReverseGeocoding
    {
        public async Task<string> GetPlaceNameAsync(double lat, double lng)
        {
            using (var httpClient = new HttpClient())
            {
                string apiUrl = $"https://api.opencagedata.com/geocode/v1/json?q={lat}+{lng}&key=19cf93b05b284049a5b747095bd6b02e";

                var response = await httpClient.GetStringAsync(apiUrl);

                // For simplicity, assuming a straightforward case without error handling
                string placeName = "";

                // Parse the response JSON and extract place name
                JObject result = JObject.Parse(response);
                var components = result["results"]?.FirstOrDefault()?["components"];
                if (components != null)
                {
                    placeName = (string)components["city"] ?? (string)components["town"] ?? (string)components["village"];
                }

                return placeName;
            }
        }

    }
}
