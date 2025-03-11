using Microsoft.AspNetCore.Http;

namespace _61MY_NETCoreMVC.Areas.UserPanel.Models
{
    public class UserProfileEditViewModel
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Password { get; set; }

        public string PasswordConfirm { get; set; }

        public string ImageUrl { get; set; }

        public IFormFile Image { get; set; }
    }
}
