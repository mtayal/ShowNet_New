using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class PYRAMID_LOG
    {
        public int PyramidLogID { get; set; }
        public string Raw { get; set; }
        public string DTO { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public Nullable<int> Type { get; set; }
        public string XmlDecodeDTO { get; set; }
        public Nullable<int> HorseShowID { get; set; }
        public string ClassID { get; set; }
        public Nullable<bool> IsResend { get; set; }
        public string Message { get; set; }
    }
}
