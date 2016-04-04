using CommanLibrary;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;
using AutoMapper;

namespace DataAccess.DAL
{
    public class ShownetDa : BaseDa
    {
        public ShownetDa(IUnitOfWork unityOfWork)
            : base(unityOfWork)
        {

        }

        public IEnumerable<HorseShowViewModel> GetHorseShow(int numberOfShows, HorseShowMode showMode)
        {
            try
            {
                DateTime nowPlusOne = DateTime.Now.AddDays(1);
                string mode = GetLabelForShowMode(showMode);
                var Shows = (from x in UnitOfWork.HorseShowRepository.GetQuery()
                             where x.StartDate <= nowPlusOne && x.IsWWWVisible //&& x.ShowMode == showMode
                             orderby x.StartDate descending
                             select new HorseShowViewModel
                             {
                                 HorseShowID = x.HorseShowID,
                                 HorseShowName = x.HorseShowName,
                                 ShowModeString = mode,
                                 StartDate = x.StartDate

                             }).Take(numberOfShows);
                return Mapper.Map<IEnumerable<HorseShowViewModel>>(Shows.ToList());
            }
            catch (Exception)
            {

                throw;
            }

        }
        public IEnumerable<HorseShowViewModel> GetUpComingHorseShow(int numberOfShows, HorseShowMode showMode)
        {
            try
            {
                var Shows = (from x in UnitOfWork.HorseShowRepository.GetQuery()
                             where x.StartDate > DateTime.Now
                             orderby x.StartDate descending
                             select new HorseShowViewModel
                             {
                                 HorseShowID = x.HorseShowID,
                                 HorseShowName = x.HorseShowName,
                                 StartDate = x.StartDate,
                                 EndDate = x.EndDate

                             }).Take(numberOfShows);
                return Mapper.Map<IEnumerable<HorseShowViewModel>>(Shows.ToList());
            }
            catch (Exception)
            {

                throw;
            }

        }

        public string GetLabelForShowMode(HorseShowMode mode)
        {
            switch (mode)
            {
                case HorseShowMode.Jumper:
                    return "H/J";
                case HorseShowMode.Dressage:
                    return "D";
                case HorseShowMode.Reining:
                    return "R";
                default:
                    return "H/J";
            }
        }

        public List<CalenderYearViewModel> yearList()
        {
            int i = DateTime.Now.Year;
            List<CalenderYearViewModel> yearListdata = new List<CalenderYearViewModel>();
            for (i = i - 13; i <= DateTime.Now.Year + 1; i++)
            {
                yearListdata.Add(new CalenderYearViewModel
                {
                    Text = i.ToString(),
                    Value = i

                });
            }
            return yearListdata;
        }
        public List<CalenderMonthViewModel> monthList()
        {
            string[] monthNames = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            List<CalenderMonthViewModel> monthListdata = new List<CalenderMonthViewModel>();
            int i = 1;
            foreach (string m in monthNames) // writing out
            {
                monthListdata.Add(new CalenderMonthViewModel
                {
                    Text = m,
                    Value = i++

                });
            }
            return monthListdata;
        }
        //1
        public HorseShowViewModel ShowDetailsDate(int? HorseShowId)
        {
            try
            {
                var HorseShowDate = (from x in UnitOfWork.HorseShowRepository.GetQuery()
                                     where x.HorseShowID == HorseShowId
                                     select new HorseShowViewModel
                                     {
                                         StartDate = x.StartDate,
                                         HorseShowID = x.HorseShowID
                                     }).FirstOrDefault();
                return HorseShowDate;
            }
            catch (Exception)
            {

                throw;
            }

        }
        //2
        public IEnumerable<HorseShowViewModel> HorseShowNameDataList(DateTime StartDate)
        {
            var HorseShowNameList = (from x in UnitOfWork.HorseShowRepository.GetQuery()
                                     where x.StartDate.Year == StartDate.Year && x.StartDate.Month == StartDate.Month
                                     select new HorseShowViewModel
                                     {
                                         HorseShowName = x.HorseShowName,
                                         HorseShowID = x.HorseShowID
                                     }).ToList();
            return HorseShowNameList;
        }
        //3
        public IEnumerable<ShowDateViewModel> HorseShowDateList(int? horseShowId)
        {
            var HorseShowDateList = (from x in UnitOfWork.ShowDateRepository.GetQuery()
                                     where x.HorseShowID == horseShowId
                                     orderby x.ShowDate ascending
                                     select new ShowDateViewModel
                                     {
                                         ShowsDate = x.ShowDate.ToString()

                                     }).Distinct().ToList();
            return HorseShowDateList;
        }
        //4
        public IEnumerable<ShowDateViewModel> HorseRingListList(DateTime showDate, int horseShowId)
        {
            var HorseShowDateList = (from x in UnitOfWork.ShowDateRepository.GetQuery()
                                     join y in UnitOfWork.RingNameRepository.GetQuery() on x.RingID equals y.RingID
                                     where x.ShowDate == showDate && x.HorseShowID == horseShowId

                                     select new ShowDateViewModel
                                     {
                                         RingName = y.RingName,
                                         ShowDayID = x.ShowDayID

                                     }).Distinct().ToList();
            return HorseShowDateList;
        }
        //5

        public IEnumerable<ScheduleViewModel> ScheduleList(int showDayId)
        {
            var ScheduleDataList = (from x in UnitOfWork.ScheduleRepository.GetQuery()
                                     where x.ShowDayID==x.ShowDayID

                                     select new ScheduleViewModel
                                     {
                                       ScheduleID=x.ScheduleID,
                                       ShowDayID=x.ShowDayID,
                                       ClassID=x.ClassID,
                                       ClassName=x.ClassName,
                                       UpdateID=x.UpdateID

                                     }).ToList();
            return ScheduleDataList;
        }





    }
}
