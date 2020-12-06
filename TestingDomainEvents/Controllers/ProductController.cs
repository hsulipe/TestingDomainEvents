using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestingDomainEvents.Services;

namespace TestingDomainEvents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersistenceController : ControllerBase
    {
        private readonly IPlayerPersistenceService _playerPersistenceService;

        public PersistenceController(IPlayerPersistenceService playerPersistenceService)
        {
            _playerPersistenceService = playerPersistenceService;
        }

        [HttpPut]
        public async Task<ActionResult> Save()
        {
            await _playerPersistenceService.Save("74189543-a47f-4356-a40f-31c8ff8fa62f", "testing", "{\"shit\": 1}");
            return Ok();
        }
    }
}
