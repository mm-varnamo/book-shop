using Microsoft.EntityFrameworkCore;

namespace book_shop.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }
    }
}
