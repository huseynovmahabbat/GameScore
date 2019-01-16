using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootball.Models
{
   public  class Role:Entity
    {
        [StringLength(maximumLength:30,MinimumLength =4)]
        public string Name { get; set; }
    }
}
