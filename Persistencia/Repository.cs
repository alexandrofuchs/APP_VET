using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Persistencia
{
    public abstract class Repository<T> : IRepository<T> where T : class

    {
        public void Add(T obj)
        {
            using (var ctx = new EFContext())
            {
                ctx.Set<T>().Add(obj);
                ctx.SaveChanges();
            };
        }

        public void Update(T obj)
        {
            using (var ctx = new EFContext())
            {
                ctx.Set<T>().Update(obj);
                ctx.SaveChanges();
            };
        }

        public void Remove(T obj)
        {
            using (var ctx = new EFContext())
            {
                ctx.Set<T>().Remove(obj);
                ctx.SaveChanges();
            };
        }

        protected virtual bool Buscar(Predicate<T> predicate)
        {
            using (var ctx = new EFContext())
            {
                return ctx.Set<T>()
                    .ToList()
                    .Exists(predicate);
            }
        }

        protected virtual T BuscarUm(Expression<Func<T, bool>> predicate)
        {
            using (var ctx = new EFContext())
            {
                return ctx.Set<T>()
                    .SingleOrDefault(predicate);
            }
        }

        protected virtual IEnumerable<T> BuscarVarios(Expression<Func<T, bool>> predicate)
        {
            using (var ctx = new EFContext())
            {
                return ctx.Set<T>()
                    .Where(predicate).ToList();
            }
        }

        public virtual IEnumerable<T> BuscarTodos()
        {
            using (var ctx = new EFContext())
            {
                return ctx.Set<T>()
                    .ToList();
            }
        }

    }
}