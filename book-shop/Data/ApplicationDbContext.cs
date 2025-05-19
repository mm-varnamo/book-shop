using book_shop.Models;
using Microsoft.EntityFrameworkCore;

namespace book_shop.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }

        public DbSet<Category> Categories { get; set; }
    }
}
