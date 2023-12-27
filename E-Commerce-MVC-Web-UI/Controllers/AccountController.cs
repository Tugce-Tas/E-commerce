using E_Commerce_MVC_Web_UI.Identity;
using E_Commerce_MVC_Web_UI.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace E_Commerce_MVC_Web_UI.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<ApplicationRole> _roleManager;

        public AccountController()
        {
            var userStore = new UserStore<ApplicationUser>(new IdentityDataContext());
            _userManager = new UserManager<ApplicationUser>(userStore);

            var roleStore = new RoleStore<ApplicationRole>(new IdentityDataContext());
            _roleManager = new RoleManager<ApplicationRole>(roleStore);
        }


        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        // POST: Account
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser();
                user.Name = model.Name;
                user.Surname = model.Surname;
                user.Email = model.Email;
                user.UserName = model.UserName;

                IdentityResult result = _userManager.Create(user, model.Password);   

                if (result.Succeeded)
                {
                   if (_roleManager.RoleExists("User"))
                    {
                        _userManager.AddToRole(user.Id, "User");
                    }

                    return RedirectToAction("Login", "Account");

                }
                else
                {
                    ModelState.AddModelError("RegisterUserError", "Kullanıcı oluşturma hatası");

                }
            }
            return View(model);
        }


        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        // POST: Account
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model)
        {
            if (ModelState.IsValid)
            {
               var user = _userManager.Find(model.Email, model.Password);

                if (user!= null)
                {
                    var authManager = HttpContext.GetOwinContext().Authentication;
                    var identityClaims = _userManager.CreateIdentity(user, "ApplicationCookie");
                    var authProp = new AuthenticationProperties();
                    authProp.IsPersistent = model.RememberMe;

                    authManager.SignIn(authProp, identityClaims);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("LoginError", "Hatalı giriş");
                }
            }
            return View(model);
        }


        public ActionResult Logout()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();
 
            return RedirectToAction("Index", "Home");
        }

    }
}