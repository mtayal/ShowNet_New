using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class View_SearchAutoComplete
    {
        public int BackID { get; set; }
        public string HorseName { get; set; }
        public string Owner1 { get; set; }
        public string Rider { get; set; }
        public int HorseShowID { get; set; }
        public string HorseShowName { get; set; }
        public int ListID { get; set; }
        public string RiderName { get; set; }
        public int MediaID { get; set; }
    }
}
