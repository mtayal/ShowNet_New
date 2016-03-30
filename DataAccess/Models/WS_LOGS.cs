using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class WS_LOGS
    {
        public int id { get; set; }
        public string Username { get; set; }
        public string IP { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public string Service { get; set; }
        public string Params { get; set; }
    }
}
