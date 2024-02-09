using Doador.Domain.Commands;
using Doador.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Doador.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _service;
        public ProdutoController(IProdutoService produtoService)
        {
            _service = produtoService;
        }
        [HttpPost]
        [Route("CadastrarProduto")]
        public async Task<IActionResult> PostAsync([FromBody] ProdutoCommand produtoCommand)
        {
            await _service.PostAsync(produtoCommand);
            return Ok();
        }
    }
}
