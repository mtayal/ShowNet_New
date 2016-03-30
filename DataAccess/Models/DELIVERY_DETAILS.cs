using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class DELIVERY_DETAILS
    {
        public DELIVERY_DETAILS()
        {
            this.MEMBER_DETAILS1 = new List<MEMBER_DETAILS>();
            this.PURCHASES = new List<Purchase>();
        }

        public int DeliveryDetailsID { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Instructions { get; set; }
        public int MemberDetails { get; set; }
        public int Purchase { get; set; }
        public virtual Purchase Purchase1 { get; set; }
        public virtual MEMBER_DETAILS MEMBER_DETAILS { get; set; }
        public virtual ICollection<MEMBER_DETAILS> MEMBER_DETAILS1 { get; set; }
        public virtual ICollection<Purchase> PURCHASES { get; set; }
    }
}
