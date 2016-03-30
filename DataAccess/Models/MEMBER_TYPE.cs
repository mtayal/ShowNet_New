using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class MEMBER_TYPE
    {
        public MEMBER_TYPE()
        {
            this.MEMBER_DETAILS = new List<MEMBER_DETAILS>();
            this.MEMBER_DETAILS1 = new List<MEMBER_DETAILS>();
            this.MEMBER_DETAILS2 = new List<MEMBER_DETAILS>();
        }

        public int TypeID { get; set; }
        public string MemberType { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Description { get; set; }
        public bool WriteData { get; set; }
        public Nullable<int> IncludedValueInCents { get; set; }
        public Nullable<int> ContractLengthInDays { get; set; }
        public Nullable<bool> IsSuperUser { get; set; }
        public virtual ICollection<MEMBER_DETAILS> MEMBER_DETAILS { get; set; }
        public virtual ICollection<MEMBER_DETAILS> MEMBER_DETAILS1 { get; set; }
        public virtual ICollection<MEMBER_DETAILS> MEMBER_DETAILS2 { get; set; }
    }
}
