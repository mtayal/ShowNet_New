using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class COMMAND
    {
        public int ID { get; set; }
        public Nullable<int> MemberID { get; set; }
        public Nullable<bool> IsComplete { get; set; }
        public Nullable<int> CommandType { get; set; }
    }
}
