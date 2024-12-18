using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PDV.Domain.Interfaces.InterfaceServicos;
using PDV.Domain.Interfaces.IProduto;

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
        public 

    }
}
