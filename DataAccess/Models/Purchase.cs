using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Purchase
    {
        public Purchase()
        {
            this.DELIVERY_DETAILS = new List<DELIVERY_DETAILS>();
        }

        public int PurchaseID { get; set; }
        public int ProductID { get; set; }
        public int MemberID { get; set; }
        public Nullable<int> MediaID { get; set; }
        public Nullable<int> HorseShowID { get; set; }
        public bool IsGUIVisible { get; set; }
        public Nullable<int> CircuitID { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public Nullable<int> AmountPaid { get; set; }
        public Nullable<int> IncludeFromProduct { get; set; }
        public Nullable<System.DateTime> Expires { get; set; }
        public Nullable<int> DeliveryDetails { get; set; }
        public Nullable<int> ProductCost { get; set; }
        public Nullable<int> ChannelID { get; set; }
        public string Notes { get; set; }
        public Nullable<int> MemberBalance { get; set; }
        public virtual CIRCUIT CIRCUIT { get; set; }
        public virtual CIRCUIT CIRCUIT1 { get; set; }
        public virtual ICollection<DELIVERY_DETAILS> DELIVERY_DETAILS { get; set; }
        public virtual DELIVERY_DETAILS DELIVERY_DETAILS1 { get; set; }
        public virtual HORSE_SHOW HORSE_SHOW { get; set; }
        public virtual Medium Medium { get; set; }
        public virtual Medium Medium1 { get; set; }
        public virtual Medium Medium2 { get; set; }
        public virtual MEMBER_DETAILS MEMBER_DETAILS { get; set; }
        public virtual MEMBER_DETAILS MEMBER_DETAILS1 { get; set; }
        public virtual MEMBER_DETAILS MEMBER_DETAILS2 { get; set; }
    }
}
