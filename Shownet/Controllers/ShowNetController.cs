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
            hs.HorseShowList = Mapper.Map<IEnumerable<HorseShowViewModel>>(shownetDa.GetHorseShow(6, HorseShowMode.Jumper).AsEnumerable());
            hs.HorseUpcomingShowList = Mapper.Map < IEnumerable < HorseShowViewModel >> (shownetDa.GetUpComingHorseShow(6, HorseShowMode.Jumper).AsEnumerable());
            return View(hs);
        }

        public ActionResult ShowDetails()
        {
            return View();
        }
        public ActionResult MyShowNet()
        {
            return View();
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