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
        private readonly UnitOfWork unitOfWork;

        public ShowNetController()
        {
            unitOfWork = new UnitOfWork();
            shownetDa = new ShownetDa(unitOfWork);
        }
        public ActionResult Default()
        {

            HorseShowListViewModel hs = new HorseShowListViewModel();
            hs.HorseShowList = shownetDa.GetHorseShow(6, HorseShowMode.Jumper).AsEnumerable();
            hs.HorseUpcomingShowList = shownetDa.GetUpComingHorseShow(6, HorseShowMode.Jumper).AsEnumerable();
            return View(hs);
        }

        public ActionResult ShowDetails(int HorseShowID)
        {
            return View();
        }
        public ActionResult MyShowNet()
        {
            if (Session["Emp_id"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
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