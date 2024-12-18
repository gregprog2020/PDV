using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Domain.Entities
{
    public class Venda : Base
    {
        public int NumeroNota { get; set; }
        public DateTime DataVenda { get; set; }

    }
}
