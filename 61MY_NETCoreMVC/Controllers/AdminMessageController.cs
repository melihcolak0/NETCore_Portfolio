using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace _61MY_NETCoreMVC.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

        public IActionResult Inbox()
        {
            ViewBag.v1 = "Kullanıcı - Admin Gelen Mesajlar";
            ViewBag.v2 = "Mesajlar";
            ViewBag.v3 = "Kullanıcı - Admin Mesajları";
            ViewBag.v4 = "/AdminMessage/Inbox";

            string p = "admin@gmail.com";
            var values = writerMessageManager.GetListReceiverMessage(p);
            return View(values);
        }

        public IActionResult Sendbox()
        {
            ViewBag.v1 = "Kullanıcı - Admin Gönderilen Mesajlar";
            ViewBag.v2 = "Mesajlar";
            ViewBag.v3 = "Kullanıcı - Admin Mesajları";
            ViewBag.v4 = "/AdminMessage/Inbox";

            string p = "admin@gmail.com";
            var values = writerMessageManager.GetListSenderMessage(p);
            return View(values);
        }

        public IActionResult MessageDetails(int id)
        {
            ViewBag.v1 = "Kullanıcı - Admin Mesaj Detayı";
            ViewBag.v2 = "Mesajlar";
            ViewBag.v3 = "Kullanıcı - Admin Mesajları";
            ViewBag.v4 = "/AdminMessage/Inbox";

            var value = writerMessageManager.TGetById(id);
            return View(value);
        }

        public IActionResult DeleteMessage(int id, string returnUrl)
        {
            var value = writerMessageManager.TGetById(id);
            writerMessageManager.TDelete(value);
            
            if (returnUrl == "Sendbox")
            {
                return RedirectToAction("Sendbox");
            }
            else
            {
                return RedirectToAction("Inbox");
            }            
        }

        [HttpGet]
        public IActionResult AddMessage()
        {
            ViewBag.v1 = "Kullanıcı - Admin Yeni Mesaj Oluştur";
            ViewBag.v2 = "Mesajlar";
            ViewBag.v3 = "Kullanıcı - Admin Mesajları";
            ViewBag.v4 = "/AdminMessage/Inbox";
            return View();
        }

        [HttpPost]
        public IActionResult AddMessage(WriterMessage p)
        {
            p.SenderName = "Admin";
            p.Sender = "admin@gmail.com";
            p.Date = DateTime.Now;

            using var context = new Context();
            var userNameSurname = context.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = userNameSurname;

            writerMessageManager.TAdd(p);
            return RedirectToAction("Sendbox");
        }
    }
}
