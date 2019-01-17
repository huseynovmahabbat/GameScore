using MiniFootball.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootball.Extensions
{
   public static class DbsetExtensions
    {
        public async static Task<Player> GetUserByEmailAsync(this DbSet<Player> players,string Email)
        {
            return await players.Where(x => x.Email == Email).FirstOrDefaultAsync();
        }
        public async static Task<Player> GetUserByIdAsync(this DbSet<Player> users, int Id)
        {
            return await users.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }
        public async static Task<List<Player>> GetFreePlayersAsync(this DbSet<Player> players)
        {
            return await players.Where(x => x.RoleId != 1 && x.TeamId==null).ToListAsync();
        }
        public static List<Skill> GetPlayerSkills(this DbSet<Player> players,int PlayerId)
        {
             return players.Where(x => x.Id == PlayerId).Select(x => x.Skills) as List<Skill>;
        }
    }
}
