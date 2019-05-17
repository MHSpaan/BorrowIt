using BorrowIt.Data;
using BorrowIt.Data.Repositories;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace BorrowIt.UnitTests.Data.Helpers
{
    public class RepositoryUnitTestsHelper : BranchRepository, IRepositoryUnitTestsHelper
    {
        public RepositoryUnitTestsHelper(IApplicationDbContext context) : base(context)
        {

        }

        public new void GetEntities()
        {
            _context.Branches.ToListAsync();
        }
    }
}
