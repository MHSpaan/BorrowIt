using BusinessLogic.Services;
using Domain;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

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
