using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace _61MY_NETCoreMVC.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Route("UserPanel/[controller]/[action]")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = value.Name + " " + value.Surname;

            // Weather API
            string api = "your_api";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            // Statistics
            using (var context = new Context())
            {
                ViewBag.v1 = context.WriterMessages.Where(x => x.Receiver == value.Email).Count();
                ViewBag.v2 = context.Announcements.Count();
                ViewBag.v3 = context.Users.Count();
                ViewBag.v4 = context.WriterMessages.Where(x => x.Sender == value.Email).Count();
            }

            return View();
        }
    }
}
