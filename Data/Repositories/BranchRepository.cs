using Domain;

namespace BorrowIt.Data.Repositories
{
    public class BranchRepository : GenericRepository<Branch>
    {
        public BranchRepository(IApplicationDbContext context) : base(context, context.Branches)
        {
        }
    }
}
