using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRentalHub
{
    [FirestoreData]
    internal class ShortRoomDetails
    {
        [FirestoreProperty ]
        public string Username { get; set; }

        [FirestoreProperty]
        public string PricePerNight { get; set; }

        [FirestoreProperty]
        public string NameTitleOfSpace { get; set; }

        [FirestoreProperty]
        public string RoomPic { get; set; }



    }
}
