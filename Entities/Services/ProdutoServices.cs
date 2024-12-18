using PDV.Domain.Entities;
using PDV.Domain.Interfaces.InterfaceServicos;
using PDV.Domain.Interfaces.IProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Domain.Services
{
    public class ProdutoServices : IProdutoServices
    {
        private readonly InterfaceProduto _interfaceProduto;
        public ProdutoServices(InterfaceProduto interfaceProduto)
        {
            _interfaceProduto = interfaceProduto;
        }
        public async Task AdicionarProduto(Produto produto)
        {
            var valido = produto.ValidarPropriedadeString(produto.Nome, "Nome");
            if(valido)
                await _interfaceProduto.Add(produto);
        }

        public async Task AtualizarProduto(Produto produto)
        {
            var valido = produto.ValidarPropriedadeString(produto.Nome, "Nome");
            if (valido)
                await _interfaceProduto.Update(produto);
        }
    }
    
}
