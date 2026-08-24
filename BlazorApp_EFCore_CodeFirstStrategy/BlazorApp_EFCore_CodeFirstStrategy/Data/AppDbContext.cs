using Microsoft.EntityFrameworkCore;
using BlazorApp_EFCore_CodeFirstStrategy.Models;

namespace BlazorApp_EFCore_CodeFirstStrategy.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autor> Autors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
    }
}
