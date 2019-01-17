using MiniFootball.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootball.DAL
{
    class GameDbContext:DbContext
    {
        public GameDbContext():base("db"){ }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Administration> Administrations { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}
