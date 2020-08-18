using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace QL_Vat_Lieu_Xay_Dung_WebApp.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Yêu Cầu Nhập Họ Và Tên", AllowEmptyStrings = false)]
        [Display(Name = "FullName")]
        public string FullName { set; get; }

        [Display(Name = "BirthDay")]
        [DataType(DataType.Date)]
        public DateTime? BirthDay { set; get; }

        [Required(ErrorMessage = "Yêu Cầu Nhập Tên Đăng Nhập", AllowEmptyStrings = false)]
        [Display(Name = "UserName")]
        public string UserName { set; get; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Mật Khẩu Phải Có Độ Dài Từ {2} Đến {1}", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword")]
        [Compare("Password", ErrorMessage = "Mật Khẩu Và Xác Nhận Mật Khẩu Không Trùng Khớp")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "PhoneNumber")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { set; get; }

        [Display(Name = "Avatar")]
        public IFormFile Avatar { get; set; }
    }
}