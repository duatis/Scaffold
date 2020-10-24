using Microsoft.AspNetCore.Mvc;
using Scaffold.BusinessLogic.Contracts;
using Scaffold.BusinessLogic.Managers;

namespace Scaffold.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PirateController : ControllerBase
    {
        private PirateManager manager;

        public PirateController(IPirateRepo _repo)
        {
            manager = new PirateManager(_repo);
        }

        [HttpGet("{id}")]
        public IPirate Get(int id)
        {
            return manager.Get(id);
        }
    }
}
