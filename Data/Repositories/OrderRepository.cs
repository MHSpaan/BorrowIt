using Domain;

namespace BorrowIt.Data.Repositories
{
    public class OrderRepository : GenericRepository<Order>
    {
        public OrderRepository(IApplicationDbContext context) : base(context, context.Orders)
        {
        }
    }
}
