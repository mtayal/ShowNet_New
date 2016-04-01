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
       [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                           @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                           @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                           ErrorMessage = "Email is not valid")] 
       [Display(Name = "Email")]
       public string Email { get; set; }

      
    }
}
