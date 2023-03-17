using _10.Data_Access;
using _10.Models;
using Microsoft.AspNetCore.Mvc;
using _10.Controllers;
using System.ComponentModel;

namespace _10.Controllers
{
    public class AccountController : Controller
    {
        private AcountRippo _AcountRippo = new AcountRippo();
        private ProductRippo _ProductRippo = new ProductRippo();
        private Login _Login = new Login();



        public IActionResult Create()
        {
            return View();
        }



        public IActionResult Login()
        {
            if (AcountRippo.currentuser == null)
            {
                return View();
            }
            else
            {
                return null;
            }


        }
        [HttpPost]
        public IActionResult Login(Account model)
        {

            var accountList = _AcountRippo.GetList();
            foreach (var account in accountList)
            {
                if (account.Email == model.Email)
                {
                    if (account.Password == model.Password)
                    {
                        _Login.loginId = account.Id;

                        ViewBag.name = account.Name;
                        if (account.user==user.admin)
                        {
                            AcountRippo.currentuser = account;
                            ViewBag.Log = account.Name;
                            return RedirectToAction("AdminActions", "Admin");
                        }
                        if (account.user == user.user)
                        {
                            AcountRippo.currentuser = account;
                            ViewBag.Log = "خروج";
                            ViewBag.id = account.Id;
                            return RedirectToAction("List", "User");
                        }
                    }
                    else
                    {
                        ViewBag.Notif = "  پسورد صحیح نیست ";
                        return RedirectToAction("Login");
                    }

                }

            }
            ViewBag.Notif = " ایمیل صحیح نیست ";
            return RedirectToAction("Login");

        }






       
        public IActionResult LogOut()
        {
            AcountRippo.currentuser = null;
            return RedirectToAction("Index", "Home");
        }


    }


}
