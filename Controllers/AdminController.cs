using _10.Data_Access;
using _10.Models;
using Microsoft.AspNetCore.Mvc;
using _10.Controllers;
namespace _10.Controllers
{
    public class AdminController : Controller
    {
        private ProductRippo _ProductRippo = new ProductRippo();
        private AcountRippo _AcountRippo = new AcountRippo();
      
         
        public IActionResult UsersList()
        {
            ViewBag.Log = "خروج";
            if (AcountRippo.currentuser == null)
            {
                return RedirectToAction("Login", "Account"); 
            }
            var result = _AcountRippo.GetList();
            
            return View(result);
        }
        public IActionResult ErroAdmin()
        {
            if (AcountRippo.currentuser != null)
            {
                ViewBag.Log = "خروج";
            }
            ViewBag.ErAdmin = "ادمین نمیتواند سفارش دهد ";
            return View();
        }
        public IActionResult AdminActions()
        {
            
            if (AcountRippo.currentuser == null)
            {

                return RedirectToAction("Login", "Account");
            }
            ViewBag.Log = "خروج";
            var result = _ProductRippo.GetList();
            return View(result);
        }
    }
}

