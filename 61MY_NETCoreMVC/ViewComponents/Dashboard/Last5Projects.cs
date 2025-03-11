using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace _61MY_NETCoreMVC.ViewComponents.Dashboard
{
    public class Last5Projects : ViewComponent
    {
        public IViewComponentResult Invoke()
        {            
            return View();
        }
    }
}
