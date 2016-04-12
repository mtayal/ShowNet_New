using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class EnteredViewModel
    {
        public int ScheduleID { get; set; }
        public int No { get; set; }
        public int Entry { get; set; }
        public int OrderIndex { get; set; }
        public int HorseID { get; set; }
        public string ClassID { get; set; }
        public string HorseName { get; set; }
        public int RiderID { get; set; }
        public string RiderName { get; set; }
        public bool? StandBy { get; set; }
        public int? Rank { get; set; }
        public int Purchages { get; set; }
        public int ModeID { get; set; }
        public string Owner { get; set; }
        public int? JFlts1 { get; set; }
        public int? TFlts1 { get; set; }
        public int? AllFlts1 { get; set; }
        public decimal? Time1 { get; set; }
        public int? JFlts2 { get; set; }
        public int? TFlts2 { get; set; }
        public int? AllFlts2 { get; set; }
        public decimal? Time2 { get; set; }
        public decimal? Score { get; set; }
        public decimal? Score2 { get; set; }
        public bool HasVideo { get { return !string.IsNullOrEmpty(MediaID); } }
        public bool Scratched { get; set; }
        public string MediaID { get; set; }
        //public string? TotalScore { get { return TotScore; } }
        public double? E { get; set; }
        public double? H { get; set; }
        public double? C { get; set; }
        public double? M { get; set; }
        public double? B { get; set; }
        public string Draw { get; set; }
        public bool Started { get; set; }
        public int ListID { get; set; }
     //   public string? TotScore { get; set; }
        public byte Status { get; set; }
        public int BackID { get; set; }
        
    }


}
