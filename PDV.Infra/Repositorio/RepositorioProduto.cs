using PDV.Domain.Entities;
using PDV.Domain.Interfaces.IProduto;
using PDV.Infra.Repositorio.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Infra.Repositorio
{
    public class RepositorioProduto : RepositorioGenerics<Produto>, InterfaceProduto
    {
    }
}
