using Domain;

namespace BorrowIt.Data.Repositories
{ 
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(IApplicationDbContext context) : base(context, context.Users)
        {
        }
    }
}
