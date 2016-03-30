using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class SPONSOR
    {
        public int SponsorID { get; set; }
        public bool Active { get; set; }
        public string Company { get; set; }
        public int UpdateID { get; set; }
        public string URL { get; set; }
        public string ImageURL { get; set; }
        public bool IsMainSponsor { get; set; }
        public Nullable<int> HorseShowID { get; set; }
        public string VideoSplashURL { get; set; }
        public Nullable<bool> UseVideoSplash { get; set; }
        public Nullable<int> MaximumPlay { get; set; }
    }
}
