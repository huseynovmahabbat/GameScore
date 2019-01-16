using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootball.Models.ViewModels
{
    public class LoginModel
    {
       
        [StringLength(maximumLength:30,MinimumLength =5)]
        public string Email { get; set; }
        [StringLength(maximumLength: 30, MinimumLength = 5)]
        public string Password { get; set; }
    }
}
