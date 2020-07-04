using System.ComponentModel.DataAnnotations;

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

        public string ConfirmPassword { get; set; }
    }
}
