using Microsoft.AspNetCore.Mvc;

namespace _61MY_NETCoreMVC.Controllers
{
    public class ErrorPagesController : Controller
    {
        public IActionResult Page401()
        {
            return View();
        }

        public IActionResult Page404()
        {
            return View();
        }
    }
}

