using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Persistencia
{
    public class ExameAnimalDAL : Repository<ExameAnimal>
    {
        public ExameAnimal BuscarPorID(long id)
        {
            return BuscarUm(e => e.ExameAnimalID == id);
        }

        public IEnumerable<ExameAnimal> BuscarPorAnimal(long id)
        {
            return BuscarVarios(e => e.AnimalID == id);
        }

        protected override ExameAnimal BuscarUm(Expression<Func<ExameAnimal, bool>> predicate)
        {
            using (var ctx = new EFContext())
            {
                return ctx.ExameAnimal
                    .Include(e => e.Animal.Cliente)
                    .SingleOrDefault(predicate);
            }
        }

        protected override IEnumerable<ExameAnimal> BuscarVarios(Expression<Func<ExameAnimal, bool>> predicate)
        {
            using (var ctx = new EFContext())
            {
                return ctx.ExameAnimal
                    .Where(predicate)
                    .Include(e => e.Animal.Cliente)
                    .ToList();
            }
        }
    }
}
