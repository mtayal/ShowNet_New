using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Message
    {
        public int MessageID { get; set; }
        public string HeadLine { get; set; }
        public string Body { get; set; }
        public Nullable<int> UpdateID { get; set; }
        public System.DateTime PostedTime { get; set; }
        public bool SentStatus { get; set; }
        public Nullable<int> HorseShowID { get; set; }
        public Nullable<bool> Visible { get; set; }
    }
}
