using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Çalışan adını giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Çalışan soyadını giriniz.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Çalışan e-postasını giriniz.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Çalışan telefon numarasını giriniz.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Çalışan şifresini giriniz.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Çalışan şifresini tekrar giriniz.")]
        [Compare("Password", ErrorMessage = "Şifreler birbiri ile eşleşmiyor.")]
        public string ConfirmPassword { get; set; }
    }
}
