using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Domain.Entities
{
    public class Produto : Base
    {
        public string Nome { get; set; }
        public string Descrição { get; set;}
    }
}
