using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class SPONSOR_IMPRESSION
    {
        public int SponsorImpressionId { get; set; }
        public Nullable<int> SponsorId { get; set; }
        public Nullable<int> HorseShowId { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public Nullable<int> MemberId { get; set; }
        public Nullable<int> ImpressionSource { get; set; }
        public string Meta { get; set; }
    }
}
