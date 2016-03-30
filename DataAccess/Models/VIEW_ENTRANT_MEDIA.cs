using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class VIEW_ENTRANT_MEDIA
    {
        public int BackID { get; set; }
        public int HorseShowID { get; set; }
        public string HorseName { get; set; }
        public string ClassName { get; set; }
        public string ClassID { get; set; }
        public Nullable<int> ListID { get; set; }
        public int MediaID { get; set; }
    }
}
