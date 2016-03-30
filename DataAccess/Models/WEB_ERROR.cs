using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class WEB_ERROR
    {
        public int ErrorID { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorTrace { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}
