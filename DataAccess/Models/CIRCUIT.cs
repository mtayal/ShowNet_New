using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class CIRCUIT
    {
        public CIRCUIT()
        {
            this.PURCHASES = new List<Purchase>();
            this.CIRCUIT_RELATIONSHIPS = new List<CIRCUIT_RELATIONSHIPS>();
            this.PURCHASES1 = new List<Purchase>();
            this.CIRCUIT_RELATIONSHIPS1 = new List<CIRCUIT_RELATIONSHIPS>();
        }

        public int CIRCUIT_ID { get; set; }
        public string CIRCUIT_NAME { get; set; }
        public string CIRCUIT_DESCRIPTION { get; set; }
        public Nullable<int> CIRCUIT_PRICE { get; set; }
        public Nullable<System.DateTime> END_DATE { get; set; }
        public virtual ICollection<Purchase> PURCHASES { get; set; }
        public virtual ICollection<CIRCUIT_RELATIONSHIPS> CIRCUIT_RELATIONSHIPS { get; set; }
        public virtual ICollection<Purchase> PURCHASES1 { get; set; }
        public virtual ICollection<CIRCUIT_RELATIONSHIPS> CIRCUIT_RELATIONSHIPS1 { get; set; }
    }
}
