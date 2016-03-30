using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class PARTNER
    {
        public PARTNER()
        {
            this.MEMBER_DETAILS = new List<MEMBER_DETAILS>();
            this.MEMBER_DETAILS1 = new List<MEMBER_DETAILS>();
        }

        public int PartnerID { get; set; }
        public Nullable<System.Guid> Guid { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public virtual ICollection<MEMBER_DETAILS> MEMBER_DETAILS { get; set; }
        public virtual ICollection<MEMBER_DETAILS> MEMBER_DETAILS1 { get; set; }
    }
}
