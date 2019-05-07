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
    public class OrdersController : GenericController<Order>, IController<Order>
    {
        public OrdersController(IServices<Order> services) : base(services)
        {

        }
    }
}
