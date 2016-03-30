using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class HORSE_SHOW
    {
        public HORSE_SHOW()
        {
            this.CIRCUIT_RELATIONSHIPS = new List<CIRCUIT_RELATIONSHIPS>();
            this.CIRCUIT_RELATIONSHIPS1 = new List<CIRCUIT_RELATIONSHIPS>();
            this.ENTRANTS = new List<ENTRANT>();
            this.ENTRANTS1 = new List<ENTRANT>();
            this.ORDERED_GO_LIST = new List<ORDERED_GO_LIST>();
            this.PURCHASES = new List<Purchase>();
            this.SHOW_DATE = new List<SHOW_DATE>();
            this.SHOW_MESSAGES_RELATIONSHIPS = new List<SHOW_MESSAGES_RELATIONSHIPS>();
            this.MEMBER_FAVORITES = new List<MEMBER_FAVORITES>();
            this.SHOW_DATE1 = new List<SHOW_DATE>();
            this.ORDERED_GO_LIST1 = new List<ORDERED_GO_LIST>();
            this.SHOW_DATE2 = new List<SHOW_DATE>();
            this.VIDEO_STREAM = new List<VIDEO_STREAM>();
            this.VIDEO_STREAM1 = new List<VIDEO_STREAM>();
            this.MEMBER_FAVORITES1 = new List<MEMBER_FAVORITES>();
            this.ORDERED_GO_LIST2 = new List<ORDERED_GO_LIST>();
        }

        public int HorseShowID { get; set; }
        public string HorseShowName { get; set; }
        public string Location { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public Nullable<int> UpdateID { get; set; }
        public bool Active { get; set; }
        public string Comment { get; set; }
        public string Password { get; set; }
        public string LongDescription { get; set; }
        public string ShowImage { get; set; }
        public string ShowWebsite { get; set; }
        public string SponsorIDList { get; set; }
        public bool IsWWWVisible { get; set; }
        public bool IsFreeMobileWatch { get; set; }
        public Nullable<bool> HasScheduleDownload { get; set; }
        public Nullable<bool> HasPrizeListDownload { get; set; }
        public Nullable<bool> HasEntryBlankDownload { get; set; }
        public int ShowMode { get; set; }
        public bool IsFreeShow { get; set; }
        public Nullable<bool> HasVideo { get; set; }
        public Nullable<bool> RequiresCircuit { get; set; }
        public Nullable<bool> HasStreaming { get; set; }
        public Nullable<bool> RequiresRegistration { get; set; }
        public string AvailableProducts { get; set; }
        public virtual ICollection<CIRCUIT_RELATIONSHIPS> CIRCUIT_RELATIONSHIPS { get; set; }
        public virtual ICollection<CIRCUIT_RELATIONSHIPS> CIRCUIT_RELATIONSHIPS1 { get; set; }
        public virtual ICollection<ENTRANT> ENTRANTS { get; set; }
        public virtual ICollection<ENTRANT> ENTRANTS1 { get; set; }
        public virtual ICollection<ORDERED_GO_LIST> ORDERED_GO_LIST { get; set; }
        public virtual ICollection<Purchase> PURCHASES { get; set; }
        public virtual ICollection<SHOW_DATE> SHOW_DATE { get; set; }
        public virtual ICollection<SHOW_MESSAGES_RELATIONSHIPS> SHOW_MESSAGES_RELATIONSHIPS { get; set; }
        public virtual ICollection<MEMBER_FAVORITES> MEMBER_FAVORITES { get; set; }
        public virtual ICollection<SHOW_DATE> SHOW_DATE1 { get; set; }
        public virtual ICollection<ORDERED_GO_LIST> ORDERED_GO_LIST1 { get; set; }
        public virtual ICollection<SHOW_DATE> SHOW_DATE2 { get; set; }
        public virtual ICollection<VIDEO_STREAM> VIDEO_STREAM { get; set; }
        public virtual ICollection<VIDEO_STREAM> VIDEO_STREAM1 { get; set; }
        public virtual ICollection<MEMBER_FAVORITES> MEMBER_FAVORITES1 { get; set; }
        public virtual ICollection<ORDERED_GO_LIST> ORDERED_GO_LIST2 { get; set; }
    }
}
