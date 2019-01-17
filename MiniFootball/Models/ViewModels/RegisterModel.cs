using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootball.Models.ViewModels
{
   public  class RegisterModel
    {
        [StringLength(maximumLength: 30, MinimumLength = 3)]
        public string Name { get; set; }

        [StringLength(maximumLength: 30, MinimumLength = 5)]
        public string Surname { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [StringLength(maximumLength: 30, MinimumLength = 6)]
        public string Password { get; set; }
        
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public byte RoleId { get; set; }


        public static implicit operator Player(RegisterModel model)
        {
            return new Player
            {
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                BirthDate = model.BirthDate,
                Password = model.Password,
                RoleId = model.RoleId

            };
        }
    }
}
