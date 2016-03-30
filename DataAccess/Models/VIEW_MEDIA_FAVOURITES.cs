using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class VIEW_MEDIA_FAVOURITES
    {
        public Nullable<int> ListID { get; set; }
        public string RiderName { get; set; }
        public string HorseName { get; set; }
        public string Trainer { get; set; }
        public Nullable<bool> HasIPhoneMedia { get; set; }
        public string ClassName { get; set; }
        public string ClassID { get; set; }
        public string HorseShowName { get; set; }
        public int HorseShowID { get; set; }
        public int BackID { get; set; }
        public int MediaID { get; set; }
        public int PurchasesMemberID { get; set; }
        public Nullable<int> FavouritesMemberID { get; set; }
    }
}
