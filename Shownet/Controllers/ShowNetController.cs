using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;
using DataAccess.DAL;
using DataAccess.Repository;
using CommanLibrary;
using AutoMapper;
namespace Shownet.Controllers
{
    public class ShowNetController : Controller
    {
        private readonly ShownetDa shownetDa;
        private readonly AccountDa accountDa;
        private readonly UnitOfWork unitOfWork;

        public ShowNetController()
        {
            unitOfWork = new UnitOfWork();
            shownetDa = new ShownetDa(unitOfWork);
            accountDa = new AccountDa(unitOfWork);
        }
        public ActionResult Default()
        {

            HorseShowListViewModel hs = new HorseShowListViewModel();
            hs.HorseShowList = shownetDa.GetHorseShow(6, HorseShowMode.Jumper).AsEnumerable();
            hs.HorseUpcomingShowList = shownetDa.GetUpComingHorseShow(6, HorseShowMode.Jumper).AsEnumerable();
            return View(hs);
        }

        public ActionResult ShowDetails(int? HorseShowID)
        {
            if (Session["Emp_id"] != null)
            {
                if (HorseShowID != null)
                {
                    HorseShowViewModel hs = new HorseShowViewModel();
                    hs = shownetDa.ShowDetailsDate(HorseShowID);
                    var sd = new ShowDetailsViewModel
                    {
                        YearList = shownetDa.yearList(),
                        MonthList = shownetDa.monthList(),
                        HorseShowList = shownetDa.HorseShowNameDataList(hs.StartDate),
                        ShowDateList = shownetDa.HorseShowDateList(HorseShowID),
                        RingNameList=shownetDa.HorseRingListList(hs.StartDate,hs.HorseShowID),
                        SelectedYear=hs.StartDate.Year,
                        SelectedMonth=hs.StartDate.Month                   
                        
                    };
                    return View(sd);
                }
                return RedirectToAction("Default", "ShowNet");
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        public bool RingScheduleList(int year, int month, int showNameId, DateTime showDate, int showDayID)
        {
            return true;
        }
        public ActionResult fillShowName(int year, int month, int showNameId, DateTime showDate, int showDayID)
        {
            var showNameDataList = shownetDa.HorseShowNameDataList(Convert.ToDateTime(month + "/" + year + "/" + 01));
            return Json(showNameDataList, JsonRequestBehavior.AllowGet);
            
        }
        public ActionResult fillShowDate(int year, int month, int showNameId, DateTime showDate, int showDayID)
        {
            var horseShowDateDataList = shownetDa.HorseShowDateList(showNameId);
            return Json(horseShowDateDataList, JsonRequestBehavior.AllowGet);

        }

        public ActionResult MyShowNet()
        {
            if (Session["Emp_id"] != null)
            {

                MemberDetailsViewModel memberDetailsViewModel = new MemberDetailsViewModel();

                int memberId = Convert.ToInt32(Session["Emp_id"]);
                memberDetailsViewModel = accountDa.EditMyShowNet(memberId);
                return View(memberDetailsViewModel);
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UpdateShowNet(MemberDetailsViewModel md)
        {
            if (Session["Emp_id"] != null)
            {
                if (ModelState.IsValid)
                {
                    accountDa.UpdateMyShowNet(md);
                    ModelState.Clear();
                    return RedirectToAction("MyShowNet", "ShowNet");
                }
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
            return RedirectToAction("Login", "Account");
        }

        public ActionResult Connection()
        {
            return View();
        }

        public ActionResult FreeView()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }



    }
}