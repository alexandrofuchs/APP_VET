using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Persistencia
{
    public interface IRepository<T> where T: class
    {
        void Add(T obj);
        void Remove(T obj);
        IEnumerable<T> BuscarTodos();
    }
}
