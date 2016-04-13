using DataAccess.DAL;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;
using Shownet.Models;
namespace Shownet.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountDa accountDa;
        private readonly UnitOfWork unitOfWork;

        public AccountController()
        {
            unitOfWork = new UnitOfWork();
            accountDa = new AccountDa(unitOfWork);
        }
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public ActionResult Registration(MemberDetailsViewModel md)
        {
            if (ModelState.IsValid)
            {
                accountDa.Registration(md);
                ModelState.Clear();
            }

            return View();
        }

        
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public ActionResult LogOut()
        {
            Session.Abandon();
            Session.Clear();
            return RedirectToAction("Default", "ShowNet");
            
        }
        [HttpPost]
        //[AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel md)
        {
            if (ModelState.IsValid)
            {
                var member = accountDa.Login(md.Email, md.Password);
                if (member != null)
                {
                    Session["Emp_id"] = member.MemberID;
                    Session["UserName"] = "Welcome : "+  member.UserName;
                    Session["Email"] = member.Email;
                    return RedirectToAction("ShowDetails", "ShowNet");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid emaild or password.");
                    return View(md);
                }
            }
            return View(md);
        }
        [HttpGet]
        public ActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ForgotPassword(ForgotViewModel fv)
        {
            fv.Status = true;
            MemberDetailsViewModel md = new MemberDetailsViewModel();
            if (ModelState.IsValid)
            {
                md = accountDa.GetPassword(fv.Email);
                if (md.Password != null && !string.IsNullOrWhiteSpace(md.Password))
                {
                    string subject = String.Format("ShowNet Password Reminder for " + md.Email, md.Email);
                    string body = String.Format(md.Email + "Your Password for ShowNet is " + md.Password, md.FirstName + md.LastName, md.Password);
                    bool? ok = SendMail.SendEmailMessage(subject, body, false, md.Email, md.UserName);
                    ViewBag.Status = ok;
                    if (fv.Status == ok)
                    {
                        return View();
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Invalid emaild or password.");
                    return View(md);
                }
            }
            return View();
        }

    }
}
