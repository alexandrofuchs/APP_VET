using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Persistencia
{
    public class AtendimentoDAL : Repository<Atendimento>
    {
        public Atendimento BuscarPorID(long id)
        {
            return BuscarUm(a => a.AtendimentoID == id);
        }

        public IEnumerable<Atendimento> BuscarPorCliente(long clienteID)
        {
            return BuscarVarios(a => a.Animal.ClienteID == clienteID);
        }

        public IEnumerable<Atendimento> BuscarEntreDatas(DateTime inicio, DateTime final)
        {
            return BuscarVarios(a => a.DataRegistro.Date >= inicio.Date && a.DataRegistro.Date <= final.Date);
        }

        public IEnumerable<Atendimento> BuscarPorMes(int mes)
        {
            return BuscarVarios(a => a.DataRegistro.Month == mes);
        }

        protected override Atendimento BuscarUm(Expression<Func<Atendimento, bool>> predicate)
        {
            using (var ctx = new EFContext())
            {
                return ctx.Atendimento
                    .Include(a => a.Animal.Cliente)
                    .Include(a => a.ItemProdutos)
                    .Include(a => a.Pagamentos)
                    .SingleOrDefault(predicate);
            }
        }

        protected override IEnumerable<Atendimento> BuscarVarios(Expression<Func<Atendimento, bool>> predicate)
        {
            using (var ctx = new EFContext())
            {
                return ctx.Atendimento
                    .Where(predicate)
                    .Include(a => a.Animal.Cliente)
                    .Include(a => a.Pagamentos)
                    .Include(a => a.ItemProdutos)
                    .ToList();
            }
        }



    }
}
