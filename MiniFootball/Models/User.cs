using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootball.Models
{
    public class User:Entity
    {
        [StringLength(maximumLength: 30, MinimumLength = 3)]
        public string Name { get; set; }
        [StringLength(maximumLength: 30, MinimumLength = 5)]
        public string Surname { get; set; }
        [EmailAddress]
        [Index(IsClustered =false,IsUnique =true)]
        [StringLength(maximumLength: 30, MinimumLength = 5)]
        public string Email { get; set; }
        [StringLength(maximumLength: 30, MinimumLength = 6)]
        public string Password { get; set; }
        
        public DateTime BirthDate { get; set; }

        
        public Role Role { get; set; }
        public int RoleId { get; set; }
        
        
        public Team Team { get; set; }
        public int? TeamId { get; set; }
    }
}
