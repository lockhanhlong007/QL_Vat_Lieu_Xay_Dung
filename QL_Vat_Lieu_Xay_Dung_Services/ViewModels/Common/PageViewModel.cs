using QL_Vat_Lieu_Xay_Dung_Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace QL_Vat_Lieu_Xay_Dung_Services.ViewModels.Common
{
    public class PageViewModel
    {
        public int Id { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [MaxLength(256)]
        [Required]
        public string Alias { set; get; }

        public string Content { set; get; }

        public Status Status { set; get; }
    }
}