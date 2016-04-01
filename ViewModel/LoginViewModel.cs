using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ViewModel
{
   public class LoginViewModel
    {
       [Required]
       [DataType(DataType.Password)]
       [Display(Name = "Password")]
       public string Password { get; set; }

       [Required]
       [DataType(DataType.EmailAddress)]
       [Display(Name = "Email")]
       public string Email { get; set; }

      
    }
}
