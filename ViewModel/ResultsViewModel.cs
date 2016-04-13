using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
   public class ResultsViewModel
    {
        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public int HorseShowId { get; set; }
        public int ScheduleID { get; set; }
        public string RingStatus { get; set; }
        public int RingId { get; set; }
        public DateTime ShowDate { get; set; }
        public int ShowDayID { get; set; }
        public int ModeID { get; set; }
        public IEnumerable<EnteredViewModel> EnteredList { get; set; }
        public IEnumerable<EnteredViewModel> EnteredListLiveData { get; set; }
    }
}
