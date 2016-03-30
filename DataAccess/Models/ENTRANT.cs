using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ENTRANT
    {
        public int BackID { get; set; }
        public int HorseShowID { get; set; }
        public int StatusID { get; set; }
        public string HorseName { get; set; }
        public string Trainer { get; set; }
        public string Owner1 { get; set; }
        public string Owner2 { get; set; }
        public Nullable<int> UpdateID { get; set; }
        public string Rider { get; set; }
        public string RiderAddr { get; set; }
        public string Owner1Addr { get; set; }
        public int EntrantID { get; set; }
        public virtual STATUS STATUS { get; set; }
        public virtual HORSE_SHOW HORSE_SHOW { get; set; }
        public virtual HORSE_SHOW HORSE_SHOW1 { get; set; }
    }
}
