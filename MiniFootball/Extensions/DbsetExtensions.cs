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
        public async static Task<User> GetUserByEmailAsync(this DbSet<User> users,string Email)
        {
            return await users.Where(x => x.Email == Email).FirstOrDefaultAsync();
        }
        public async static Task<User> GetUserByIdAsync(this DbSet<User> users, int Id)
        {
            return await users.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }
        public async static Task<List<User>> GetFreePlayersAsync(this DbSet<User> users)
        {
            return await users.Where(x => x.RoleId != 1 && x.TeamId==null).ToListAsync();
        }
    }
}
