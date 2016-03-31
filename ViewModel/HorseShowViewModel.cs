using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
   public class HorseShowViewModel
    {
        public int HorseShowID { get; set; }
        public string HorseShowName { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Nullable<int> UpdateID { get; set; }
        public bool Active { get; set; }
        public string Comment { get; set; }
        public string Password { get; set; }
        public string LongDescription { get; set; }
        public string ShowImage { get; set; }
        public string ShowWebsite { get; set; }
        public string SponsorIDList { get; set; }
        public bool IsWWWVisible { get; set; }
        public bool IsFreeMobileWatch { get; set; }
        public Nullable<bool> HasScheduleDownload { get; set; }
        public Nullable<bool> HasPrizeListDownload { get; set; }
        public Nullable<bool> HasEntryBlankDownload { get; set; }
        public int ShowMode { get; set; }
        public string ShowModeString { get; set; }
        public bool IsFreeShow { get; set; }
        public Nullable<bool> HasVideo { get; set; }
        public Nullable<bool> RequiresCircuit { get; set; }
        public Nullable<bool> HasStreaming { get; set; }
        public Nullable<bool> RequiresRegistration { get; set; }
        public string AvailableProducts { get; set; }



    }
   public class HorseShowListViewModel
    {
        public IEnumerable<HorseShowViewModel> HorseShowList { get; set; }
        public IEnumerable<HorseShowViewModel> HorseUpcomingShowList { get; set; }

    }
   

}
