﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Domain.Interfaces.Generic
{
    public interface InterfaceGeneric <T> where T : class
    {
        Task Add(T Objeto);
        Task Update(T Objeto);
        Task Delete(T Objeto);
        Task<T> GetEntityById(Guid Id);
        Task<List<T>> List();
    }
}
