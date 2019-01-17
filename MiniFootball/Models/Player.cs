using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootball.Models
{
    public class Player:Entity
    {
        public Player()
        {
            Skills = new HashSet<Skill>();
        }

        [Required]
        [StringLength(maximumLength: 30, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 30, MinimumLength = 5)]
        public string Surname { get; set; }

        [EmailAddress]
        [Required]
        [Index(IsClustered =false,IsUnique =true)]
        [StringLength(maximumLength: 30, MinimumLength = 5)]
        public string Email { get; set; }

        [Required]
        [StringLength(maximumLength: 30, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(maximumLength: 30, MinimumLength = 5)]
        public string Postion { get; set; }

       
        public Role Role { get; set; }
        public int RoleId { get; set; }
        
        
        public Team Team { get; set; }
        public int? TeamId { get; set; }

        public ICollection<Skill> Skills { get; set; }
    }
}
