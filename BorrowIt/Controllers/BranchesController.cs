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
    public class BranchesController : GenericController<Branch>, IController<Branch>
    {
        public BranchesController(IServices<Branch> services) : base(services)
        {

        }
    }
}
