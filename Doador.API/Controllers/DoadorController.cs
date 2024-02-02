using Doador.Domain.Commands;
using Doador.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Doador.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoadorController : ControllerBase
    {
        private readonly IDoadorService _service;
        public DoadorController(IDoadorService doadorService)
        {
            _service = doadorService;
        }
        [HttpPost]
        [Route("CadastrarDoador")]
        public async Task<IActionResult> PostAsync([FromBody] DoadorCommand doadorCommand)
        {
            await _service.PostAsync(doadorCommand);
            return Ok();
        }
    }
}
