using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SabaLab_List.ViewModels
{
    public class LoginViewModels
    {
        [Required(ErrorMessage ="نام کاربری الزامی است")]
        
        public string UserName { get; set; }

        [Required(ErrorMessage = "رمزعبور الزامی است")]
        
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="مرابخاطربسپار")]
        public bool RememberMe { get; set; }

    }
}
