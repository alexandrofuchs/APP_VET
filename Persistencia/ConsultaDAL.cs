using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Persistencia
{
    public class ConsultaDAL : Repository<Consulta>
    {
        public Consulta BuscarPorID(long consultaID)
        {
            return BuscarUm(c => c.ConsultaID == consultaID);
        }

        public IEnumerable<Consulta> BuscarPorData(DateTime data)
        {
            return BuscarVarios(c => c.DataConsulta.Date.Equals(data));
        }        

        public IEnumerable<Consulta> BuscarPorAnimal(long id)
        {
            return BuscarVarios(c => c.AnimalID == id);
        }

        protected override Consulta BuscarUm(Expression<Func<Consulta, bool>> predicate)
        {
            using (var ctx = new EFContext())
            {
                return ctx.Consulta
                    .Include(c => c.Veterinario)
                    .Include(c => c.Animal)
                    .Include(c => c.Animal.Cliente)
                    .Include(c => c.DadosConsulta)
                    .SingleOrDefault(predicate);
            }
        }

        protected override IEnumerable<Consulta> BuscarVarios(Expression<Func<Consulta, bool>> predicate)
        {
            using (var ctx = new EFContext())
            {
                return ctx
                    .Consulta
                    .Where(predicate)
                    .Include(c => c.Veterinario)
                    .Include(c => c.Animal)
                    .Include(c => c.Animal.Cliente)
                    .Include(c => c.DadosConsulta)
                    .ToList();
            }
        }
    }
}
