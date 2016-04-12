using CommanLibrary;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;
using AutoMapper;
using DataAccess.Models;

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
                                         ShowDayID = x.ShowDayID,
                                         RingID = x.RingID
                                     }).ToList();
            return HorseShowDateList;
        }
        //5


        public IEnumerable<ScheduleViewModel> ScheduleList(int showDayId, int horseShowId)
        {

            var ringId = (from r in UnitOfWork.ShowDateRepository.GetQuery()
                          where r.ShowDayID == showDayId
                          select new
                          {
                              r.RingID,
                              r.ShowDayID
                          });
            var Schedule = (from x in UnitOfWork.OrderedGoListRepository.GetQuery()
                            where x.HorseShowID == horseShowId
                            select new
                            {
                                x.ClassID,
                                x.ScheduleID,
                                x.Started,
                                x.Scratched
                            });


            var ScheduleDataList = (from x in UnitOfWork.ScheduleRepository.GetQuery()
                                    where x.ShowDayID == showDayId

                                    select new ScheduleViewModel
                                    {
                                        ScheduleID = x.ScheduleID,
                                        ShowDayID = x.ShowDayID,
                                        ClassID = x.ClassID,
                                        ClassName = x.ClassName,
                                        UpdateID = x.UpdateID,
                                        ETATime = x.ETA.ToString(),
                                        SeenCount = Schedule.Where(a => a.ScheduleID == x.ScheduleID && a.ClassID == x.ClassID && a.Started == true && a.Scratched == false).Count(),
                                        ClassCount = Schedule.Where(a => a.ScheduleID == x.ScheduleID && a.ClassID == x.ClassID && a.Scratched == false).Count(),
                                        RingId = ringId.FirstOrDefault(a => a.ShowDayID == x.ShowDayID).RingID,
                                        RingStatus = x.RingStatus
                                    }).ToList();
            return ScheduleDataList;
        }


        public IEnumerable<MemberGroupViewModel> getMemberGroupList(int memberId)
        {
            try
            {
                var MemberGroupList = (from a in UnitOfWork.MemberDetailsRepository.GetQuery()
                                       join b in UnitOfWork.MemberGroupRepository.GetQuery() on a.MemberID equals b.AssociatedMember
                                       where b.Member == memberId

                                       select new MemberGroupViewModel
                                       {
                                           ID = b.ID,
                                           Member = b.Member,
                                           AssociatedMember = b.AssociatedMember,
                                           AssociateUserName = a.UserName,
                                           Password = a.Password
                                       }).ToList();

                return MemberGroupList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deleteAssociateMemberId(int id)
        {
            try
            {
                var MemberGroupList = UnitOfWork.MemberGroupRepository.GetQuery().Where(x => x.ID == id).SingleOrDefault();
                UnitOfWork.MemberGroupRepository.Delete(MemberGroupList);
                UnitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddNewAssociateUser(int loginMemberId, LoginViewModel newLogin)
        {
            try
            {
                var MemberDetails = from x in UnitOfWork.MemberDetailsRepository.GetQuery()
                                    where ((x.UserName == newLogin.Email || x.Email == newLogin.Email) && x.Password == newLogin.Password)

                                    select new MemberDetailsViewModel
                                    {
                                        MemberID = x.MemberID
                                    };

                int Id = MemberDetails.ToList().FirstOrDefault().MemberID;

                var MemberGroups = from y in UnitOfWork.MemberGroupRepository.GetQuery()
                                   where (y.Member == loginMemberId && y.AssociatedMember == Id)

                                   select new MemberGroupViewModel
                                   {
                                       Member = y.Member
                                   };
                if (MemberGroups.ToList().Count() != 0)
                {


                }
                else
                {
                    UnitOfWork.MemberGroupRepository.Insert(new MEMBER_GROUP { Member = loginMemberId, AssociatedMember = MemberDetails.ToList().FirstOrDefault().MemberID });
                    UnitOfWork.Save();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ResultsViewModel getResults(int ringID, int horseShowID, int scheduleID, string classID)
        {
            ResultsViewModel rs = new ResultsViewModel();
            var classResultData = (from a in UnitOfWork.ScheduleRepository.GetQuery()
                                   join b in UnitOfWork.ShowDateRepository.GetQuery() on a.ShowDayID equals b.ShowDayID
                                   join c in UnitOfWork.RingNameRepository.GetQuery() on b.RingID equals c.RingID
                                   join d in UnitOfWork.HorseShowRepository.GetQuery() on b.HorseShowID equals d.HorseShowID
                                   where a.ScheduleID == scheduleID && a.ClassID == classID

                                   select new ResultsViewModel
                                   {
                                       ClassId = a.ClassID,
                                       ClassName = a.ClassName,
                                       HorseShowId = d.HorseShowID,
                                       RingStatus = a.RingStatus,
                                       ShowDate = b.ShowDate,
                                       RingId = b.RingID,
                                       ShowDayID = a.ShowDayID,
                                       ModeID = a.ModeID
                                   });
            if (classResultData.ToList().FirstOrDefault().RingStatus == "Entered")
            {

                var Result = (from a in UnitOfWork.OrderedGoListRepository.GetQuery()
                              join b in UnitOfWork.EntrantRepository.GetQuery() on new { e1 = a.HorseShowID, e2 = a.BackID } equals new { e1 = b.HorseShowID, e2 = b.BackID }
                              join c in UnitOfWork.ScheduleRepository.GetQuery() on a.ScheduleID equals c.ScheduleID
                              join d in UnitOfWork.HorseShowRepository.GetQuery() on b.HorseShowID equals d.HorseShowID
                              where a.ScheduleID == scheduleID && a.ClassID == classID
                              select new EnteredViewModel
                              {
                                  OrderIndex = a.OrderIndex + 1,
                                  Entry = b.BackID,
                                  HorseName = b.HorseName,
                                  RiderName = a.RiderName,
                                  Rank = a.Rank
                              }).ToList();
                rs.EnteredList = Result;
            }
            else if (classResultData.ToList().FirstOrDefault().RingStatus == "Gone")
            {
                int ShowDayID = UnitOfWork.ShowDateRepository.GetQuery().FirstOrDefault(a => a.HorseShowID == classResultData.ToList().FirstOrDefault().HorseShowId && a.RingID == classResultData.ToList().FirstOrDefault().RingId && a.ShowDate == classResultData.ToList().FirstOrDefault().ShowDate).ShowDayID;
                int ModeID = (from a in UnitOfWork.ModeRepository.GetQuery()
                              join b in UnitOfWork.ScheduleRepository.GetQuery() on a.ModeID equals b.ModeID
                              join c in UnitOfWork.OrderedGoListRepository.GetQuery() on b.ScheduleID equals c.ScheduleID
                              join d in UnitOfWork.ShowDateRepository.GetQuery() on c.HorseShowID equals d.HorseShowID
                              where c.HorseShowID == classResultData.FirstOrDefault().HorseShowId
                              && d.RingID == classResultData.FirstOrDefault().RingId
                              && b.ClassID == classResultData.FirstOrDefault().ClassId
                              && b.ShowDayID == classResultData.FirstOrDefault().ShowDayID
                              select new EnteredViewModel
                              {
                                  ModeID = a.ModeID
                              }).FirstOrDefault().ModeID;
                if (ModeID == 1 || ModeID == 11)
                {
                    var Result = (from a in UnitOfWork.OrderedGoListRepository.GetQuery()
                                  join b in UnitOfWork.ScheduleRepository.GetQuery() on a.ScheduleID equals b.ScheduleID
                                  join c in UnitOfWork.EntrantRepository.GetQuery() on new { e1 = a.HorseShowID, e2 = a.BackID } equals new { e1 = c.HorseShowID, e2 = c.BackID }
                                  where b.ShowDayID == ShowDayID && a.ClassID == classResultData.ToList().FirstOrDefault().ClassId
                                  orderby a.Scratched, a.Rank, a.OrderIndex ascending, a.StandBy descending

                                  select new EnteredViewModel
                                  {
                                      ClassID = a.ClassID,
                                      Scratched = a.Scratched,
                                      Started = a.Started,
                                      OrderIndex = a.OrderIndex,
                                      ListID = a.ListID,
                                      Status = a.Status,
                                      BackID = a.BackID,
                                      RiderName = a.RiderName,
                                      HorseName = c.HorseName,
                                      Owner = c.Owner1,
                                      ModeID = b.ModeID,
                                      JFlts1 = a.JumpFaults1,
                                      TFlts1 = a.TimeFaults1,
                                      AllFlts1 = a.TimeFaults1,
                                      Time1 = a.Time1,
                                      JFlts2 = a.JumpFaults2,
                                      TFlts2 = a.TimeFaults2,
                                      AllFlts2 = a.TimeFaults2,
                                      Time2 = a.Time1,
                                      MediaID = a.MediaID,
                                      StandBy = a.StandBy,
                                      Rank = a.Rank,
                                      Score = a.Score,
                                      Score2 = a.Score2,
                                      //TotalScore=a.TotalScore,
                                      Draw = a.Draw,
                                      ScheduleID = a.ScheduleID
                                  }).ToList();
                    rs.EnteredList = Result;
                }
                else if (ModeID == 2 || ModeID == 15)
                {
                    var Result = (from a in UnitOfWork.OrderedGoListRepository.GetQuery()
                                  join b in UnitOfWork.ScheduleRepository.GetQuery() on a.ScheduleID equals b.ScheduleID
                                  join c in UnitOfWork.EntrantRepository.GetQuery() on new { e1 = a.HorseShowID, e2 = a.BackID } equals new { e1 = c.HorseShowID, e2 = c.BackID }
                                  where b.ShowDayID == ShowDayID && a.ClassID == classResultData.ToList().FirstOrDefault().ClassId
                                  orderby a.Scratched, a.OrderIndex ascending, a.Score descending

                                  select new EnteredViewModel
                                  {
                                      ClassID = a.ClassID,
                                      Scratched = a.Scratched,
                                      Started = a.Started,
                                      OrderIndex = a.OrderIndex,
                                      ListID = a.ListID,
                                      Status = a.Status,
                                      BackID = a.BackID,
                                      RiderName = a.RiderName,
                                      HorseName = c.HorseName,
                                      Owner = c.Owner1,
                                      ModeID = b.ModeID,
                                      JFlts1 = a.JumpFaults1,
                                      TFlts1 = a.TimeFaults1,
                                      AllFlts1 = a.TimeFaults1,
                                      Time1 = a.Time1,
                                      JFlts2 = a.JumpFaults2,
                                      TFlts2 = a.TimeFaults2,
                                      AllFlts2 = a.TimeFaults2,
                                      Time2 = a.Time1,
                                      MediaID = a.MediaID,
                                      StandBy = a.StandBy,
                                      Rank = a.Rank,
                                      Score = a.Score,
                                      Score2 = a.Score2,
                                      //TotalScore=a.TotalScore,
                                      Draw = a.Draw,
                                      ScheduleID = a.ScheduleID
                                  }).ToList();
                    rs.EnteredList = Result;
                }
                else if (ModeID == 3)
                {
                    var Result = (from a in UnitOfWork.OrderedGoListRepository.GetQuery()
                                  join b in UnitOfWork.ScheduleRepository.GetQuery() on a.ScheduleID equals b.ScheduleID
                                  join c in UnitOfWork.EntrantRepository.GetQuery() on new { e1 = a.HorseShowID, e2 = a.BackID } equals new { e1 = c.HorseShowID, e2 = c.BackID }
                                  where b.ShowDayID == ShowDayID && a.ClassID == classResultData.ToList().FirstOrDefault().ClassId
                                  orderby a.Scratched, a.TotalFaults1, a.TotalFaults2, a.Time2, a.Time1, a.OrderIndex ascending

                                  select new EnteredViewModel
                                  {
                                      ClassID = a.ClassID,
                                      Scratched = a.Scratched,
                                      Started = a.Started,
                                      OrderIndex = a.OrderIndex,
                                      ListID = a.ListID,
                                      Status = a.Status,
                                      BackID = a.BackID,
                                      RiderName = a.RiderName,
                                      HorseName = c.HorseName,
                                      Owner = c.Owner1,
                                      ModeID = b.ModeID,
                                      JFlts1 = a.JumpFaults1,
                                      TFlts1 = a.TimeFaults1,
                                      AllFlts1 = a.TimeFaults1,
                                      Time1 = a.Time1,
                                      JFlts2 = a.JumpFaults2,
                                      TFlts2 = a.TimeFaults2,
                                      AllFlts2 = a.TimeFaults2,
                                      Time2 = a.Time1,
                                      MediaID = a.MediaID,
                                      StandBy = a.StandBy,
                                      Rank = a.Rank,
                                      Score = a.Score,
                                      Score2 = a.Score2,
                                      //TotalScore=a.TotalScore,
                                      Draw = a.Draw,
                                      ScheduleID = a.ScheduleID
                                  }).ToList();
                    rs.EnteredList = Result;
                }
                else if (ModeID == 4 || ModeID == 8 || ModeID == 10)
                {
                    int No = 0;
                    var Result = (from a in UnitOfWork.OrderedGoListRepository.GetQuery()
                                  join b in UnitOfWork.ScheduleRepository.GetQuery() on a.ScheduleID equals b.ScheduleID
                                  join c in UnitOfWork.EntrantRepository.GetQuery() on new { e1 = a.HorseShowID, e2 = a.BackID } equals new { e1 = c.HorseShowID, e2 = c.BackID }
                                  where b.ShowDayID == ShowDayID && a.ClassID == classResultData.ToList().FirstOrDefault().ClassId
                                  orderby a.Scratched, a.TotalFaults2, a.TotalFaults1, a.Time2, a.Time1, a.OrderIndex ascending

                                  select new EnteredViewModel
                                  {
                                      ClassID = a.ClassID,
                                      Scratched = a.Scratched,
                                      Started = a.Started,
                                      OrderIndex = a.OrderIndex,
                                      ListID = a.ListID,
                                      Status = a.Status,
                                      BackID = a.BackID,
                                      RiderName = a.RiderName,
                                      HorseName = c.HorseName,
                                      Owner = c.Owner1,
                                      ModeID = b.ModeID,
                                      JFlts1 = a.JumpFaults1,
                                      TFlts1 = a.TimeFaults1,
                                      AllFlts1 = a.TimeFaults1,
                                      Time1 = a.Time1,
                                      JFlts2 = a.JumpFaults2,
                                      TFlts2 = a.TimeFaults2,
                                      AllFlts2 = a.TimeFaults2,
                                      Time2 = a.Time1,
                                      MediaID = a.MediaID,
                                      StandBy = a.StandBy,
                                      Rank = a.Rank,
                                      Score = a.Score,
                                      Score2 = a.Score2,
                                      //TotalScore=a.TotalScore,
                                      Draw = a.Draw,
                                      ScheduleID = a.ScheduleID
                                  }).ToList();
                    rs.EnteredList = Result;
                }
                else if (ModeID == 5 || ModeID == 9 || ModeID == 13)
                {
                    var Result = (from a in UnitOfWork.OrderedGoListRepository.GetQuery()
                                  join b in UnitOfWork.ScheduleRepository.GetQuery() on a.ScheduleID equals b.ScheduleID
                                  join c in UnitOfWork.EntrantRepository.GetQuery() on new { e1 = a.HorseShowID, e2 = a.BackID } equals new { e1 = c.HorseShowID, e2 = c.BackID }
                                  where b.ShowDayID == ShowDayID && a.ClassID == classResultData.ToList().FirstOrDefault().ClassId
                                  orderby a.Scratched, a.TotalFaults1, a.Time1, a.OrderIndex ascending

                                  select new EnteredViewModel
                                  {
                                      ClassID = a.ClassID,
                                      Scratched = a.Scratched,
                                      Started = a.Started,
                                      OrderIndex = a.OrderIndex,
                                      ListID = a.ListID,
                                      Status = a.Status,
                                      BackID = a.BackID,
                                      RiderName = a.RiderName,
                                      HorseName = c.HorseName,
                                      Owner = c.Owner1,
                                      ModeID = b.ModeID,
                                      JFlts1 = a.JumpFaults1,
                                      TFlts1 = a.TimeFaults1,
                                      AllFlts1 = a.TimeFaults1,
                                      Time1 = a.Time1,
                                      JFlts2 = a.JumpFaults2,
                                      TFlts2 = a.TimeFaults2,
                                      AllFlts2 = a.TimeFaults2,
                                      Time2 = a.Time1,
                                      MediaID = a.MediaID,
                                      StandBy = a.StandBy,
                                      Rank = a.Rank,
                                      Score = a.Score,
                                      Score2 = a.Score2,
                                      //TotalScore=a.TotalScore,
                                      Draw = a.Draw,
                                      ScheduleID = a.ScheduleID
                                  }).ToList();
                    rs.EnteredList = Result;
                }
                else if (ModeID == 6)
                {
                    var Result = (from a in UnitOfWork.OrderedGoListRepository.GetQuery()
                                  join b in UnitOfWork.ScheduleRepository.GetQuery() on a.ScheduleID equals b.ScheduleID
                                  join c in UnitOfWork.EntrantRepository.GetQuery() on new { e1 = a.HorseShowID, e2 = a.BackID } equals new { e1 = c.HorseShowID, e2 = c.BackID }
                                  where b.ShowDayID == ShowDayID && a.ClassID == classResultData.ToList().FirstOrDefault().ClassId
                                  orderby a.Scratched, a.TotalFaults1, a.TimeFaults1, a.OrderIndex ascending

                                  select new EnteredViewModel
                                  {
                                      ClassID = a.ClassID,
                                      Scratched = a.Scratched,
                                      Started = a.Started,
                                      OrderIndex = a.OrderIndex,
                                      ListID = a.ListID,
                                      Status = a.Status,
                                      BackID = a.BackID,
                                      RiderName = a.RiderName,
                                      HorseName = c.HorseName,
                                      Owner = c.Owner1,
                                      ModeID = b.ModeID,
                                      JFlts1 = a.JumpFaults1,
                                      TFlts1 = a.TimeFaults1,
                                      AllFlts1 = a.TimeFaults1,
                                      Time1 = a.Time1,
                                      JFlts2 = a.JumpFaults2,
                                      TFlts2 = a.TimeFaults2,
                                      AllFlts2 = a.TimeFaults2,
                                      Time2 = a.Time1,
                                      MediaID = a.MediaID,
                                      StandBy = a.StandBy,
                                      Rank = a.Rank,
                                      Score = a.Score,
                                      Score2 = a.Score2,
                                      //TotalScore=a.TotalScore,
                                      Draw = a.Draw,
                                      ScheduleID = a.ScheduleID
                                  }).ToList();
                    rs.EnteredList = Result;
                }
                else if (ModeID == 7)
                {
                    var Result = (from a in UnitOfWork.OrderedGoListRepository.GetQuery()
                                  join b in UnitOfWork.ScheduleRepository.GetQuery() on a.ScheduleID equals b.ScheduleID
                                  join c in UnitOfWork.EntrantRepository.GetQuery() on new { e1 = a.HorseShowID, e2 = a.BackID } equals new { e1 = c.HorseShowID, e2 = c.BackID }
                                  where b.ShowDayID == ShowDayID && a.ClassID == classResultData.ToList().FirstOrDefault().ClassId
                                  orderby a.Scratched, a.TotalScore descending, a.OrderIndex ascending

                                  select new EnteredViewModel
                                  {
                                      ClassID = a.ClassID,
                                      Scratched = a.Scratched,
                                      Started = a.Started,
                                      OrderIndex = a.OrderIndex,
                                      ListID = a.ListID,
                                      Status = a.Status,
                                      BackID = a.BackID,
                                      RiderName = a.RiderName,
                                      HorseName = c.HorseName,
                                      Owner = c.Owner1,
                                      ModeID = b.ModeID,
                                      JFlts1 = a.JumpFaults1,
                                      TFlts1 = a.TimeFaults1,
                                      AllFlts1 = a.TimeFaults1,
                                      Time1 = a.Time1,
                                      JFlts2 = a.JumpFaults2,
                                      TFlts2 = a.TimeFaults2,
                                      AllFlts2 = a.TimeFaults2,
                                      Time2 = a.Time1,
                                      MediaID = a.MediaID,
                                      StandBy = a.StandBy,
                                      Rank = a.Rank,
                                      Score = a.Score,
                                      Score2 = a.Score2,
                                      //TotalScore=a.TotalScore,
                                      Draw = a.Draw,
                                      ScheduleID = a.ScheduleID
                                  }).ToList();
                    rs.EnteredList = Result;
                }
                else if (ModeID == 14)
                {
                    var Result = (from a in UnitOfWork.OrderedGoListRepository.GetQuery()
                                  join b in UnitOfWork.ScheduleRepository.GetQuery() on a.ScheduleID equals b.ScheduleID
                                  join c in UnitOfWork.EntrantRepository.GetQuery() on new { e1 = a.HorseShowID, e2 = a.BackID } equals new { e1 = c.HorseShowID, e2 = c.BackID }
                                  where b.ShowDayID == ShowDayID && a.ClassID == classResultData.ToList().FirstOrDefault().ClassId
                                  orderby a.TotalScore descending, a.OrderIndex ascending

                                  select new EnteredViewModel
                                  {
                                      ClassID = a.ClassID,
                                      Scratched = a.Scratched,
                                      Started = a.Started,
                                      OrderIndex = a.OrderIndex,
                                      ListID = a.ListID,
                                      Status = a.Status,
                                      BackID = a.BackID,
                                      RiderName = a.RiderName,
                                      HorseName = c.HorseName,
                                      Owner = c.Owner1,
                                      ModeID = b.ModeID,
                                      JFlts1 = a.JumpFaults1,
                                      TFlts1 = a.TimeFaults1,
                                      AllFlts1 = a.TimeFaults1,
                                      Time1 = a.Time1,
                                      JFlts2 = a.JumpFaults2,
                                      TFlts2 = a.TimeFaults2,
                                      AllFlts2 = a.TimeFaults2,
                                      Time2 = a.Time1,
                                      MediaID = a.MediaID,
                                      StandBy = a.StandBy,
                                      Rank = a.Rank,
                                      Score = a.Score,
                                      Score2 = a.Score2,
                                      //TotalScore=a.TotalScore,
                                      Draw = a.Draw,
                                      ScheduleID = a.ScheduleID
                                  }).ToList();
                    rs.EnteredList = Result;
                }
                else if (ModeID == 7)
                {
                    var Result = (from a in UnitOfWork.OrderedGoListRepository.GetQuery()
                                  join b in UnitOfWork.ScheduleRepository.GetQuery() on a.ScheduleID equals b.ScheduleID
                                  join c in UnitOfWork.EntrantRepository.GetQuery() on new { e1 = a.HorseShowID, e2 = a.BackID } equals new { e1 = c.HorseShowID, e2 = c.BackID }
                                  where b.ShowDayID == ShowDayID && a.ClassID == classResultData.ToList().FirstOrDefault().ClassId
                                  orderby a.Scratched, a.TotalScore descending, a.OrderIndex ascending

                                  select new EnteredViewModel
                                  {
                                      ClassID = a.ClassID,
                                      Scratched = a.Scratched,
                                      Started = a.Started,
                                      OrderIndex = a.OrderIndex,
                                      ListID = a.ListID,
                                      Status = a.Status,
                                      BackID = a.BackID,
                                      RiderName = a.RiderName,
                                      HorseName = c.HorseName,
                                      Owner = c.Owner1,
                                      ModeID = b.ModeID,
                                      JFlts1 = a.JumpFaults1,
                                      TFlts1 = a.TimeFaults1,
                                      AllFlts1 = a.TimeFaults1,
                                      Time1 = a.Time1,
                                      JFlts2 = a.JumpFaults2,
                                      TFlts2 = a.TimeFaults2,
                                      AllFlts2 = a.TimeFaults2,
                                      Time2 = a.Time1,
                                      MediaID = a.MediaID,
                                      StandBy = a.StandBy,
                                      Rank = a.Rank,
                                      Score = a.Score,
                                      Score2 = a.Score2,
                                      //TotalScore=a.TotalScore,
                                      Draw = a.Draw,
                                      ScheduleID = a.ScheduleID

                                  }).ToList();
                    rs.EnteredList = Result;
                }

            }
            else if (classResultData.ToList().FirstOrDefault().RingStatus != "Entered" && classResultData.ToList().FirstOrDefault().RingStatus != "Gone") // For Live RingStatus
            {
                var showDetail = (from a in UnitOfWork.ShowDateRepository.GetQuery()
                                  where a.HorseShowID == classResultData.ToList().FirstOrDefault().HorseShowId && a.RingID == classResultData.ToList().FirstOrDefault().RingId && a.ShowDate == classResultData.ToList().FirstOrDefault().ShowDate
                                  select new
                                  {
                                      a.ShowDayID,
                                      a.CurSchedID1,
                                      a.CurSchedID2
                                  });

                var Result = (from a in UnitOfWork.OrderedGoListRepository.GetQuery()
                              join b in UnitOfWork.ScheduleRepository.GetQuery() on a.ScheduleID equals b.ScheduleID
                              join c in UnitOfWork.EntrantRepository.GetQuery() on new { e1 = a.HorseShowID, e2 = a.BackID } equals new { e1 = c.HorseShowID, e2 = c.BackID }
                              where (b.RingStatus == "Started" || b.RingStatus == "Round 2")
                              && b.ShowDayID == showDetail.ToList().FirstOrDefault().ShowDayID && a.ScheduleID == showDetail.ToList().FirstOrDefault().CurSchedID1
                              && a.Started == false && a.Scratched == false && a.Deleted == false
                              select new EnteredViewModel
                              {
                                  ListID = a.ListID,
                                  OrderIndex = a.OrderIndex,
                                  ClassID = a.ClassID,
                                  BackID = a.BackID,
                                  HorseName = c.HorseName,
                                  RiderName = a.RiderName,
                                  Status = a.Status,
                                  Draw = a.Draw,
                                  ScheduleID = a.ScheduleID

                              }).ToList();

                rs.EnteredList = Result.Where(x => x.ClassID == classResultData.ToList().FirstOrDefault().ClassId).ToList();
            }
            rs.ClassName = classResultData.ToList().FirstOrDefault().ClassName;
            rs.HorseShowId = classResultData.ToList().FirstOrDefault().HorseShowId;
            rs.ModeID = classResultData.ToList().FirstOrDefault().ModeID;
            if (rs.ModeID == 3 || rs.ModeID == 4 || rs.ModeID == 12)
            {
                rs.EnteredList = rs.EnteredList.Where(a => a.Started == true && a.Scratched == false);
            }
            else
            {
                rs.EnteredList = rs.EnteredList.Where(a => a.Started == true && a.Scratched == false);
            }

            return rs;
        }
        #region For Showing List on My Video Page
        public IEnumerable<ViewShowPurchaseViewModel> GetViewShowPurchase(int memberId)
        {
            try
            {
                var ViewShowPurchaseList = (from vsp in UnitOfWork.ViewShowPurchaseRepository.GetQuery()
                                            where vsp.MemberID == memberId
                                            select new ViewShowPurchaseViewModel
                                            {
                                                PurchaseID = vsp.PurchaseID,
                                                MemberID = vsp.MemberID,
                                                HorseShowID = vsp.HorseShowID,
                                                HorseShowName = vsp.HorseShowName,
                                                StartDate = vsp.StartDate,
                                                ProductID = vsp.ProductID,
                                                AmountPaid = vsp.AmountPaid,
                                                CircuitID = vsp.CircuitID,
                                            }).ToList();

                return ViewShowPurchaseList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region For Payment & credit
        public PaymentCreditViewModel GetUpdatePaymentCredit(int MemberID)
        {


            try
            {
                PaymentCreditViewModel pc = new PaymentCreditViewModel();
                var PurchasesData = (from p1 in UnitOfWork.PurchaseRepository.GetQuery()
                                     join p2 in UnitOfWork.ProductRepository.GetQuery() on p1.ProductID equals p2.ProductID
                                     where p1.MemberID == MemberID
                                     orderby p1.Expires descending
                                     select new PurchaseViewModel
                                     {
                                         ProductName = p2.ProductName,
                                         Expires = p1.Expires,
                                     }).FirstOrDefault();

                var AccountingData = (from a in UnitOfWork.AccountingRepository.GetQuery()
                                      where a.MEMBERID == MemberID
                                      select new AccountingViewModel
                                      {
                                          BALANCE = a.BALANCE,
                                      });

                var viewEntrantMediaList = (from vp in UnitOfWork.ViewPurchasesRepository.GetQuery()
                                            where vp.MemberID == MemberID
                                            select new ViewPurchasesViewModel
                                            {
                                                ProductName = vp.ProductName,
                                                AmountPaid = vp.AmountPaid,
                                                ProductDescription = vp.ProductDescription,
                                                Timestamp = vp.Timestamp,
                                                Notes = vp.Notes,
                                                MemberBalance = vp.MemberBalance,
                                            }).ToList();


                pc.AccountingObject.BALANCE = Convert.ToDecimal(AccountingData.FirstOrDefault().BALANCE);
                pc.PurchaseObject = PurchasesData;
                pc.ViewPurchasesList = viewEntrantMediaList;
                return pc;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
