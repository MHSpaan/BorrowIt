using BorrowIt.Data.Repositories;
using BusinessLogic.Validators;
using Domain;

namespace BusinessLogic.Services
{
    public class OrderServices : GenericServices<Order>, IServices<Order>
    {
        public OrderServices(IRepository<Order> repository, IValidator<Order> validator) : base(repository, validator)
        {
        }
    }
}
