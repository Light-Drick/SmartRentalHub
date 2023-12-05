using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRentalHub.Class
{
    [FirestoreData]
    internal class SpaceDetails
    {
        [FirestoreProperty]
        public string Username { get; set; }

        [FirestoreProperty]
        public string Location { get; set; }

        [FirestoreProperty]
        public string Type { get; set; }


        [FirestoreProperty]
        public string Price { get; set; }

        [FirestoreProperty]
        public string AvailableDates { get; set; }

        [FirestoreProperty]
        public string Amenities { get; set; }
        [FirestoreProperty]
        public string PhoneNumber { get; set; }
        [FirestoreProperty]
        public string NameOfSpace { get; set; }
        [FirestoreProperty]
        public string StartDate { get; set; }
        [FirestoreProperty]
        public string EndDate { get; set; }
        [FirestoreProperty]
        public string Rules { get; set; }

        [FirestoreProperty]
        public string RoomPic { get; set; }
    }
}
