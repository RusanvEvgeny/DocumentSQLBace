using ITUniver.DocBase.Web.Models;
using ITUniver.DocBase.Web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ITUniver.DocBase.Web.Controllers
{
    public class AccountController : Controller
    {
        private NHUserRepository UserRepository { get; set; }

        public AccountController()
        {
            UserRepository = new NHUserRepository();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Что-то пошло не так");
                return View(model);
            }
            
            var user = UserRepository
                .Find($" Login = N'{model.Login}' AND Password = N'{model.Password}' ")
                .FirstOrDefault();
            if (user == null)
            {
                ModelState.AddModelError("", "Ошибка авторизации");
                return View(model);
            }
            
            FormsAuthentication.SetAuthCookie(model.Login, false);
            
            return RedirectToAction("Exec", "Calc");
        }


        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}