using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class VIEW_PURCHASES_TEST
    {
        public int PurchaseID { get; set; }
        public int ProductID { get; set; }
        public int MemberID { get; set; }
        public Nullable<int> MediaID { get; set; }
        public Nullable<int> HorseShowID { get; set; }
        public Nullable<int> CircuitID { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public Nullable<System.DateTime> Expires { get; set; }
        public Nullable<int> AmountPaid { get; set; }
        public Nullable<int> IncludeFromProduct { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string HorseName { get; set; }
        public Nullable<int> BackID { get; set; }
        public string ClassID { get; set; }
        public string ClassName { get; set; }
        public string HorseShowName { get; set; }
        public string CIRCUIT_NAME { get; set; }
    }
}
