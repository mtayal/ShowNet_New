using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class EntrantViewModel
    {
        public int BackID { get; set; }
        public int HorseShowID { get; set; }
        public int StatusID { get; set; }
        public string HorseName { get; set; }
        public string Trainer { get; set; }
        public string Owner1 { get; set; }
        public string Owner2 { get; set; }
        public Nullable<int> UpdateID { get; set; }
        public string Rider { get; set; }
        public string RiderAddr { get; set; }
        public string Owner1Addr { get; set; }
        public int EntrantID { get; set; }
    }
}
