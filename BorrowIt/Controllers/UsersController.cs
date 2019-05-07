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
    public class UsersController : GenericController<User>, IController<User>
    {
        public UsersController(IServices<User> services) : base(services)
        {

        }
    }
}
