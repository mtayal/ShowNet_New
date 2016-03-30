using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class NCAA_HORSE
    {
        public int HorseID { get; set; }
        public string HorseName { get; set; }
        public string Trainer { get; set; }
        public string Owner1 { get; set; }
        public string Owner2 { get; set; }
        public Nullable<int> UpdateID { get; set; }
        public string Owner1Addr { get; set; }
        public Nullable<int> Bracket { get; set; }
        public virtual NCAA_BRACKET NCAA_BRACKET { get; set; }
        public virtual NCAA_BRACKET NCAA_BRACKET1 { get; set; }
    }
}
