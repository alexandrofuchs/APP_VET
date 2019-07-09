using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Persistencia
{
    public class AnimalDAL : Repository<Animal>
    {
        public Animal BuscarPorID(long id)
        {
            return BuscarUm(a => a.AnimalID == id);
        }

        public IEnumerable<Animal> BuscarPorNome(string nome)
        {
            return BuscarVarios(a => a.Nome.Contains(nome));
        }

        public IEnumerable<Animal> BuscarPorNomeProprietario(string nome)
        {
            return BuscarVarios(a => a.Cliente.Nome.Contains(nome));
        }

        public IEnumerable<Animal> BuscarPorProprietario(long clienteID)
        {
            return BuscarVarios(a => a.ClienteID == clienteID);
        }

        public override IEnumerable<Animal> BuscarTodos()
        {
            using (var ctx = new EFContext())
            {
                return ctx.Animal
                        .Include(a => a.Cliente)
                        .Include(a => a.Consultas)
                        .Include(a => a.Exames)
                        .ToList();
            }
        }

        protected override Animal BuscarUm(Expression<Func<Animal, bool>> predicate)
        {
            using (var ctx = new EFContext())
            {
                return ctx.Animal
                        .Include(a => a.Cliente)
                        .Include(a => a.Consultas)
                        .Include(a => a.Exames)
                        .SingleOrDefault(predicate);
            }
        }

        protected override IEnumerable<Animal> BuscarVarios(Expression<Func<Animal, bool>> predicate)
        {
            using (var ctx = new EFContext())
            {
                return ctx.Animal
                    .Where(predicate)
                    .Include(a => a.Cliente)
                    .Include(a => a.Consultas)
                    .Include(a => a.Exames)
                    .ToList();
            }
        }
        


       

    }
}
