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
            Users = new HashSet<User>();
        }
        [StringLength(maximumLength:50,MinimumLength =5)]
        public string Name { get; set; }
        [Required]
        public DateTime EstablishmentDate { get; set; }

        public byte[] Logo { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
