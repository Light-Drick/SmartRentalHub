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

        public string RoomType { get; set; }


        [FirestoreProperty]
        public string Price { get; set; }

   
        [FirestoreProperty]
        public string Amenities { get; set; }
        [FirestoreProperty]
        public string PhoneNumber { get; set; }
        [FirestoreProperty]
        public string NameTitleOfSpace { get; set; }
        [FirestoreProperty]
        public string StartDate { get; set; }
        [FirestoreProperty]
        public string EndDate { get; set; }
        [FirestoreProperty]
        public string RulesConditions{ get; set; }


        [FirestoreProperty]
        public double Latitude { get; set; }
        [FirestoreProperty]
        public double Longitude { get; set; }
        [FirestoreProperty]
        public string Address { get; set; }

        [FirestoreProperty]
        public string Accommodation { get; set; }

        [FirestoreProperty]
        public string BathRoom { get; set; }

        [FirestoreProperty]
        public string Bed { get; set; }

        [FirestoreProperty]
        public string Bedroom { get; set; }

        [FirestoreProperty]
        public string Guest { get; set; }




    }
}
