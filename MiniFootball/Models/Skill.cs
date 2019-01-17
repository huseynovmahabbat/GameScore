using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootball.Models
{
    public class Skill:Entity
    {
        [Required]
        public string Name { get; set; }
        public Player Player { get; set; }
        public int? PlayerId { get; set; }
    }
}
