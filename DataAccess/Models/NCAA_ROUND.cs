using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class NCAA_ROUND
    {
        public int RoundID { get; set; }
        public Nullable<int> Team1Entrant { get; set; }
        public Nullable<int> Team2Entrant { get; set; }
        public string HorseName { get; set; }
        public Nullable<int> Team1Score { get; set; }
        public Nullable<int> Team2Score { get; set; }
        public Nullable<int> OrderIndex { get; set; }
        public Nullable<int> Bracket { get; set; }
        public virtual NCAA_BRACKET NCAA_BRACKET { get; set; }
        public virtual NCAA_BRACKET NCAA_BRACKET1 { get; set; }
        public virtual NCAA_ENTRANT NCAA_ENTRANT { get; set; }
        public virtual NCAA_ENTRANT NCAA_ENTRANT1 { get; set; }
        public virtual NCAA_ENTRANT NCAA_ENTRANT2 { get; set; }
        public virtual NCAA_ENTRANT NCAA_ENTRANT3 { get; set; }
    }
}
