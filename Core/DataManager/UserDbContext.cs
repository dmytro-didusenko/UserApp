using Core.DataManager.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.DataManager
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}
