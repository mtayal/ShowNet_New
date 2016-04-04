using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
   public class OrderedGoListViewModel
    {
        public int ListID { get; set; }
        public int HorseShowID { get; set; }
        public int ScheduleID { get; set; }
        public string ClassID { get; set; }
        public int OrderIndex { get; set; }
        public int BackID { get; set; }
        public string RiderName { get; set; }
        public bool Started { get; set; }
        public bool Scratched { get; set; }
        public Nullable<bool> StandBy { get; set; }
        public Nullable<int> JumpFaults1 { get; set; }
        public Nullable<int> TimeFaults1 { get; set; }
        public Nullable<int> TotalFaults1 { get; set; }
        public Nullable<decimal> Time1 { get; set; }
        public Nullable<int> JumpFaults2 { get; set; }
        public Nullable<int> TimeFaults2 { get; set; }
        public Nullable<int> TotalFaults2 { get; set; }
        public Nullable<decimal> Time2 { get; set; }
        public Nullable<decimal> Score { get; set; }
        public Nullable<int> Rank { get; set; }
        public Nullable<int> UpdateID { get; set; }
        public bool Added { get; set; }
        public int GoneIndex { get; set; }
        public bool Deleted { get; set; }
        public bool Modified { get; set; }
        public bool FinalOrder { get; set; }
        public Nullable<bool> Time1Pos { get; set; }
        public Nullable<bool> Time2Pos { get; set; }
        public Nullable<decimal> Score2 { get; set; }
        public Nullable<decimal> TotalScore { get; set; }
        public string MediaID { get; set; }
        public byte[] Timestamp { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public byte Status { get; set; }
        public Nullable<double> E { get; set; }
        public Nullable<double> H { get; set; }
        public Nullable<double> C { get; set; }
        public Nullable<double> M { get; set; }
        public Nullable<double> B { get; set; }
        public Nullable<double> MaxDresage { get; set; }
        public string Draw { get; set; }
    }
}
