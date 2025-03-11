using System.ComponentModel.DataAnnotations;

namespace _61MY_NETCoreMVC.Areas.UserPanel.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen resim dizinini giriniz")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage ="Lütfen kullanıcı adınızı giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        [Compare("Password", ErrorMessage ="Şifreler birbiriyle uyuşmuyor")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen mail adresi giriniz")]
        public string Mail { get; set; }
    }
}
