using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace _61MY_NETCoreMVC.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Route("UserPanel/Message")]
    public class MessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {            
            _userManager = userManager;
        }

        [Route("")]
        [Route("ReceiverMessage")]
        public async Task<IActionResult> ReceiverMessage(string p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            p = user.Email;
            var values = writerMessageManager.GetListReceiverMessage(p); 
            return View(values);
        }
       
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            p = user.Email;
            var values = writerMessageManager.GetListSenderMessage(p);
            return View(values);
        }

        [Route("ReceiverMessageDetails/{id}")]
        public IActionResult ReceiverMessageDetails(int id)
        {
            var value = writerMessageManager.TGetById(id);
            return View(value);
        }

        [Route("SenderMessageDetails/{id}")]
        public IActionResult SenderMessageDetails(int id)
        {
            var value = writerMessageManager.TGetById(id);
            return View(value);
        }


        [HttpGet]       
        [Route("AddMessage")]
        public IActionResult AddMessage()
        {
            return View();
        }

        [HttpPost]        
        [Route("AddMessage")]
        public async Task<IActionResult> AddMessage(WriterMessage p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name + " " + values.Surname;
            p.Date = DateTime.Now;
            p.Sender = mail;
            p.SenderName = name;

            using var context = new Context();
            var userNameSurname = context.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = userNameSurname;

            writerMessageManager.TAdd(p);
            return RedirectToAction("SenderMessage");
        }
    }
}
