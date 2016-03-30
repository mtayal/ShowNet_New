using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class FEED_ORDER
    {
        public int OrderID { get; set; }
        public string Name { get; set; }
        public string StableWith { get; set; }
        public string Location { get; set; }
        public string StallNumber { get; set; }
        public string WEFNo { get; set; }
        public string SendingTo { get; set; }
        public string Barn { get; set; }
        public string Stall { get; set; }
        public string UserName { get; set; }
    }
}
