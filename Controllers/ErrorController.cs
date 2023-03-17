using Microsoft.AspNetCore.Mvc;

namespace _10.Controllers
{
    public class ErrorController: Controller
    {
        [Route("/Home/HandleError/{code:int}")]
        public IActionResult HandleError(int code)
        {
            ViewData["ErrorMessage"] = $"Error occurred. The ErrorCode is: {code}";
            return View("~/Views/Shared/HandleError.cshtml");
        }

    }
}
