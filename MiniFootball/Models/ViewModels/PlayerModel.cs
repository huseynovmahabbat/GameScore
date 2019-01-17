﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootball.Models.ViewModels
{
   public  class PlayerModel:Entity
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public List<Skill> Skills { get; set; }
        public byte Age { get; set; }
    }
}
