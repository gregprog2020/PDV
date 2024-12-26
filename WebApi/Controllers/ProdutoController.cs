using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PDV.Domain.Interfaces.InterfaceServicos;
using PDV.Domain.Interfaces.IProduto;
using PDV.Domain.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly InterfaceProduto _interfaceProduto;
        private readonly IProdutoServices _iProdutoService;
        public ProdutoController (InterfaceProduto interfaceProduto, 
            IProdutoServices iProdutoServices)
        {
            _interfaceProduto = interfaceProduto;
            _iProdutoService = iProdutoServices;
        }

        [HttpGet("api/produtos")]
        [HttpGet("{id}")]
        public async Task<IActionResult> ObterTodosProdutos()
        {
            var produto = await _interfaceProduto.List();

            if (produto == null)
            {
                return NotFound(new { Mensagem = "Produto não encontrado." });
            }

            return Ok(produto);
        }

    }
}
