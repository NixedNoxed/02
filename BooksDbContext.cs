using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp
{
    public class BooksDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("BooksDatabase");
        }
    }
}
