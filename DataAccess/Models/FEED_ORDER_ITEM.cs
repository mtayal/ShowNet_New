using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class FEED_ORDER_ITEM
    {
        public int ItemID { get; set; }
        public int OrderID { get; set; }
        public string Desc { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string ItemName { get; set; }
    }
}
