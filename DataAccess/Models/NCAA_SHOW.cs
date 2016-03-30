using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class NCAA_SHOW
    {
        public NCAA_SHOW()
        {
            this.NCAA_SCHEUDLE = new List<NCAA_SCHEUDLE>();
            this.NCAA_SCHEUDLE1 = new List<NCAA_SCHEUDLE>();
        }

        public int HorseShowID { get; set; }
        public string HorseShowName { get; set; }
        public string Location { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> UpdateID { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string Comment { get; set; }
        public string Password { get; set; }
        public string LongDescription { get; set; }
        public string ShowImage { get; set; }
        public string ShowWebsite { get; set; }
        public string SponsorIDList { get; set; }
        public virtual ICollection<NCAA_SCHEUDLE> NCAA_SCHEUDLE { get; set; }
        public virtual ICollection<NCAA_SCHEUDLE> NCAA_SCHEUDLE1 { get; set; }
    }
}
