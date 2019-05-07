using BusinessLogic.Services;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BorrowIt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : GenericController<Car>, IController<Car>
    {

        public CarsController(IServices<Car> services) : base(services)
        {

        }
    }
}
