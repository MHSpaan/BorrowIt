using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Threading;
using System.Threading.Tasks;

namespace BorrowIt.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Car> Cars { get; set; }
        DbSet<Branch> Branches { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Order> Orders { get; set; }

        EntityEntry Update(object entity);

        EntityEntry Add(object entity);

        void Save();
    }
}
