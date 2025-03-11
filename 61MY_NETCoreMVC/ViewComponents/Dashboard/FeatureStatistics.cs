using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace _61MY_NETCoreMVC.ViewComponents.Dashboard
{
    public class FeatureStatistics : ViewComponent
    {
        Context context = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.skillCount = context.Skills.Count();
            ViewBag.readMessageCount = context.Messages.Where(x => x.Status == true).Count();
            ViewBag.unreadMessageCount = context.Messages.Where(x => x.Status == false).Count();
            ViewBag.experienceCount = context.Experiences.Count();
            return View();
        }
    }
}
