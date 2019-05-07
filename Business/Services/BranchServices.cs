using BorrowIt.Data.Repositories;
using BusinessLogic.Validators;
using Domain;

namespace BusinessLogic.Services
{
    public class BranchServices : GenericServices<Branch>, IServices<Branch>
    {
        public BranchServices(IRepository<Branch> repository, IValidator<Branch> validator) : base(repository, validator)
        {
        }
    }
}
