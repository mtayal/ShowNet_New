using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class NCAA_BRACKET
    {
        public NCAA_BRACKET()
        {
            this.NCAA_HORSE = new List<NCAA_HORSE>();
            this.NCAA_HORSE1 = new List<NCAA_HORSE>();
            this.NCAA_ROUND = new List<NCAA_ROUND>();
            this.NCAA_ROUND1 = new List<NCAA_ROUND>();
        }

        public int BracketID { get; set; }
        public Nullable<int> Team1 { get; set; }
        public Nullable<int> Team2 { get; set; }
        public Nullable<int> Schedule { get; set; }
        public Nullable<int> WinnerBracket { get; set; }
        public Nullable<int> LoserBracket { get; set; }
        public Nullable<bool> IsComplete { get; set; }
        public Nullable<int> Team1Score { get; set; }
        public Nullable<int> Team2Score { get; set; }
        public Nullable<int> WinningTeamID { get; set; }
        public Nullable<int> LosingTeamID { get; set; }
        public string BracketName { get; set; }
        public Nullable<int> BracketIdentifier { get; set; }
        public virtual NCAA_SCHEUDLE NCAA_SCHEUDLE { get; set; }
        public virtual NCAA_TEAM NCAA_TEAM { get; set; }
        public virtual NCAA_TEAM NCAA_TEAM1 { get; set; }
        public virtual ICollection<NCAA_HORSE> NCAA_HORSE { get; set; }
        public virtual ICollection<NCAA_HORSE> NCAA_HORSE1 { get; set; }
        public virtual ICollection<NCAA_ROUND> NCAA_ROUND { get; set; }
        public virtual NCAA_SCHEUDLE NCAA_SCHEUDLE1 { get; set; }
        public virtual NCAA_TEAM NCAA_TEAM2 { get; set; }
        public virtual NCAA_TEAM NCAA_TEAM3 { get; set; }
        public virtual ICollection<NCAA_ROUND> NCAA_ROUND1 { get; set; }
    }
}
