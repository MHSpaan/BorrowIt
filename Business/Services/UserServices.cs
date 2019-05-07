using BorrowIt.Data.Repositories;
using BusinessLogic.Validators;
using Domain;

namespace BusinessLogic.Services
{
    public class UserServices : GenericServices<User>, IServices<User>
    {
        public UserServices(IRepository<User> repository, IValidator<User> validator) : base(repository, validator)
        {
        }
    }
}
