using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp
{
    public class UsersDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("UsersDatabase");
        }
    }
}
