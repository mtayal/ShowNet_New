using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
   public class ShowDetailsViewModel
    {
        public int HorseShowID { get; set; }
        public DateTime StartDate { get; set; }
        public IEnumerable<CalenderYearViewModel> YearList { get; set; }
        public IEnumerable<CalenderMonthViewModel> MonthList { get; set; }
        public IEnumerable<ScheduleViewModel> ScheduleList { get; set; }
        public IEnumerable<HorseShowViewModel> HorseShowList { get; set; }
        public IEnumerable<ShowDateViewModel> ShowDateList { get; set; }
        public IEnumerable<ShowDateViewModel> RingNameList { get; set; }
        public int SelectedSchedule { get; set; }
        public int SelectedHorseShow { get; set; }
        public int SelectedHorseShowDate { get; set; }
        public int SelectedYear { get; set; }
        public int SelectedMonth { get; set; }
        public int SelectedRingName { get; set; }
        
    }
}
