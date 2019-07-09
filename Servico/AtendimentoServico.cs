using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico
{
   public class AtendimentoServico
    {
        AtendimentoDAL atendimentoDAL = new AtendimentoDAL();


        public void Registrar(Atendimento atendimento)
        {
            if (!(atendimento.TotalAtendimento() > 0))
            {
                throw new Exception("Erro! Total não pode ser Zero!");
            }
            atendimentoDAL.Add(atendimento);
        }

        public Atendimento BuscarPorID(long id)
        {
            return atendimentoDAL.BuscarPorID(id);
        }

        public IEnumerable<Atendimento> BuscarPorCliente(long clienteID)
        {
           return atendimentoDAL.BuscarPorCliente(clienteID);
        }

        public IEnumerable<Atendimento> BuscarEntreDatas(DateTime inicio, DateTime final)
        {
            return atendimentoDAL.BuscarEntreDatas(inicio, final);
        }

        public IEnumerable<Atendimento> BuscarPorMes(int mes)
        {
            return atendimentoDAL.BuscarPorMes(mes);
        }


    }
}
