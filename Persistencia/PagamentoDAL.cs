using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Persistencia
{
    public class PagamentoDAL : Repository<Pagamento>
    {
        public IEnumerable<Pagamento> BuscarPorData(DateTime data)
        {
            return BuscarVarios(p => p.DataHora.Date.Equals(data.Date));
        }

        public IEnumerable<Pagamento> BuscarEntreDatas(DateTime inicio, DateTime final)
        {
            return BuscarVarios(p => p.DataHora.Date >= inicio.Date && p.DataHora.Date <= final);
        }

        public IEnumerable<Pagamento> BuscarPorMes(int mes)
        {
            return BuscarVarios(p => p.DataHora.Month == mes);
        }

        protected override IEnumerable<Pagamento> BuscarVarios(Expression<Func<Pagamento, bool>> predicate)
        {
            using (var ctx = new EFContext())
            {
                return ctx.Pagamento
                    .Where(predicate)
                    .Include(p => p.Atendimento.Animal.Cliente)
                    .ToList();
            }
        }

    }
}
