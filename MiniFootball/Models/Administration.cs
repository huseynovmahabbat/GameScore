using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootball.Models
{
    public class Administration:Entity
    {
        

        [EmailAddress]
        [Index(IsClustered = false, IsUnique = true)]
        [StringLength(maximumLength: 30, MinimumLength = 5)]
        public string Email { get; set; }

        [StringLength(maximumLength: 30, MinimumLength = 6)]
        public string Password { get; set; }

        [StringLength(maximumLength: 30, MinimumLength = 3)]
        public string Name { get; set; }

        [StringLength(maximumLength: 30, MinimumLength = 5)]
        public string Surname { get; set; }

        public Role Role { get; set; }
        public int RoleId { get; set; }
        
      
        
    }

}
