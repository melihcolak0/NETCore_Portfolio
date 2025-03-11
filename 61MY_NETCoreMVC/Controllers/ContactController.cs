using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace _61MY_NETCoreMVC.Controllers
{
    public class ContactController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "İletişim Mesajları";
            ViewBag.v2 = "İletişim";
            ViewBag.v3 = "İletişim Mesajları";
            ViewBag.v4 = "/Contact/Index";

            var values = messageManager.TGetList();
            return View(values);
        }

        public IActionResult DeleteContact(int id)
        {
            var value = messageManager.TGetById(id);
            messageManager.TDelete(value);
            return RedirectToAction("Index");
        }

        public IActionResult ContactDetails(int id)
        {
            ViewBag.v1 = "İletişim Mesaj Detayı";
            ViewBag.v2 = "İletişim";
            ViewBag.v3 = "İletişim Mesaj Detayı";
            ViewBag.v4 = "/Contact/Index";

            var value = messageManager.TGetById(id);
            return View(value);
        }
    }
}
