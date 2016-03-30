using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class PRODUCT_TOKEN
    {
        public int ProductTokenID { get; set; }
        public string Token { get; set; }
        public string Email { get; set; }
        public string IPAddress { get; set; }
        public Nullable<System.DateTime> Expires { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public string FactoryName { get; set; }
        public Nullable<int> FactoryKey { get; set; }
    }
}
