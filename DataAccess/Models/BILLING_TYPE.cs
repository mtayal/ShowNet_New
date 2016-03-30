using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class BILLING_TYPE
    {
        public BILLING_TYPE()
        {
            this.BILLINGs = new List<BILLING>();
            this.BILLINGs1 = new List<BILLING>();
        }

        public int BILLING_TYPEID { get; set; }
        public string BILLING_TYPE1 { get; set; }
        public virtual ICollection<BILLING> BILLINGs { get; set; }
        public virtual ICollection<BILLING> BILLINGs1 { get; set; }
    }
}
