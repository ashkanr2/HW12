using _10.Data_Access;
using _10.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Principal;

namespace _10.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (AcountRippo.currentuser != null)
            {
                ViewBag.Log = "خروج";
                if (AcountRippo.currentuser.user == user.admin)
                {
                    ViewBag.admin = true;
                }
            }
           

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            if (AcountRippo.currentuser != null)
            {
                ViewBag.Log = "خروج";
            }
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}