using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Review.API.DatabaseConfigurations
{
    public class RevewProductDbContext : DbContext
    {
        public RevewProductDbContext(DbContextOptions<RevewProductDbContext> options) : base(options)
        {

        }
        public DbSet<ReviewModel> Review { get; set; }
        public DbSet<ProductModel> Product { get; set; }
    }
}
