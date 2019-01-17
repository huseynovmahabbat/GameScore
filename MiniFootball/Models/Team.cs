using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootball.Models
{
    public class Team:Entity
    {
        public Team()
        {
            Users = new HashSet<Player>();
        }

        [Required]
        [StringLength(maximumLength:50,MinimumLength =5)]
        public string Name { get; set; }

        [Required]
        public DateTime EstablishmentDate { get; set; }

        [Required]
        public byte[] Logo { get; set; }

        [Required]
        public ICollection<Player> Users { get; set; }
    }
}
