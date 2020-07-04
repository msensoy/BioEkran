using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UygulamaUI.Models
{
    public class RegisterBindingModel
    {
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Password { get; set; }

        [NotMapped] // Does not effect with your database
        [Compare("Password",ErrorMessage ="Şifreler eşleşmiyor")]
        public string ConfirmPassword { get; set; }
    }
}
