using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SabaLab_List.ViewModels
{
    public class RegisterViewModels
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name ="نام کاربری")]
        public string UserName { get; set; }

        [Required]
        [Display(Name ="ایمیل")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name ="رمزعبور")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name ="تاییدرمزعبور")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
