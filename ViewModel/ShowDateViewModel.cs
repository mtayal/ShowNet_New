using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ShowDateViewModel
    {
        public int ShowDayID { get; set; }
        public int HorseShowID { get; set; }
        public System.DateTime ShowDate { get; set; }
        public int RingID { get; set; }
        public int CurrentSeqNo { get; set; }
        public System.DateTime StartTime { get; set; }
        public Nullable<int> UpdateID { get; set; }
        public int CurSchedID1 { get; set; }
        public int CurSchedID2 { get; set; }
        public string Comment { get; set; }
        public string RingName { get; set; }
        public string ShowsDate { get; set; }
    }
}
