using Domain;
using Microsoft.EntityFrameworkCore;

namespace BorrowIt.Data.Repositories
{ 
    public class CarRepository : GenericRepository<Car>
    {
        public CarRepository(IApplicationDbContext context) : base(context, context.Cars)
        {

        }


    }
}
