using Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Persistencia
{
    public class AgendamentoDAL : Repository<Agendamento>
    {
        public bool BuscarData(DateTime data, long veterinarioID)
        {
            return Buscar(a => a.DataHora.Equals(data) && a.Status == Modelo.Enums.StatusAgendamento.Agendado 
            && a.VeterinarioID == veterinarioID);
        }
        
        public Agendamento BuscarPorID(long agendamentoID)
        {
           return BuscarUm(a => a.AgendamentoID == agendamentoID);
        }

        public IEnumerable<Agendamento> BuscarPorMes(int mes)
        {
            return BuscarVarios(a => a.DataHora.Month == mes);
        }

        public IEnumerable<Agendamento> BuscarPorData(DateTime data)
        {
            return BuscarVarios(a => a.DataHora.Date.Equals(data));
        }

        protected override Agendamento BuscarUm(Expression<Func<Agendamento, bool>> predicate)
        {
            using (var ctx = new EFContext())
            {
                return ctx.Agendamento
                    .Include(a => a.Veterinario)
                    .Include(a => a.Animal)
                    .Include(a => a.Animal.Cliente)
                    .SingleOrDefault(predicate);
            }            
        }

        protected override IEnumerable<Agendamento> BuscarVarios(Expression<Func<Agendamento, bool>> predicate)
        {
            using (var ctx = new EFContext())
            {
                return ctx
                    .Agendamento
                    .Where(predicate)
                    .Include(a => a.Animal.Cliente)
                    .Include(a => a.Veterinario)
                    .ToList();
            }
        }


    }
}

