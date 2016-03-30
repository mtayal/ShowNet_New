using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ACCOUNTING
    {
        public ACCOUNTING()
        {
            this.BILLINGs = new List<BILLING>();
            this.BILLINGs1 = new List<BILLING>();
            this.BILLINGs2 = new List<BILLING>();
        }

        public int ACCOUNTID { get; set; }
        public int MEMBERID { get; set; }
        public decimal STARTING_BALANCE { get; set; }
        public decimal BALANCE { get; set; }
        public decimal CREDIT_LIMIT { get; set; }
        public bool ENABLED { get; set; }
        public Nullable<System.DateTime> DATEMODIFIED { get; set; }
        public string MODIFIEDBY { get; set; }
        public int VERSION { get; set; }
        public Nullable<System.DateTime> DATECREATED { get; set; }
        public string CREATEDBY { get; set; }
        public virtual MEMBER_DETAILS MEMBER_DETAILS { get; set; }
        public virtual ICollection<BILLING> BILLINGs { get; set; }
        public virtual ICollection<BILLING> BILLINGs1 { get; set; }
        public virtual MEMBER_DETAILS MEMBER_DETAILS1 { get; set; }
        public virtual MEMBER_DETAILS MEMBER_DETAILS2 { get; set; }
        public virtual ICollection<BILLING> BILLINGs2 { get; set; }
    }
}
