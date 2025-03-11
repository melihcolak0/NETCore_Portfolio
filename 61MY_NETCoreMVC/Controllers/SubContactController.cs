using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace _61MY_NETCoreMVC.Controllers
{
    public class SubContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "İletişim Bilgileri";
            ViewBag.v2 = "İletişim Bilgileri";
            ViewBag.v3 = "İletişim Bilgileri";
            ViewBag.v4 = "/SubContact/Index";
            var value = contactManager.TGetById(1);
            return View(value);
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contactManager.TUpdate(contact);
            return RedirectToAction("Index", "Default");
        }
    }
}
