using BorrowIt.Data.Repositories;
using BusinessLogic.Validators;
using Domain;

namespace BusinessLogic.Services
{
    public class CarServices : GenericServices<Car>, IServices<Car>
    {
        public CarServices(IRepository<Car> repository, IValidator<Car> validator) : base(repository, validator)
        {

        }
    }
}
