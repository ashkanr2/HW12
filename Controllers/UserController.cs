using _10.Data_Access;
using Microsoft.AspNetCore.Mvc;

namespace _10.Controllers
{
    public class UserController : Controller
    {
        private ProductRippo _ProductRippo = new ProductRippo();
        public IActionResult List()
        {
            
            ViewBag.Log = "خروج";
            var result = _ProductRippo.GetList();
            return View(result);
        }
    }
}
