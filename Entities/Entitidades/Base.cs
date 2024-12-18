using PDV.Domain.Entities.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Domain.Entities
{
    public class Base : Notificacao
    {
        public Guid Id { get; set; }
    }
}
