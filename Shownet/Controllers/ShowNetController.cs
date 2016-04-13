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
                        RingNameList = shownetDa.HorseRingListList(hs.StartDate, hs.HorseShowID),
                        SelectedYear = hs.StartDate.Year,
                        SelectedMonth = hs.StartDate.Month

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

        public ActionResult fillRingScheduleList(int year, int month, int showNameId, DateTime showDate, int showDayID)
        {
            var scheduleDataList = shownetDa.ScheduleList(showDayID, showNameId);
            return Json(scheduleDataList, JsonRequestBehavior.AllowGet);
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
        public ActionResult fillRingName(int year, int month, int showNameId, DateTime showDate, int showDayID)
        {
            var ringNameDataList = shownetDa.HorseRingListList(showDate, showNameId);
            return Json(ringNameDataList, JsonRequestBehavior.AllowGet);

        }


        public ActionResult MyShowNet()
        {
            string ShowId = string.Empty;
            if (Session["Emp_id"] != null)
            {

                MemberDetailsViewModel memberDetailsViewModel = new MemberDetailsViewModel();

                int memberId = Convert.ToInt32(Session["Emp_id"]);
                memberDetailsViewModel = accountDa.EditMyShowNet(memberId);
                memberDetailsViewModel.MemberGroupList = shownetDa.getMemberGroupList(memberId);
                memberDetailsViewModel.PaymentCredit = shownetDa.GetUpdatePaymentCredit(memberId);
                memberDetailsViewModel.ViewShowPurchaseList = shownetDa.GetViewShowPurchase(memberId,ShowId);
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
        public ActionResult ClassResults(int ringID, int horseShowID, int scheduleID, string classID)
        {
            ResultsViewModel rv = new ResultsViewModel();
            rv = shownetDa.getResults(ringID, horseShowID, scheduleID, classID);

            return View(rv);
        }
        //public string ClassResultsCheckMode(int ringID, int horseShowID, int scheduleID, string classID)
        //{

        //    string s = shownetDa.checkModeForResults(ringID, horseShowID, scheduleID, classID);

        //    return s;
        //}

        public ActionResult DeleteAssociateMember(int id)
        {
            if (Session["Emp_id"] != null)
            {
                shownetDa.deleteAssociateMemberId(id);

                return RedirectToAction("MyShowNet", "ShowNet");
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        [HttpPost]
        public ActionResult AddNewUser(LoginViewModel loginViewModel)
        {
            if (Session["Emp_id"] != null)
            {
                MemberDetailsViewModel memberDetailsViewModel = new MemberDetailsViewModel();
                memberDetailsViewModel.MemberGroupList = shownetDa.getMemberGroupList(Convert.ToInt32(Session["Emp_id"]));
                int count = memberDetailsViewModel.MemberGroupList.Count();
                if (count == 2)
                {
                    TempData["Message"] = "There are already two user.";
                }
                else if (count == 0 || count == 1)
                {
                    shownetDa.AddNewAssociateUser(Convert.ToInt32(Session["Emp_id"]), loginViewModel);
                }
                return RedirectToAction("MyShowNet", "ShowNet");
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }
        public ActionResult Getprivatized()
        {
            return View("~/Views/ShowNet/Privatized.cshtml");
        }

        public ActionResult Pricing()
        {
            return View("~/Views/ShowNet/Pricing.cshtml");
        }

        public ActionResult Info()
        {
            return View("~/Views/ShowNet/Info.cshtml");
        }
        public ActionResult SearchResults(string SearchText, string SearchTypes)
        {
            return View();
        }


    }
}