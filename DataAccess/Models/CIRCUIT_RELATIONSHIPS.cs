using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class CIRCUIT_RELATIONSHIPS
    {
        public int CIRCUIT_RELATIONSHIP_ID { get; set; }
        public Nullable<int> CIRCUIT_ID { get; set; }
        public Nullable<int> HORSE_SHOW_ID { get; set; }
        public virtual CIRCUIT CIRCUIT { get; set; }
        public virtual CIRCUIT CIRCUIT1 { get; set; }
        public virtual HORSE_SHOW HORSE_SHOW { get; set; }
        public virtual HORSE_SHOW HORSE_SHOW1 { get; set; }
    }
}
