using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;

namespace Servico
{
    public class AgendamentoServico
    {
        AgendamentoDAL agendamentoDAL = new AgendamentoDAL();

        private void ValidarDados(Agendamento agendamento)
        {
           if(agendamentoDAL.BuscarData(agendamento.DataHora, agendamento.VeterinarioID))
            {
                throw new Exception("Horário já Agendado para este Veterinário!");
            }           
        }

        private void VerificaAgendamento(Agendamento agendamento)
        {
            if (agendamento is null)
            {
                throw new Exception("Agendamento não definido!");
            }
        }

        public void Registrar(Agendamento agendamento)
        {
            VerificaAgendamento(agendamento);
            ValidarDados(agendamento);
            agendamentoDAL.Add(agendamento);
        }

        public void Remover(Agendamento agendamento)
        {
            VerificaAgendamento(agendamento);
            agendamentoDAL.Remove(agendamento);
        }

        public void Atualizar(Agendamento agendamento)
        {
            VerificaAgendamento(agendamento);
            agendamentoDAL.Update(agendamento);
        }
               
        public IEnumerable<Agendamento> BuscarPorData(DateTime data)
        {
            return agendamentoDAL.BuscarPorData(data);
        }

        public Agendamento BuscarPorID(long consultaID)
        {
            return agendamentoDAL.BuscarPorID(consultaID);
        }

        public IEnumerable<Agendamento> BuscarPorMes(int mes)
        {
            return agendamentoDAL.BuscarPorMes(mes);
        }
    }
}

