using Domain;
using Microsoft.EntityFrameworkCore;

namespace BorrowIt.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }

        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base (options)
        {

        }

        public void Save()
        {
            base.SaveChanges();
        }
    }

}
