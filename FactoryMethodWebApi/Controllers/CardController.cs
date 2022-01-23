using FactoryMethodWebApi.IServices;
using Microsoft.AspNetCore.Mvc;

namespace FactoryMethodWebApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CardController : ControllerBase
    {
        private readonly IFactoryService _factoryService;
        public CardController(IFactoryService factoryService)
        {
            _factoryService = factoryService;   
        }
        [HttpGet("{cardName}")]
        public async Task<IActionResult> Get(string cardName)
        {
            var data = await Task.Run(()=>_factoryService.Get(cardName).CardInfo()); 
            return Ok(data);
        }
    }
}
