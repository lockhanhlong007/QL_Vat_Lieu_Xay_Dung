using System.ComponentModel.DataAnnotations;

namespace QL_Vat_Lieu_Xay_Dung_WebApp.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "UserName")]
        public string UserName { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember")]
        public bool RememberMe { get; set; }
    }
}