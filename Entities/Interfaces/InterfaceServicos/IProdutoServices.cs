using PDV.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Domain.Interfaces.InterfaceServicos
{
    public interface IProdutoServices
    {
        Task AdicionarProduto(Produto produto);
        Task AtualizarProduto(Produto produto);
        
    }
}
