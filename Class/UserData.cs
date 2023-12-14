using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRentalHub
{
    [FirestoreData]
    internal class UserData
    {
        [FirestoreProperty]
        public string Firstname { get; set; }

        [FirestoreProperty]
        public string Lastname { get; set; }

        [FirestoreProperty]
        public string Username {  get; set; }

        [FirestoreProperty]
        public string Password { get; set; }

        [FirestoreProperty]
        public string Email { get; set; }

        [FirestoreProperty]
        public string PhoneNumber { get; set; } 
        [FirestoreProperty]
        public string Address { get; set; }

        [FirestoreProperty]
        public string ProfilePic { get; set; }

        [FirestoreProperty]
        public bool NotifyNewApartments { get; set; }

        [FirestoreProperty]
        public string AccomodationPreference { get; set; }

        [FirestoreProperty]
        public string GuestPreference { get; set; }

        [FirestoreProperty]
        public string BedPreference { get; set; }

        [FirestoreProperty]
        public string RoomTypePreference { get; set; }

        [FirestoreProperty]
        public string BedroomPreference { get; set; }

        [FirestoreProperty]
        public string BathroomsPreference { get; set; }

    }
}
